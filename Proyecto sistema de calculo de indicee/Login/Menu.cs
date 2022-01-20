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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizardiseño();
        }
        private void customizardiseño()
        {
            pnl_Inicio.Visible = false;
         

        }
        private void hidepaneles()
        {
            if (pnl_Inicio.Visible==true)
            {
                pnl_Inicio.Visible = false;
            }
      
        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible== false)
            {
                hidepaneles();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(pnl_Inicio);
        } 

        private void pnl_LadoIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void btn_MenuProcesos_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidepaneles();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }

        //Boton Menu Estudiante
        private void button2_Click_1(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            est.Show();
            this.Close();
            


        }

        //Boton Menu Calculo_Indice
        private void button6_Click(object sender, EventArgs e)
        {
            Calculo_Indice cal = new Calculo_Indice();
            cal.Show();
            this.Close();
        }

        //Boton Menu de Calificaciones
        private void button5_Click_1(object sender, EventArgs e)
        {
            Calificaciones ca = new Calificaciones();
            ca.Show();
            this.Close();

        }

        //Boton Menu Asignaturas
        private void button4_Click_1(object sender, EventArgs e)
        {
            Asignaturas asg = new Asignaturas();
            asg.Show();
            this.Close();
        }

        //Boton menu de Profesor
        private void button3_Click_1(object sender, EventArgs e)
        {
            Profesor pro = new Profesor();
            pro.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Calificaciones cal = new Calificaciones();
            cal.Show();
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Calculo_Indice ind = new Calculo_Indice();
            ind.Show();
            this.Close();
        }
    }
}
