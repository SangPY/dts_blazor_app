using dts_blazor_app.Api.Entities;

namespace dts_blazor_app.Api.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TodoTask>> GetTaskList();

        Task<TodoTask> Create(TodoTask task);

        Task<TodoTask> Update(TodoTask task);

        Task<TodoTask> Delete(TodoTask task);

        Task<TodoTask> GetById(Guid id);
    }
}
