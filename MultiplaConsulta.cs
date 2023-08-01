using ConsumingBreakingBadAPI.Modelo;
using System.Text.Json;

namespace ConsumingBreakingBadAPI
{
    internal class MultiplaConsulta
    {
        public static async Task ExecutarMultiplaConsultasBreakingBad(int x)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.Clear();
                    string resposta = await client.GetStringAsync($"https://api.breakingbadquotes.xyz/v1/quotes/{x}");
                    var falas = JsonSerializer.Deserialize<List<FalaPopular>>(resposta);
                    int qntFalas = 0;
                    foreach(var fala in falas!)
                    {
                        Console.WriteLine($"\n\nCitacao: {fala.Fala}\nAutor: {fala.Autor}");
                        qntFalas++;
                    }
                    Console.WriteLine($"\n\nQuantia de falas listadas: {qntFalas}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"O seguinte erro foi encontrado: {ex.Message}");
                }
            }
        }
    }
}
