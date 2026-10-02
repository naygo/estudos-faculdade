using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao2
{
    class Siena : CarroSedan
    {

        public Siena(int chassis)
        {
            modelo = "Siena";
            this.chassis = chassis;
        }

        public override void exibirInfoSedan()
        {
            Console.WriteLine(modelo + " - " + fabrica + " - " + categoria + " - " + chassis);
        }
    }
}
