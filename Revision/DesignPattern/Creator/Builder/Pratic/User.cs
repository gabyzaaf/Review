using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Creator.Builder.Pratic
{
    internal class User
    {
        private string name; 
        private string firstname;
        public int Age {  private get;  set; } // optionnal
        public string Address { private get; set; } // optionnal


        public User(string name, string firstname)
        {
            this.name = name;
            this.firstname = firstname;
        }

        public override string ToString()
        {
            return $"the name {name} - firstname {firstname} - age {Age} - Address {Address}";
        }
    }
}
