using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_02_01_FactoryMethod
{
    internal class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmessão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
