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
    
    public partial class UTU_DeviceManager
    {
        public System.Guid uidID { get; set; }
        public string cMacAddress { get; set; }
        public string cDeviceToken { get; set; }
        public string cNotificationSound { get; set; }
        public string cUserId { get; set; }
        public Nullable<bool> bLogout { get; set; }
        public Nullable<bool> bShowSummaryMsg { get; set; }
        public string cDeviceType { get; set; }
        public Nullable<System.DateTime> dLoginTime { get; set; }
        public Nullable<int> iCount { get; set; }
    }
}
