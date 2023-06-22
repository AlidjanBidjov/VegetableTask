using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin2.Models
{
    public class VegetableContext:DbContext
    {
        public VegetableContext() : base("VegetableContext")
        {

        }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<VegetableType> VegetablesType { get; set; }
    }
}
