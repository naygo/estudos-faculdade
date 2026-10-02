using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    abstract class CarroSedan : FabricaVW
    {
        

        public CarroSedan()
        {
            categoria = "Sedan";
        }
        abstract public void exibirInfoSedan();


    }
}
