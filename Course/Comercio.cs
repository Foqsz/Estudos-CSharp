
namespace Course
{
    internal class Comercio
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public Comercio(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}