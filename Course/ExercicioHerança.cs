using Course.Devices;
using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class ExercicioHerança
    {
        static void Mainx(string[] args)
        {
            string path = @"C:\Users\vinic\AppData\Local\Temp\Estudo.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<NewEmployee2> list = new List<NewEmployee2>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new NewEmployee2(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (NewEmployee2 emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
