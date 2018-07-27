using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class ConditionModel
    {
        /// <summary>
        /// id
        /// </summary>
        public long col_Id { get; set; }
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
        /// <summary>
        /// 状态
        /// </summary>
        public int finishedflag_id { get; set; }
        /// <summary>
        /// 模板表单id
        /// </summary>
        public long form_appid { get; set; }
    }
}
