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
    
    public partial class EA_NotifyPerson
    {
        public int NotifyPersonID { get; set; }
        public int EAP_ID { get; set; }
        public string cUser_ID { get; set; }
        public string Notify_Type { get; set; }
        public string Notify_Mode { get; set; }
        public string Enabled_Flag { get; set; }
        public bool IsGroup { get; set; }
    
        public virtual EA_Position EA_Position { get; set; }
    }
}
