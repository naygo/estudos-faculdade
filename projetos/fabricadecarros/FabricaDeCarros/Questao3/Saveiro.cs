using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    class Saveiro: Picape
    {

        public Saveiro(int chassis)
        {
            modelo = "Saveiro";
            this.chassis = chassis;

        }

        public override void exibirInfoPicape()
        {
            Console.WriteLine(modelo + " - " + fabrica + " - " + categoria + " - " + chassis);
        }
    }
}
