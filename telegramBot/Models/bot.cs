using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Telegram.Bot;
using telegramBot.Models.Commands;


namespace telegramBot.Models
{
    public static class Bot
    {

        public static TelegramBotClient client;
        public static List<Command> commandList;

        public static IReadOnlyList<Command> Command { get => commandList.AsReadOnly(); }

        public static TelegramBotClient Get()
        {
            
            if (client != null)
            {
                return client;
            }
            
            commandList = new List<Command>();                        
            commandList.Add(new Greeting());
            commandList.Add(new Inpute());
            //команды

            client = new TelegramBotClient(ApplicationSetting.token);
            //опция Timeout не решила проблему с бесконечной отправкой сообщений от Eva.

            var hook = string.Format(ApplicationSetting.URL, "api/message/update");
            client.SetWebhookAsync(hook);
            //способ SetWebhookAsync не решил проблему с бесконечной отправкой сообщений от Eva.
            
            return client;       

        }


    }
}