using common;
using dal;
using danjukaipiao.App_Start;
using danjukaipiao.Authorize;
using model;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace danjukaipiao.Controllers.api
{
    //[ApiAuthorize]
    public class ListController : ApiController
    {
        /// <summary>
        /// 获取基本信息列表
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        /// 
        [HttpPost]
        [Route("api/List/getList")]
        [ActionName("getList")]
        public object getList(Condition condition) {
            condition.form_enumvalue = (form_enumvalue) HttpContext.Current.Session["caiwu"];
            condition.userInfo =(userInfo)HttpContext.Current.Session["userInfo"];
            FromOA f = new FromOA();
            return f.getList(condition);
        }
        /// <summary>
        /// 获取关联数据
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getSunByattachment")]
        [ActionName("getSunByattachment")]
        public object getSunByattachment(ResultListModel model)
        {
            FromOA f = new FromOA();
           return f.getSunByattachment(model);
        }
        /// <summary>
        /// 打印时候获取详细信息，包含没个申请的明细
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getDetail")]
        [ActionName("getDetail")]
        public object getDetail(ResultListModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.type))
            {
                ResultListModel re = new ResultListModel();
                re.list = new List<Detail>();
                Detail d = new Detail();
                re.lAmount =null;
                d.jine = null;
                re.list.Add(d);
                return re;
            }
            FromOA f = new FromOA();
            return f.getDetail(model);
        }/// <summary>
        /// 获取流程签字
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getProcess")]
        [ActionName("getProcess")]
        public object getProcess(WriteModel pro)
        {
            FromOA f = new FromOA();
            List<WriteModel> list = f.getProcessList(pro);
            return list;
        }
        /// <summary>
        /// 获取出纳日记账信息
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getChunaBianhao")]
        [ActionName("getChunaBianhao")]
        public object getChunaBianhao([FromUri] string pid)
        {
            FromOA f = new FromOA();
           return f.getChunaBianhao(pid);
        }
        /// <summary>
        /// 获取预支单科目大纲
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getCode")]
        [ActionName("getCode")]
        public object getCode(WriteModel pro)
        {
            FromOA f = new FromOA();
            return f.getCode("U8预支单费用科目");
        }
        /// <summary>
        /// 获取费用科目大纲
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/List/getCodes")]
        [ActionName("getCodes")]
        public object getCodes(WriteModel pro)
        {
            FromOA f = new FromOA();
            return f.getCode("U8046费用科目");
        }

    }
}
