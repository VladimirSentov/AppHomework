using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App.Persistance.Repositories
{
    public class RaportRepository
    {
        private string fileExpens = @"\Data\Users.csv";


        public List<User> GetExpense()
        {
            User user = new User();
            List<User> users = new List<User>();
            using (StreamReader expenseSteamReader = new StreamReader(fileExpens))
            {
                string expenseMassiv;
                while ((expenseMassiv = expenseSteamReader.ReadLine()) != null)
                {
                    // expenseMassiv = expenseSteamReader.ReadToEnd();                  
                    user = user.Parse(expenseMassiv);
                    users.Add(user);
                }
            };
            return users;
        }

        public void Insert()
        {   
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int total = 0;
            DateTime reportDay=DateTime.Now;
            string curency=null;
            string fileExpenses = $@"\Data\Expenses_{month}_{year}.csv";
            List<User> users = GetExpense();
            foreach (User user in users)
            {
                total += user.Amount;
                curency = user.Currency;

                using (StreamWriter expenseStreamWriter = new StreamWriter(fileExpenses, true))
                {
                    expenseStreamWriter.WriteLine(user);
                };
            }

            using (StreamWriter expenseStreamWriter = new StreamWriter(fileExpenses, true))
            {
                expenseStreamWriter.WriteLine($"\t\t\t\t\t\t\t\tTotal:{total}{curency}\n\t\t\t\t\t\t\t\tDate:{reportDay}");
            };
        }
    }
}
