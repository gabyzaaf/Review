using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DesignPattern.Creator.Builder.Pratic
{
    class UserBuilder
    {
        User user;

        public UserBuilder Begin(string lastname,string firstname)
        {
            user = new User(lastname, firstname);
            return this;
        }

        public UserBuilder Age(int age)
        {
            user.Age = age;
            return this;
        }

        public UserBuilder Address(string address)
        {
            user.Address = address;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
