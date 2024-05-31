using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.dal;
using Mediatek_86.model;

namespace Mediatek_86.controller
{   /// <summary>
    /// Controleur de FormaddPers
    /// </summary>
    public class AddPersController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        private readonly PersonnelAcces personnelAccess;
        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public AddPersController()
        {
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAcces();
        }
        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetLesServices() 
        {
            return serviceAccess.GetLesServices();
        }
        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }
        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void AddPersonnel(Personnel personnel) 
        { 
            personnelAccess.AddPersonnel(personnel);
        }
    }
}
