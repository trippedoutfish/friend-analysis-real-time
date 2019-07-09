using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Fart.Discord.Bot.JsonModels;
using Newtonsoft.Json;

namespace Fart.Discord.Bot.Services
{
    public class JokeService
    {
        private readonly HttpClient _http;

        public JokeService(HttpClient http)
            => _http = http;

        public async Task<string> GetJokeAsync(string prompt)
        {
            var resp = await _http.GetAsync(Environment.GetEnvironmentVariable("JokeApi")+prompt.Replace(" ", "+"));
            return await resp.Content.ReadAsStringAsync();
        }
    }
}
