using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task18Subtask1
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation()
        {
            Console.WriteLine("\n Добро пожаловать в приложение по скачиванию видео с YouTube");
            Console.WriteLine("\n Введите Url Видео.");
            string videoUrl = Console.ReadLine();
            Console.WriteLine("\n Скачивание наснется через 5сек");

            GetAsync(videoUrl);

            DownloadAsync(videoUrl);

            Thread.Sleep(5000);

            static async Task GetAsync(string videoUrl)
            {
                var youtube = new YoutubeClient();
                
                Console.WriteLine("\n Информация о видео.");

                var video = await youtube.Videos.GetAsync(videoUrl);

                Console.WriteLine($"\n{videoUrl}");
                Console.WriteLine($"\n{video.Title}");
                Console.WriteLine($"\n{video.UploadDate.DateTime.ToLongDateString()}");
                Console.WriteLine($"\n{video.Duration}");
            }

            static async Task DownloadAsync(string videoUrl)
            {
                var youtube = new YoutubeClient();

                var video = await youtube.Videos.GetAsync(videoUrl);

                await youtube.Videos.DownloadAsync(videoUrl, "Video.mp4");

                Console.WriteLine("Скачивание завершено!");
                Console.WriteLine("Скаченное видео находится в папке приложения");

            }
        }
    }
}