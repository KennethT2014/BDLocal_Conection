using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BDLocal_Conection.Data;
//using System.Data.Entity.Core.EntityProductos;

namespace BDLocal_Conection.Clases
{
    public class DProducto
    {
        SqlConnection sqlConnection = new SqlConnection();

        static string servidor = "KENNETH";
        static string baseDatos = "Productos" ;
        static string usuario = "joan";
        static string password = "654321";
        static string puerto = "53198";

        string cadenaConexion = "data source="+servidor+","+puerto+";user id="+usuario+";password="+password+";initial catalog=" + baseDatos+";persist security info=true";

        public SqlConnection EstablecerConexion()
        {
            try
            {
                sqlConnection.ConnectionString = cadenaConexion;
                sqlConnection.Open();
                MessageBox.Show("No hubieron excepciones inesperadas, y se\nestablecio la conexión con los datos correctamente.");
            }catch(SqlException ex)
            {
                MessageBox.Show("Error en la conexión del tipo "+ex.ToString());
            }

            return sqlConnection;
        }

        static public void SalvarProducto(Producto p)
        {

        }

        public static List<Producto> MostrarProductos()
        {
            var Consulta = (from c in EstablecerConexion().Database select c);
            return Consulta.ToList();
        }
    }
}
