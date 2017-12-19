using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability.Practical
{
    class Maintener : ApproverSalarie
    {
        public override void Process(SalariePeople people)
        {
            if (people.Salarie < 5000)
            {
                Console.WriteLine(" he is an Maintener --> "+people);
            }
        }
    }
}
