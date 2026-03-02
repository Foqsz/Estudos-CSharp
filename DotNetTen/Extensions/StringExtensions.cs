namespace DotNetTen.Extensions;

public static class StringExtensions
{
    //public static bool IsEmpty(this string? value)
    //{
    //    return string.IsNullOrWhiteSpace(value);
    //}

    extension(string? value)
    {
        public bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public int Tamanho => value.IsEmpty() ? 0 : value!.Length;
    }
}
