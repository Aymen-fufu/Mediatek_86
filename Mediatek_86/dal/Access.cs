using Mediatek_86.bddmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek_86.dal
{   /// <summary>
/// sigleton : classe d'acces a bddManager
/// </summary>
    public class Access
    {
        ///chaine de connecion a la bdd 
        /// MODIFIER LES PARAMETRES
        private static readonly string connectionString = "server=localhost;user id=user_mediatek86;password=user_mediatek86_pwd;persistsecurityinfo=True;database=mediatek86;SslMode=none";

        /// instance unique de la classe
        private static Access instance = null;

        /// getter sur l'objet d'acces au donnees
        public BddManager Manager { get; }

        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception) 
            { 
                Environment.Exit(0);
            }
        }
        
        /// creation d'une seule instance de la classe 
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
    }
}
