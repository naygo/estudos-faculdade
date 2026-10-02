using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    class Voyage : CarroSedan
    {

        public Voyage(int chassis)
        {
            modelo = "Voyage";
            this.chassis = chassis;
        }

        public override void exibirInfoSedan()
        {
            Console.WriteLine(modelo + " - " + fabrica + " - " + categoria + " - " + chassis);
        }
    }
}
