using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.DependencyInjection
{
    public interface IDeliveryServiceProvider
    {
        IDeliveryService GetDeliveryService(string name);
    }
}