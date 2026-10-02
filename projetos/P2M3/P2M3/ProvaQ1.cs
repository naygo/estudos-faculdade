using System;
using System.Collections.Generic;
using System.Text;

namespace P2M3
{
    class CCelulaDicionario
    {
        // Atributos
        public Object key, value;
        public CCelulaDicionario prox;
        // Construtora que anula os três atributos da célula
        public CCelulaDicionario()
        {
        }
        // Construtora que inicializa key e value com os argumentos passados
        // por parâmetro e anula a referência à próxima célula
        public CCelulaDicionario(Object chave, Object valor)
        {
        }
        // Construtora que inicializa todos os atribulos da célula com os argumentos
        // passados por parâmetro
        public CCelulaDicionario(Object chave, Object valor, CCelulaDicionario proxima)
        {
        }
    }
    class CDicionario
    {
        private CCelulaDicionario primeira, ultima;
        public CDicionario()
        {
        }
        public bool vazio()
        {
        }
        public void put(Object key, Object value)
        {
        }
        public Object get(Object key)
        {
        }
    }
}
