using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeGlaserHW1
{
    public class PizzaInfo
    {
        public string pizzaSize { get; set; }

        // The instructions say 15 for both medium and large.
        public int pizzaBaseCost { get; set; }

        public int numberOfToppings { get; set; }

        public List<string> toppingsList { get; set; }
    }
}
