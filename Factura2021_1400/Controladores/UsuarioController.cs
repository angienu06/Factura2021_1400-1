using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factura2021_1400.Vistas;

namespace Factura2021_1400.Controladores
{
    public class UsuarioController
    {
        UsuariosView vista;

        public UsuarioController(UsuariosView view)
        {
            vista = view;
            vista.NuevoButton.Click += new EventHandler(Nuevo);
        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
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
    
    }
}
