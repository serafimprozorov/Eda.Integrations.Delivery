using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The contract for the delivery geo service.
    /// </summary>
    public interface IDeliveryGeoService
    {
        /// <summary>
        /// Gets available countries.
        /// </summary>
        /// <param name="start">The beginning of the name.</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>
        /// The list of available countries.
        /// </returns>
        Task<IReadOnlyList<ICountry>> GetCountries(string start, CancellationToken ct = default);

        
        /// <summary>
        /// Gets available regions in the <paramref name="country"/>.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <param name="start">The beginning of the name.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// The list of available countries.
        /// </returns>
        Task<IReadOnlyList<IRegion>> GetRegions(ICountry country, string start, CancellationToken ct = default);
        
        
        /// <summary>
        /// Gets available cities in the <see cref="region"/>. 
        /// </summary>
        /// <param name="region">The region.</param>
        /// <param name="start">The beginning of the name.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// The list of available cities.
        /// </returns>
        Task<IReadOnlyList<ICity>> GetCities(IRegion region, string start,
            CancellationToken ct = default);

        
        /// <summary>
        /// Gets available streets in the <see cref="city"/>.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="start">The beginning of the name.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// The list of available streets.
        /// </returns>
        Task<IReadOnlyList<IStreet>> GetStreets(ICity city, string start, CancellationToken ct = default);
    }
}