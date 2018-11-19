using System;
using System.Collections.Generic;

namespace model
{
    public class ResultListModel
    {
        /// <summary>
        /// formmain id
        /// </summary>
        public string Id { get; set; }//Id
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? chuangjinshijin { get; set; }//发起时间
        /// <summary>
        /// 发起人
        /// </summary>
        public string faqiren { get; set; }//发起人
        /// <summary>
        /// 公司
        /// </summary>
        public string company { get; set; }//公司
        /// <summary>
        /// 电话
        /// </summary>
        public string phone { get; set; }//电话
        /// <summary>
        /// 小写总金额
        /// </summary>
        public decimal lAmount { get; set; }//小写总金额
        /// <summary>
        /// 大写金额
        /// </summary>
        public string cAmount { get; set; }//大写金额
        /// <summary>
        /// 受益部门
        /// </summary>
        public string shouyibumen { get; set; }//受益部门（现在返回的是U8的部门id了）

        public string body_type { get; set; }//表单类型，只支持Form
        /// <summary>
        /// 申请表头
        /// </summary>
        public string title { get; set; }//申请表名称
        /// <summary>
        /// 完成时间
        /// </summary>
        public string finish_date { get; set; }//流程完成时间
        /// <summary>
        /// 发起部门
        /// </summary>
        public string faqibumen { get; set; }//发起部门
        /// <summary>
        /// 票据id
        /// </summary>
        public string colId { get; set; }//票据id
        public string tName { get; set; }//票据所在表
        public string mid { get; set; }//发起人id
        public string type { get; set; }//类型
        //拓展后的新模板要拥有滴
        public decimal yuzhi { get; set; }//预支
        public decimal yinhuan { get; set; }//应退、补
        public string shoukuandanwei { get; set; }//收款单位
        public string shoukuanyh { get; set; }//收款银行
        public string zhanhao { get; set; }//收款账号
        public string fukuanriqi { get; set; }//付款日期
        public int feiyongleixing { get; set; }//费用类型(判断是采购销售委外商的必须生单再制单)
       //差旅费特有的
        public int gongjitianshu { get; set; }//共计天数
        public DateTime? starDate { get; set; } //开始时间
        public string chuchaishiyou { get; set; }//出差事由
        public string endDate { get; set; } //结束时间
        //出纳的时候要选择的
        public string xiaozhang { get; set; }//销账确认
        public string fukuanpingzhenhao { get; set; }//付款确认凭证号
        public int contentId { get; set; }
        public Content content { get; set; }
        public string zhiwu { get; set; }//等级（流程签字需要）
        //申请明细
       public List<Detail> list { get; set; }
        public List<Piaoju> piaoju { get; set; }
        public int UnitType { get; set; }//供应商或者客户1：客户 2 ：供应商
        public int UnitID { get; set; }//供应商或者客户对应的id
        public int shifouPingzhen { get; set; }//是否生成日记账
        public int shifouShengdan { get; set; }//是否生单
        public int shifouZhidan { get; set; }//是否制单
        public string liuShui { get; set; }//流水号
        public string chunabianhao { get; set; }//一单一证后拥有出纳编号
        public string danjubianhao { get; set; }//一单一证后拥有单据编号
        public string pingzhenhao { get; set; }//一单一证后拥有凭证号
    }

    public class Content {
        public int ID { get; set; }
        public string AcctName { get; set; }
        public string SubjectCode { get; set; }

        public string ccode_name { get; set; }
    }
    /// <summary>
    /// 每个票据
    /// </summary>
    public class Piaoju {//取消
        public int tabClass { get; set; }//票据编号
        public string yinhuan { get; set; }//每个票据应还款
        public string yuzhijine { get; set; }//每个票据应付款
        public string yinhuanQuanbu { get; set; }//每个票据的累计金额（发票的金额总计）
        public string yuzhijineQuanbu { get; set; }//应付款
        public List<Detail> Detail { get; set; }//每个票据集合
        public Yinhan Yinhan { get; set; }//银行流量记录部分
        public string chunabianhao{get;set;}
        public string pingzhenhao { get; set; }
        public string danjubianhao { get; set; }
        public List<Liuliang> liuliangList { get; set; }//流量集合部分
        public List<Detail> Yuzhi { get; set; }//预支冲账部分


    }
    public class Yinhan {
        public string miaoshu { get; set; }//描述,做打印
        public decimal jine { get; set; }//kemu
        public string kemu { get; set; }//liushuizhang
        public string shouyibumen { get; set; }
        public decimal jiefan { get; set; }
    }
    public class Liuliang {
        public string citemccode { get; set; }
        public string cDirection { get; set; }
        public string citemcode { get; set; }
        public string citemname { get; set; }

        public string iotherused { get; set; }
        public decimal jine { get; set; }
    }
    public class Detail
    {
        //报销单有
        public string miaoshu { get; set; }//描述,做打印
        public string xianqing { get; set; }//详情不做打印，太多了
        /// <summary>
        /// 金额（税前金额）
        /// </summary>
        public decimal jine { get; set; }
        public DateTime? shijin { get; set; }//期限
        //差旅费特有
        public decimal jinexiaoji { get; set; }//金额小计
        public DateTime? riqi { get; set; }//日期
        public decimal qita { get; set; }//其他
        public decimal jintie { get; set; }//差旅费津贴
        public decimal shineijiaotong { get; set; }//本市内交通费
        public decimal chuchaijiaotong { get; set; }//出差地市内交通费
        public decimal zhusu { get; set; }//住宿费
        public decimal chechuan { get; set; }//车船费
        public decimal jipiao { get; set; }//机票费
        public int tianshu { get; set; }//天数
        public string qizhididian { get; set; }//起止地点

        //修改模板后，删除原有的 归类大纲
        public string kemu { get; set; }//科目
        public string shouyibumen { get; set; }//受益部门（改为返回u8部门的id）
        /// <summary>
        /// 税后金额
        /// </summary>
        public Double shuihoujine { get; set; }
        /// <summary>
        /// 税点
        /// </summary>
        public int shuidian { get; set; }
        /// <summary>
        /// 税额
        /// </summary>
        public decimal shuie { get; set; }
        public decimal jiefan { get; set; }//借方金额
    }

}
