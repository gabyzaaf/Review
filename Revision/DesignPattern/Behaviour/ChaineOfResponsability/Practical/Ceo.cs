using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability.Practical
{
    internal class Ceo : ApproverSalarie
    {
        public override void Process(SalariePeople people)
        {
            if (people.Salarie >= 10000)
            {
                Console.WriteLine("He is the CEO --> "+people);
            }
            else if(Successor != null)
            {
                Successor.Process(people);
            }
        }
    }
}
