using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGenius
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var game = new Game();
            game.Roll(1);
            int score = game.Score();
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(1);
            int score = game.Score();
            Assert.AreEqual(2, score);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            int score = game.Score();
            Assert.AreEqual(0, score);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            game.Roll(1);
            int score = game.Score();
            Assert.AreEqual(11, score);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            game.Roll(1);
            game.Roll(3);
            int score = game.Score();
            Assert.AreEqual(15, score);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            game.Roll(1);
            game.Roll(3);
            game.Roll(7);
            int score = game.Score();
            Assert.AreEqual(15, score);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            game.Roll(7);
            game.Roll(3);
            int score = game.Score();
            Assert.AreEqual(17, score);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(9);
            game.Roll(7);
            game.Roll(3);
            game.Roll(8);
            int score = game.Score();
            Assert.AreEqual(35, score);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(3);
            game.Roll(5);
            int score = game.Score();
            Assert.AreEqual(26, score);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(10);
            game.Roll(3);
            int score = game.Score();
            Assert.AreEqual(23, score);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(10);
            game.Roll(3);
            game.Roll(3);
            int score = game.Score();
            Assert.AreEqual(45, score);
        }

        [TestMethod]
        public void TestMethod12()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(10);
            game.Roll(3);
            game.Roll(0);
            int score = game.Score();
            Assert.AreEqual(39, score);
        }

        [TestMethod]
        public void TestMethod13()
        {
            var game = new Game();
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(3);
            game.Roll(0);
            int score = game.Score();
            Assert.AreEqual(3, score);
        }

        [TestMethod]
        public void TestMethod14()
        {
            var game = new Game();
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);
            int score = game.Score();
            Assert.AreEqual(30, score);
        }

        [TestMethod]
        public void TestMethod15()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(3);
            game.Roll(7);
            game.Roll(10);
            int score = game.Score();
            Assert.AreEqual(21, score);
        }

        [TestMethod]
        public void TestMethod16()
        {
            var game = new Game();
            game.Roll(1);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(0);
            game.Roll(3);
            game.Roll(7);
            game.Roll(10);
            game.Roll(1);
            game.Roll(2);
            int score = game.Score();
            Assert.AreEqual(21, score);
        }
    }
}