using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class Col_bodyModel
    {
        public long id { get; set; }
        public string body_type { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public long col_id { get; set; }
        public string content_name { get; set; }
    }
}
