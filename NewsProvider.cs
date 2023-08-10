using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson12_Task1
{
    
    public class NewsProvider
    {
        public event SendANewNews NewNews;

        public event SendACurrentWeather CurrentWeather;

        public event SendAHumor Humor;

        public event SendASport Sport;

        public event SendAIncident Incident;

        public void ShowNewNews(NewsProviderArgs e)
        {
            if (NewNews != null)
            {
                NewNews(this, e);

            }

        }
        public void ShowCurrentWeather(NewsProviderArgs e)
        {
            if (CurrentWeather != null)
            {
                CurrentWeather(this, e);

            }

        }
        public void ShowHumor(NewsProviderArgs e)
        {
            if (Humor != null)
            {
                Humor(this, e);

            }

        }
        public void ShowSport(NewsProviderArgs e)
        {
            if (Sport != null)
            {
                Sport(this, e);

            }

        }
        public void ShowIncident(NewsProviderArgs e)
        {
            if (Incident != null)
            {
                Incident(this, e);

            }

        }
    }
}
