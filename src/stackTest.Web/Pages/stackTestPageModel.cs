using stackTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace stackTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class stackTestPageModel : AbpPageModel
    {
        protected stackTestPageModel()
        {
            LocalizationResourceType = typeof(stackTestResource);
        }
    }
}