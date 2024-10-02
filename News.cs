using System;
namespace NewsSystem
{

    class News
    {
        public string Title { get; }
        public List<string> Topics { get; }
        public string Content { get; }

        public News(string title, List<string> topics, string content)
        {
            Title = title;
            Topics = topics;
            Content = content;
        }
    }
}

