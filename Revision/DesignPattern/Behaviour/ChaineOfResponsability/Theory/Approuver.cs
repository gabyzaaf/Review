using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability
{
    internal abstract class Approuver
    {
        public Approuver Successor { protected get;  set; }
        internal abstract void ProcessRequest(Purchase purchase);
    }
}
