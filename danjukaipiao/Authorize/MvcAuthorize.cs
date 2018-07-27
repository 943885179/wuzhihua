using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace danjukaipiao.Authorize
{
    public class MvcAuthorize: AuthorizeAttribute
    {
        /// <summary>
        /// 禁用mvc
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}