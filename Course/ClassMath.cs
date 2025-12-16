using System;

class Program
{
    static void MainClassMath()
    {
        // 1. Arredondamento
        double num = 5.65;
        double rounded = Math.Round(num);
        Console.WriteLine($"Arredondado: {rounded}");  // Resultado: 6.0

        // 2. Valor absoluto
        int negative = -10;
        int absolute = Math.Abs(negative);
        Console.WriteLine($"Valor absoluto: {absolute}");  // Resultado: 10

        // 3. Exponenciação
        double baseNum = 2;
        double exponent = 3;
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"2 elevado a 3: {power}");  // Resultado: 8.0

        // 4. Raiz quadrada
        double number = 16;
        double sqrt = Math.Sqrt(number);
        Console.WriteLine($"Raiz quadrada de 16: {sqrt}");  // Resultado: 4.0

        // 5. Máximo e Mínimo
        int a = 10;
        int b = 20;
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        Console.WriteLine($"Máximo: {max}, Mínimo: {min}");  // Resultado: Máximo: 20, Mínimo: 10
    }
}
