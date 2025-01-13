using BowlingKata;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void Can_Roll()
        {
            _game.Roll(0);

            Assert.Pass();
        }

        [Test]
        public void Can_SinglePin_ScoreIsCorrect()
        {
            _game.Roll(1);

            Assert.That(_game.Score(), Is.EqualTo(1));
        }
    }
}
