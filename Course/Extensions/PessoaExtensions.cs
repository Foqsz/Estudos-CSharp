namespace Course.Extensions;
public static class PessoaExtensions
{
    extension(Pessoa p)
    {
        public string Describe() => $"{p.Name}, {p.Idade} anos";

        public bool isAdult => p.Idade >= 18;
    }

    extension(Pessoa)
    {
        public static Pessoa Default =>
            new Pessoa { Name = "Desconhecido", Idade = 0 };
    }
} 

public class Pessoa
{
    public string Name { get; set; } = string.Empty;
    public int Idade { get; set; }
}