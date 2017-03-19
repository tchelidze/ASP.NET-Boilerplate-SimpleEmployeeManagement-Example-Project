using SimpleEmployeeManagement.Employees;

namespace SimpleEmployeeManagement.Web.Controllers
{
    public class EmployeesController : SimpleEmployeeManagementControllerBase
    {
        readonly IEmployeeAppService _service;

        public EmployeesController(
            IEmployeeAppService service)
        {
            _service = service;
        }
    }
}