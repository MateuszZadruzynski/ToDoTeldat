using Microsoft.EntityFrameworkCore;
using Models;

namespace DBConnect
{
    public class DBConnects : DbContext
    {
        public DBConnects(DbContextOptions<DBConnects> options) : base(options) 
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        #region DbSets
        public DbSet<ToDoTask> ToDoTasks { get; set; }

        #endregion
    }
}