using Discord;
using Discord.Webhook;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fart.Discord.Bot.Services
{
    public class FartHookService
    {
        private readonly string fartHookId = Environment.GetEnvironmentVariable("fartHookId");
        private readonly string fartHookToken = Environment.GetEnvironmentVariable("fartHookToken");
        public async Task PostWebhook(string Title, string Description)
        {
            using (var client = new DiscordWebhookClient($"https://discordapp.com/api/webhooks/{fartHookId}/{fartHookToken}"))
            {
                var embed = new EmbedBuilder();

                embed.AddField("First To Die Achievement",
                "Probably [Sangaro](https://www.youtube.com/watch?v=dQw4w9WgXcQ) I guess!")
                .WithFooter(footer => footer.Text = "I can't wait for this for real")
                .WithColor(Color.Gold)
                .WithTitle("Classic WoW Achievement Test")
                .WithCurrentTimestamp()
                .Build();

                // Webhooks are able to send multiple embeds per message
                // As such, your embeds must be passed as a collection. 
                await client.SendMessageAsync( embeds: new[] { embed.Build() });
            }
        }
    }
}
