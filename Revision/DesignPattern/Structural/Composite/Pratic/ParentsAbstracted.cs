using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite.Pratic
{
    internal abstract class ParentsAbstracted
    {
        protected string _name;

        public ParentsAbstracted(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        internal abstract void Add(ParentsAbstracted parent);
        internal abstract void Remove(ParentsAbstracted parent);
        internal abstract void Display(int indice);
        
    }
}
