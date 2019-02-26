using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutterlin_Sebastien_Classe_Abstraite
{
    public class Patron: Employe
    {
        public static int ChiffreDaffaire { get; set; }
        public int Pourcentage { get; set; }
        public int Salaire { get; set; }






        public Patron(int CA, int pourcentage,int matricule, string nom, string prenom, DateTime datedenaissance) : base(matricule, nom, prenom, datedenaissance)
        {

            Patron.ChiffreDaffaire = CA;
            this.Pourcentage = pourcentage;

            this.GetSalaire();
            
            

            
            






        }





        public override int GetSalaire()
        {
            this.Salaire = (Patron.ChiffreDaffaire * this.Pourcentage) / 100;
            return this.Salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Le salaire de ce patron est de " + this.GetSalaire() + " et son pourcentage est" + this.Pourcentage;
        }

















    }
}
