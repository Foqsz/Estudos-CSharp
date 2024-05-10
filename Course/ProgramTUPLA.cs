using Course.Models;
using System;
using System.Globalization;

namespace Course
{
    internal class ProgramTUPLA
    { 
        static void MainTupla(string[] args)
        {
            LeituraArquivo leituraArquivo = new LeituraArquivo();

            var (sucesso, linhasArquivo, quantLinhas) = leituraArquivo.LerArquivo("C:\\Users\\vinic\\Documents\\Projetos Estudo\\Course\\Course\\Arquives\\Arquivo.txt");
             
            if (sucesso)
            {

                Console.WriteLine("Quantidade linhas do arquivo: " + quantLinhas);
                foreach (string linha in linhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Não foi possivel ler o arquivo");
            }
        }
    }
}
