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
    
    public partial class edoc_form_element
    {
        public long id { get; set; }
        public Nullable<long> form_id { get; set; }
        public Nullable<long> element_id { get; set; }
        public Nullable<byte> required { get; set; }
    
        public virtual edoc_element edoc_element { get; set; }
        public virtual edoc_form edoc_form { get; set; }
    }
}
