using System;

namespace model
{
    /// <summary>
    /// 获取交易类型，现金or转账
    /// </summary>
    public class SettleStyleModel
    {
        public string cSSCode { get; set; }
        public string cSSName { get; set; }
        public string bSSFlag { get; set; }
        public string iSSGrade { get; set; }
        public string bSSEnd { get; set; }
        public string pubufts { get; set; }
        public string iSSBillType { get; set; }
        public string bPortalSettle { get; set; }

    }
}
