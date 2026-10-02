using System;
using System.Collections.Generic;
using System.Text;

namespace P2M3
{
    #region Classe CCelula - representa a célula utilizada pelas classes CLista, CFila e CPilha
    class CCelula
    {
        public Object Item; // O Item armazendo pela célula
        public CCelula Prox; // Referencia a próxima célula

        public CCelula()
        {
            Item = null;
            Prox = null;
        }

        public CCelula(object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }

        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
    #endregion

    #region Classe CFila - Fila (ou lista FIFO: first-in first-out)
    class CFila
    {
        private CCelula Frente; // Referencia a primeira célula da CFila (Célula cabeça)
        private CCelula Tras; // Referencia a última célula da CFila
        private int Qtde = 0;

        public CFila()
        {
            Frente = new CCelula();
            Tras = Frente;
        }

        public bool Vazia()
        {
            return Frente == Tras;
        }

        public void Enfileira( ... ) // Defina os parâmetros que você achar necessários
        {
            // Construa seu método para enfileirar
        }

        public Object Desenfileira()
        {
            Object Item = null;
            if (Frente != Tras)
            {
                Frente = Frente.Prox;
                Item = Frente.Item;
                Qtde--;
            }
            return Item;
        }

        public Object Peek()
        {
            return (Frente != Tras) ? Frente.Prox.Item : null;
        }

        public bool Contem(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Frente.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public int Quantidade()
        {
            return Qtde;
        }

        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }
    }
    #endregion

}
