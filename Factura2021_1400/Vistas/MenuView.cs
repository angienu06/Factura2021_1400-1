using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Factura2021_1400.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        UsuariosView vistaUsuarios;
        ClientesView vistaClientes;
        FacturaView vistaFactura;

        public string EmailUsuario;


        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaUsuarios == null)
            {
                vistaUsuarios = new UsuariosView();
                vistaUsuarios.MdiParent = this;
                vistaUsuarios.FormClosed += Vista_FormClosed;
                vistaUsuarios.Show();
            }
            else
            {
                vistaUsuarios.Activate();
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaUsuarios = null;
        }

        private void ClientesToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaClientes == null)
            {
                vistaClientes = new ClientesView();
                vistaClientes.MdiParent = this;
                vistaClientes.FormClosed += VistaClientes_FormClosed; ;
                vistaClientes.Show();
            }
            else
            {
                vistaClientes.Activate();
            }
        }

        private void VistaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClientes = null;
        }

        private void FacturaToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaFactura == null)
            {
                vistaFactura = new FacturaView();
                vistaFactura.MdiParent = this;
                vistaFactura.EmailUsuario = EmailUsuario;
                vistaFactura.FormClosed += VistaFactura_FormClosed;
                vistaFactura.Show();
            }
            else
            {
                vistaFactura.Activate();
            }
        }

        private void VistaFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaFactura = null;
        }
    }
}
