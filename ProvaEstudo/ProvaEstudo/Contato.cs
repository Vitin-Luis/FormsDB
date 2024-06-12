using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEstudo
{
    public class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        public Contato(int id, string nome, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
        }

        public Contato() { }

        public override string ToString()
        {
            return nome;
        }

    }
}
