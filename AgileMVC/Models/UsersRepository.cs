using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AgileMVC.Models
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;
        public UsersRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Movie GetUser(int id)
    {
        // Here you are free to do whatever data access code you like
        // You can invoke direct SQL queries, stored procedures, whatever 

        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = conn.CreateCommand())
        {
            conn.Open();
            cmd.CommandText = "SELECT id, name FROM person WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                return new Movie
                {
                    UserID = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
            }
        }
    }
    }
}