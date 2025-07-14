using HelloWorld.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HelloWorld.Web.Pages;

public abstract class HelloWorldPageModel : AbpPageModel
{
    protected HelloWorldPageModel()
    {
        LocalizationResourceType = typeof(HelloWorldResource);
    }
}
