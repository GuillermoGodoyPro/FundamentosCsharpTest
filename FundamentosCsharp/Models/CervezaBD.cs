using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCsharp.Models
{
    internal class CervezaBD
    {
        //DESKTOP-HPKD1LJ
        private string connectionString = "Data Source=DESKTOP-HPKD1LJ\\SQLEXPRESS; Initial Catalog=cerveza;" +
          "User=sa;Password=xxx"  ;

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad " +
                "from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.marca = reader.GetString(1);

                    cervezas.Add(cerveza);
                }

                reader.Close(); 
                connection.Close();

            }

            return cervezas;
        }    
    }
}
