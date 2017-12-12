using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Creator.Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        internal override void BuildPartA()
        {
            _product.Add("PartA");
        }

        internal override void BuildPartB()
        {
            _product.Add("PartB");
        }

        internal override Product GetResult()
        {
            return _product;
        }
    }
}
