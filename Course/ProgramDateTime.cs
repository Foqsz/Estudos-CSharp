using System; 

namespace Course
{
    internal class ProgramDateTime
    {
        static void MainDT(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morming dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}