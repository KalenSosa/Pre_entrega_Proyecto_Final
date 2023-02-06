using practica_sql;
using System;
using System.Data.SqlClient;


namespace ManipulandoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class DataAccess
        {
            private string connectionString = "Data Source=DESKTOP-C32K7O8\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            public Usuario GetUser(int userId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Id = 1", connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    
                        return new Usuario
                        {
                            Id1 = reader.GetInt64(0),
                            Nombre1 = reader.GetString(1),
                           Contraseña1 = reader.GetString(4)
                        };
                    }

                    return null;
                }
            }

            public List<Producto> GetProducts(int userId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Producto WHERE Id = 1", connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    SqlDataReader reader = command.ExecuteReader();
                    List<Producto> products = new List<Producto>();

                    while (reader.Read())
                    {
                        products.Add(new Producto
                        {
                            Id1 = reader.GetInt64(0),
                            Descripciones1 = reader.GetString(1),
                            Costo1 = reader.GetFloat(2),
                            PrecioVenta1 = reader.GetFloat(3)
                        });
                    }

                    return products;
                }
            }

            public List<ProductoVenta> GetSoldProducts (int userId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT p.* FROM Producto AS P INNER JOIN Venta AS V ON p.Id = V.Id WHERE p.Id = 1", connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    SqlDataReader reader = command.ExecuteReader();
                    List<ProductoVenta> SoldProducts = new List<ProductoVenta>();

                    while (reader.Read())
                    {
                     SoldProducts.Add(new ProductoVenta
                        {
                            Id1 = reader.GetInt64(0),
                            Stock1 = reader.GetInt32(1),
                            IdProducto1 = reader.GetInt64(2),
                            IdVenta1 = reader.GetInt64(3)

                        });
                    }

                    return SoldProducts;
                }
            }

            public List<Venta> GetSales (int userId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                 SqlCommand command = new SqlCommand("SELECT V.* FROM Venta As V INNER JOIN Producto AS P ON V.IdUsuario = P.IdUsuario WHERE p.Id = 1", connection);
                 command.Parameters.AddWithValue("@UserId", userId);


                SqlDataReader reader = command.ExecuteReader();
                List<Venta> Sales = new List<Venta>();

                while (reader.Read())
                {
                    Sales.Add(new Venta
                    {
                        Id1 = reader.GetInt64(0),
                        Comentarios1 = reader.GetString(1),
                        IdUsuario1 = reader.GetInt64(2)
                    }); ; ;
                }

                return Sales;

            }
            }
        }

    }
