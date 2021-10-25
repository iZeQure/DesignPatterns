using ObjectLibrary.Abstractions;
using System.Collections.Generic;

namespace RepositoryPatternLibrary.Abstractions
{
    /// <summary>
    /// Represents a generic Repository.
    /// </summary>
    /// <typeparam name="TAggregate">Type of the aggregate root.</typeparam>
    /// <typeparam name="KCriteria">Defines a criteria.</typeparam>
    public interface IRepository<TAggregate, KCriteria> where TAggregate : IAggregateRoot
    {
        TAggregate Create(TAggregate item);
        TAggregate GetById(KCriteria id);
        TAggregate Update(TAggregate item);
        bool Delete(TAggregate item);
        List<TAggregate> GetAll();
    }
}
