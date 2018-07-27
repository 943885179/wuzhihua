using Models;
using System;

namespace model
{
  public  class Condition
    {
        /// <summary>
        /// formmain id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 流水号 id
        /// </summary>
        public string liuShui { get; set; }
        public long col_id { get; set; }
        /// <summary>
        /// 时间范围开始
        /// </summary>
        public DateTime? startDate { get; set; }
        /// <summary>
        /// 时间范围结束
        /// </summary>
        public DateTime? endDate { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string menberName { get; set; }
        public string start { get; set; }

        public string type { get; set; }
        public userInfo userInfo{get;set;}
        public form_enumvalue form_enumvalue { get; set; }
    }
}
