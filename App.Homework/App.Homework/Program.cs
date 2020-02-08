using App.Core.Managers;
using System;

namespace App.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.GenerateData();

            ExpenseManager expenseManager = new ExpenseManager();
            expenseManager.GenerateTestData();


            RaportManager raportManager = new RaportManager();
            raportManager.Execute();



        }
    }
}
