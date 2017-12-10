
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Revision
{
     class User
    {
        protected string nom;
        private string prenom;
        private int age;

        public User(string nom,string prenom,int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public virtual void Display()
        {
            Console.WriteLine($" The name is {this.nom} {this.prenom} {this.age} ans");
        }

    }
}