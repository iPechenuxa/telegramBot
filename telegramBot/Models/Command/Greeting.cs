using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace telegramBot.Models.Commands
{
    public class Greeting : Command
    {
        public override string Name => "hello";
               
        public override async void Execute(Message message, TelegramBotClient client)
        {

            var chatId = message.Chat.Id;

            var messageId = message.MessageId;
                 
            string botText = "Hello, what's your name?";
            //здесь должна быть логика         
                     
            await client.SendTextMessageAsync(chatId, botText, replyToMessageId: messageId);
            //Bot.commandList.Clear();

        }

    }
}