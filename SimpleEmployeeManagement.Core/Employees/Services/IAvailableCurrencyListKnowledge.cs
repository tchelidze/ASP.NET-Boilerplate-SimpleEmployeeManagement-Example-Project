using System.Collections.Generic;

namespace SimpleEmployeeManagement.Employees.Services
{
    public interface IAvailableCurrencyListKnowledge
    {
        IEnumerable<string> List();
    }
}