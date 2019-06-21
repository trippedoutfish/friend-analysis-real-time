using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fart.Web.Data
{
    public class CharacterLoaderService
    {
        public Task<PlayerCharacter[]> GetCharactersAsync()
        {
            return Task.Run(() => JsonConvert.DeserializeObject<PlayerCharacter[]>(File.ReadAllText(@"Data/json/mockCharacters.json")));
        }
    }
}