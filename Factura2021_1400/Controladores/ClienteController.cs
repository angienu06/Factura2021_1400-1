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
    public class ClienteController
    {
        ClientesView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;

        public ClienteController(ClientesView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
        }


        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.IdentidadMaskedTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdentidadMaskedTextBox, "Ingrese una identidad");
                vista.IdentidadMaskedTextBox.Focus();
                return;
            }
            if (vista.NombreTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreTextBox, "Ingrese un nombre");
                vista.NombreTextBox.Focus();
                return;
            }
            if (vista.EmailTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EmailTextBox, "Ingrese un email");
                vista.EmailTextBox.Focus();
                return;
            }
            if (vista.DireccionTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DireccionTextBox, "Ingrese unu dirección");
                vista.DireccionTextBox.Focus();
                return;
            }

            cliente.Identidad = vista.IdentidadMaskedTextBox.Text;
            cliente.Nombre = vista.NombreTextBox.Text;
            cliente.Email = vista.EmailTextBox.Text;
            cliente.Direccion = vista.DireccionTextBox.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                if (inserto)
                {
                    MessageBox.Show("Cliente creado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente no se pudo insertar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void HabilitarControles()
        {
            vista.IdentidadMaskedTextBox.Enabled = true;
            vista.NombreTextBox.Enabled = true;
            vista.DireccionTextBox.Enabled = true;
            vista.EmailTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ImagenButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;

        }

    }
}
