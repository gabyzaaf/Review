using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Composite.Pratic
{
    internal class Family : ParentsAbstracted
    {
        private List<ParentsAbstracted> parents = new List<ParentsAbstracted>();

        public Family(string name) : base(name)
        {
        }

        internal override void Add(ParentsAbstracted parent)
        {
            parents.Add(parent);
        }

        internal override void Display(int indice)
        {
            Console.WriteLine($"The family name is {_name}");
            parents.ForEach(people => people.Display(indice++));
        }

        internal override void Remove(ParentsAbstracted parent)
        {
            this.parents.Remove(parent);
        }
    }
}
