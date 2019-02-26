using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sutterlin_Sebastien_Classe_Abstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier O1 = new Ouvrier(27, new DateTime(1954,8,27), "Sutterlin", "Paul", new DateTime(1933,9,4) );
            Ouvrier O2 = new Ouvrier(28, new DateTime(2017, 2, 27), "Sutterlin", "Sébastien", new DateTime(1995, 9, 27));

            Console.WriteLine(O2);


            Cadre C1 = new Cadre(29, 2, "Madembo", "Grâce", new DateTime(1985, 12, 1));

            Console.WriteLine(C1);

            Patron P1 = new Patron(50000, 75, 30, "Hatton", "Jerome", new DateTime(1970, 5, 3));
            Console.WriteLine(P1);









        }
    }
}
