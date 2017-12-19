using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability
{
    class Director : Approuver
    {
        internal override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Amount > 25000.0)
            {
                Console.WriteLine($" {this.GetType().Name} Approuved request # {purchase.Number}");
            }else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
