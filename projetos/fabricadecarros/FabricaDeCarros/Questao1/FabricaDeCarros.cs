using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaDeCarros.Questao1
{
    abstract class FabricaDeCarros
    {
        public abstract CarroSedan criarCarroSedan(int chassis);
        public abstract CarroPopular criarCarroPopular(int chassis);
    }
}
