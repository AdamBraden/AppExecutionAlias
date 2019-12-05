using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateProcessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.UseShellExecute = false;
            startInfo.EnvironmentVariables["FOO"] = "Test";
            startInfo.FileName = @"ConsoleApp6.exe";
            startInfo.CreateNoWindow = false;

            System.Diagnostics.Process.Start(startInfo).WaitForExit();
            
        }
    }
}
