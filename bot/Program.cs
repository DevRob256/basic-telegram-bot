using System;
using Telegram.Bot;


namespace bot
{
    class Program
    {

        static TelegramBotClient botClient = new TelegramBotClient("1268622258:AAHzyjxcLNC0ZGDayQvi0H2blDfFQXXA3Jo");
        static void Main(string[] args)
        {

            botClient.OnMessage += BotClient_OnMessage;
            botClient.StartReceiving();
            Console.ReadLine();

        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            Console.WriteLine(e.Message.Text);


            if (e.Message.Text.ToUpper() == "HI") 
            {
                botClient.SendTextMessageAsync(e.Message.Chat.Id, "Whats up?");
            
            }

        }
    }
}
