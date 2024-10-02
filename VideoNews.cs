using System;
namespace NewsSystem
{
    class VideoNews : News
    {
        public string VideoUrl { get; }

        public VideoNews(string title, List<string> topics, string videoUrl)
            : base(title, topics, videoUrl) 
        {
            VideoUrl = videoUrl;
        }

        public void DisplayVideo()
        {
            Console.WriteLine($"Відео новина: {Title}");
            Console.WriteLine($"Теми: {string.Join(", ", Topics)}");
            Console.WriteLine($"URL відео: {VideoUrl}");
        }
    }
}

