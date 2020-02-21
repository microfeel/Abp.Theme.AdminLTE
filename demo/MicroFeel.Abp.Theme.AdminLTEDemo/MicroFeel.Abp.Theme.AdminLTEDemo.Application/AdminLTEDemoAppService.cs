using System;
using System.Collections.Generic;
using System.Text;
using MicroFeel.Abp.Theme.AdminLTEDemo.Localization;
using Volo.Abp.Application.Services;

namespace MicroFeel.Abp.Theme.AdminLTEDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AdminLTEDemoAppService : ApplicationService
    {
        protected AdminLTEDemoAppService()
        {
            LocalizationResource = typeof(AdminLTEDemoResource);
        }
    }
}
