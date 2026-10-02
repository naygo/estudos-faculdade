using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    abstract class CarroPopular : FabricaVW
    {
        public CarroPopular()
        {
            categoria = "Popular";
        }

        abstract public void exibirInfoPopular();

    }
}
