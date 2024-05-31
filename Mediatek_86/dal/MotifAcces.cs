﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediatek_86.model;

namespace Mediatek_86.dal

{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les motifs
    /// </summary>
    public class MotifAcces
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public MotifAcces()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        /// <returns>Liste des motifs</returns>
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
