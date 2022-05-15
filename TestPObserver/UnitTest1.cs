using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer;

namespace TestObserver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EditorInListAll()
        {
            Countdown countdown = new Countdown();
            Editor editor = new Editor("Костя");
            countdown.Subscribe(editor);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1);
            Assert.IsTrue(editor.GotTheNews);
        }
        [TestMethod]
        public void EditorInListOne()
        {
            Countdown countdown = new Countdown();
            Editor editor = new Editor("Костя");
            countdown.Subscribe(editor);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1, editor);
            Assert.IsTrue(editor.GotTheNews);
        }
        [TestMethod]
        public void MarketerInListAll()
        {
            Countdown countdown = new Countdown();
            Marketer marketer = new Marketer("Костя");
            countdown.Subscribe(marketer);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1);
            Assert.IsTrue(marketer.GotTheNews);
        }
        [TestMethod]
        public void MarketerInListOne()
        {
            Countdown countdown = new Countdown();
            Marketer marketer = new Marketer("Костя");
            countdown.Subscribe(marketer);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1, marketer);
            Assert.IsTrue(marketer.GotTheNews);
        }
        [TestMethod]
        public void TypesetterInListAll()
        {
            Countdown countdown = new Countdown();
            Typesetter typesetter = new Typesetter("Костя");
            countdown.Subscribe(typesetter);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1);
            Assert.IsTrue(typesetter.GotTheNews);
        }
        [TestMethod]
        public void TypesetterInListOne()
        {
            Countdown countdown = new Countdown();
            Typesetter typesetter = new Typesetter("Костя");
            countdown.Subscribe(typesetter);
            News news = new News("Перенос собрания");
            countdown.Notify(news, 1, typesetter);
            Assert.IsTrue(typesetter.GotTheNews);
        }
    }
}