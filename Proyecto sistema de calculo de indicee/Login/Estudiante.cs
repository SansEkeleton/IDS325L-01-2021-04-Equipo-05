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

namespace Login
{
    public partial class Estudiante : Form
    {
        
        SqlCommand comando;
        private SqlConnection conexion;
        public Estudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = 
                    new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbAcademia.mdf;Integrated Security=True");
                conexion.Open();
                SqlCommand instruccion = conexion.CreateCommand();

                instruccion.CommandText = "SELECT Nombre, Carrera, Id FROM Estudiantes";

                SqlDataReader reader = instruccion.ExecuteReader();

                DataTable dtRecords = new DataTable();

                dtRecords.Load(reader);

                dataGridView1.DataSource = dtRecords;

                conexion.Open();                                 //Abriendo base de datos
                comando.ExecuteNonQuery();
                MessageBox.Show("Tarea Modificada con exito.");

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();                                //Cerrando base de datos
                    conexion = null;
                    comando = null;
                }
            }
        }

        //Boton Inicio Estudiante
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Menu inicio = new Menu();
            inicio.Show();
            this.Close();
        }


        Random Id = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //string aux = string.Empty;
            //Estudiante est;

            //for (byte i = 0; i < 7; i++)
            //{
            //    aux += $"{Id.Next(0, 9)}";
            //}
            //if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            //{
            //    MessageBox.Show("Se deben rellenar los cuadros de texto"); //Cambiar a algo mas elegante
            //}
            //else
            //{
            //    try
            //    {
            //        est = new Estudiante(textBox1.Text, textBox3.Text, textBox2.Text, aux);
            //        EstAdapter.InsertEst(est.Matricula, est.Name, est.Surname, est.Career); //No Introduce datos a la tabla
            //        EstDT = EstAdapter.GetData();
            //        CargarTabla(dataGridView1);

            //        textBox1.Text = "";
            //        textBox2.Text = "";
            //        textBox3.Text = "";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Ha ocurrido un error: " + ex);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
