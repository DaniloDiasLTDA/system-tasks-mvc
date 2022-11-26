using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using SystemTasks.Data.Map;
using SystemTasks.Models;

namespace SystemTasks.Data

{
    public class SystemTasksDBcontext : DbContext
    {
        public SystemTasksDBcontext(DbContextOptions<SystemTasksDBcontext> options)
            : base(options)
        {            
        }

        public  DbSet<UserModel> User { get; set; }
        public DbSet<TaskModel> Task { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
