using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleEmployeeManagement.Employees.Entities;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class CurrencyDomainService : ICurrencyDomainService
    {

        public CurrencyDomainService()
        {
        }

        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return null;

        }

    }
}
