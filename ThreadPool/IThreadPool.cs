namespace ThreadPool;

public interface IThreadPool
{
    void EnqueueTask(Action task);

    void Shutdown();
}