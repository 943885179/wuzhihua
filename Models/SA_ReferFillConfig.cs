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
    
    public partial class SA_ReferFillConfig
    {
        public string cardnumber { get; set; }
        public string fieldname { get; set; }
        public string cardsection { get; set; }
        public string refername { get; set; }
        public string sourcefieldname { get; set; }
        public string destfieldname { get; set; }
        public Nullable<bool> breferfill { get; set; }
        public Nullable<bool> bcellcheckfill { get; set; }
        public Nullable<bool> bclear { get; set; }
        public long autoid { get; set; }
        public Nullable<byte> bcheckchange { get; set; }
        public string changemsg { get; set; }
        public Nullable<byte> brefervoucherfill { get; set; }
    }
}
