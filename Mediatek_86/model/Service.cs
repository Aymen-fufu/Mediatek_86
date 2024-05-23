using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.model
{
    public class Service
    {
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>

        public Service(int idprofil, string nom)
        {
            this.IdService = idprofil;
            this.Nom = nom;
        }
        public int IdService { get; }
        public string Nom { get; }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
