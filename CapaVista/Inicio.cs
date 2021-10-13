using System;
using CapaLogica;
using System.Windows.Forms;

namespace CapaVista
{
    //https://coolors.co/f72585-b5179e-7209b7-560bad-480ca8-3a0ca3-3f37c9-4361ee-4895ef-4cc9f0 paleta de colores
    //https://coolors.co/7400b8-6930c3-5e60ce-5390d9-4ea8de-48bfe3-56cfe1-64dfdf-72efdd-80ffdb
    public partial class Inicio : Form
    {
        private CL_ValidarLogin validar;
        

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
                    validar = new CL_ValidarLogin();
                    validar.Usuario = txtUsuario.Text;
                    validar.Clave = txtClave.Text;
                    string resultado = validar.ValidarLogin();
                    if (resultado == "Login Exitoso") DialogResult = DialogResult.OK;
                    MensajeError(resultado);
                    txtClave.Text = "";
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"No fue posible realizar la transaccion\n\n\n\n{ex}","ERROR");
                //}                
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
            //limpia el mensaje de error
            lblMensajeError.Text = "";
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            //limpia el mensaje de error
            lblMensajeError.Text = "";
        }
    }
}
