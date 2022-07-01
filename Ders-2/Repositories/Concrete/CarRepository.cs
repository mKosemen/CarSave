using CarSave.Entities.Concrete;
using CarSave.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSave.Repositories.Concrete
{
    public class CarRepository : BaseCarRepository
    {
        public override void ClearTextBox(TextBox txtModel, TextBox txtMarka, TextBox txtPrice)
        {
            throw new NotImplementedException();
        }

        public override void CreateCar(string Model, string Marka, decimal Price)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCar(int Id)
        {
            throw new NotImplementedException();
        }

        public override void Find(int Id, TextBox txtModel, TextBox txtMarka, TextBox txtPrice)
        {
            throw new NotImplementedException();
        }

        public override List<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public override void UpdateCar(int Id, string Model, string Marka, decimal Price)
        {
            throw new NotImplementedException();
        }
    }
}
