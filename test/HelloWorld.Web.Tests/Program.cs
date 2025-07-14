using Microsoft.AspNetCore.Builder;
using HelloWorld;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("HelloWorld.Web.csproj"); 
await builder.RunAbpModuleAsync<HelloWorldWebTestModule>(applicationName: "HelloWorld.Web");

public partial class Program
{
}
