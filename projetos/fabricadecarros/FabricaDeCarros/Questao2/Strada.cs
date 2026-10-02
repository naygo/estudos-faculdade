using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao2
{
    class Strada: Picape
    {

        public Strada(int chassis)
        {
            modelo = "Strada";
            this.chassis = chassis;

        }

        public override void exibirInfoPicape()
        {
            Console.WriteLine(modelo + " - " + fabrica + " - " + categoria + " - " + chassis);
        }
    }
}
