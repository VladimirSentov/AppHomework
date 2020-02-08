using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Models
{
    public class Expense
    {
       
        public User User { get; set; }
        public Guid ExpenseId { get; set; }
        public DateTime Date { get; set; }
        public String Name { get; set; }
        public int Amount { get; set; }
        public String Currency { get; set; }
        public String ExpenseName { get; set; }
 
        public override string ToString()
        {
            return $"{ExpenseId},{Date},{Name},{Amount},{Currency},{ExpenseName}";
        }
    }
}
