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
    public class U8Controller : ApiController
    {
        FromU8 dao = new FromU8();
        U8DAL dal = new U8DAL();
        /// <summary>
        /// 获取付款账号
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getAccInfo")]
        [ActionName("getAccInfo")]
        public object getAccInfo([FromUri]int type) {
            type = type == 1 ? 0 :1;//1为现金，2为银行日记账
             var result= dao.getAccInfo( type);//1:银行日记账,0:现金
            return result;
        }
        /// <summary>
        /// 获取付款类型
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getSettleStyle")]
        [ActionName("getSettleStyle")]
        public object getSettleStyle()
        {
            var style= dao.getSettleStyle();
            return style;
        }
        /// <summary>
        /// 获取供应商或者是收款人
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getReceivables")]
        [ActionName("getReceivables")]
        public object getReceivables(ResultListModel model)
        {
          var  result= dao.geCustomertUnit(model.shoukuandanwei);//客户
          if (result != null) {
                return true;
            }
             result = dao.geVendortUnit(model.shoukuandanwei);//供应商
            if (result != null)
            {
                return true;
            }
            else {
               return false;
            }
        }
        /// <summary>
        /// 获取付款账号
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getCodeList")]
        [ActionName("getCodeList")]
        public object getgetCodeList()
        {
            return dao.getCodeList();
        } 
        /// <summary>
          /// 获取流量
          /// </summary>
          /// <returns></returns>
        [HttpGet]
        [Route("api/U8/getProjectBycode")]
        [ActionName("getProjectBycode")]
        public object getProjectBycode([FromUri] string citemcode)
        {
            return dao.getProjectBycode(citemcode);
        }
        /// <summary>
        /// 获取流量列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/U8/getProject")]
        [ActionName("getProject")]
        public List<fitemss98> getProject()
        {
            return dao.getProject();
        }
        /// <summary>
        /// 添加收付款到U8
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/addToAcctBook")]
        [ActionName("addToAcctBook")]
        public object addToAcctBook(ResultListModel model)
        {
            var user = (userInfo)HttpContext.Current.Session["userInfo"];
            if (user.type == 0 || user.type == 1)
            {
                return dal.addToAcctBook(model,user);
            }
            else {
                return new { errorMsg = "无权操作" };
            }
        }
        /// <summary>
        /// 生单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/addToCloseBill")]
        [ActionName("addToCloseBill")]
        public object addToCloseBill(ResultListModel model)
        {
            var user = (userInfo)HttpContext.Current.Session["userInfo"];

            if (user.type == 1)
            {
                return dal.addToCloseBill(model, user);
            }
            else
            {
                return new { errorMsg = "无权操作" };
            }
        }
        /// <summary>
        /// 制单（不带签字）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/addToCashSignRelate")]
        [ActionName("addToCashSignRelate")]
        public object addToCashSignRelate(ResultListModel model)
        {
            var user = (userInfo)HttpContext.Current.Session["userInfo"];

            if (user.type == 1)
            {
                return dal.addToCashSignRelate(model, user);
            }
            else
            {
                return new { errorMsg = "无权操作" };
            }
        }
        /// <summary>
        /// 签字
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/addToCcashier")]
        [ActionName("addToCcashier")]
        public object addToCcashier(ResultListModel model)
        {
            return dao.addToCcashier(model);
        }
        /// <summary>
        /// 获取付款的单位（已生成付款单）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getRecordTableByPid")]
        [ActionName("getRecordTableByPid")]
        public object getRecordTableByPid(ResultListModel model)
        {
            return dao.getRecordTableByPid(model.Id);
        }
        /// <summary>
           /// 获取U8部门
           /// </summary>
           /// <param name="model"></param>
           /// <returns></returns>
        [HttpPost]
        [Route("api/U8/getDepatementList")]
        [ActionName("getDepatementList")]
        public object getDepatementList()
        {
            return dao.getDepatementList();
        }
    }
}
