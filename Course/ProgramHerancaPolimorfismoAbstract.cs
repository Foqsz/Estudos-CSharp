using System;
using Course.Models;

namespace Course
{
    internal class ProgramHerancaPolimorfismoAbstract
    {
        static void MainxAbsx(string[] args)
        {
            PessoaD PessoaP1 = new PessoaD(); //Iniciar um objeto.
            PessoaP1.Nome = "Victor";
            PessoaP1.Idade = 20;
            PessoaP1.Apresentar();
            Console.WriteLine("-------------------------------");

            Student aluno = new Student();
            aluno.Nome = "Vinicius";
            aluno.Idade = 20;
            aluno.Email = "foqs@gmail.com";
            aluno.Nota = 9;
            aluno.Apresentar();
            Console.WriteLine("-------------------------------");

            Teatcher professor = new Teatcher();
            professor.Nome = "Pedro";
            professor.Idade = 35;
            professor.Salario = 3700;
            professor.Apresentar();
            Console.WriteLine("-------------------------------");

            ContaPixCorrente c = new ContaPixCorrente();
            c.Creditar(100);
            c.ExibirSaldo();
            Console.WriteLine("-------------------------------");

            //--------------------------------------------//

            Console.WriteLine("-------------------------------");
            NewPix pix = new NewPix(654, 1000);

            pix.ExibirSaldo();
            pix.Sacar(5000);
            pix.ExibirSaldo();


        }
    }
}
