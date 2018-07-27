using dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace danjukaipiao.Controllers.api
{
    public class OAController : ApiController
    {
        [HttpPost]
        [Route("api/OA/getList")]
        [ActionName("getList")]
        public object getList(ConditionModel condition)
        {
            OAApplyDal f = new OAApplyDal();
            return  f.getList(condition);
        }
    }
}
