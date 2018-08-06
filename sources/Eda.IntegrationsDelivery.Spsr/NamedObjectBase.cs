using System.Collections.Generic;
using System.Globalization;
using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal abstract class NamedObjectBase
    {
        private readonly string _invariantCultureName;
        private readonly IReadOnlyDictionary<CultureInfo, string> _names;


        protected NamedObjectBase(IReadOnlyDictionary<CultureInfo, string> names, string invariantCultureName)
        {
            _names = names;
            _invariantCultureName = invariantCultureName;
        }



        public string GetName(CultureInfo culture = null) =>
            _names.TryGetValue(culture ?? CultureInfo.InvariantCulture, out var name) ? name : _invariantCultureName;
    }
}