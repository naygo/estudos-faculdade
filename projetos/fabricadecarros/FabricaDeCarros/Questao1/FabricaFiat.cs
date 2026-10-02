using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao1
{
    class FabricaFiat:FabricaDeCarros
    {
        protected string modelo;
        protected string fabrica;
        protected string categoria;
        protected int chassis;

        public FabricaFiat()
        {
            fabrica = "Fiat";
        }


        public override CarroSedan criarCarroSedan(int chassis)
        {
            return new Siena(chassis);
        }

        public override CarroPopular criarCarroPopular(int chassis)
        {
            return new Palio(chassis);
        }

        public static void teste()
        {
            FabricaDeCarros fabrica = new FabricaFiat();
            CarroSedan sedan = fabrica.criarCarroSedan(9876);
            CarroPopular popular = fabrica.criarCarroPopular(1234);

            sedan.exibirInfoSedan();
            popular.exibirInfoPopular();

            Console.Write("\n\nTecle qualquer tecla para exibir a próxima questão...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
