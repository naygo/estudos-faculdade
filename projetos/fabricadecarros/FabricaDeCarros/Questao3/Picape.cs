using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    abstract class Picape: FabricaVW
    {
        public Picape()
        {
            categoria = "Picape";
        }
        abstract public void exibirInfoPicape();


    }
}
