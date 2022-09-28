using Ardalis.Specification;

namespace MicroserviceTemplate.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}