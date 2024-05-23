using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.model
{
    public class Responsable
    {

        /// <param name="identifiant"></param>
        /// <param name="mdp"></param>
        public Responsable(string identifiant, string mdp) 
        {
            this.Identifiant = identifiant;
            this.Mdp = mdp;
        }
        public string Identifiant { get; }
        public string Mdp { get; }
    }
}
