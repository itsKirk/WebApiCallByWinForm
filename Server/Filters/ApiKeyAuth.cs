using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Server.Filters
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
  public class ApiKeyAuth : Attribute, IAsyncActionFilter
  {
    private const string ApiKeyHeaderValue = "APIKey";
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
      if (!context.HttpContext.Request.Headers.TryGetValue("ApiKeyHeaderValue", out var someCorrectKey))
      {
        context.Result = new UnauthorizedResult();
        return;
      }
      var configuration = context.HttpContext.RequestServices.GetService<IConfiguration>();
      var apiKey = configuration.GetValue<string>("APIKey");
      if (!apiKey.Equals(someCorrectKey))
      {
        context.Result = new UnauthorizedResult();
        return;
      }
      await next();
    }
  }
}
