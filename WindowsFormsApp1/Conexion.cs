using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Conexion
    {
        public SqlConnection cadenaSql = new SqlConnection("Data Source=SQL5101.site4now.net;Initial Catalog=DB_A6EB38_TractoLeo;User Id=DB_A6EB38_TractoLeo_admin;Password=Elpsykongro145");
        
        //public SqlConnection cadenaSql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TractoLeo-Test;Integrated Security=True");
        public void conecta()
        {
            try
            {
                cadenaSql.Open();
            }
            catch
            {
                string Msj = "Verifique su conexion a internet";
                MessageBox.Show(Msj);
            }
            
        }
        public void desconecta()
        {
            cadenaSql.Close();
        }
    }
}
