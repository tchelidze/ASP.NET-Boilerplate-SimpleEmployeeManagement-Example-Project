using System.Linq;
using Abp.UI;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class CurrencyCreationPolicy : ICurrencyCreationPolicy
    {
        readonly IAvailableCurrencyListKnowledge _availableCurrencyListKnowledge;

        public CurrencyCreationPolicy(
            IAvailableCurrencyListKnowledge availableCurrencyListKnowledge)
        {
            _availableCurrencyListKnowledge = availableCurrencyListKnowledge;
        }

        public void CheckCurrencyCreationAttempt(string currencyName)
        {
            if (_availableCurrencyListKnowledge.List().All(it => it != currencyName))
                throw new UserFriendlyException("Invalid currency name");
        }
    }
}
