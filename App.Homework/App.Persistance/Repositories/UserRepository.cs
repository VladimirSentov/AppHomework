using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App.Persistance.Repositories
{
   public class UserRepository
    {
        public void Insert(User user)

        {
            
            using (StreamWriter userStreamWriter = new StreamWriter(@"\Data\Users.csv", true))
            {
                userStreamWriter.WriteLine(user);
            }
        }
    }
}
