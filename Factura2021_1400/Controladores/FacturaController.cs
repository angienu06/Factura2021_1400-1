using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factura2021_1400.Modelos.DAO;
using Factura2021_1400.Modelos.Entidades;
using Factura2021_1400.Vistas;

namespace Factura2021_1400.Controladores
{
    public class FacturaController
    {
        FacturaView vista;
        FacturaDAO facturaDAO = new FacturaDAO();
        Factura factura = new Factura();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        Producto producto = new Producto();
        ProductoDAO productoDAO = new ProductoDAO();
        public string _EmailUsuario;
        Usuario user = new Usuario();

        List<DetalleFactura> listaDetalleFactura = new List<DetalleFactura>();

        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalPagar = 0;


        public FacturaController(FacturaView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
            vista.IdentidadMaskedTextBox.KeyPress += IdentidadMaskedTextBox_KeyPress;
            vista.BuscarClienteButton.Click += BuscarClienteButton_Click;
            vista.CodigoProductoTextBox.KeyPress += CodigoProductoTextBox_KeyPress;
            vista.CantidadTextBox.KeyPress += CantidadTextBox_KeyPress;
            vista.GuardarButton.Click += GuardarButton_Click;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Fecha = vista.FechaDateTimePicker.Value;
            factura.IdCliente = cliente.Id;
            factura.IdUsuario = user.Id;
            factura.SubTotal = subTotal;
            factura.ISV = isv;
            factura.Total = Convert.ToDecimal(vista.TotalTextBox.Text);
            factura.Descuento = Convert.ToDecimal(vista.DescuentosTextBox.Text);

            bool inserto = facturaDAO.InsertarNuevaFactura(factura, listaDetalleFactura);
            if (inserto)
            {
                MessageBox.Show("Factura registrada correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar la factura");
            }

        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(vista.CantidadTextBox.Text))
            {
                DetalleFactura detalleFactura = new DetalleFactura();
                detalleFactura.IdProducto = producto.Id;
                detalleFactura.Cantidad = Convert.ToInt32(vista.CantidadTextBox.Text);
                detalleFactura.Precio = producto.Precio;
                detalleFactura.Total = Convert.ToDecimal(Convert.ToInt32(vista.CantidadTextBox.Text) * producto.Precio);

                subTotal += detalleFactura.Total;
                isv = subTotal * 0.15M;
                totalPagar = subTotal + isv;

                listaDetalleFactura.Add(detalleFactura);
                vista.DetalleDataGridView.DataSource = null;
                vista.DetalleDataGridView.DataSource = listaDetalleFactura;

                vista.SubtotalTextBox.Text = subTotal.ToString("N2");
                vista.ImpuestoTextBox.Text = isv.ToString("N2");
                vista.TotalTextBox.Text = totalPagar.ToString("N2");
            }
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = productoDAO.GetProductoPorCodigo(vista.CodigoProductoTextBox.Text);

                vista.DescripcionProductoTextBox.Text = producto.Descripcion;
            }
            else
            {
                producto = null;
                vista.DescripcionProductoTextBox.Clear();
            }
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClienteView form = new BuscarClienteView();
            form.ShowDialog();
            cliente = form._cliente;
            vista.IdentidadMaskedTextBox.Text = cliente.Identidad;
            vista.NombreTextBox.Text = cliente.Nombre;
        }

        private void IdentidadMaskedTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cliente = clienteDAO.GetClientePorIdentidad(vista.IdentidadMaskedTextBox.Text);

                vista.NombreTextBox.Text = cliente.Nombre;
            }
            else
            {
                cliente = null;
                vista.NombreTextBox.Clear();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            user = usuarioDAO.GetUsuarioPorEmail(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            vista.UsuarioTextBox.Text = user.Nombre;
        }
    }
}
