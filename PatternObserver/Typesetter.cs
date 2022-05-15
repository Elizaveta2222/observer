using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Typesetter : IObserver<News>
    {
        public string Name { get; set; }
        public bool GotTheNews { get; set; }

        public Typesetter(string name)
        {
            Name = name;
            GotTheNews = false;
        }
        public void Update(News news)
        {
            GotTheNews = true;
            Console.WriteLine($"-- Верстальщик {Name} получил новость {news.Title}");
        }
    }
}
