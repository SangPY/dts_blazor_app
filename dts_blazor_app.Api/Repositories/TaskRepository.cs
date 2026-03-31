using dts_blazor_app.Api.Data;
using dts_blazor_app.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dts_blazor_app.Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoListDbContext _context;

        public TaskRepository(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TodoTask>> GetTaskList()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TodoTask> Create(TodoTask task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TodoTask> Update(TodoTask task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TodoTask> Delete(TodoTask task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TodoTask> GetById(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }

    }
}
