using CarSave.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSave.Entities.Concrete
{
    public class Car:BaseEntity
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public decimal Price { get; set; }

        public Car(int Id, string Model, string Marka, decimal Price)
        {
            this.Id = Id;
            this.Model = Model;
            this.Marka = Marka;
            this.Price = Price;
        }

    }
}
