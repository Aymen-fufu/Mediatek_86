using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.model;

namespace Mediatek_86.dal
{
    public class ServiceAccess
    {
        private Access access = null;

        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Service> GetLesServices() 
        { 
            List<Service> lesServices = new List<Service>();

            if (access.Manager != null) 
            { 
                string req = "select * from service order by nom";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records) 
                        {
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
