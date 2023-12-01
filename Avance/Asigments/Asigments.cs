using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance.Asigments
{
    internal class Asigments
    {
        public string ConsultaTareas()
        {
            string connectionString = "Data Source=AllanPC;Initial Catalog=Patitos_Fronterizos;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Asignaciones";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader[""].ToString();
                }
                else
                {
                    return "Null";
                }
            }
        }
    }
}
