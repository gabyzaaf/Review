using System;
using System.Collections.Generic;

namespace Revision.DesignPattern.Creator.Builder
{
    internal class Product
    {

        List<string> _products = new List<string>();

        internal void Add(string part)
        {
            _products.Add(part);
        }

        public void Show() {
            _products.ForEach(p => Console.WriteLine(p));
        }
    }
}