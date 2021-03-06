using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Editor : IObserver<News>
    {
        public string Name { get; set; }
        public bool GotTheNews { get; set; }
        public Editor(string name)
        {
            Name = name;
            GotTheNews = false;
        }
        public void Update(News news)
        {
            GotTheNews = true;
            Console.WriteLine($"-- Редактор {Name} получил новость {news.Title}");
        }
    }
}
