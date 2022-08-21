using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_02_01_FactoryMethod
{
    internal class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabreza Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabreza especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
