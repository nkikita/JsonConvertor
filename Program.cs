using System.Net.Http.Json;
using System.Threading.Tasks;
using JsonConvertor.models;

class Program{
    static async Task Main(string[] args){
        HttpClient client = new HttpClient();
        await GetJson(client);
    }

    static async Task  GetJson(HttpClient client){
        var jsontext = await client.GetFromJsonAsync<List<Product>>("http://localhost:5084/getProducts");
        foreach (var a in jsontext){
            Console.WriteLine("id = " +a.id + " name = " + a.name);
            Console.Out.Flush();
        }
    }
}
