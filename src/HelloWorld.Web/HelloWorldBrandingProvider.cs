using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using HelloWorld.Localization;

namespace HelloWorld.Web;

[Dependency(ReplaceServices = true)]
public class HelloWorldBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HelloWorldResource> _localizer;

    public HelloWorldBrandingProvider(IStringLocalizer<HelloWorldResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
