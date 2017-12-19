using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability.Practical
{
    internal abstract class ApproverSalarie
    {
        public ApproverSalarie Successor { protected get; set; }
        public abstract void Process(SalariePeople people);

    }
}
