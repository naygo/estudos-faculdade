using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao3
{
    class FabricaVW:FabricaDeCarros
    {
        protected string modelo;
        protected string fabrica;
        protected string categoria;
        protected int chassis;

        public FabricaVW()
        {
            fabrica = "Volkswagen";
        }


        public override CarroSedan criarCarroSedan(int chassis)
        {
            return new Voyage(chassis);
        }

        public override CarroPopular criarCarroPopular(int chassis)
        {
            return new Gol(chassis);
        }
        public override Picape criarPicape(int chassis)
        {
            return new Saveiro(chassis);
        }

        public static void teste()
        {
            FabricaDeCarros fabrica = new FabricaVW();
            CarroSedan sedan = fabrica.criarCarroSedan(9876);
            CarroPopular popular = fabrica.criarCarroPopular(1234);
            Picape picape = fabrica.criarPicape(5674);

            sedan.exibirInfoSedan();
            popular.exibirInfoPopular();
            picape.exibirInfoPicape();

        }

    }
}
