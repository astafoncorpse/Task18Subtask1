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
            static async Task GetAsync(string videoUrl)
            {

                var youtube = new YoutubeClient();

                var videoUrl = "https://www.youtube.com/watch?v=1SxqH04ZBhs";
                var video = await youtube.Videos.GetAsync(videoUrl);

                var title = video.Title; 
                var duration = video.Duration; 
                Console.WriteLine($"{videoUrl}");
                Console.WriteLine($"{video.Title}");
                Console.WriteLine($"{video.Duration}");
            }

            static async Task DownloadAsync(string videoUrl, string outputFilePath)
            {
                var youtube = new YoutubeClient();

                var videoUrl = "https://youtube.com/watch?v=u_yIGGhubZs";
                await youtube.Videos.DownloadAsync(videoUrl, "video.mp4");
            }
        }
    }
}