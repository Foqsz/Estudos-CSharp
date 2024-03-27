 

namespace Course.Entities
{
    internal class ExerciseLINQSQL
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
 
        public ExerciseLINQSQL(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
