using CarSave.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSave
{
    public class SeedData
    {
        public List<Car> CarList = new List<Car>()
        {
            new Car(1,"Ceed","Kia",350000.75m),
            new Car(2,"Rio","Kia",310000.15m)
        };
        
    }
}
