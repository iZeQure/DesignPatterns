using FactoryPatternLibrary.Abstractions;
using ObjectLibrary.Abstractions;
using System;
using System.Collections.Generic;

namespace RepositoryPatternLibrary.Repositories.User
{
    public class DbUserRepository : IUserRepository
    {
        private readonly IUserFactory _userFactory;

        public DbUserRepository(IUserFactory userFactory)
        {
            _userFactory = userFactory;
        }

        public IUser Create(IUser item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IUser item)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IUser GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public IUser Update(IUser item)
        {
            throw new NotImplementedException();
        }
    }
}
