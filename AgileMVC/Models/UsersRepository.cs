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
            _connectionString = @"Data Source=NOTEBOOK\SQLEXPRESS;Initial Catalog=SomeDatabese;Integrated Security=True";
        }



        public Movie GetUser(int UserID)
    {
        // Here you are free to do whatever data access code you like
        // You can invoke direct SQL queries, stored procedures, whatever 

        using (var conn = new SqlConnection(_connectionString))
        using (var cmd = conn.CreateCommand())
        {
            conn.Open();
            cmd.CommandText = "SELECT UserID, name FROM Persons WHERE UserID = @UserID";
            cmd.Parameters.AddWithValue("@UserID", UserID);
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }
                return new Movie
                {
                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                };
            }
        }
    }
    }
}