using System;
using System.Diagnostics;

namespace PPPOE
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCmd("Rasdial.exe", " 宽带连接 17300000000@njxy " + Console.ReadLine());
            Console.ReadKey();
        }

        static void RunCmd(string cmdExe, string cmdStr)
        {
            try
            {
                using (Process myPro = new Process())
                {
                    //指定启动进程是调用的应用程序和命令行参数
                    ProcessStartInfo psi = new ProcessStartInfo(cmdExe, cmdStr);
                    myPro.StartInfo = psi;
                    myPro.Start();
                    myPro.WaitForExit();
                }
            }
            catch
            {

            }
        }
    }
}
