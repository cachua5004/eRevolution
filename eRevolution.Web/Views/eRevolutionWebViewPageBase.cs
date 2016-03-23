using Abp.Web.Mvc.Views;

namespace eRevolution.Web.Views
{
    public abstract class eRevolutionWebViewPageBase : eRevolutionWebViewPageBase<dynamic>
    {

    }

    public abstract class eRevolutionWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected eRevolutionWebViewPageBase()
        {
            LocalizationSourceName = eRevolutionConsts.LocalizationSourceName;
        }
    }
}