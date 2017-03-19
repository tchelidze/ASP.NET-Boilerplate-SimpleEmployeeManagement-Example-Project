using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class AvailableCurrencyListKnowledge : IAvailableCurrencyListKnowledge
    {
        public IEnumerable<string> List()
            => CultureInfo
                .GetCultures(CultureTypes.AllCultures)
                .Select(culture => culture.NumberFormat.CurrencySymbol);
    }
}
