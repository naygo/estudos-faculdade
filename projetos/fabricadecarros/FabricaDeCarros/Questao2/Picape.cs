using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao2
{
    abstract class Picape: FabricaFiat
    {
        public Picape()
        {
            categoria = "Picape";
        }
        abstract public void exibirInfoPicape();


    }
}
