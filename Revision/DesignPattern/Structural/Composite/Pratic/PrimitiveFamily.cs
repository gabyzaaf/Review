using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite.Pratic
{
    internal class PrimitiveFamily : ParentsAbstracted
    {
        public PrimitiveFamily(string name) : base(name)
        {
        }

        internal override void Add(ParentsAbstracted parent)
        {
            Console.WriteLine("Not add for this class");
        }

        internal override void Display(int indice)
        {
            Console.WriteLine($"with indice {indice} {_name}");
        }

       
        internal override void Remove(ParentsAbstracted parent)
        {
            Console.WriteLine("Not remove for this class");
        }
    }
}
