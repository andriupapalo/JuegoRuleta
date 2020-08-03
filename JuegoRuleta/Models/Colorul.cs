using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoRuleta.Models
{
    public class Colorul
    {
        public int indice { get; set; }
        public string name { get; set; }
        public Colorul(int indice, string name)
        {
            this.indice = indice;
            this.name = name;
        }

        public Colorul()
        {
        }
    }
}

