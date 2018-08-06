using System.Collections.Generic;
using System.Globalization;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The contract for the delivery service factory.
    /// </summary>
    public interface IDeliveryServiceFactory
    {
        /// <summary>
        /// Creates the <see cref="IAddress"/> implementation.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        /// <param name="street">The street.</param>
        /// <param name="building">The building.</param>
        /// <param name="contact">The contact.</param>
        /// <param name="note">The note.</param>
        IAddress NewAddress(string postalCode, IStreet street, string building, IContact contact, string note);


        /// <summary>
        /// Creates th <see cref="IStreet"/> instance.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="city">The city.</param>
        /// <param name="name">The name.</param>
        /// <param name="latittude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        IStreet NewSreet(object id, ICity city, string name, double latittude, double longitude);
        

        /// <summary>
        /// Creates the new <see cref="ICity"/> implementation.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="region">The region.</param>
        /// <param name="names">The names table.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        ICity NewCity(object id, IRegion region, IReadOnlyDictionary<CultureInfo, string> names, double latitude, double longitude);


        /// <summary>
        /// Creates the new <see cref="IRegion"/> implementation.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="country">The country.</param>
        /// <param name="names">The names table.</param>
        IRegion NewRegion(object id, ICountry country, IReadOnlyDictionary<CultureInfo, string> names);
        
        
        /// <summary>
        /// Creates a new <see cref="ICountry"/> instance.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="names">The names table.</param>
        /// <param name="culture">The country culture.</param>
        /// <param name="currency">The country currency.</param>
        ICountry NewCountry(object id, IReadOnlyDictionary<CultureInfo, string> names, CultureInfo culture,
            object currency);
        
        
        /// <summary>
        /// Creates the new <see cref="IContact"/> implementation.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="email">The e-mail.</param>
        IContact NewContact(string name, string phone, string email);


        /// <summary>
        /// Creates the new <see cref="IDeliveryRequest"/> implementation.
        /// </summary>
        /// <param name="sourceAddress">The source address.</param>
        /// <param name="destinationAddress">The destination address.</param>
        /// <param name="deliveryType">The delivery type.</param>
        /// <param name="parcel">The parcel.</param>
        /// <param name="currency">The currency.</param>
        IDeliveryRequest NewDeliveryRequest(IAddress sourceAddress, IAddress destinationAddress, object deliveryType,
            IParcel parcel, object currency);
        
        
        /// <summary>
        /// Creates the new <see cref="IDeliveryInformation"/> implementation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cost">The cost.</param>
        IDeliveryInformation NewDeliveryInformation(IDeliveryRequest request, decimal cost);


        /// <summary>
        /// Creates the new <see cref="IDelivery"/> implementation.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="currency">The currency.</param>
        /// <param name="type">The type.</param>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        /// <param name="pickPoint">The pick point.</param>
        /// <param name="parcel">The parcel.</param>
        IDelivery NewDelivery(object id, decimal cost, object currency, string type, IAddress source,
            IAddress destination, IPickPoint pickPoint, IParcel parcel);

        
        /// <summary>
        /// Creates th new instance of the <see cref="IPickPoint"/> type.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="address">The address.</param>
        /// <param name="schedule">The schedule.</param>
        IPickPoint NewPickupPoint(object id, IAddress address, WorkingWeekSchedule schedule);


        /// <summary>
        /// Creates the new instance of the <see cref="IParcel"/> type.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="parcelType">The parcel type.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="length">The length.</param>
        IParcel NewParcel(decimal weight, object parcelType, int width, int height, int length);
        
        
        /// <summary>
        /// Creaes the new instance of the <see cref="IDeliveryOrder"/> type.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="delivery">The delivery.</param>
        IDeliveryOrder NewDeliveryOrder(object id, IDelivery delivery);

        
        

        
        

        
        
    }
}