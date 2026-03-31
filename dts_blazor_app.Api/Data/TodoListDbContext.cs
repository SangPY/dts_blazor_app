using dts_blazor_app.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dts_blazor_app.Api.Data
{
    public class TodoListDbContext : IdentityDbContext<User, Role, Guid>
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {

        }

        public DbSet<TodoTask> Tasks { set; get; }
    }
}
