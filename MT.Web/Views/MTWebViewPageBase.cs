using Abp.Web.Mvc.Views;

namespace MT.Web.Views
{
    public abstract class MTWebViewPageBase : MTWebViewPageBase<dynamic>
    {

    }

    public abstract class MTWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MTWebViewPageBase()
        {
            LocalizationSourceName = MTConsts.LocalizationSourceName;
        }
    }
}