using System;

namespace model
{
   public class WriteModel
    {
        public string col_id { get; set; }//单据编号
        public string name { get; set; }//签字人
        public string depatement { get; set; }//签字部门
        public string leave { get; set; }//签字人等级

        public int attitude { get; set; }//签字人态度
        public DateTime? create_date { get; set; }//签字日期
    }
}
