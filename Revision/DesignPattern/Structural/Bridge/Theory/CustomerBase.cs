using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Structural.Bridge.Theory
{
    class CustomerBase
    {
        private DataObject dataObject;
        protected string group;

        public CustomerBase(string group) {
            this.group = group;
        }

        public DataObject Data
        {
            set
            {
                dataObject = value;
            }
            get
            {
                return dataObject;
            }
        }

        public virtual void Next()
        {
            dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            dataObject.AddRecord(customer);
        }

        public virtual void ShowAll()
        {
            dataObject.ShowAllRecords();
        }

        public virtual void Show()
        {
            dataObject.ShowRecord();
        }

    }
}
