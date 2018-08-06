namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for the parcel.
    /// </summary>
    public interface IParcel
    {
        /// <summary>
        /// Gets the weight.
        /// </summary>
        decimal Weight { get; }
        
        /// <summary>
        /// Gets the type.
        /// </summary>
        object Type { get; }
        
//        int Width { get; }
//        
//        int Height { get; }
    }
}