using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PList_Contact
{
    internal class ListaTelefone
    {
        public Telefone Head { get; set; }
        public Telefone Tail { get; set; }

        public ListaTelefone()
        {
            Head = Tail = null;
        }

        public void Puch(Telefone aux)
        {
            if (Tail == null && Head == null)
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
        }

        public string Print()
        {
            string telefone = "";
            Telefone aux = Head;
            do
            {
                telefone = telefone + aux.ToString();
                aux = aux.Proximo;
            } while (aux != null);
            return telefone;
        }

    }
}
