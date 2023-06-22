using Magazin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin2.Controllers
{
    public class VegetableLogic
    {
        private VegetableContext _vegetableDbContext = new VegetableContext();//Database
        public List<Vegetable> GetAll()
        {
            return _vegetableDbContext.Vegetables.Include("VegetableTypes").ToList();

        }
        public Vegetable Get(int id)
        {
            Vegetable findedVegetable = _vegetableDbContext.Vegetables.Find(id);
            if (findedVegetable != null)
            {
                _vegetableDbContext.Entry(findedVegetable).Reference(x => x.VegetableType).Load();
            }
            return findedVegetable;

        }

        public void Create(Vegetable vegetable)
        {
            _vegetableDbContext.Vegetables.Add(vegetable);
            _vegetableDbContext.SaveChanges();
        }

        public void Update(int id, Vegetable vegetable)
        {
            Vegetable findedVegetable = _vegetableDbContext.Vegetables.Find(id);
            if (findedVegetable == null)
            {
                return;
            }
            findedVegetable.Name = vegetable.Name;
            findedVegetable.price = vegetable.price;
            findedVegetable.Description = vegetable.Description;
            findedVegetable.typeId = vegetable.typeId; ;
            _vegetableDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Vegetable findedVegetable = _vegetableDbContext.Vegetables.Find(id);
            _vegetableDbContext.Vegetables.Remove(findedVegetable);
            _vegetableDbContext.SaveChanges();
        }
    }
}
