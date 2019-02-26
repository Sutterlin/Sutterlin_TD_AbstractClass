using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutterlin_Sebastien_Classe_Abstraite
{
    public class Cadre: Employe
    {

        
        public int Salaire { get; set; }
        public int Indice { get; set; }




        

        public Cadre(int matricule,int indice, string nom, string prenom, DateTime datedenaissance) : base(matricule, nom, prenom, datedenaissance)
        {
            this.Indice = indice;


            this.GetSalaire();
           









        }





        public override int GetSalaire()
        {
            switch (this.Indice)
            {
                case 1:
                    this.Salaire = 13000;
                    break;

                case 2:
                    this.Salaire = 15000;
                    break;

                case 3:
                    this.Salaire = 17000;
                    break;

                case 4:
                    this.Salaire = 20000;
                    break;



            }
            return this.Salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Le salaire de ce cadre est de " + this.GetSalaire() + " et son indice est" + this.Indice;
        }
    













}
}
