using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using Mediatek_86.model;


namespace Mediatek_86.dal
{


    public class ResponsableAcces
    {
        private readonly Access access = null;

        public ResponsableAcces()
        {
            access = Access.GetInstance();
        }

        public Boolean ControlAuth(Responsable responsable) 
        { 
            if (access != null) 
            { 
                string req = "select * from responsable where login = @login and pwd = SHA2(@pwd,256)";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Identifiant);
                parameters.Add("@pwd", responsable.Mdp);
                
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}


