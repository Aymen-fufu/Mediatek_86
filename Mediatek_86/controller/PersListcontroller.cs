using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.dal;
using Mediatek_86.model;

namespace Mediatek_86.controller
{   
    /// <summary>
    /// Controlleur de FormPersList
    /// </summary>
    public class PersListcontroller
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAcces personnelAcces;
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public PersListcontroller()
        {
            personnelAcces = new PersonnelAcces();
            absenceAccess = new AbsenceAccess();
        }
        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels() 
        { 
            return personnelAcces.GetLesPersonnels();
        }
        /// <summary>
        /// Demande de suppression de toutes les absences d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void DelAllAbsence(Personnel personnel) 
        { 
            absenceAccess.DelAllAbsence(personnel);
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Personnel concerné</param>
        public void DelPersonnel(Personnel personnel) 
        { 
            personnelAcces.DelPersonnel(personnel);
        }
    }
    
}
