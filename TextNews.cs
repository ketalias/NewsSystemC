using System;
namespace NewsSystem
{
    class TextNews : News
    {
        public TextNews(string title, List<string> topics, string content)
            : base(title, topics, content)
        {
        }

        public void DisplayText()
        {
            Console.WriteLine($"Текстова новина: {Title}");
            Console.WriteLine($"Теми: {string.Join(", ", Topics)}");
            Console.WriteLine($"Текст: {Content}");
        }
    }
}

