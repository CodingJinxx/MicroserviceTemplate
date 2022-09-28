using Ardalis.Result;
using MicroserviceTemplate.Core.ProjectAggregate;

namespace MicroserviceTemplate.Core.Interfaces;

public interface IToDoItemSearchService
{
    Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
    Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}