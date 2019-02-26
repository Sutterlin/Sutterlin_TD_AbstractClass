using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutterlin_Sebastien_Classe_Abstraite
{
    /// <summary>
    /// La classe abstraite employée. On ne peut pas l'instancier, mais d'autres classes peuvent hériter de celle là et s'y conforme.
    /// </summary>
    public abstract class Employe
    {
        protected int Matricule { get; set; }
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected DateTime DateDeNaissance { get; set; }

        public Employe(int Matricule, string Nom, string Prenom, DateTime DateDeNaissance)
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateDeNaissance = DateDeNaissance;

        }

        public override string ToString()
        {
            return "Le matricule est " + Matricule + ", son Nom est " +Nom+", son prenom est "+Prenom+ " et sa date de naissance est "+ DateDeNaissance ;
        }

        public abstract int GetSalaire();

    }
}
