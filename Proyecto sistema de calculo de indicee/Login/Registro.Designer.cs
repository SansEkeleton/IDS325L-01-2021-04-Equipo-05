
namespace Login
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_ConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_IniciarSesion = new System.Windows.Forms.LinkLabel();
            this.txt_TipoUsuario = new System.Windows.Forms.TextBox();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Black;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(343, 118);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(271, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Text = "NOMBRE";
            this.txt_nombre.Enter += new System.EventHandler(this.txt_nombre_Enter);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // txt_IDUsuario
            // 
            this.txt_IDUsuario.BackColor = System.Drawing.Color.Black;
            this.txt_IDUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IDUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_IDUsuario.Location = new System.Drawing.Point(343, 207);
            this.txt_IDUsuario.Name = "txt_IDUsuario";
            this.txt_IDUsuario.Size = new System.Drawing.Size(271, 20);
            this.txt_IDUsuario.TabIndex = 1;
            this.txt_IDUsuario.Text = "ID USUARIO";
            this.txt_IDUsuario.Enter += new System.EventHandler(this.txt_IDUsuario_Enter);
            this.txt_IDUsuario.Leave += new System.EventHandler(this.txt_IDUsuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.Black;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contraseña.Location = new System.Drawing.Point(672, 207);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(264, 20);
            this.txt_contraseña.TabIndex = 2;
            this.txt_contraseña.Text = "CONTRASEÑA";
            this.txt_contraseña.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // txt_ConfirmarContraseña
            // 
            this.txt_ConfirmarContraseña.BackColor = System.Drawing.Color.Black;
            this.txt_ConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmarContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmarContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ConfirmarContraseña.Location = new System.Drawing.Point(672, 307);
            this.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña";
            this.txt_ConfirmarContraseña.Size = new System.Drawing.Size(264, 20);
            this.txt_ConfirmarContraseña.TabIndex = 3;
            this.txt_ConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
            this.txt_ConfirmarContraseña.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txt_ConfirmarContraseña.Enter += new System.EventHandler(this.txt_ConfirmarContraseña_Enter);
            this.txt_ConfirmarContraseña.Leave += new System.EventHandler(this.txt_ConfirmarContraseña_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 512);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Registrar.Location = new System.Drawing.Point(390, 361);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(418, 40);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.Text = "Registrarse";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registro Usuario";
            // 
            // lnk_IniciarSesion
            // 
            this.lnk_IniciarSesion.AutoSize = true;
            this.lnk_IniciarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_IniciarSesion.LinkColor = System.Drawing.Color.DimGray;
            this.lnk_IniciarSesion.Location = new System.Drawing.Point(495, 439);
            this.lnk_IniciarSesion.Name = "lnk_IniciarSesion";
            this.lnk_IniciarSesion.Size = new System.Drawing.Size(222, 17);
            this.lnk_IniciarSesion.TabIndex = 9;
            this.lnk_IniciarSesion.TabStop = true;
            this.lnk_IniciarSesion.Text = "Ya estas registrado?, Inicia Sesión";
            this.lnk_IniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_TipoUsuario
            // 
            this.txt_TipoUsuario.BackColor = System.Drawing.Color.Black;
            this.txt_TipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TipoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TipoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_TipoUsuario.Location = new System.Drawing.Point(343, 307);
            this.txt_TipoUsuario.Name = "txt_TipoUsuario";
            this.txt_TipoUsuario.Size = new System.Drawing.Size(271, 20);
            this.txt_TipoUsuario.TabIndex = 10;
            this.txt_TipoUsuario.Text = "TIPO USUARIO";
            this.txt_TipoUsuario.TextChanged += new System.EventHandler(this.txt_TipoUsuario_TextChanged);
            this.txt_TipoUsuario.Enter += new System.EventHandler(this.txt_TipoUsuario_Enter);
            this.txt_TipoUsuario.Leave += new System.EventHandler(this.txt_TipoUsuario_Leave);
            // 
            // txt_carrera
            // 
            this.txt_carrera.BackColor = System.Drawing.Color.Black;
            this.txt_carrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_carrera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carrera.ForeColor = System.Drawing.Color.DimGray;
            this.txt_carrera.Location = new System.Drawing.Point(672, 118);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(271, 20);
            this.txt_carrera.TabIndex = 11;
            this.txt_carrera.Text = "CARRERA";
            this.txt_carrera.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txt_carrera.Enter += new System.EventHandler(this.txt_carrera_Enter);
            this.txt_carrera.Leave += new System.EventHandler(this.txt_carrera_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(928, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(912, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(942, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_carrera);
            this.Controls.Add(this.txt_TipoUsuario);
            this.Controls.Add(this.lnk_IniciarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ConfirmarContraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_IDUsuario);
            this.Controls.Add(this.txt_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_IDUsuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_ConfirmarContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_IniciarSesion;
        private System.Windows.Forms.TextBox txt_TipoUsuario;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}