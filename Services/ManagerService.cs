using DataBase;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ManagerService
    {
        public void ChangeCapacity(int newCapacity)
        {
            Aeroplane aeroplane = new Aeroplane();
            aeroplane.capacity = newCapacity;
        }
        DataBase dataBase = new DataBase();
        
    }
}
