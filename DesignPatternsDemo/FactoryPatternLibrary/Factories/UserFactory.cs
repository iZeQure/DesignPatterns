using FactoryPatternLibrary.Abstractions;
using ObjectLibrary.Abstractions;
using ObjectLibrary.Core;
using System;

namespace FactoryPatternLibrary.Factories
{
    /// <summary>
    /// Represents a class handling the factory of users.
    /// </summary>
    public class UserFactory : IUserFactory
    {
        public IUser Create(int criteria, params string[] values)
        {
            try
            {
                return new User(criteria, values[0], values[1], values[2], values[3]);
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(values), "Values was out of range in order to create the user.");
            }
        }
    }
}
