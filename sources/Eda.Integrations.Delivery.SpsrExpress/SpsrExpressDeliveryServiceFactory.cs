using System.Collections.Generic;
using System.Globalization;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    public class SpsrExpressDeliveryServiceFactory : IDeliveryServiceFactory
    {
        public IAddress NewAddress(ICountry country, ICity city, IContact contact, object address)
        {
            throw new System.NotImplementedException();
        }

        public ICity NewCity(object id, IReadOnlyDictionary<CultureInfo, string> names, double latitude, double longitude)
        {
            throw new System.NotImplementedException();
        }

        public IContact NewContact(string name, string phone)
        {
            throw new System.NotImplementedException();
        }

        public ICountry NewCountry(object id, IReadOnlyDictionary<CultureInfo, string> names, CultureInfo culture, object currency)
        {
            throw new System.NotImplementedException();
        }

        public IDelivery NewDelivery(object id)
        {
            throw new System.NotImplementedException();
        }

        public IDeliveryInformation NewDeliveryInformation(IDeliveryRequest request, decimal cost)
        {
            throw new System.NotImplementedException();
        }

        public IDeliveryOrder NewDeliveryOrder(object id, IDelivery delivery)
        {
            throw new System.NotImplementedException();
        }

        public IDeliveryRequest NewDeliveryRequest(IAddress sourceAddress, IAddress destinationAddress, object deliveryType,
            IParcel parcel)
        {
            throw new System.NotImplementedException();
        }

        public IParcel NewParcel(decimal weight, object parcelType)
        {
            throw new System.NotImplementedException();
        }

        public IPickPoint NewPickupPoint(object id, IAddress address, WorkingWeekSchedule schedule)
        {
            throw new System.NotImplementedException();
        }
    }
}