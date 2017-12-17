using Revision;
using Revision.Banc;
using Revision.DesignPattern.Creator.Builder;
using Revision.DesignPattern.Creator.Builder.Pratic;
using Revision.DesignPattern.Creator.Prototype;
using Revision.DesignPattern.Structural.Bridge.Theory;
using Revision.DesignPattern.Structural.Composite;
using Revision.DesignPattern.Structural.Composite.Pratic;
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


            User user = new UserBuilder()
                .Begin("zaafrani", "Gabriel")
                .Address("22 Rue De paris")
                .Build();
            Console.WriteLine(user);

            ConcretePrototype1 proto= new ConcretePrototype1("200");
            ConcretePrototype1 c1 = (ConcretePrototype1)proto.Clone();
           
            Console.WriteLine($"The value is {c1.Id}");

            // Bridge Pattern

            Customer customers = new Customer("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomerData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Composite Pattern Theory.

            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            CompositeElement comp = new CompositeElement("Two Circle");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            root.Display(1);

            // Composite Pattern  pratic
            Family family = new Family("Zaafrani");
            family.Add(new PrimitiveFamily("Gabriel"));
            family.Add(new PrimitiveFamily("Sarah"));

            Family familyH = new Family("Heftman");
            familyH.Add(new PrimitiveFamily("Jessica"));
            familyH.Add(new PrimitiveFamily("Raphael"));
            family.Add(familyH);

            family.Display(0);
            


        }
    }
}
