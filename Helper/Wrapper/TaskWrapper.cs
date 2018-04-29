using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Helper.Wrapper
{
    public class TaskWrapper : ITask
    {
        private Task _task;

        public void Run(Action action)
        {
            using (_task = new Task(action))
            {
                _task.Start();
            }
        }

        public TaskStatus GetStatus()
        {
            return _task?.Status ?? TaskStatus.RanToCompletion;
        }
    }

    public class TaskWrapper<T> : ITask<T>
    {
        private Task<T> _task;

        public async Task<T> Run(Func<T> action)
        {
            using (_task = new Task<T>(action))
            {
                _task.Start();

                return await _task;
            }
        }

        public TaskStatus GetStatus()
        {
            return _task?.Status ?? TaskStatus.RanToCompletion;
        }
    }
}