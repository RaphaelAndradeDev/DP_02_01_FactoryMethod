using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_02_01_FactoryMethod
{
    internal class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) return new PizzaMussarelaSP();
            if (tipo.Equals("C")) return new PizzaCalabresaSP();
            else return null;
        }
    }
}
