using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using stackTest.Localization;
using Volo.Abp.Application.Services;

namespace stackTest
{
    /* Inherit your application services from this class.
     */
    public class StackTestAppService : ApplicationService
    {
        public StackTestAppService()
        {
            LocalizationResource = typeof(stackTestResource);
        }
    }
}
