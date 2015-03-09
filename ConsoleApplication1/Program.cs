using System;
using MiNET;
using log4net;
using System.Diagnostics;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MiNetServer));
        private static MiNetServer server = new MiNetServer();
        private static void Main(string[] args)
        {
            //setinfo();
            Console.Title = "MiNETServer 服务器" + "||Version:1.0.266.0";
            Program.start();
            string str = Console.ReadLine();
            stoprestart(str);
        }
        private static void start()
        {
            CMDColor.INFO("启动MiNET");
            server.StartServer();
            CMDColor.INFO("MiNET已启动. 如需关闭请输入:[stop]停止运行，或者输入[restart]重启");
        }
        private static void stoprestart(string str)
        {
            
            if (str.ToLower() == "stop" || str == "关闭")
            {
                server.StartServer();
                Console.Clear();
                CMDColor.Warning("服务器已关闭,点击回车键关闭窗体.");
                Console.ReadLine();
            }
            else if (str.ToLower() == "restart" || str == "重启")
            {
                Console.Clear();
                Program.start();
                //string str1 = ;
                stoprestart(Console.ReadLine());
            }
            else
            {
                Console.Clear();
                CMDColor.Warning("输入错误，请重新输入！");
                //string str2 = Console.ReadLine();
                stoprestart(Console.ReadLine());
            }
        }
        /*目前暂时不启用该方法
        private static void setinfo()
        {
            string cpu = string.Empty, Memory = string.Empty, Thread = string.Empty;
            Process CurrentProcess = Process.GetCurrentProcess();
            CurrentProcess.Id.ToString();//PID
            cpu = ((Double)(CurrentProcess.TotalProcessorTime.TotalMilliseconds - CurrentProcess.UserProcessorTime.TotalMilliseconds)).ToString();//CPU
            Memory = (CurrentProcess.WorkingSet64 / 1024 / 1024).ToString() + "M (" + (CurrentProcess.WorkingSet64 / 1024).ToString() + "KB)";//占用内存
            Thread = CurrentProcess.Threads.Count.ToString();//线程
            Console.Title = "CPU:" + cpu + "||Memory:" + Memory + "||Thread:" + Thread;
        }
        */
    }
}
