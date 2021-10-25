using System;

namespace FactoryPatternLibrary.Abstractions
{
    /// <summary>
    /// Represents a generic factory.
    /// </summary>
    /// <typeparam name="TEntity">Defines the entity to be used as generic.</typeparam>
    public interface IFactory<TEntity, KCriteria>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TEntity"/>.
        /// </summary>
        /// <param name="criteria">Represents the type of the identify.</param>
        /// <param name="values">Defines the values to populate the entity.</param>
        /// <returns>An initialized entity.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Is thrown whenever values is out of range of creation when creating the entity.</exception>
        TEntity Create(KCriteria criteria, params string[] values);
    }
}
