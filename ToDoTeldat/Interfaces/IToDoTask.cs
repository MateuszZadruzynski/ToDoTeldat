using Models;

namespace ToDoTeldat.Interfaces
{
    public interface IToDoTask
    {
        public List<ToDoTask> GetTasks();

        public void AddTask(ToDoTask toDoTask);

        public void EditTask(ToDoTask toDoTask);

        public void DeleteTask(ToDoTask toDoTask);
    }
}
