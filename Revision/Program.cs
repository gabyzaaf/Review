using Revision;
using Revision.Banc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    class Program
    {
        static void Main(string[] args)
        {

            CompteBancaire compte2 = new CompteEpargne("Anthony", 800, "Dollars", 0.5);
           

            List<CompteBancaire> compteList = new List<CompteBancaire>();
            compte2.Debiter(200);
            compteList.Add(compte2);
            
            compteList.ForEach(s => Console.WriteLine(s.Decrire()) );

            


        }
    }
}
