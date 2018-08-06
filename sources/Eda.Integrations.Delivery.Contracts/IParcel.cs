namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The data contract for the parcel.
    /// </summary>
    public interface IParcel
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        string Type { get; }

        
        /// <summary>
        /// Gets the weight.
        /// </summary>
        decimal Weight { get; }

        
        /// <summary>
        /// Gets the length.
        /// </summary>
        int Length { get; }
        
        
        /// <summary>
        /// Gets the width.
        /// </summary>
        int Width { get; }

        
        /// <summary>
        /// Gets the height.
        /// </summary>
        int Height { get; }
    }
}