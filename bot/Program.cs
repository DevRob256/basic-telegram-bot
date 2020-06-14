using System;
using Telegram.Bot;
using System.IO;
using Telegram.Bot.Types.InputFiles;



namespace bot
{
    class Program
    {

        static TelegramBotClient botClient = new TelegramBotClient("YOUR TOKEN HERE");
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

            if (e.Message.Text.ToUpper() == "SEND ME A PICTURE")
            {

                FileStream fs = File.OpenRead(@"FULL FILE PATH HERE");
                InputOnlineFile myPhoto = new InputOnlineFile(fs, "myPhoto.png");

                botClient.SendPhotoAsync(e.Message.Chat.Id, myPhoto,"CAPTION");

            }


        }
    }
}


