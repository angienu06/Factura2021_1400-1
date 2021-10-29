using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factura2021_1400.Modelos.DAO;
using Factura2021_1400.Modelos.Entidades;
using Factura2021_1400.Vistas;
using System.Windows.Forms;

namespace Factura2021_1400.Controladores
{
    public class UsuarioController
    {
        UsuariosView vista;
        string operacion = string.Empty;

        public UsuarioController(UsuariosView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object serder, EventArgs e)
        {
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
            if (vista.ClaveTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.ClaveTextBox, "Ingrese una clave");
                vista.ClaveTextBox.Focus();
                return;
            }

            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = new Usuario();

            user.Nombre = vista.NombreTextBox.Text;
            user.Email = vista.EmailTextBox.Text;
            user.Clave = vista.ClaveTextBox.Text;
            user.EsAdministrador = vista.EsAdministradorCheckBox.Checked;

            bool inserto = userDAO.InsertarNuevoUsuario(user);

            if (inserto)
            {
                DesabilitarControles();
                LimpiarControles();
                MessageBox.Show("Usuario Creado Exitosamente", "Atención", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo insertar el usuario", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void LimpiarControles()
        {
            vista.IdtextBox.Clear();
            vista.NombreTextBox.Clear();
            vista.EmailTextBox.Clear();
            vista.ClaveTextBox.Clear();
            vista.EsAdministradorCheckBox.Enabled = false;
        }

        private void HabilitarControles()
        {
            vista.IdtextBox.Enabled = true;
            vista.NombreTextBox.Enabled = true;
            vista.EmailTextBox.Enabled = true;
            vista.ClaveTextBox.Enabled = true;
            vista.EsAdministradorCheckBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdtextBox.Enabled = false;
            vista.NombreTextBox.Enabled = false;
            vista.EmailTextBox.Enabled = false;
            vista.ClaveTextBox.Enabled = false;
            vista.EsAdministradorCheckBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;
        }

    }
}
