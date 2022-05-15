using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable<TypeDefinition> // издатель
    {
        void Notify(TypeDefinition data, int waitingTime); // уведомление всех подписчиков
        void Notify(TypeDefinition data, int waitingTime, IObserver<TypeDefinition> observer); // уведомление одного подписчика

        void Subscribe(IObserver<TypeDefinition> observer); //подписка
        void Unsubscribe(IObserver<TypeDefinition> observer); //отписка
    }
}
