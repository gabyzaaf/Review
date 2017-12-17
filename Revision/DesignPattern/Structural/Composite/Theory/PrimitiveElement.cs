using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite
{
    internal class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
            
        }

        internal override void Add(DrawingElement d)
        {
            Console.WriteLine("Cannot add to a primitiveElement");
        }

        internal override void Display(int i)
        {
            Console.WriteLine(new String('-',i)+" "+_name);
        }

        internal override void Remove(DrawingElement e)
        {
            Console.WriteLine("Cannot remove from a primitive Element");
        }
    }
}
