using Models;

namespace ToDoTeldat.Interfaces
{
    public interface IToDoTask
    {
        public Task AddTask(ToDoTask toDoTask);

        public Task EditTask(ToDoTask toDoTask);

        public Task DeleteTask(int taskId);
    }
}
