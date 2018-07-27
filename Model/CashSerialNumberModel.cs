using System;

namespace model
{
    /// <summary>
    /// 出纳类别字（收、付）
    /// </summary>
    public class CashSerialNumberModel
    {
        public int ID { get; set; }
        public string SNWord { get; set; }
        public string SNText { get; set; }
        public string U8VouchSign { get; set; }

    }
}
