using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCom
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool runone;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "SerialCom", out runone);
            if(runone)
            {
                Application.Run(new SerialCom());
            }
            else
            {
                MessageBox.Show("已经运行了一个实例了");
            }
            
        }

        public static System.Diagnostics.Process RunningInstance()
        {
            System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);
            foreach(System.Diagnostics.Process process in processes)
            {
                if(process.Id != current.Id)//忽略当前进程
                {
                    if(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/","\\") ==current.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }

            return null;
        }
    }
}
