using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace telegramBot.Models.Commands
{
    public class Greeting : Command
    {
        public override string Name => "Hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {

            var chatId = message.Chat.Id;

            var messageId = message.MessageId;
      
            //здесь должна быть логика

            await client.SendTextMessageAsync(chatId, "I'm Eva", replyToMessageId: messageId);

        }

    }
}