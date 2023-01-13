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

        public async Task AddTask(ToDoTask toDoTask)
        {
            try
            {
                using (var context = DbContextFactory.CreateDbContext())
                {
                    await context.ToDoTasks.AddAsync(toDoTask);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas dodwania zadania!",ex);
            }
        }

        public async Task DeleteTask(int taskId)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas usuwania zadania!", ex);
            }
        }

        public async Task EditTask(ToDoTask toDoTask)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas edytowania zadania!", ex);
            }
        }
    }
}
