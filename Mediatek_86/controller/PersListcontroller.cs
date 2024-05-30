using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.dal;
using Mediatek_86.model;

namespace Mediatek_86.controller
{
    public class PersListcontroller
    {
        private readonly PersonnelAcces personnelAcces;

        private readonly AbsenceAccess absenceAccess;

        public PersListcontroller()
        {
            personnelAcces = new PersonnelAcces();
            absenceAccess = new AbsenceAccess();
        }

        public List<Personnel> GetLesPersonnels() 
        { 
            return personnelAcces.GetLesPersonnels();
        }

        public void DelAllAbsence(Personnel personnel) 
        { 
            absenceAccess.DelAllAbsence(personnel);
        }

        public void DelPersonnel(Personnel personnel) 
        { 
            personnelAcces.DelPersonnel(personnel);
        }
    }
    
}
