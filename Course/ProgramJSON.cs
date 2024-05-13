using Course.Models;
using System.Globalization;
using Newtonsoft.Json;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string conteudoLista = File.ReadAllText("C:\\Users\\vinic\\Documents\\Projetos Estudo\\Course\\Course\\Arquives/vendas.json");

            List<VendaJs> listaVendas = JsonConvert.DeserializeObject<List<VendaJs>>(conteudoLista);
             
            foreach (VendaJs v in listaVendas)
            {
                Console.WriteLine($"Id: {v.Id}, Produto: {v.Produto}, " +
                    $"Preço: {v.Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Data: {v.DataVenda.ToString("dd/MM/yyyy HH:mm")} ");
            }
        }
    }
}
