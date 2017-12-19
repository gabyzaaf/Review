using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability
{
    class President : Approuver
    {
        internal override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine($" {this.GetType().Name } --- {purchase.Number}" );
            }
            else
            {
                Console.WriteLine($"Request {purchase.Number}");
            }
        }
    }
}
