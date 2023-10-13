using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;

namespace TelegramBotExperiments
{

    class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("5462724219:AAEx7WpUYhDoP8xChuwaJuAA8-0TLoNTI1A");
        static void Main(string[] args)
        {
            TelegramBot.SaveImage.TestConnection();
            //Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            //var cts = new CancellationTokenSource();
            //var cancellationToken = cts.Token;
            //var receiverOptions = new ReceiverOptions
            //{
            //    AllowedUpdates = { }, // receive all update types
            //};
            //bot.StartReceiving(
            //    TelegramBot.WorkerBot.HandleUpdateAsync,
            //    TelegramBot.WorkerBot.HandleErrorAsync,
            //    receiverOptions,
            //    cancellationToken
            //);
            Console.ReadLine();
        }
    }
}