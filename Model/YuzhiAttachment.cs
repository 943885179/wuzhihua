using model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public   class YuzhiAttachment
    {
        public string Id { get; set; }
        public long col_id { get; set; }
        public List<Detail> detailList { get; set; }
        public List<RecordTable> record { get; set; }
    }
}
