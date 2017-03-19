using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using SimpleEmployeeManagement.Authorization;
using SimpleEmployeeManagement.MultiTenancy;

namespace SimpleEmployeeManagement.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : SimpleEmployeeManagementControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}