using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_02_01_FactoryMethod
{
    internal class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não foi criada");
            }
            return pizzaria;
        }
    }
}
