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
                            DateTime fecha = Convert.ToDateTime(reader["Fecha"]).Date;
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);

                            Producto prod = ADOProducto.Obtener(id);

                            ventas.Add(new Venta(id, productoId, fecha, prod, cantidad));


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

        public static void Guardar(Venta venta)
        {
            try
            {

                string query = "INSERT INTO Venta (Producto_Id, Fecha, Cantidad) VALUES (@Producto_Id, @Fecha, @Cantidad)";


                using (SqlConnection sqlConnection = new SqlConnection(ADOVenta.stringConnection))
                {
                    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

                    sqlCommand.Parameters.AddWithValue("Producto_Id", venta.ProductoId);
                    sqlCommand.Parameters.AddWithValue("Fecha", venta.Fecha);
                    sqlCommand.Parameters.AddWithValue("Cantidad", venta.Cantidad);


                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();   
                }
    
            }
            catch (Exception)
            {

            }
        }
    }
  
}
