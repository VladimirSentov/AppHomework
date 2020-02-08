using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Models
{
    public enum SocialStatus
    {
        Unknow = 0,
        Worker = 1,
        Student = 2,
        Pensioner = 3,
        Child = 4
    }
    public class User
    {
        public Guid UserID { get; set; }
        public DateTime Date { get; set; }
        public String Name { get; set; }
        public int Amount { get; set; }
        public String Currency { get; set; }
        public String UserName { get; set; }
        public SocialStatus Status { get; set; }


        public override string ToString()
        {
            //return $"Date:{Date};Name:{Name};Amount:{Amount}; Currency:{Currency}; UserName: {UserName}; Status: {Status} ";
            return $"{Date.ToString("d")},{Name},{Amount},{Currency},{UserName},{Status}";
        }


        public User Parse(String t)
        {
            User userResult = null;

            string[] expenseValues = t.Split(new char[] { ',' });


            userResult = new User();
        

            userResult.Date = DateTime.Parse(expenseValues[0]);
            userResult.Name = expenseValues[1];
            userResult.Amount = int.Parse(expenseValues[2]);
            userResult.Currency = expenseValues[3];
            userResult.UserName = expenseValues[4];
            SocialStatus status;
            Enum.TryParse(expenseValues[5], true, out status);
            userResult.Status = status;


            return userResult;
         
        }
    }
}
