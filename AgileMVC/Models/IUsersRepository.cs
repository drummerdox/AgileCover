using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMVC.Models
{
     public interface IUsersRepository
    {
         Movie GetUser(int UserID);
    }
}
