using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsSystem
{
    interface IObserver
    {
        void Update(News news);
    }

    class Subscriber : IObserver
    {
        private string name;
        private bool subscribeToVideos;
        private List<string> topicFilter;

        public Subscriber(string name, bool subscribeToVideos = false, List<string> topicFilter = null)
        {
            this.name = name;
            this.subscribeToVideos = subscribeToVideos;
            this.topicFilter = topicFilter;
        }

        public void Update(News news)
        {
            if (news is VideoNews && this.subscribeToVideos)
            {
                var videoNews = news as VideoNews;
                Console.WriteLine($"[{name}] - Відео новина: {videoNews.Title}");
                Console.WriteLine($"URL відео: {videoNews.VideoUrl}");
            }
            else if (news is TextNews)
            {
                var textNews = news as TextNews;

                if (topicFilter == null || topicFilter.Any(topic => textNews.Topics.Contains(topic)))
                {
                    Console.WriteLine($"[{name}] - Текстова новина: {textNews.Title}");
                    Console.WriteLine($"Текст: {textNews.Content}");
                }
            }
        }
    }
}
