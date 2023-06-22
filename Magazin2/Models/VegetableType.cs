using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin2
{
    public class VegetableType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        ICollection<Vegetable> Vegetable { get; set; }
    }
}
