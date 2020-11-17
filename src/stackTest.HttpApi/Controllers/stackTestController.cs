using stackTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace stackTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class stackTestController : AbpController
    {
        protected stackTestController()
        {
            LocalizationResource = typeof(stackTestResource);
        }
    }
}