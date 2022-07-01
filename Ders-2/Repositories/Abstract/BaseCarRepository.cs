using CarSave.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSave.Repositories.Abstract
{
    public abstract class BaseCarRepository
    {
        //CRUD işlemlerini yapacağız.
        public abstract List<Car> GetCars();
        public abstract void CreateCar(string Model, string Marka, decimal Price);
        public abstract void UpdateCar(int Id, string Model, string Marka, decimal Price);
        public abstract void DeleteCar(int Id);
        public abstract void Find(int Id, TextBox txtModel, TextBox txtMarka, TextBox txtPrice);
        public abstract void ClearTextBox(TextBox txtModel, TextBox txtMarka, TextBox txtPrice);
    }
}
