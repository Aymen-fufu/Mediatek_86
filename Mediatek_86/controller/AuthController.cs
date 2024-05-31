using Mediatek_86.dal;
using Mediatek_86.model;
using System;

namespace Mediatek_86.controller
{
    /// <summary>
    /// Controleur de FormAuth
    /// </summary>
    public class AuthController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAcces responsableAcces;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public AuthController() 
        { 
            responsableAcces = new ResponsableAcces();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns>vrai si les informations de connexion sont correctes</returns>
        
        public Boolean ControlAuth(Responsable responsable)
        {
            return responsableAcces.ControlAuth(responsable);
        }
    }
}
