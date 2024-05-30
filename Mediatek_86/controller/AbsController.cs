using Mediatek_86.dal;
using Mediatek_86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.controller
{
   public class AbsController
   {

        private readonly AbsenceAccess absenceAccess;
        private readonly MotifAcces motifAcces;

        public AbsController() 
        { 
            absenceAccess = new AbsenceAccess();
            motifAcces = new MotifAcces();
        }

        public List<Absence> GetLesAbsences(Personnel personnel) 
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        public List<Motif> GetLesMotifs() 
        {
            return motifAcces.GetLesMotifs();
        }

        public void AddAbsence(Absence absence) 
        { 
            absenceAccess.AddAbsence(absence);
        }

        public void DelAbsence(Absence absence) 
        { 
            absenceAccess.DelAbsence(absence);
        }

        public void UpdateAbsence(Absence absence, Personnel personnel, DateTime dateDebut) 
        { 
            absenceAccess.UpdateAbsence(absence, personnel, dateDebut);
        }
   }
}
