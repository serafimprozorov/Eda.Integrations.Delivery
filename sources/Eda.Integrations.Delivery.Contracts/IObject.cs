namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for object.
    /// It just has id.
    /// </summary>
    public interface IObject
    {
        /// <summary>
        /// Gets the id.
        /// </summary>
        object Id { get; }
    }
}