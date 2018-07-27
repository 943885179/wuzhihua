using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class LogHelper
    {
        private static string LogPath = string.Empty;
        public static void WriteLog(string log)
        {
            if(string.IsNullOrEmpty(LogPath))
            {
                LogPath = Process.GetCurrentProcess().MainModule.FileName;//获得程序运行完整目录
                LogPath = LogPath.Replace(Process.GetCurrentProcess().MainModule.ModuleName, "");//去除程序名
                LogPath = LogPath + "LOG";//拼接获得程序日志目录
                if (Directory.Exists(LogPath) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(LogPath);
                }
            }
            string logFilePath = LogPath + "\\" + DateTime.Now.Date.ToShortDateString() + ".log";
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath);//创建该文件
            }
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    StreamWriter logFileWriter = new StreamWriter(logFilePath, true);
                    logFileWriter.WriteLine(log);
                    logFileWriter.Close();
                    break;
                }
                catch(Exception)
                {
                    if ((i + 1) < 10)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
