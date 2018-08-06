using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressAddress : IAddress
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public object Id { get; set; }
        public ICountry Country { get; set; }
        public ICity City { get; set; }
        public IContact Contact { get; set; }
        public object Address { get; set; }
    }
}