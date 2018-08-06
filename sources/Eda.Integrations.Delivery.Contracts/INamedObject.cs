using System.Globalization;


namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The contract for named object.
    /// </summary>
    public interface INamedObject : IObject
    {
        /// <summary>
        /// Gets the object name for passed <paramref name="culture"/>.
        /// </summary>
        /// <param name="culture">The culture.</param>
        /// <returns>
        /// The object name.
        /// </returns>
        string GetName(CultureInfo culture);
    }
}