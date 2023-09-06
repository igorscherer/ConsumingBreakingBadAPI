using ConsumingBreakingBadAPI.Modelo;
using System.Text.Json;

namespace ConsumingBreakingBadAPI
{
    internal class ConsultaAleatoria
    {
        public static async Task ExecutarConsultaBreakingBad()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.Clear();
                    string resposta = await client.GetStringAsync("https://api.breakingbadquotes.xyz/v1/quotes/1");
                    var falas = JsonSerializer.Deserialize<List<FalaPopular>>(resposta);
                    Console.WriteLine($"\nCitacao: {falas[0].Fala}  \n\nAutor: {falas[0].Autor}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"O seguinte erro foi encontrado: {ex.Message}");
                }
            }
        }
    }
}
