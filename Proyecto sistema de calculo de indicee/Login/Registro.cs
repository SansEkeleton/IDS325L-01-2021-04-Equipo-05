using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;




namespace Login
{
    public partial class Registro : Form
    {
        SqlCommand comando;
        string str_sql;
        

        public Registro()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE")
            {
                txt_nombre.Text = "";
                txt_nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE";
                txt_nombre.ForeColor = Color.DimGray;
            }
        }
        private void txt_IDUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_IDUsuario.Text == "ID USUARIO")
            {
                txt_IDUsuario.Text = "";
                txt_IDUsuario.ForeColor = Color.LightGray;
            }
        }
        private void txt_IDUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_IDUsuario.Text == "")
            {
                txt_IDUsuario.Text = "ID USUARIO";
                txt_IDUsuario.ForeColor = Color.DimGray;
            }
        }



        private void txt_TipoUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_TipoUsuario.Text == "TIPO USUARIO")
            {
                txt_TipoUsuario.Text = "";
                txt_TipoUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_TipoUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_TipoUsuario.Text == "")
            {
                txt_TipoUsuario.Text = "TIPO USUARIO";
                txt_TipoUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_carrera_Enter(object sender, EventArgs e)
        {
            if (txt_carrera.Text == "CARRERA")
            {
                txt_carrera.Text = "";
                txt_carrera.ForeColor = Color.LightGray;
            }
        }

        private void txt_carrera_Leave(object sender, EventArgs e)
        {
            if (txt_carrera.Text == "")
            {
                txt_carrera.Text = "CARRERA";
                txt_carrera.ForeColor = Color.DimGray;
            }
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "CONTRASEÑA")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.LightGray;
                txt_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "")
            {
                txt_contraseña.Text = "CONTRASEÑA";
                txt_contraseña.ForeColor = Color.LightGray;
                txt_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void txt_ConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txt_ConfirmarContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txt_ConfirmarContraseña.Text = "";
                txt_ConfirmarContraseña.ForeColor = Color.LightGray;
                txt_ConfirmarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_ConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (txt_ConfirmarContraseña.Text == "")
            {
                txt_ConfirmarContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txt_ConfirmarContraseña.ForeColor = Color.LightGray;
                txt_ConfirmarContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text != txt_ConfirmarContraseña.Text)
            {
                MessageBox.Show("La contraseña debe ser igual al campo confirmar contraseña.", "Error");   //Error al dejar nombre de tarea vacia
            }
            else
            {
                try
                {
                    SqlConnection conexion = 
                        new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbAcademia.mdf;Integrated Security=True");
                    conexion.Open();

                    //Insertando valores
                    str_sql = "insert into Sistema(Nombre, ID_usuario, Contraseña,Carrera,Tipo_usuario) values(@Nombre, @ID_Usuario, @Contraseña,@Carrera,@Tipo_usuario)";

                    //Instanciando los valores insertado
                    comando = new SqlCommand(str_sql, conexion);

                    //Tomando datos
                    comando.Parameters.AddWithValue("@Nombre", txt_nombre.Text);
                    comando.Parameters.AddWithValue("@ID_Usuario", txt_IDUsuario.Text);
                    comando.Parameters.AddWithValue("@Contraseña", txt_contraseña.Text);
                    comando.Parameters.AddWithValue("@Carrera", txt_carrera.Text);
                    comando.Parameters.AddWithValue("@Tipo_usuario", txt_TipoUsuario.Text);


                                                   //Abriendo base de datos
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso.");
                    conexion.Close();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
         

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TipoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

