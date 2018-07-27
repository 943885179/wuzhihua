using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace common
{
    public  class GetIP
    { 
        public static Boolean ipCan() {
            string wIp = getExternalIp();//外网ip固定
            var nIp = getIP();
            string[] canLoginList = new string[] { "陈永鹏", "陈妹二"};//允许访问的ip
            Boolean neiwanIp = false;
            foreach (var user in canLoginList) {
                if (user.Equals(nIp.userName)) {
                    neiwanIp = true;
                    break;
                }
            }
            if (wIp.Equals("183.62.20.2")&&neiwanIp) {
                return true;
            }
            return true;//ip地址不符合，不允许登录
        }
        /// <summary>
        /// 外网IP
        /// </summary>
        /// <returns></returns>
        public static string getExternalIp()
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.Default;
                //string response = client.DownloadString("http://1212.ip138.com/ic.asp");//失效了
                //string response = client.DownloadString("http://icanhazip.com/");//可用，可能不稳定
                string response = client.DownloadString("http://ip.chinaz.com/");//站长之家
                string myReg = @"<dd class=""fz24"">([\s\S]+?)<\/dd>";
                Match mc = Regex.Match(response, myReg, RegexOptions.Singleline);
                if (mc.Success && mc.Groups.Count > 1)
                {
                    response = mc.Groups[1].Value;
                    return response;
                }
                else
                {
                    return "Can't get you Ip address!";
                }
            }
            catch (Exception)
            {
                return "Can't get you Ip address!";
            }

        }
        /// <summary>
        /// 内网IP
        /// </summary>
        /// <returns></returns>
        public static UserModel getIP() {
            //与上面一样，只不过用了Dns.GetHostAddresses()的方法
            IPAddress[] dnsIps = Dns.GetHostAddresses(Dns.GetHostName());
            for (int i = 0; i < dnsIps.Length; i++)
            {
                if (dnsIps[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    //netInfo += "\r\nDns.GetHostAddresses()得到本机正在使用的IP为：" + dnsIps[i].ToString();

                    // return dnsIps[i].ToString();
                    return new UserModel() {
                        loginName="cyp",
                        userName="陈永鹏"
                    };

                }
            }
            return null;
        }
    }
}
