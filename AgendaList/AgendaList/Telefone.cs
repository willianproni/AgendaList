using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PList_Contact
{
    internal class Telefone
    {
        public string Tipo { get; set; }
        public int DDD { get; set; }
        public float Numero { get; set; }
        public Telefone Proximo { get; set; }

        public Telefone(string tipo, int ddd, float número)
        {
            Tipo = tipo;
            DDD = ddd;
            Numero = número;
            Proximo = null;
        }

        public override string ToString()
        {
            return $"\n{Tipo}" +
                    $"\n({DDD}) {Numero}\n";
        }
    }
}
