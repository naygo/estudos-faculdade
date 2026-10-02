using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    class Gol : CarroPopular
    {

        public Gol(int chassis)
        {
            modelo = "Gol";
            this.chassis = chassis;

        }
  
        public override void exibirInfoPopular()
        {
            Console.WriteLine(modelo+" - "+fabrica+" - "+categoria+" - "+chassis);
        }


    }
}
