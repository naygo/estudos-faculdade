using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaDeCarros.Questao1;
using FabricaDeCarros.Questao2;
using FabricaDeCarros.Questao3;

namespace FabricaDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao1.FabricaFiat.teste();
            Questao2.FabricaFiat.teste();
            FabricaVW.teste();
            Console.ReadKey();

        }
    }
}
