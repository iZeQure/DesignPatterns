using ObjectLibrary.Abstractions;

namespace ObjectLibrary.Core
{
    /// <summary>
    /// Represents a class handling the data of a basic user.
    /// </summary>
    public class User : IUser
    {
        private readonly int _id;
        private readonly string _username;
        private readonly string _email;
        private readonly string _firstName;
        private readonly string _lastName;

        public User(int id, string username, string email, string firstName, string lastName)
        {
            _id = id;
            _username = username;
            _email = email;
            _firstName = firstName;
            _lastName = lastName;
        }

        public int Id { get { return _id; } }

        public string Username { get { return _username; } }

        public string Email { get { return _email; } }

        public string FirstName { get { return _firstName; } }

        public string LastName { get { return _lastName; } }

        public string FullName
        {
            get { return $"{FirstName + LastName}"; }
        }
    }
}
