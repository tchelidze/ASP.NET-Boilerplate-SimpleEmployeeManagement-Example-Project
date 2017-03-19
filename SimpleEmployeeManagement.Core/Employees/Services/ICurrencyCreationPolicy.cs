namespace SimpleEmployeeManagement.Employees.Services
{
    public interface ICurrencyCreationPolicy
    {
        void CheckCurrencyCreationAttempt(string currencyName);
    }
}