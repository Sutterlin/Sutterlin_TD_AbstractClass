using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutterlin_Sebastien_Classe_Abstraite
{
    /// <summary>
    /// ouvrier se conforme à la classe Employe. 
    /// </summary>
    class Ouvrier : Employe
    {
        public DateTime DateArrivee { get; set; }
        public int Salaire { get; set; }



        
        const int SMIG = 2500;

        public Ouvrier(int matricule, DateTime DateArrivee, string nom, string prenom, DateTime datedenaissance) : base(matricule, nom, prenom, datedenaissance)
        {
            this.DateArrivee = DateArrivee;


            this.GetSalaire();

        






        }





        public override int GetSalaire()
        {
            if ((SMIG + (DateTime.Now.Year - this.DateArrivee.Year) * 100) < SMIG * 2)
            {
                this.Salaire = SMIG + (DateTime.Now.Year - this.DateArrivee.Year) * 100;
            }
            else
            {
                this.Salaire = SMIG * 2;
            }
            return this.Salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Le salaire de cet ouvrier est de " + this.GetSalaire() + " et sa date d'arrivée est " + this.DateArrivee;
        }
    }
}
