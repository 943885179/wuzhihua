using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
 public   class Col_summaryModel
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public long id { get; set; }
        public string idStr { get; set; }
        /// <summary>
        /// 状态，暂未使用
        /// </summary>
        public Nullable<int> state { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string subject { get; set; }
        /// <summary>
        /// 处理期限
        /// </summary>
        public Nullable<long> deadline { get; set; }
        /// <summary>
        /// 提前提醒
        /// </summary>
        public Nullable<int> col_type { get; set; }
        /// <summary>
        /// 允许归档
        /// </summary>
        public Nullable<byte> can_archive { get; set; }
        /// <summary>
        /// 允许修改正文
        /// </summary>
        public Nullable<byte> can_modify { get; set; }
        /// <summary>
        /// 允许转发协同
        /// </summary>
        public Nullable<byte> can_due_reminder { get; set; }
        public Nullable<byte> can_forward { get; set; }
        /// <summary>
        /// 允许修改
        /// </summary>
        public Nullable<byte> can_edit { get; set; }
        /// <summary>
        /// 允许跟踪
        /// </summary>
        public Nullable<byte> can_track { get; set; }
        public Nullable<long> remind_interval { get; set; }
        /// <summary>
        /// 协同关联的项目id
        /// </summary>
        public Nullable<long> project_id { get; set; }
        public Nullable<int> important_level { get; set; }
        public Nullable<int> resent_time { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<System.DateTime> create_date { get; set; }
        /// <summary>
        /// 发起时间
        /// </summary>
        public Nullable<System.DateTime> start_date { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public Nullable<System.DateTime> finish_date { get; set; }
        public Nullable<byte> is_audited { get; set; }
        public Nullable<long> archive_id { get; set; }
        public Nullable<long> start_member_id { get; set; }
        public string process_id { get; set; }
        public Nullable<long> case_id { get; set; }
        public Nullable<long> advance_remind { get; set; }
        public string identifier { get; set; }
        public string forward_member { get; set; }
        public Nullable<long> templete_id { get; set; }
        public string workflow_rule { get; set; }
        public string webservice_code { get; set; }
        public string body_type { get; set; }
        public Nullable<long> form_recordid { get; set; }
        public Nullable<long> formid { get; set; }
        /// <summary>
        /// 当正文类型为from时对应的表单id
        /// </summary>
        public  string form_appid { get; set; }
        public Nullable<long> org_department_id { get; set; }
        public Nullable<long> org_account_id { get; set; }
        public string source { get; set; }
        public Nullable<long> parentform_summaryid { get; set; }
        public Nullable<int> newflow_type { get; set; }
        public byte can_edit_attachment { get; set; }
        public Nullable<byte> is_vouch { get; set; }
        public Nullable<long> over_worktime { get; set; }
        public Nullable<long> run_worktime { get; set; }
        public Nullable<long> over_time { get; set; }
        public Nullable<long> run_time { get; set; }
        public Nullable<byte> can_autostopflow { get; set; }
    }
}
