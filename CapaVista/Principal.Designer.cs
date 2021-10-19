
namespace CapaVista
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblDatosActivo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnProfesionales = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatosActivo
            // 
            this.lblDatosActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosActivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDatosActivo.Location = new System.Drawing.Point(1045, 15);
            this.lblDatosActivo.Name = "lblDatosActivo";
            this.lblDatosActivo.Size = new System.Drawing.Size(193, 20);
            this.lblDatosActivo.TabIndex = 27;
            this.lblDatosActivo.Text = "NombrePersonaLogueada";
            this.lblDatosActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(149)))), ((int)(((byte)(239)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLogout.Location = new System.Drawing.Point(1129, 59);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 25);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.btnEspecialidades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnEspecialidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnEspecialidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btnEspecialidades.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnEspecialidades.Location = new System.Drawing.Point(0, 361);
            this.btnEspecialidades.Margin = new System.Windows.Forms.Padding(0);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(145, 81);
            this.btnEspecialidades.TabIndex = 13;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            // 
            // btnProfesionales
            // 
            this.btnProfesionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.btnProfesionales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnProfesionales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnProfesionales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnProfesionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionales.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btnProfesionales.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnProfesionales.Location = new System.Drawing.Point(0, 280);
            this.btnProfesionales.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfesionales.Name = "btnProfesionales";
            this.btnProfesionales.Size = new System.Drawing.Size(145, 81);
            this.btnProfesionales.TabIndex = 12;
            this.btnProfesionales.Text = "Profesionales";
            this.btnProfesionales.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btnPacientes.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPacientes.Location = new System.Drawing.Point(0, 199);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(145, 81);
            this.btnPacientes.TabIndex = 11;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.healthcare;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Size = new System.Drawing.Size(145, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 800);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1442, 50);
            this.panel3.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1392, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 800);
            this.panel2.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.button1.ForeColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(0, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 81);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consultorios";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnPacientes);
            this.flowLayoutPanel1.Controls.Add(this.btnProfesionales);
            this.flowLayoutPanel1.Controls.Add(this.btnEspecialidades);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 800);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.button2.ForeColor = System.Drawing.Color.Aquamarine;
            this.button2.Location = new System.Drawing.Point(0, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 81);
            this.button2.TabIndex = 15;
            this.button2.Text = "Turnos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(11)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblDatosActivo);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(148, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 118);
            this.panel1.TabIndex = 34;
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCargo.Location = new System.Drawing.Point(1045, 36);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(193, 20);
            this.lblCargo.TabIndex = 28;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(184)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.button3.ForeColor = System.Drawing.Color.Aquamarine;
            this.button3.Location = new System.Drawing.Point(0, 523);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 81);
            this.button3.TabIndex = 16;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1442, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDatosActivo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnProfesionales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button button3;
    }
}