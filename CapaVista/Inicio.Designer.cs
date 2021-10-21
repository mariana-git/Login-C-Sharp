
namespace CapaVista
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.panelLogin.Controls.Add(this.btnCancelar);
            this.panelLogin.Controls.Add(this.lblMensajeError);
            this.panelLogin.Controls.Add(this.btnCerrar);
            this.panelLogin.Controls.Add(this.panel3);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.lblSegundo);
            this.panelLogin.Controls.Add(this.lblPrimero);
            this.panelLogin.Controls.Add(this.txtClave);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogin.Location = new System.Drawing.Point(231, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(371, 405);
            this.panelLogin.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnCancelar.Location = new System.Drawing.Point(79, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(217, 44);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensajeError.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.lblMensajeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblMensajeError.Image = global::CapaVista.Properties.Resources.error;
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(97, 235);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(143, 19);
            this.lblMensajeError.TabIndex = 8;
            this.lblMensajeError.Text = "      Mensaje de Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeError.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::CapaVista.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(314, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(54, 57);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.panel3.Location = new System.Drawing.Point(80, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(79, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            this.panel2.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnIngresar.Location = new System.Drawing.Point(81, 271);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(217, 44);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.lblSegundo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.lblSegundo.Location = new System.Drawing.Point(77, 161);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(112, 24);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Constraseña";
            // 
            // lblPrimero
            // 
            this.lblPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.lblPrimero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.lblPrimero.Location = new System.Drawing.Point(77, 88);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(72, 24);
            this.lblPrimero.TabIndex = 2;
            this.lblPrimero.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.White;
            this.txtClave.Location = new System.Drawing.Point(81, 188);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(217, 26);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.Enter += new System.EventHandler(this.TxtClave_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(80, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(24, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(602, 405);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.Button btnCancelar;
    }
}

