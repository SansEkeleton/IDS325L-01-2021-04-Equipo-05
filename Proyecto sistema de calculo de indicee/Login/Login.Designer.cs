
namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_IdUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.lnk_registro = new System.Windows.Forms.LinkLabel();
            this.pcb_cerrar = new System.Windows.Forms.PictureBox();
            this.pcb_minimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(230, 208);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txt_IdUsuario
            // 
            this.txt_IdUsuario.BackColor = System.Drawing.Color.Black;
            this.txt_IdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_IdUsuario.Location = new System.Drawing.Point(369, 93);
            this.txt_IdUsuario.Name = "txt_IdUsuario";
            this.txt_IdUsuario.Size = new System.Drawing.Size(300, 27);
            this.txt_IdUsuario.TabIndex = 1;
            this.txt_IdUsuario.Text = "ID USUARIO";
            this.txt_IdUsuario.Enter += new System.EventHandler(this.txt_IdUsuario_Enter);
            this.txt_IdUsuario.Leave += new System.EventHandler(this.txt_IdUsuario_Leave);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.Black;
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_Contraseña.Location = new System.Drawing.Point(369, 150);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(300, 27);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.Text = "CONTRASEÑA";
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Contraseña_Enter);
            this.txt_Contraseña.Leave += new System.EventHandler(this.txt_Contraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(453, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_IniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarSesion.ForeColor = System.Drawing.Color.LightGray;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(369, 218);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(300, 37);
            this.btn_IniciarSesion.TabIndex = 3;
            this.btn_IniciarSesion.Text = "INICIAR SESIÓN";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // lnk_registro
            // 
            this.lnk_registro.AutoSize = true;
            this.lnk_registro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_registro.LinkColor = System.Drawing.Color.DimGray;
            this.lnk_registro.Location = new System.Drawing.Point(390, 290);
            this.lnk_registro.Name = "lnk_registro";
            this.lnk_registro.Size = new System.Drawing.Size(256, 21);
            this.lnk_registro.TabIndex = 0;
            this.lnk_registro.TabStop = true;
            this.lnk_registro.Text = "No estas registrado?, Registrate";
            this.lnk_registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_registro_LinkClicked);
            // 
            // pcb_cerrar
            // 
            this.pcb_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_cerrar.Image")));
            this.pcb_cerrar.Location = new System.Drawing.Point(764, 0);
            this.pcb_cerrar.Name = "pcb_cerrar";
            this.pcb_cerrar.Size = new System.Drawing.Size(15, 15);
            this.pcb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_cerrar.TabIndex = 6;
            this.pcb_cerrar.TabStop = false;
            this.pcb_cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcb_minimizar
            // 
            this.pcb_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("pcb_minimizar.Image")));
            this.pcb_minimizar.Location = new System.Drawing.Point(747, 0);
            this.pcb_minimizar.Name = "pcb_minimizar";
            this.pcb_minimizar.Size = new System.Drawing.Size(15, 15);
            this.pcb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minimizar.TabIndex = 7;
            this.pcb_minimizar.TabStop = false;
            this.pcb_minimizar.Click += new System.EventHandler(this.pcb_minimizar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.pcb_minimizar);
            this.Controls.Add(this.pcb_cerrar);
            this.Controls.Add(this.lnk_registro);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_IdUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_IdUsuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.LinkLabel lnk_registro;
        private System.Windows.Forms.PictureBox pcb_cerrar;
        private System.Windows.Forms.PictureBox pcb_minimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

