using Microsoft.AspNetCore.Builder;
using Inva.LawMax;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Inva.LawMax.Web.csproj");
await builder.RunAbpModuleAsync<LawMaxWebTestModule>(applicationName: "Inva.LawMax.Web" );

public partial class Program
{
}
