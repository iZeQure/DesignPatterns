namespace ObjectLibrary.Abstractions
{
    /// <summary>
    /// Represents a generic snowflake identity.
    /// </summary>
    public interface ISnowflakeIdentify
    {
        public int Id { get; }
    }
}
