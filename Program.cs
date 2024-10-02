using System;
using System.Collections.Generic;
using NewsSystem;

//4.Система публікує новини. Новини бувають в текстовому форматі та відео.
//Кожна новина це об’єкт що містить заголовок, теми новини (масив слів) та текст новини чи  URL відео.
// Публікація новини  полягає у додаванні відповідного об'єкту до однієї із 2 колекцій.
// Користувач може підписатися на всі текстові новини, на всі відео новини чи тільки текстові новини за вказаною темою.
// При публікації новини надсилати користувачу, згідно з його підпискою, повідомлення про новину
// (в консоль вивести заголовок новини).

class Program
{
    static void Main(string[] args)
    {
        var newsPublisher = new NewsPublisher();


        var subscriber1 = new Subscriber("Користувач 1", subscribeToVideos: true);
        var subscriber2 = new Subscriber("Користувач 2", topicFilter: new List<string> { "спорт", "технології" });

        newsPublisher.AddSubscriber(subscriber1);
        newsPublisher.AddSubscriber(subscriber2);

        var textNews = new TextNews("Новий прорив у технологіях", new List<string> { "технології" }, "Детальний опис технологічного прориву...");
        newsPublisher.PublishNews(textNews);

        var videoNews = new VideoNews("Спортивні новини дня", new List<string> { "спорт" }, "http://video.url/sports");
        newsPublisher.PublishNews(videoNews);


    }
}