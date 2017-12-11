using Revision2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Banc
{
    internal class CompteEpargne : CompteBancaire
    {
        private double tauxInteret;

        public CompteEpargne(string titulaire, double solde, string devise,double tauxInteret) : base(titulaire, solde, devise)
        {
            this.tauxInteret = tauxInteret;
        }

        public void AjouterInteret() {
            double interets = Solde * tauxInteret;
            Solde += interets;
        }

        public override void Debiter(double montant)
        {
            if (montant <= Solde / 2)
                Solde -= montant;
        }

       
    }
}
