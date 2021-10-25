namespace ObjectLibrary.Abstractions
{
    /// <summary>
    /// Represents a generic user.
    /// </summary>
    public interface IUser : ISnowflakeIdentify, IAggregateRoot
    {
        /// <summary>
        /// Gets the Username.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets the Email Address.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Gets the First Name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Gets the Last Name.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Gets the Full Name.
        /// </summary>
        public string FullName { get; }
    }
}
