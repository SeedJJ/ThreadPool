
namespace ThreadPool;

public class ThreadPool : IThreadPool
{
    void IThreadPool.EnqueueTask(Action task)
    {
        throw new NotImplementedException();
    }

    void IThreadPool.Shutdown()
    {
        throw new NotImplementedException();
    }
}