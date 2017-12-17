using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Bridge.Theory
{
    internal class Customer : CustomerBase
    {
        public Customer(string group) : base(group)
        {
        }

        public override void ShowAll()
        {
            Console.WriteLine("----------");
            base.ShowAll();
            Console.WriteLine("----------");
        }

    }
}
