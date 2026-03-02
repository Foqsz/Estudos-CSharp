namespace Course
{
    class ProgramBeecrowd
    {
        static void Main(string[] args)
        {
            var usuario = new User
            {
                Nome = "Ph",
                Email = "vv"
            };

            var random = new Random();
            var number = random.Next(1, 1000);
            Console.WriteLine(number);
        }

        public class User
        {
            public required string Nome { get; init; }
            public required string Email { get; init; }
        }
    }
}
