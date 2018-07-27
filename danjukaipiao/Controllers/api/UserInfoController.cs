using dal;
using Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace danjukaipiao.Controllers.api
{
    public class UserInfoController : ApiController
    {
        public static UserInfoDal dal = new UserInfoDal();
        [HttpPost]
        [Route("api/UserInfo/loginUserInfo")]
        [ActionName("loginUserInfo")]
        public object loginUserInfo(UserModel user) {
            var userInfo= dal.getUserInfo(user);
            if (HttpContext.Current.Session["userInfo"] == null)
            {
                HttpContext.Current.Session.Add("userInfo", userInfo);
            }
            else {
                HttpContext.Current.Session["userInfo"] = userInfo;
            }
            //如果type为1则表示是财务审单
            if (userInfo != null && userInfo.type == 1) {
                var caiwu = dal.getCaiwu(userInfo);
                HttpContext.Current.Session["caiwu"] = caiwu;
            }
            HttpContext.Current.Session.Timeout = 6000;
            return userInfo;
        }
        [HttpPost]
        [Route("api/UserInfo/getUserInfo")]
        [ActionName("getUserInfo")]
        public object getUserInfo()
        {
            return HttpContext.Current.Session["userInfo"];
        }
        [HttpPost]
        [Route("api/UserInfo/updateUserInfo")]
        [ActionName("updateUserInfo")]
        public object updateUserInfo(UserModel user)
        {
            var userInfo= dal.updateUserInfo(user);
            HttpContext.Current.Session["userInfo"]=null;
            return userInfo;
        }

    }
}
