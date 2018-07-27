using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 返回列表
    /// </summary>
    public class ResultDateModel
    {
        /// <summary>
        /// 获取头部信息
        /// </summary>
        public Col_summaryModel col_summary { get; set; }
        /// <summary>
        /// 获取个人事项
        /// </summary>
        public v3x_affair v3x_affair { get; set; }
        /// <summary>
        /// 获取内容信息
        /// </summary>
        public col_body col_body { get; set; }
        /// <summary>
        /// 获取发起人信息
        /// </summary>
        public v3x_org_member v3x_org_member { get; set; }
        /// <summary>
        /// 获取发起部门信息
        /// </summary>
        public v3x_org_department v3x_org_department { get; set; }
        /// <summary>
        /// 获取受益部门（签字信息）
        /// </summary>
        public v3x_org_department v3x_org_department1 { get; set; }
        /// <summary>
        /// 差旅费集合
        /// </summary>
        public ChailvList ChailvList { get; set; }
        /// <summary>
        /// 费用报销单集合
        /// </summary>
        public BaoxiaoList BaoxiaoList { get; set; }

        /// <summary>
        /// 付款审批单集合
        /// </summary>
        public ShenpiList ShenpiList { get; set; }

        /// <summary>
        /// 预支单集合
        /// </summary>
        public YuzhiList YuzhiList { get; set; }
        /// <summary>
        /// shanghaiyuemu feiyongshgnqingbiao
        /// </summary>
        public ShenqianbiaoList ShenqianbiaoList { get; set; }
        /// <summary>
        /// 签字流程
        /// </summary>
        public List<Write> WriteList { get; set; }
    }
    /// <summary>
    /// 差旅费获取详细描述
    /// </summary>
    public class ChailvList{
        /// <summary>
        /// 差旅费报销单（内容）
        /// </summary>
        public formmain_0545 formmain_0559 { get; set; }
        /// <summary>
        /// 差旅费明细
        /// </summary>
        public List<formson_0546> formson_0560List { get; set; }
    }

    public class ShenqianbiaoList
    {
        public formmain_0190 formmain_0190 { get; set; }
        public List<formson_0191> formson_0191List { get; set; }
    }
    /// <summary>
    /// 费用报销单获取详细描述
    /// </summary>
    public class BaoxiaoList
    {
        /// <summary>
        /// 费用报销单（内容）
        /// </summary>
        public formmain_0545 formmain_0563 { get; set; }
        /// <summary>
        /// 费用报销单明细
        /// </summary>
        public List<formson_0564List> formson_0564List { get; set; }
    }
    /// <summary>
    /// 费用报销单明细（集合）
    /// </summary>
    public class formson_0564List
    {
        public formson_0546 formson_0564 { get; set; }
        public v3x_org_department v3x_org_department { get; set; }
    }
    /// <summary>
    /// 预支单获取详细描述
    /// </summary>
    public class YuzhiList
    {
        /// <summary>
        /// 预支单（内容）
        /// </summary>
        public formmain_0545 formmain_0567 { get; set; }
        /// <summary>
        /// 预支单明细
        /// </summary>
        public List<formson_0568List> formson_0568List { get; set; }
    }
    /// <summary>
    /// 预支单明细（集合）
    /// </summary>
    public class formson_0568List
    {
        public formson_0546 formson_0568 { get; set; }
        public v3x_org_department v3x_org_department { get; set; }
    }
    /// <summary>
    ///付款审批单获取详细描述
    /// </summary>
    public class ShenpiList
    {
        /// <summary>
        /// 付款审批单（内容）
        /// </summary>
        public formmain_0545 formmain_0571 { get; set; }
        /// <summary>
        /// 付款审批单明细
        /// </summary>
        public List<formson_0572List> formson_0572List { get; set; }
    }
    /// <summary>
    /// 付款审批单明细（集合）
    /// </summary>
    public class formson_0572List
    {
        public formson_0546 formson_0572 { get; set; }
        public v3x_org_department v3x_org_department { get; set; }
    }

    public class Write {
        /// <summary>
        /// 签字人姓名
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 签字时间
        /// </summary>
        public DateTime? date { get; set; }
        /// <summary>
        /// 签字人职位等级
        /// </summary>
        public string leave { get; set; }
    }
}
