﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factura2021_1400.Controladores;

namespace Factura2021_1400.Vistas
{
    public partial class ClientesView : Form
    {
        public ClientesView()
        {
            InitializeComponent();
            ClienteController controlador = new ClienteController(this);
        }
    }
}
