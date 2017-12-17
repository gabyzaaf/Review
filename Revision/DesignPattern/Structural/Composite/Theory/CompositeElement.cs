using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite
{
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        internal override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        internal override void Display(int i)
        {
            Console.WriteLine(new String('-', i) +"+ " + _name);
            foreach (var item in elements)
            {
                item.Display(i + 2);
            }
        }

        internal override void Remove(DrawingElement e)
        {
            elements.Remove(e);
        }
    }
}
