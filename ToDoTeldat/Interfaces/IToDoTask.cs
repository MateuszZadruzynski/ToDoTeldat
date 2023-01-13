using Models;

namespace ToDoTeldat.Interfaces
{
    public interface IToDoTask
    {
        public IEnumerable<ToDoTask> GetTasks();

        public Task AddTask(ToDoTask toDoTask);

        public Task EditTask(ToDoTask toDoTask);

        public Task DeleteTask(int taskId);
    }
}
