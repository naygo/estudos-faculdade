using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao2
{
    class Palio : CarroPopular
    {

        public Palio(int chassis)
        {
            modelo = "Palio";
            this.chassis = chassis;

        }
  
        public override void exibirInfoPopular()
        {
            Console.WriteLine(modelo+" - "+fabrica+" - "+categoria+" - "+chassis);
        }


    }
}
