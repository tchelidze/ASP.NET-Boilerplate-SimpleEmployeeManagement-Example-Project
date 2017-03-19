namespace SimpleEmployeeManagement.Employees.Services
{
    public interface INationalityCreationPolicy
    {
        void CheckNationalityCreationAttempt(string nationalityName);
    }
}