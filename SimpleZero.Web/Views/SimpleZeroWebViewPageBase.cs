using Abp.Web.Mvc.Views;

namespace SimpleZero.Web.Views
{
    public abstract class SimpleZeroWebViewPageBase : SimpleZeroWebViewPageBase<dynamic>
    {

    }

    public abstract class SimpleZeroWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SimpleZeroWebViewPageBase()
        {
            LocalizationSourceName = SimpleZeroConsts.LocalizationSourceName;
        }
    }
}