using P3JordanA.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P3JordanA.Services
{
    public class ServicioS : Servicio
    {

        private string url = "https://api.chucknorris.io/jokes/random";   
        public async Task<List<Chistechuck>> GetChistechucks()
            
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode P3JordanA = nodos["jokes"];

            var chiste = JsonSerializer.Deserialize<List<Chistechuck>>(P3JordanA.ToString());
            return chiste;

        }
    }
}
