using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            string conectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbAcademia.mdf;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(conectionString);
            conexion.Open();

            return conexion;
          
        }
    }
}
