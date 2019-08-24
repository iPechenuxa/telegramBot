using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using telegramBot.Models;
using System.Threading.Tasks;

namespace telegramBot.Controllers
{
    public class MessageController : ApiController
    {

        [Route(@"api/message/update")]

        public OkResult Update([FromBody]Update update)
        {

            if (update == null) return Ok();

            var commands = Bot.Command;
            var message = update.Message;
            var client = Bot.Get();                         

            foreach (var command in commands)
            {

                if (command.Contains(message.Text))
                {
                    
                    command.Execute(message, client);
                    break;

                }

            }
                       
            return Ok();

        }

    }
}
