﻿using System.Collections.Generic;
using System.Globalization;
using Eda.Integrations.Delivery.Contracts;


namespace Eda.Integrations.Delivery.DependencyInjection
{
    public interface IDeliveryServiceFactory
    {
        IAddress NewAddress(ICountry country, ICity city, IContact contact, object address);

        ICity NewCity(object id, IReadOnlyDictionary<CultureInfo, string> names, double latitude, double longitude);

        IContact NewContact(string name, string phone);

        ICountry NewCountry(object id, IReadOnlyDictionary<CultureInfo, string> names, CultureInfo culture,
            object currency);

        IDelivery NewDelivery(object id);

        IDeliveryInformation NewDeliveryInformation(IDeliveryRequest request, decimal cost);

        IDeliveryOrder NewDeliveryOrder(object id, IDelivery delivery);

        IDeliveryRequest NewDeliveryRequest(IAddress sourceAddress, IAddress destinationAddress, object deliveryType,
            IParcel parcel);

        IParcel NewParcel(decimal weight, object parcelType);

        IPickupPoint NewPickupPoint(object id, IAddress address, IWorkingHours workingHours);

        IWorkingHours NewWorkingHours();
    }
}