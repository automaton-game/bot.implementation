
using automatonGame.bot.implementation;

namespace automatonGame.bot.implementation.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var a = RobotFactory.Create();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}