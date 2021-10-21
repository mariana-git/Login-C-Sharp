using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using CapaVista.Usuarios;
using CapaLogica.Login;
using CapaSoporte;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Principal : Form
    {
        private UserControl userControlActivo = null; //variable para manipular en el metodo del ControlUser Activo en el panel
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

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirUC(new CV_UCUsuarios());
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelPrincipal.Controls.Add(UControlActivo);
            panelPrincipal.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }

    }
}
