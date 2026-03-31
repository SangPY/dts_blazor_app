using dts_blazor_app.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dts_blazor_app.Api.Data
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {

        }

        public DbSet<TodoTask> Tasks { set; get; }
    }
}
