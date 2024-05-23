using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.model
{
    public class Motif
    {
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        
        public Motif(int idmotif, string libelle) 
        { 
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
        public int Idmotif { get; }
        public string Libelle { get; }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
