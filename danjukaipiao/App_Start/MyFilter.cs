using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace danjukaipiao.App_Start
{
    public class MyFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // base.OnActionExecuting(actionContext);
            //获取请求参数
            var ip = common.GetIP.getIP();
            //TODO:业务判断
            if (ip.Equals("10.0.0.102")) //请求终止，进行调整或者内容输出
            {
                //HttpContext.Current.Response.Redirect("~/home/index");
                HttpContext.Current.Response.Write("{\"id\":1,\"name\":\"小明\"}");
                //创建响应对象，初始化为成功，没有指定的话本次请求将不会被拦截
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
        }

    }
}