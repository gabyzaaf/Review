using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Creator.Prototype
{
    internal abstract class Prototype
    {
        public string Id { get;  set; }

        public Prototype(string id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();

    }
}
