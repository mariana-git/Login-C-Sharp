using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaSoporte;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            lblDatosActivo.Text = CS_UsuarioActivo.Nombre + " " + CS_UsuarioActivo.Apellido ;
            lblCargo.Text = CS_UsuarioActivo.Cargo;
        }
    }
}
