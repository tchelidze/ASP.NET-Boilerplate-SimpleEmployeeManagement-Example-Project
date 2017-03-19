using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class AvailableNationalityListKnowledge : IAvailableNationalityListKnowledge
    {
        public IEnumerable<string> List()
            => CultureInfo
            .GetCultures(CultureTypes.AllCultures)
            .Select(it => new RegionInfo(it.LCID))
            .Select(it => it.EnglishName);
    }
}
