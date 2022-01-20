
namespace Login
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnl_LadoIzquierdo = new System.Windows.Forms.Panel();
            this.pnl_Inicio = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMenuAsig = new System.Windows.Forms.Button();
            this.btnMenuProf = new System.Windows.Forms.Button();
            this.btnMenuEst = new System.Windows.Forms.Button();
            this.btn_MenuInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_LadoIzquierdo.SuspendLayout();
            this.pnl_Inicio.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_LadoIzquierdo
            // 
            this.pnl_LadoIzquierdo.AllowDrop = true;
            this.pnl_LadoIzquierdo.AutoScroll = true;
            this.pnl_LadoIzquierdo.BackColor = System.Drawing.Color.Black;
            this.pnl_LadoIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_LadoIzquierdo.Controls.Add(this.button1);
            this.pnl_LadoIzquierdo.Controls.Add(this.pnl_Inicio);
            this.pnl_LadoIzquierdo.Controls.Add(this.btn_MenuInicio);
            this.pnl_LadoIzquierdo.Controls.Add(this.panel2);
            this.pnl_LadoIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_LadoIzquierdo.ForeColor = System.Drawing.Color.LightGray;
            this.pnl_LadoIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnl_LadoIzquierdo.Name = "pnl_LadoIzquierdo";
            this.pnl_LadoIzquierdo.Size = new System.Drawing.Size(250, 645);
            this.pnl_LadoIzquierdo.TabIndex = 0;
            this.pnl_LadoIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_LadoIzquierdo_Paint);
            // 
            // pnl_Inicio
            // 
            this.pnl_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Inicio.Controls.Add(this.button3);
            this.pnl_Inicio.Controls.Add(this.button2);
            this.pnl_Inicio.Controls.Add(this.btnMenuAsig);
            this.pnl_Inicio.Controls.Add(this.btnMenuProf);
            this.pnl_Inicio.Controls.Add(this.btnMenuEst);
            this.pnl_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Inicio.Location = new System.Drawing.Point(0, 144);
            this.pnl_Inicio.Name = "pnl_Inicio";
            this.pnl_Inicio.Size = new System.Drawing.Size(248, 222);
            this.pnl_Inicio.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(248, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calculo de indice";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 135);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(248, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calificaciones";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btnMenuAsig
            // 
            this.btnMenuAsig.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenuAsig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuAsig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAsig.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuAsig.Location = new System.Drawing.Point(0, 90);
            this.btnMenuAsig.Name = "btnMenuAsig";
            this.btnMenuAsig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuAsig.Size = new System.Drawing.Size(248, 45);
            this.btnMenuAsig.TabIndex = 6;
            this.btnMenuAsig.Text = "Asignaturas";
            this.btnMenuAsig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAsig.UseVisualStyleBackColor = false;
            this.btnMenuAsig.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnMenuProf
            // 
            this.btnMenuProf.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenuProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProf.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuProf.Location = new System.Drawing.Point(0, 45);
            this.btnMenuProf.Name = "btnMenuProf";
            this.btnMenuProf.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuProf.Size = new System.Drawing.Size(248, 45);
            this.btnMenuProf.TabIndex = 5;
            this.btnMenuProf.Text = "Menú de Profesor";
            this.btnMenuProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProf.UseVisualStyleBackColor = false;
            this.btnMenuProf.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnMenuEst
            // 
            this.btnMenuEst.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenuEst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEst.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuEst.Location = new System.Drawing.Point(0, 0);
            this.btnMenuEst.Name = "btnMenuEst";
            this.btnMenuEst.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuEst.Size = new System.Drawing.Size(248, 45);
            this.btnMenuEst.TabIndex = 4;
            this.btnMenuEst.Text = "Menú de Estudiante";
            this.btnMenuEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEst.UseVisualStyleBackColor = false;
            this.btnMenuEst.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_MenuInicio
            // 
            this.btn_MenuInicio.BackColor = System.Drawing.Color.DarkRed;
            this.btn_MenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuInicio.ForeColor = System.Drawing.Color.LightGray;
            this.btn_MenuInicio.Location = new System.Drawing.Point(0, 99);
            this.btn_MenuInicio.Name = "btn_MenuInicio";
            this.btn_MenuInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_MenuInicio.Size = new System.Drawing.Size(248, 45);
            this.btn_MenuInicio.TabIndex = 1;
            this.btn_MenuInicio.Text = "Inicio";
            this.btn_MenuInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuInicio.UseVisualStyleBackColor = false;
            this.btn_MenuInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 99);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-130, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 366);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(248, 50);
            this.button1.TabIndex = 7;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(934, 645);
            this.Controls.Add(this.pnl_LadoIzquierdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnl_LadoIzquierdo.ResumeLayout(false);
            this.pnl_Inicio.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LadoIzquierdo;
        private System.Windows.Forms.Button btn_MenuInicio;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_Inicio;
        private System.Windows.Forms.Button btnMenuAsig;
        private System.Windows.Forms.Button btnMenuProf;
        private System.Windows.Forms.Button btnMenuEst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}