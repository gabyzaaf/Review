using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Banc
{
    class CompteCourant : CompteBancaire
    {
        private string numeroCb;
        private double decouvertMaxi;

        public CompteCourant(string titulaire, double solde, string devise,string numeroCb,double decouvertMaxi) : base(titulaire, solde, devise)
        {
            this.numeroCb = numeroCb;
            this.decouvertMaxi = decouvertMaxi;
        }

        public override void Debiter(double montant)
        {
            if (Solde - montant >= decouvertMaxi) {
                Solde -= montant;
            }
        }
    }
}
