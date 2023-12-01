using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avance.Config;
using Avance.Enums;
using Avance.Cursos;

namespace Avance.Services
{
    internal class AuthenticationService
    {
        public int? AuthenticateStudent(string correoElectronico, string contrasena)
        {
            using (var connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                var query = "SELECT EstudianteID FROM EstudiantesAnálisis WHERE CorreoElectronico = @CorreoElectronico AND Contrasena = @Contrasena";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena); // Asumiendo que la contraseña está en texto plano, aunque debería estar hasheada

                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return null; // Devuelve null si las credenciales no son correctas
        }

        public int? AuthenticateProfessor(string correoElectronico, string contrasena)
        {
            using (var connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                var query = "SELECT ProfesorID FROM Profesores WHERE CorreoElectronico = @CorreoElectronico AND Contrasena = @Contrasena";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena); // Asume que la contraseña está hasheada

                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return null; // Devuelve null si las credenciales no son correctas
        }
        public List<Curso> GetCursosDelEstudiante(int estudianteId)
        {
            List<Curso> cursosDelEstudiante = new List<Curso>();
            using (var connection = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                var query = @"
            SELECT CursoID, NombreCurso 
            FROM EstudianteCursos
            WHERE EstudianteID = @EstudianteID";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteId);
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var curso = new Curso
                            {
                                CursoID = reader.GetInt32(reader.GetOrdinal("CursoID")),
                                NombreCurso = reader.GetString(reader.GetOrdinal("NombreCurso"))
                            };
                            cursosDelEstudiante.Add(curso);
                        }
                    }
                }
            }
            return cursosDelEstudiante;
        }

    }
}
