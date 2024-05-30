using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.dal;
using Mediatek_86.model;

namespace Mediatek_86.controller
{
    public class AddPersController
    {
        private readonly ServiceAccess serviceAccess;
        private readonly PersonnelAcces personnelAccess;

        public AddPersController()
        {
            serviceAccess = new ServiceAccess();
            personnelAccess = new PersonnelAcces();
        }

        public List<Service> GetLesServices() 
        {
            return serviceAccess.GetLesServices();
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        public void AddPersonnel(Personnel personnel) 
        { 
            personnelAccess.AddPersonnel(personnel);
        }
    }
}
