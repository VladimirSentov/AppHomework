using App.Domain.Models;
using App.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Managers
{
    public class RaportManager
    {
    private RaportRepository raportRepository = new RaportRepository();
        public void Execute()
        {     
            raportRepository.GetExpense();
            raportRepository.Insert();
        }
    }


}
