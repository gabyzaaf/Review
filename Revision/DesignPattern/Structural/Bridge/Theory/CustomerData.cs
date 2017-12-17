using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Bridge.Theory
{
    class CustomerData : DataObject
    {
        List<string> _customers = new List<string>();
        int current = 0;


        public CustomerData()
        {
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void AddRecord(string name)
        {
            _customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            _customers.Remove(name);
        }

        public override void NextRecord()
        {
            if (current <= _customers.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void ShowAllRecords()
        {
            _customers.ForEach(customer => Console.WriteLine(customer));
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_customers[current]);
        }
    }
}
