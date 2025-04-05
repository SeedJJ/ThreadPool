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
        public void TestRunSingleTask()
        {
            bool isExecuted = false;

            _threadPool.EnqueueTask(() => {
                isExecuted = true;
            });

            Thread.Sleep(500);

            Assert.That(isExecuted, Is.True, "Single Task has not been executed.");
        }

        [TearDown]
        public void Teardown()
        {
            _threadPool.Shutdown();
        }
    }
}
