using DotNetTen.Entities;
using DotNetTen.Extensions;

var aluno = Student.CreateDefault();

Console.WriteLine($"Olá, Aluno {aluno.Name}.");