
namespace CapaVista
{
    partial class ClaveExpirada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClaveNueva1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveNueva2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(70, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Constraseña Expirada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por favor, proporcione una nueva:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::CapaVista.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(355, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 51);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensajeError.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.lblMensajeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.lblMensajeError.Image = global::CapaVista.Properties.Resources.error;
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(97, 286);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(143, 19);
            this.lblMensajeError.TabIndex = 12;
            this.lblMensajeError.Text = "      Mensaje de Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeError.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnConfirmar.Location = new System.Drawing.Point(11, 329);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(386, 35);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Constraseña Actual";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtClaveActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveActual.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveActual.ForeColor = System.Drawing.Color.White;
            this.txtClaveActual.Location = new System.Drawing.Point(193, 151);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(204, 26);
            this.txtClaveActual.TabIndex = 9;
            this.txtClaveActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nueva Constraseña ";
            // 
            // txtClaveNueva1
            // 
            this.txtClaveNueva1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtClaveNueva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveNueva1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveNueva1.ForeColor = System.Drawing.Color.White;
            this.txtClaveNueva1.Location = new System.Drawing.Point(193, 190);
            this.txtClaveNueva1.Name = "txtClaveNueva1";
            this.txtClaveNueva1.PasswordChar = '*';
            this.txtClaveNueva1.Size = new System.Drawing.Size(204, 26);
            this.txtClaveNueva1.TabIndex = 13;
            this.txtClaveNueva1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(7, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Repetir Constraseña ";
            // 
            // txtClaveNueva2
            // 
            this.txtClaveNueva2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(12)))), ((int)(((byte)(168)))));
            this.txtClaveNueva2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveNueva2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveNueva2.ForeColor = System.Drawing.Color.White;
            this.txtClaveNueva2.Location = new System.Drawing.Point(193, 231);
            this.txtClaveNueva2.Name = "txtClaveNueva2";
            this.txtClaveNueva2.PasswordChar = '*';
            this.txtClaveNueva2.Size = new System.Drawing.Size(204, 26);
            this.txtClaveNueva2.TabIndex = 15;
            this.txtClaveNueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClaveExpirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(412, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClaveNueva2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClaveNueva1);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClaveExpirada";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClaveNueva1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveNueva2;
    }
}