using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace fundamentos_CSHARP.Models
{
    internal class ManageDB
    {
        private MySqlConnection connection = Conection.ConectDB();
        public void View()
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM animales WHERE id > @number;";
                command.Parameters.AddWithValue("@number", 0);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Muestra los nombres de las columnas
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i) + "\t");
                    }
                    Console.WriteLine();

                    // Muestra los datos de cada fila
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i].ToString() + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    public void Add(byte Familia, string Sonido, byte Tamaño, string Nombre, byte Velocidad)
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO animales (familia, sonido, tamaño, nombre, velocidad) " + 
                                                   "VALUES (@familia, @sonido, @tamaño, @nombre, @velocidad);";

                command.Parameters.AddWithValue("@familia", Familia);
                command.Parameters.AddWithValue("@sonido", Sonido);
                command.Parameters.AddWithValue("@tamaño", Tamaño);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@velocidad", Velocidad);

                command.ExecuteNonQuery();

                Console.WriteLine("Registro agregado");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Edit(byte Id, byte Familia, string Sonido, byte Tamaño, string Nombre, byte Velocidad)
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE animales Set familia = @familia, sonido = @sonido, tamaño = @tamaño, nombre = @nombre, velocidad = @velocidad "+
                                      "WHERE id = @ID;";

                command.Parameters.AddWithValue("@familia", Familia);
                command.Parameters.AddWithValue("@sonido", Sonido);
                command.Parameters.AddWithValue("@tamaño", Tamaño);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@velocidad", Velocidad);
                command.Parameters.AddWithValue("@ID", Id);

                command.ExecuteNonQuery();

                Console.WriteLine("Registro modificado");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Delete(byte Id)
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM animales WHERE id = @ID;";

                command.Parameters.AddWithValue("@ID", Id);

                command.ExecuteNonQuery();

                Console.WriteLine("Registro Eliminado");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}
