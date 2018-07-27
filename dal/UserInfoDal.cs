using Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    /// <summary>
    /// 员工登录信息获取
    /// </summary>
     public  class UserInfoDal
    {
        /// <summary>
        /// 获取用户信息，登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public userInfo getUserInfo(UserModel user) {
            using (var db = new OAtoU8DATAEntities())
            {
                try
                {
                    return db.userInfo.Where(o => o.name.Equals(user.userName) && o.password.Equals(user.password)).FirstOrDefault();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        //获取审单财务
        public form_enumvalue getCaiwu(userInfo user) {
            using (var db = new v3xEntities())
            {
                return (from e in db.form_enumvalue join el in db.form_enumlist on e.ref_enumid equals el.id where e.showValue.Contains(user.name) select e).FirstOrDefault();
            }

            }
        public userInfo updateUserInfo(UserModel user) {
            using (var db = new OAtoU8DATAEntities())
            {
                try
                {
                    var oldUser= db.userInfo.Where(o => o.name.Equals(user.userName) && o.password.Equals(user.password)).FirstOrDefault();
                    oldUser.password = user.newpassword;
                    db.SaveChanges();
                    return oldUser;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
