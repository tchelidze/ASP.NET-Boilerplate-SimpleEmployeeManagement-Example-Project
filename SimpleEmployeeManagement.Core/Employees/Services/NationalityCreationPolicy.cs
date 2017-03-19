using System.Linq;
using Abp.UI;

namespace SimpleEmployeeManagement.Employees.Services
{
    public class NationalityCreationPolicy : INationalityCreationPolicy
    {
        readonly IAvailableNationalityListKnowledge _availableNationalityListKnowledge;

        public NationalityCreationPolicy(
            IAvailableNationalityListKnowledge availableNationalityListKnowledge)
        {
            _availableNationalityListKnowledge = availableNationalityListKnowledge;
        }

        public void CheckNationalityCreationAttempt(string nationalityName)
        {
            if (_availableNationalityListKnowledge.List().All(it => it != nationalityName))
                throw new UserFriendlyException("Invalid nationality");
        }
    }
}
