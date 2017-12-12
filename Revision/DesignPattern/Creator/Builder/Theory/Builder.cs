using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Creator.Builder
{
    internal abstract class Builder
    {
        internal abstract void BuildPartA();


        internal abstract void BuildPartB();

        internal abstract Product GetResult();
        
    }
}
