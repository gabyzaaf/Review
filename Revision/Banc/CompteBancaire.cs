using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.Banc
{
    internal abstract class CompteBancaire
    {
        public string Titulaire { get; private set; }
        public double Solde { get; protected set; }
        public String Devise { get; private set; }

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.Titulaire = titulaire;
            this.Solde = solde;
            this.Devise = devise;
        }

        public void Crediter(double montant) {
            this.Solde += montant;
        }

       
        public virtual String Decrire() {
            return $" Le titulaire est {this.Titulaire} le solde est {this.Solde} et la devise est {this.Devise}";
        }

        public abstract void Debiter(double montant);



    }
}
