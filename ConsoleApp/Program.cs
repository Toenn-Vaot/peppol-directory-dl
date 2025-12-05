using System.Diagnostics;
using System.Text.Json;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "PEPPOL Business cards";
            Console.WriteLine();
            var watch = Stopwatch.StartNew();
            Console.WriteLine("1- Download the latest list of business cards as stream");
            await using var streamWeb = await new HttpClient().GetStreamAsync("https://directory.peppol.eu/export/businesscards-json");
            Console.WriteLine("2- Deserialize JSON data stream");
            var jsonData = await JsonSerializer.DeserializeAsync<PeppolBusinessCards>(streamWeb);
            watch.Stop();
            Console.WriteLine($"   --- File downloaded and deserialized in {watch.ElapsedMilliseconds / 1000} sec");
            Console.WriteLine();
            Console.WriteLine("3- Extracted version info");
            Console.WriteLine($"   -Version: {jsonData.Version}");
            Console.WriteLine($"   -Participants: {jsonData.ParticipantCount}");
            Console.WriteLine($"   -Code List Supported: {jsonData.CodeListSupported}");
            Console.WriteLine($"   -Creation Date: {jsonData.CreationDate}");
            
            Console.WriteLine();
            Console.WriteLine("4- Find out a record (0537522332)");
            var item = jsonData.BusinessCards.FirstOrDefault(x => x.Pid.EndsWith("0537522332"));
            Console.WriteLine($"Found {item?.Entities.First().Names.First().Name}");
            Console.ReadKey();
        }
    }
}
