using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
     class Gamer : User
    {
        private string favoriteGame;

        public Gamer(string nom, string prenom, int age,string favoriteGame) : base(nom, prenom, age)
        {
            this.favoriteGame = favoriteGame;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"The favorite game is {favoriteGame}");
        }

        public string Play(string element)
        {
            return $"The role Played is {element}";
        }

        
    }
}
