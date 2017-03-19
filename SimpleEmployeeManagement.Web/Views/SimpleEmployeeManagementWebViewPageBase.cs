using Abp.Web.Mvc.Views;

namespace SimpleEmployeeManagement.Web.Views
{
    public abstract class SimpleEmployeeManagementWebViewPageBase : SimpleEmployeeManagementWebViewPageBase<dynamic>
    {

    }

    public abstract class SimpleEmployeeManagementWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SimpleEmployeeManagementWebViewPageBase()
        {
            LocalizationSourceName = SimpleEmployeeManagementConsts.LocalizationSourceName;
        }
    }
}