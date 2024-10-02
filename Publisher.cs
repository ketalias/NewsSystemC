using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsSystem
{
    class NewsPublisher
    {
        private List<TextNews> textNews = new List<TextNews>();   
        private List<VideoNews> videoNews = new List<VideoNews>();
        private List<IObserver> subscribers = new List<IObserver>();

        public void AddSubscriber(IObserver subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(IObserver subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void PublishNews(TextNews news)
        {
            textNews.Add(news);
            Notify(news);
        }

        public void PublishNews(VideoNews news)
        {
            videoNews.Add(news);
            Notify(news);
        }

        private void Notify(News news)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(news);
            }
        }
    }
}
