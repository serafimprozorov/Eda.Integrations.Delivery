using System.Collections.Generic;
using System.Globalization;
using Eda.Integrations.Delivery.Contracts;
using Eda.Integrations.Delivery.DependencyInjection;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressFactory : IDeliveryServiceFactory
    {
        public IAddress NewAddress(ICountry country, ICity city, IContact contact, object address) => new SpsrExpressAddress();
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

        public IPickupPoint NewPickupPoint(object id, IAddress address, IWorkingHours workingHours)
        {
            throw new System.NotImplementedException();
        }

        public IWorkingHours NewWorkingHours()
        {
            throw new System.NotImplementedException();
        }
    }
}