using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Repository.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetItemsAsync();

        Task<TodoItem> GetItemAsync(int id);

        Task CreateAsync(TodoItem item);

        Task UpdateAsync(TodoItem item);

        Task DeleteAsync(int id);
    }
}