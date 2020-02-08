using App.Domain.Models;
using App.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Managers
{
   public class UserManager
    {
        UserRepository userRepository = new UserRepository();

        public void GenerateData()
        {
            var user = new User
            {
                UserID = Guid.NewGuid(),
                Name = "Milk",
                Amount = 18,
                Date = new DateTime(19, 12, 01),
                UserName = "Vladimir",
                Currency = "MDL",
                Status = 0

            };

            userRepository.Insert(user);

            user = new User
            {
                UserID = Guid.NewGuid(),
                Name = "Bread",
                Amount = 25,
                Date = new DateTime(19, 12, 05),
                UserName = "Vladimir",
                Currency = "MDL",
                Status = SocialStatus.Pensioner
            };

            userRepository.Insert(user);

        }
    }
}
