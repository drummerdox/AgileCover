using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AgileMVC.Models
{
    public interface IUsersRepository
    {
        public Movie GetUser(int UserID);
    }
}
