using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Calculadora_Winium
{
    class Program
    {
        static void Main(string[] args)
        {

            //É necessario que o Driver.exe esteja sendo executado
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = false;
            System.Diagnostics.Process.Start(@"C:\Users\Auditeste\Documents\Daniel\Dev\c#\winium\Calculadora_Winium\Winium.Desktop.Driver.exe");

            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"C:/windows/system32/calc.exe");
            var driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);

            var window = driver.FindElement(By.Name("Calculadora"));

            window.FindElement(By.Name("Dois")).Click();
            window.FindElement(By.Name("Menos")).Click();
            window.FindElement(By.Name("Quatro")).Click();
            window.FindElement(By.Name("Mais")).Click();
            window.FindElement(By.Name("Nove")).Click();
            window.FindElement(By.Name("Igual a")).Click();

            //driver.Close();
        }
    }
}
