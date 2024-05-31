using Mediatek_86.dal;
using Mediatek_86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.controller
{  /// <summary>
   /// Controleur de FormAbsence
   /// </summary>
    public class AbsController
   {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Objet d'accès aux opération possibles sur Motif
        /// </summary>
        private readonly MotifAcces motifAcces;
        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public AbsController() 
        { 
            absenceAccess = new AbsenceAccess();
            motifAcces = new MotifAcces();
        }
        /// <summary>
        /// Récupère et retourne les infos des développeurs
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(Personnel personnel) 
        {
            return absenceAccess.GetLesAbsences(personnel);
        }
        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetLesMotifs() 
        {
            return motifAcces.GetLesMotifs();
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence) 
        { 
            absenceAccess.AddAbsence(absence);
        }
        /// <summary>
        /// Demande de suppresion d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence) 
        { 
            absenceAccess.DelAbsence(absence);
        }
        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        /// <param name="personnel">personnel concerné</param>
        /// <param name="dateDebut">datedebut originelle</param>
        public void UpdateAbsence(Absence absence, Personnel personnel, DateTime dateDebut) 
        { 
            absenceAccess.UpdateAbsence(absence, personnel, dateDebut);
        }
   }
}
