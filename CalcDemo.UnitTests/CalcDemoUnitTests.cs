using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcDemo.UnitTests
{
    [TestClass]
    public class CalcDemoUnitTests
    {
        internal const string sutFileName = "CalculatorDemo.exe";

        public TestContext TestContext { get; set; }

        [ClassCleanup]
        public static void Cleanup()
        {
            // leave empty
        }

        [TestMethod]
        public void TestMethod1()
        {
            var fi = new FileInfo(Assembly.GetExecutingAssembly().FullName);

            string workingDir = fi.Directory.FullName;
            if (!File.Exists(Path.Combine(workingDir, sutFileName)))
                Assert.Fail("Deployment of {0} is not successful!", sutFileName);
                    
            Debug.WriteLine("CalcDemo.exe exists!");

            ProcessStartInfo pi = new ProcessStartInfo
            {
                FileName = sutFileName,
                UseShellExecute = false,
                WorkingDirectory = workingDir,
            };

            var process = Process.Start(pi);
            if( process == null)
            {
                Assert.Fail("CalcDemo.exe can't be launched! Please check this issue!");
            }
            Thread.Sleep(5000);
            process.Kill();
            Thread.Sleep(100);

        }
    }
}
