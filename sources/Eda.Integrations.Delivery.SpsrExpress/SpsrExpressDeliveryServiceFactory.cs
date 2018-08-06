using System.Collections.Generic;
using System.Globalization;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    public class SpsrExpressDeliveryServiceFactory : IDeliveryServiceFactory
    {
        public IAddress NewAddress(string postalCode, IStreet street, string building, IContact contact, string note)
        {
            throw new System.NotImplementedException();
        }

        public IStreet NewSreet(object id, ICity city, string name, double latittude, double longitude)
        {
            throw new System.NotImplementedException();
        }

        public ICity NewCity(object id, IRegion region, IReadOnlyDictionary<CultureInfo, string> names, double latitude, double longitude)
        {
            throw new System.NotImplementedException();
        }

        public IRegion NewRegion(object id, ICountry country, IReadOnlyDictionary<CultureInfo, string> names)
        {
            throw new System.NotImplementedException();
        }

        public ICountry NewCountry(object id, IReadOnlyDictionary<CultureInfo, string> names, CultureInfo culture, object currency)
        {
            throw new System.NotImplementedException();
        }

        
        public IContact NewContact(string name, string phone, string email) =>
            new SpsrExpressContact(name, phone, email);
        

        public IDeliveryRequest NewDeliveryRequest(IAddress sourceAddress, IAddress destinationAddress, object deliveryType,
            IParcel parcel, object currency)
        {
            throw new System.NotImplementedException();
        }

        public IDeliveryInformation NewDeliveryInformation(IDeliveryRequest request, decimal cost)
        {
            throw new System.NotImplementedException();
        }

        public IDelivery NewDelivery(object id, decimal cost, object currency, string type, IAddress source, IAddress destination,
            IPickPoint pickPoint, IParcel parcel)
        {
            throw new System.NotImplementedException();
        }

        public IPickPoint NewPickupPoint(object id, IAddress address, WorkingWeekSchedule schedule)
        {
            throw new System.NotImplementedException();
        }

        public IParcel NewParcel(decimal weight, object parcelType, int width, int height, int length)
        {
            throw new System.NotImplementedException();
        }

        public IDeliveryOrder NewDeliveryOrder(object id, IDelivery delivery)
        {
            throw new System.NotImplementedException();
        }
    }
}