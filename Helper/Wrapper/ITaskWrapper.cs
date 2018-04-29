using System;
using System.Threading.Tasks;

namespace Helper.Wrapper
{
    public interface ITaskWrapper
    {
        TaskStatus GetStatus();
    }

    public interface ITask : ITaskWrapper
    {
        void Run(Action action);
    }

    public interface ITask<T> : ITaskWrapper
    {
        Task<T> Run(Func<T> action);
    }
}