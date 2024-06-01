using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENFDB.DATA
{
    internal class mascotas
    {
        public string connectionstring = "server = localhost;database = mascotas;user=root;Password=Fabian178_";

        public bool Probarconexion()
        {
            using (MySqlConnection conection = new MySqlConnection(connectionstring))
            {
                try
                {
                    conection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }
        public DataTable leerpersonajes()
        {
            DataTable patitas = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "select * from patitas";
                using (MySqlCommand comand = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comand))
                    {
                        adapter.Fill(patitas);
                    }
                }
                return patitas;
            }
        }
        public int CrearPersonaje(string nombre,DateTime fecha_nacimeinto,  string raza, string color, string condicion, string sexo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "INSERT INTO patitas (nombre, fecha_nacimiento, raza, color, condicion, sexo) VALUES (@nombre, @fecha_nacimiento, @raza, @color, @condicion, @sexo)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimeinto);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@condicion", condicion);
                    command.Parameters.AddWithValue("@sexo", sexo);


                    return command.ExecuteNonQuery();
                }
            }
        }


        public int ActualizarPersonaje(string id, string nombre,DateTime fecha_nacimiento, string raza, string color, string condicion, string sexo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "update patitas set nombre=@nombre, fecha_nacimiento=@fecha_nacimiento, raza=@raza, color=@color, condicion=@condicion, sexo=@sexo where id=@id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@condicion", condicion);
                    command.Parameters.AddWithValue("@sexo", sexo);

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Borrarpersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string sql = "delete from patitas where id =@id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable Buscar(int id)
        {
            DataTable patitas = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string buscar = "SELECT * FROM patitas WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(buscar, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(patitas);
                    }
                }
            }

            return patitas;
        }
    }
}



