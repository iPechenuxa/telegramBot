using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telegramBot.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contains(string Command)
        {

            return Command.Contains(Name) && Command.Contains(ApplicationSetting.name);

        }

    }
}