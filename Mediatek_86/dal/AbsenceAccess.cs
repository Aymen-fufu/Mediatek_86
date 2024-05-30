using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.model;

namespace Mediatek_86.dal
{
    public class AbsenceAccess
    {
        private readonly Access access = null;

        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        public List<Absence> GetLesAbsences(Personnel personnel) 
        { 
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null) 
            {
                string req = "SELECT p.idpersonnel as idpersonnel, a.datedebut as datedebut, a.datefin as datefin, a.idmotif as idmotif, m.libelle as motif ";
                req += "FROM personnel p JOIN absence a ON (p.idpersonnel = a.idpersonnel) JOIN motif m ON (a.idmotif = m.idmotif) ";
                req += "WHERE p.idpersonnel = @idpersonnel ";
                req += "ORDER BY a.datedebut DESC;";
                Dictionary<string, Object> parameters = new Dictionary<string, Object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if(records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }

            }
        }
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        public void DelAllAbsence(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel;";
                Dictionary<string, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        public void UpdateAbsence(Absence absence, Personnel personnel, DateTime dateDebut)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebutref";
                Dictionary<string, Object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                parameters.Add("@datedebutref", dateDebut);

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }

            }
        }
    }
}
