using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.model;

namespace Mediatek_86.dal
{
    public class MotifAcces
    {

        private readonly Access access = null;

        public MotifAcces()
        {
            access = Access.GetInstance();
        }

        public List<Motif> GetLesMotifs() 
        { 
            List<Motif> lesMotifs = new List<Motif>();
            
            if (access.Manager != null) 
            {
                string req = "select * from motif order by libelle";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (object[] record in records)
                        {
                            Motif motif = new Motif((int)record[0], (string)record[1]);
                            lesMotifs.Add(motif);
                        }
                    }
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesMotifs;
        }

    }
}
