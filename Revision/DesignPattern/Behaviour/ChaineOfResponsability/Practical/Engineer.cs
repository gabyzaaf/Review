using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability.Practical
{
    class Engineer : ApproverSalarie
    {
        public override void Process(SalariePeople people)
        {
            if (people.Salarie >= 5000 && people.Salarie < 10000)
            {
                Console.WriteLine($"this is an {this.GetType().Name} --> {people}" );
            }else if (Successor != null)
            {
                Successor.Process(people);
            }
        }
    }
}
