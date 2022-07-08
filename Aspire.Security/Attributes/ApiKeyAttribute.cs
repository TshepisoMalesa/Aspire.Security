using Aspire.Security.Secrets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspire.Security.Attributes
{
  [AttributeUsage(validOn: AttributeTargets.Class)]
  public class ApiKeyAttribute : Attribute, IAsyncActionFilter
  {

    string APIKEYNAME = Keys.AspireAPI.Headers.Name;

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
      if (!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
      {
        context.Result = new ContentResult()
        {
          StatusCode = 401,
          Content = "Api Key was not provided"
        };
        return;
      }

      if (!Keys.AspireAPI.Headers.Value.Equals(extractedApiKey))
      {
        context.Result = new ContentResult()
        {
          StatusCode = 401,
          Content = "Api Key is not valid"
        };
        return;
      }

      await next();
    }
  }
}
