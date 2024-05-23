using Mediatek_86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.dal
{
    public class PersonnelAcces
    {
        private readonly Access access = null;

        public PersonnelAcces()
        {
            access = Access.GetInstance();
        }

        public List<Personnel> GetLesPersonnels() 
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null) 
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service ";
                req += "from personnel p join service s on (p.idservice = s.idservice) ";
                req += "order by nom, prenom;";

                try 
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if(records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null) 
            { 

            }
        }
       
    }

    
}
