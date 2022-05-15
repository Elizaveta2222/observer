using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver<TypeDefinition> // подписчик
    {
        void Update(TypeDefinition data); //получение данных от издателя
    }
}
