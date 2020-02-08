using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App.Persistance.Repositories
{
    public class ExpenseRepository
    {
        private string fileExpens = @"\Data\Expenses.csv";

        public void Insert(Expense expense)
        {
            using (StreamWriter expenseStreamWriter = new StreamWriter(fileExpens, true))
            {
                expenseStreamWriter.WriteLine(expense);
            };

        }
            //public void ReadList()
            //{
            //  using (StreamReader expenseSteamReader=new StreamReader(fileExpens))
            //    {
            //        Console.WriteLine(expenseSteamReader.ReadToEnd());
            //    }
            //}


       
    }
}
