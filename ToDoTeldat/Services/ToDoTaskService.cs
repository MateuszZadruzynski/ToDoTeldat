using DBConnect;
using Microsoft.EntityFrameworkCore;
using Models;
using ToDoTeldat.Interfaces;

namespace ToDoTeldat.Services
{
    public class ToDoTaskService : IToDoTask
    {
        private IDbContextFactory<DBConnects> DbContextFactory;

        public ToDoTaskService(IDbContextFactory<DBConnects> dbContextFactory)
        {
            DbContextFactory = dbContextFactory;
        }

        public List<ToDoTask> GetTasks()
        {
            try
            {
                using (var context = DbContextFactory.CreateDbContext())
                {
                    var data = context.ToDoTasks.Where(x => x.Id != null).ToList();

                    return data;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas dodwania zadania!", ex);
                return new List<ToDoTask>();
            }
        }

        public void AddTask(ToDoTask toDoTask)
        {
            try
            {
                using (var context = DbContextFactory.CreateDbContext())
                {
                    context.ToDoTasks.Add(toDoTask);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas dodwania zadania!", ex);
            }
        }

        public void DeleteTask(ToDoTask toDoTask)
        {
            try
            {
                using (var context = DbContextFactory.CreateDbContext())
                {
                    context.ToDoTasks.Remove(toDoTask);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas usuwania zadania!", ex);
            }
        }

        public void EditTask(ToDoTask toDoTask)
        {
            try
            {
                using (var context = DbContextFactory.CreateDbContext())
                {
                    context.ToDoTasks.Update(toDoTask);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas edytowania zadania!", ex);
            }
        }
    }
}
