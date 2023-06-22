using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin2
{
    public class Vegetable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public int typeId { get; set; }
        VegetableType vegetableType { get; set; }
    }
}
