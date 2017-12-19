namespace Revision.DesignPattern.Behaviour.ChaineOfResponsability.Practical
{
    public class SalariePeople
    {

        public  string Name { get; private set; }
        public string Firstname { get; private set; }
        public double Salarie { get; private set; }

        public SalariePeople(string name, string firstname, double salarie)
        {
            this.Name = name;
            this.Firstname = firstname;
            this.Salarie = salarie;
        }

        public override string ToString()
        {
            return $"The name is {Name} -- Firstnam {Firstname} -- Salarie {Salarie}";
        }
    }
}