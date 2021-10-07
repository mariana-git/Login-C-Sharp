﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaLogica;
using System.Windows.Forms;

namespace CapaVista
{
    //https://coolors.co/f72585-b5179e-7209b7-560bad-480ca8-3a0ca3-3f37c9-4361ee-4895ef-4cc9f0 paleta de colores
    //https://coolors.co/7400b8-6930c3-5e60ce-5390d9-4ea8de-48bfe3-56cfe1-64dfdf-72efdd-80ffdb
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            AcceptButton = btnIngresar;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //antes de consultar la BD valido que los textbox tengan datos
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError("Ingresar Usuario");
                txtUsuario.Focus();
            }
            else if (txtClave.Text == string.Empty)
            {
                MensajeError("Ingresar Clave");
                txtClave.Focus();
            }
            else
            {
                //Abro este form de login en un diálogo modal desde el MAIN, si se valida el Usuario, se abre el form principal
                try
                {
                    CL_ValidarLogin validar = new CL_ValidarLogin();
                    validar.Usuario = txtUsuario.Text;
                    validar.Clave = txtClave.Text;
                    bool existe = validar.ValidarLogin();
                    if (existe)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MensajeError("Usuario inexistente\nVuelva a Intentarlo");
                        txtClave.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No fue posible realizar la transaccion\n\n\n\n\n\n{ex}", "ERROR");
                }
            }
        }
        private void MensajeError(string mensaje)
        {
            //muestra mensajes de error en un label de este formulario de login
            lblMensajeError.Text ="     " + mensaje;
            lblMensajeError.Visible = true;
        }
    }
}
