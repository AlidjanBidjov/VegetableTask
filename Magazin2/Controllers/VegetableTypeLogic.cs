using Magazin2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin2.Controllers
{
    public class VegetableTypeLogic
    {
        private VegetableContext _vegatableDbContext = new VegetableContext();

        public List<VegetableType> GetAllVegetableTypes()
        {
            return _vegatableDbContext.VegetablesType.ToList();
        }

        public string GetBreedById(int id)
        {
            return _vegatableDbContext.VegetablesType.Find(id).Name;
        }
    }
}
