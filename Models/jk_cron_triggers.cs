//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class jk_cron_triggers
    {
        public string TRIGGER_NAME { get; set; }
        public string TRIGGER_GROUP { get; set; }
        public string CRON_EXPRESSION { get; set; }
        public string TIME_ZONE_ID { get; set; }
    
        public virtual jk_triggers jk_triggers { get; set; }
    }
}
