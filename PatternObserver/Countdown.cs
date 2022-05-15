using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Countdown : IObservable<News>
    {
        // список читателей
        private List<IObserver<News>> observers = new List<IObserver<News>>();
        //уведомление всех читателей
        public void Notify(News data, int waitingTime)
        {
            Thread.Sleep(waitingTime);
            foreach (var observer in observers)
            {
                observer.Update(data);
            }
        }
        //уведомление одного выбранного читателя
        public void Notify(News data, int waitingTime, IObserver<News> observer)
        {
            Thread.Sleep(waitingTime);
            observer.Update(data);
        }
        public void Subscribe(IObserver<News> observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(IObserver<News> observer)
        {
            observers.Remove(observer);
        }
    }
}
