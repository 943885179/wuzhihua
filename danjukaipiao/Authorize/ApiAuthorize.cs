using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace danjukaipiao.Authorize
{
    public class ApiAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            /*var response = actionContext.Response = actionContext.Response ?? new System.Net.Http.HttpResponseMessage();
            response.StatusCode = System.Net.HttpStatusCode.Forbidden;
            var content = new {success=false};
            response.Content = new StringContent(Json.Encode(content),Encoding.UTF8,"application/json");*/
            var authoriztion = actionContext.Request.Headers.Authorization;
            if (common.GetIP.ipCan())
            {
                base.IsAuthorized(actionContext);
                return;
            }
            base.HandleUnauthorizedRequest(actionContext);
        }
    }
}