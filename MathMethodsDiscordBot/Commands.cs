using System;
using System.Collections.Generic;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading;
using System.Threading.Tasks;

namespace MathMethodsDiscordBot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task Test()
        {
            await ReplyAsync("This is a test message");
        }
    }
}
