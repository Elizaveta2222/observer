using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Demonstration
    {
        public static void Main(string[] args)
        {
            // издатель
            Countdown countdown = new Countdown();

            // подписчики
            Marketer marketer = new Marketer("Слава");
            Editor editor = new Editor("Костя");
            Typesetter typesetter = new Typesetter("Лера");

            countdown.Subscribe(marketer);
            countdown.Subscribe(editor);
            countdown.Subscribe(typesetter);

            News news = new News("Перенос собрания");

            while (true)
            {
                Console.WriteLine("Введите время ожидания");
                int waitingTime = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Отправить всем подписчикам или одному конкретному?");
                Console.WriteLine("1 - всем");
                Console.WriteLine("2 - одному");
                Console.WriteLine("Для выхода нажмите 0");

                ConsoleKeyInfo click = new ConsoleKeyInfo();
                click = Console.ReadKey(true);

                switch (click.KeyChar)
                {
                    case '1':
                        Console.WriteLine("отправка...");
                        countdown.Notify(news, waitingTime);
                        break;
                    case '2':
                        Console.WriteLine("Выберите, кому отправить новость:");
                        Console.WriteLine("1 - Славе");
                        Console.WriteLine("2 - Косте");
                        Console.WriteLine("3 - Лере");
                        click = Console.ReadKey(true);
                        switch (click.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("отправка...");
                                countdown.Notify(news, waitingTime, marketer);
                                break;
                            case '2':
                                Console.WriteLine("отправка...");
                                countdown.Notify(news, waitingTime, editor);
                                break;
                            case '3':
                                Console.WriteLine("отправка...");
                                countdown.Notify(news, waitingTime, typesetter);
                                break;
                        }
                        break;
                }
                if (click.KeyChar == '0')
                {
                    break;
                }
            }

        }
    }
}