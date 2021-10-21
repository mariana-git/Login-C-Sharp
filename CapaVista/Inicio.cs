using System;
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
            btnCancelar.Visible = false;
            txtClave.UseSystemPasswordChar = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string mensaje;
            
            if(btnIngresar.Text == "Ingresar")
            {
                //antes de consultar la BD valido a nivel formulario que los textbox tengan datos
                if (txtUsuario.Text == string.Empty)
                {
                    MensajeError("Ingresar Usuario");
                }
                else if (txtClave.Text == string.Empty)
                {
                    MensajeError("Ingresar Clave");
                }
                else
                {
                    //Abro este form de login en un diálogo modal desde el MAIN, si se valida el Usuario, se abre el form principal, sino se cierra toda la aplicacion
                    //try
                    //{
                    CL_ValidarLogin validar = new CL_ValidarLogin
                    {
                        Usuario = txtUsuario.Text,
                        Clave = txtClave.Text
                    };
                    mensaje = validar.ValidarLogin();
                    MensajeError(mensaje);
                    if (mensaje == "Login Exitoso") DialogResult = DialogResult.OK;
                    if (mensaje == "Contraseña Expirada")
                    {
                        txtClave.Text = "";
                        txtUsuario.Text = "";
                        MessageBox.Show("Deberá registrar una nueva clave.\n\nREQUISITOS:\n\n - Entre 4 y 8 Caracteres\n - Al menos una letra minúscula\n - Al menos una letra mayúscula\n - Al menos un número", mensaje);
                        btnCancelar.Visible = true;
                        txtUsuario.UseSystemPasswordChar = true;
                        btnIngresar.Text = "Confirmar";
                        lblPrimero.Text = "Nueva Clave";
                        lblSegundo.Text = "Confirmar Clave";
                        lblMensajeError.Text = "";
                    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show($"No fue posible realizar la transaccion\n\n\n\n{ex}","ERROR");
                    //}                    
                }
            }
            else
            {
                if (txtUsuario.Text == txtClave.Text)
                {
                    CL_CambioClave cambiar = new CL_CambioClave();
                    mensaje = cambiar.NuevaClave(txtClave.Text);
                    MensajeError(mensaje);
                    if(mensaje == "Registro Exitoso")
                    {
                        MessageBox.Show(mensaje);
                        btnCancelar.PerformClick();
                    }
                }
                else MensajeError("Las Claves No Coinciden");
            }
        }
        private void MensajeError(string mensaje)
        {
            //muestra mensajes de error en un label de este formulario de login
            lblMensajeError.Text ="     " + mensaje;
            lblMensajeError.Visible = true;
        }

        private void TxtClave_Enter(object sender, EventArgs e)
        {
            //quita el mensaje de error
            lblMensajeError.Visible = false;
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            //quita el mensaje de error
            lblMensajeError.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            btnIngresar.Text = "Ingresar";
            lblPrimero.Text = "Usuario";
            lblSegundo.Text = "Clave";
            txtClave.Text = "";
            txtUsuario.Text = "";
            btnCancelar.Visible = false;
            lblMensajeError.Visible = false;
            txtUsuario.UseSystemPasswordChar = false;
        }
    }
}
