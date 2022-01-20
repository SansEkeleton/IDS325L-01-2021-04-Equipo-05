using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Login
{
    public partial class Login : Form
    {
        SqlCommand comando;
        string str_sql;

        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txt_IdUsuario_Enter(object sender, EventArgs e)
        {
            if (txt_IdUsuario.Text == "ID USUARIO")
            {
                txt_IdUsuario.Text = "";
                txt_IdUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_IdUsuario_Leave(object sender, EventArgs e)
        {
            if (txt_IdUsuario.Text=="")
            {
                txt_IdUsuario.Text = "ID USUARIO";
                txt_IdUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "CONTRASEÑA")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.ForeColor = Color.LightGray;
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "CONTRASEÑA";
                txt_Contraseña.ForeColor = Color.DimGray;
                txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void pcb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lnk_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro re = new Registro();
            re.Show();
            this.Hide();

            
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = 
                    new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbAcademia.mdf;Integrated Security=True");
                conexion.Open();


                //Insertando valores
                str_sql = "Select ID_usuario,Contraseña From Sistema where ID_usuario =@Nombre and Contraseña =@Contraseña"; 
                comando = new SqlCommand(str_sql, conexion);
                comando.Parameters.AddWithValue("@Nombre", txt_IdUsuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txt_Contraseña.Text);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login exitoso");
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

                //Instanciando los valores insertado
                dr.Close();
                comando.ExecuteNonQuery();
                conexion.Close();           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Menu me = new Menu();
            me.Show();
            this.Hide();
            

        }
    }
}
