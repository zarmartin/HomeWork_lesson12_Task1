
using HomeWork_lesson12_Task1;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        NewsProvider news = new NewsProvider();

        Client client = new Client(news);

        NewsProviderArgs telephone = new NewsProviderArgs();

        telephone.news = "by telephone";

        NewsProviderArgs sms = new NewsProviderArgs();

        sms.news = "by sms";

        news.ShowHumor(telephone);

        news.ShowHumor(sms);

        Console.ReadKey();
    }
}