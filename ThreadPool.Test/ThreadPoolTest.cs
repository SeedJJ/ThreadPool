using Moq;

namespace ThreadPool.Test
{
    public class Tests
    {
        private IThreadPool _threadPool;

        [SetUp]
        public void Setup()
        {
            _threadPool = new Mock<IThreadPool>().Object;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
