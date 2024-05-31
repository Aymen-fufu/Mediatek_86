using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.model
{
    /// <summary>
    /// Classe métier liée à la table Service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>
        public Service(int idprofil, string nom)
        {
            this.IdService = idprofil;
            this.Nom = nom;
        }
        public int IdService { get; }
        public string Nom { get; }
        /// <summary>
        /// Définit l'information à afficher (nom)
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
