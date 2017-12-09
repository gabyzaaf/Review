using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Zaafrani","Gabriel",27);
            user.Display();

            var gamer = new Gamer("Cordona", "Jo", 23, "Mario");
            gamer.Display();
            Console.WriteLine(gamer.Play("zaaaa", 23));
        }
    }
}
