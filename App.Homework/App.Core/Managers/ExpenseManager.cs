using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using App.Persistance.Repositories;
namespace App.Core.Managers
{
    public class ExpenseManager
    {
        ExpenseRepository expenseRepository = new ExpenseRepository();


        public void GenerateTestData()
        {
            for (var i = 0; i <= 5; i++)
            {
                var expense = new Expense
                {
                

                    ExpenseId = Guid.NewGuid(),
                        Name = "ExpenseBolt",
                        Amount = 18,
                        Date = new DateTime(19, 11, 01),
                        ExpenseName = "Vladimir",
                        Currency = "MDL",
                      
                    

                };
                expenseRepository.Insert(expense);

                expense = new Expense
                {
                 

                    ExpenseId = Guid.NewGuid(),
                        Name = "ExpenseBread",
                        Amount = 25,
                        Date = new DateTime(19, 12, 05),
                    ExpenseName = "Vladimir",
                        Currency = "MDL",
                     
                    

                };
                expenseRepository.Insert(expense);


            }
        }
    }

}