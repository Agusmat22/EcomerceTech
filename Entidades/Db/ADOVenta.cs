using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Db
{
    public static class ADOVenta
    {
        private static string stringConnection;

        static ADOVenta() 
        { 
            ADOVenta.stringConnection = "Server = .; Database = EcommerceTech; Trusted_Connection = True;";
        }


        public static List<Venta> Obtener()
        {

            List<Venta> ventas = new List<Venta>();

            try
            {
                string query = "SELECT * FROM Venta";

                using (SqlConnection sqlConnection = new SqlConnection(ADOVenta.stringConnection))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read()) 
                        { 
                            int id = Convert.ToInt32(reader["Id"]);
                            int productoId = Convert.ToInt32(reader["Producto_Id"]);
                            DateTime fecha = Convert.ToDateTime(reader["Fecha"]);

                            Producto prod = ADOProducto.Obtener(id);

                            ventas.Add(new Venta(id, productoId, fecha, prod));


                        }
                        
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            
            }

            return ventas;
        }
    }
}
