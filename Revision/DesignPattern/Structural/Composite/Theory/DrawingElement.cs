using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite
{
    internal abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            _name = name;
        }

        internal abstract void Add(DrawingElement d);
        internal abstract void Remove(DrawingElement e);
        internal abstract void Display(int i);
    }
}
