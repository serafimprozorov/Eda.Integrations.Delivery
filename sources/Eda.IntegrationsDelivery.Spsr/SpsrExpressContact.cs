using Eda.Integrations.Delivery.Contracts;


namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressContact : IContact
    {
        public SpsrExpressContact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        
        
        public string Name { get; }
        
        public string Phone { get; }
    }
}