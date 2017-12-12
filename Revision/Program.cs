using Revision;
using Revision.Banc;
using Revision.DesignPattern.Creator.Builder;
using Revision.DesignPattern.Creator.Builder.Pratic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    class Program
    {
        static void Main(string[] args)
        {

            CompteBancaire compte2 = new CompteEpargne("Anthony", 800, "Dollars", 0.5);
           

            List<CompteBancaire> compteList = new List<CompteBancaire>();
            compte2.Debiter(200);
            compteList.Add(compte2);
            
            compteList.ForEach(s => Console.WriteLine(s.Decrire()) );

            // Pattern

            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            var builder = new FluentBuilder();
            var product = builder.Begin().Engine.Tire().Build();
            product.Show();


            User user = new UserBuilder()
                .Begin("zaafrani", "Gabriel")
                .Address("22 Rue De paris")
                .Build();
            Console.WriteLine(user);


        }
    }
}
