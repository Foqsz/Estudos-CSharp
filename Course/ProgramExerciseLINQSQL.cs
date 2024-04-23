using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Course.Entities;  

namespace Course
{
    internal class ProgramExerciseLINQSQL  
    {
        static void MainLQ(string[] args)   
        { 
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
             
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Cria uma lista para armazenar objetos do tipo ExerciseLINQSQL
            List<ExerciseLINQSQL> list = new List<ExerciseLINQSQL>();

            try  
            {
                // Abre o arquivo para leitura
                using (StreamReader sr = File.OpenText(path))
                {
                    // Loop enquanto não atingir o final do arquivo
                    while (!sr.EndOfStream)
                    {
                        // Lê uma linha do arquivo, divide os campos separados por vírgula
                        // e atribui cada parte a uma variável
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        // Adiciona um novo objeto ExerciseLINQSQL à lista com os dados lidos
                        list.Add(new ExerciseLINQSQL(name, email, salary));
                    }

                    // Filtra os objetos cujo salário seja superior ao limite fornecido,
                    // ordena-os por email e seleciona apenas os emails
                    var emails = list.Where(obj => obj.Salary > limit)
                                     .OrderBy(obj => obj.Email) 
                                     .Select(obj => obj.Email);

                    // Calcula a soma dos salários das pessoas cujo nome começa com 'M'
                    var sum = list.Where(obj => obj.Name[0] == 'M')
                                  .Sum(obj => obj.Salary);

                    // Imprime os emails dos funcionários com salário acima do limite
                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    // Imprime a soma dos salários dos funcionários cujo nome começa com 'M'
                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
