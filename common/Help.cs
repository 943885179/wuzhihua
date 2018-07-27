using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    /// <summary>
    /// 忽略登录验证标签
    /// </summary>
    public class LoginSkipAttribute : Attribute
    {
       
    }
    /// <summary>
    /// 忽略权限验证标签
    /// </summary>
    public class PermissionSkipAttribute : Attribute
    { }
    public  class Help
    {
    }

}
