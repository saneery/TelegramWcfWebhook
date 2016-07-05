using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace WcfBot
{
    public class Service1 : IService1
    {
        public void GetUpdate(Update update)
        {
            var Bot = new Telegram.Bot.Api("<token>");
            if(update.message.text == "Привет")
            {
                Bot.SendTextMessage(update.message.chat.id, "Привет," + update.message.from.first_name);
            }
        }
    }
}
