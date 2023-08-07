using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson12_Task1
{
    public delegate void SendANewNews(object sender, NewsProviderArgs e);

    public delegate void SendACurrentWeather(object sender, NewsProviderArgs e);

    public delegate void SendAHumor(object sender, NewsProviderArgs e);

    public delegate void SendASport(object sender, NewsProviderArgs e);

    public delegate void SendAIncident(object sender, NewsProviderArgs e);

    public class Client
    {
        public string news = "NewsProvider";

        public void NewNews(object sender, NewsProviderArgs e)
        {
            Console.WriteLine("You got the news by", news);
        }

        public void CurrentWeather(object sender, NewsProviderArgs e)
        {
            Console.WriteLine("You got the weather forecast by ", news);
        }

        public void Humor(object sender, NewsProviderArgs e)
        {
            Console.WriteLine("You got joke by", news);
        }

        public void Sport(object sender, NewsProviderArgs e)
        {
            Console.WriteLine("You have won on a bet by", news);
        }

        public void Incident(object sender, NewsProviderArgs e)
        {
            Console.WriteLine("You got terrible news by", news);
        }
        public Client(NewsProvider news)
        {
            SendANewNews newnews = new SendANewNews(NewNews);

            SendACurrentWeather currentWeather = new SendACurrentWeather(CurrentWeather);

            SendAHumor humor = new SendAHumor(Humor);

            SendASport sport = new SendASport(Sport);

            SendAIncident incident = new SendAIncident(Incident);

            news.NewNews += newnews;

            news.CurrentWeather += currentWeather;

            news.Humor += humor;

            news.Sport += sport;

            news.Incident += incident;


        }



        
    }
}
