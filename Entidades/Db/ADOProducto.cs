using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Db
{
    public static class ADOProducto
    {
        private static string stringConnection;

        static ADOProducto() 
        { 
            ADOProducto.stringConnection ="Server = .; Database = EcommerceTech; Trusted_Connection = True;";

        }


        /// <summary>
        /// Obtiene todos los productos de la DB
        /// </summary>
        /// <returns></returns>
        public static List<Producto> Obtener() 
        {

            List<Producto> productos = new List<Producto>();

            try
            {
                string query = "SELECT * FROM Producto";

                using (SqlConnection sqlConnection = new SqlConnection( ADOProducto.stringConnection))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read()) 
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            double precio = reader.GetDouble(2);

                            if (!Enum.TryParse(reader.GetString(3), out ETipo tipo))
                            {
                                throw new ArgumentNullException("Error TIPO INVALID");
                            }

                            int stock = reader.GetInt32(4);

                            productos.Add(new Producto(id, nombre, precio, tipo, stock)); 
                        }

                    }


                }

            }
            catch (Exception) 
            {
                throw;
            }

            return productos;
        
        
        }

        public static Producto Obtener(int idProducto)
        {

            Producto producto = new Producto();

            try
            {
                string query = "SELECT * FROM Producto WHERE Id=@IdProducto";

                using (SqlConnection sqlConnection = new SqlConnection(ADOProducto.stringConnection))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("IdProducto", idProducto);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            double precio = reader.GetDouble(2);

                            if (!Enum.TryParse(reader.GetString(3), out ETipo tipo))
                            {
                                throw new ArgumentNullException("Error TIPO INVALID");
                            }

                            int stock = reader.GetInt32(4);

                            producto =  new Producto(id, nombre, precio, tipo, stock);
                        }

                    }


                }

            }
            catch (Exception)
            {
                throw;
            }

            return producto;


        }

        public static void Guardar(Producto producto)
        {

            try
            {
                string query = "INSERT INTO Producto (Nombre,Precio,Tipo,Stock) VALUES (@Nombre,@Precio,@Tipo,@Stock)";

                using (SqlConnection sqlConnection = new SqlConnection(ADOProducto.stringConnection))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Nombre", producto.Nombre);
                    sqlCommand.Parameters.AddWithValue("Precio", producto.Precio);
                    sqlCommand.Parameters.AddWithValue("Tipo", producto.Tipo.ToString());
                    sqlCommand.Parameters.AddWithValue("Stock", producto.Stock);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();


                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void Eliminar(Producto producto)
        {

            try
            {
                string query = "DELETE FROM * WHERE id=@id";

                using (SqlConnection sqlConnection = new SqlConnection(ADOProducto.stringConnection))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("id", producto.Id);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();


                }

            }
            catch (Exception)
            {
                throw;
            }

        }

    }

}

