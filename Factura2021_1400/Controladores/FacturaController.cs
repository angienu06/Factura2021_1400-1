using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string _EmailUsuario;

        public FacturaController(FacturaView view, string usuario)
        {
            vista = view;
            _EmailUsuario = usuario;
            vista.Load += new EventHandler(Load);

        }

        private void Load(object sender, EventArgs e)
        {
            vista.UsuarioTextBox.Text = _EmailUsuario;
        }
    }
}
