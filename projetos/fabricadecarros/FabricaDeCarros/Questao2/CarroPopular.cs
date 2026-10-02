using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao2
{
    abstract class CarroPopular : FabricaFiat
    {
        public CarroPopular()
        {
            categoria = "Popular";
        }

        abstract public void exibirInfoPopular();

    }
}
