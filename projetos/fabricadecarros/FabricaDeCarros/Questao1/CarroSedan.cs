using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao1
{
    abstract class CarroSedan : FabricaFiat
    {
        

        public CarroSedan()
        {
            categoria = "Sedan";
        }
        abstract public void exibirInfoSedan();


    }
}
