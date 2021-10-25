using System;
using ObjectLibrary.Abstractions;

namespace FactoryPatternLibrary.Abstractions
{
    /// <summary>
    /// Represents a generic user factory.
    /// </summary>
    public interface IUserFactory : IFactory<IUser, int> { }
}
