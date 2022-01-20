using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioProf_Click(object sender, EventArgs e)
        {
            Menu inicio = new Menu();
            inicio.Show();
            this.Close();
        }

        Random id = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //string aux = string.Empty;

            //for (byte i = 0; i < 7; i++)
            //{
            //    aux += $"{id.Next(0, 9)}";
            //}

            //if (nametxtbox.Text == "" || Lastnametxtbox.Text == "" || textBox1.Text == "")
            //{
            //    MessageBox.Show("Se deben rellenar los cuadros de texto"); //Cambiar a algo mas elegante
            //}
            //else
            //{
            //    try
            //    {
            //        profesor = new Profesor(nametxtbox.Text, Lastnametxtbox.Text, textBox1.Text, aux);
            //        profAdapter.InsertProf(profesor.Clave, profesor.Name, profesor.Surname, profesor.Are);
            //        ProfDT = profAdapter.GetData();
            //        CargarTabla(dataGridView1);

            //        nametxtbox.Text = "";
            //        Lastnametxtbox.Text = "";
            //        textBox1.Text = "";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Se ha producido un error: " + ex);
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
