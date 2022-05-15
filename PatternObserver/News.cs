using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class News
    {
        public string Title { get; set; }
        public News(string title)
        {
            Title = title;
        }
    }
}
