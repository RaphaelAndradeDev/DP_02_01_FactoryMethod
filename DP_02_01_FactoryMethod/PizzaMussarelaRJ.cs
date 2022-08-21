using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_02_01_FactoryMethod
{
    internal class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmessão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}
