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
    public class XkcdService
    {
        private readonly HttpClient _http;

        public XkcdService(HttpClient http)
            => _http = http;

        public async Task<Stream> GetXkcdComicAsync()
        {
            var resp = await _http.GetAsync("https://xkcd.com/info.0.json");
            var json = await resp.Content.ReadAsStringAsync();
            var imgLink = JsonConvert.DeserializeObject<XkcdApi>(json);
            var img = await _http.GetAsync(imgLink.img);
            return await img.Content.ReadAsStreamAsync();
        }
    }
}
