using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSSSRUItest
{
    public class WebDriver
    {
        public static IWebDriver DriverInstance { get; set; }

        public static void Initialize()
        {
            DriverInstance = new ChromeDriver();
            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            DriverInstance.Manage().Window.Maximize();
        }

        public static string siteUrl
        {
            get { return "http://blog.csssr.ru/qa-engineer/"; } //add site url
        }

        public static void Navigate()
        {
            DriverInstance.Navigate().GoToUrl(siteUrl);
        }

        public static void Close()
        {
            DriverInstance.Close();
            DriverInstance.Quit();
        }
    }
}
