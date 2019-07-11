using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class Apptests
    {
        const string _expectedVersionNumber = "ver. 1.1";

        [TestMethod]
        public void MatchVersionCode()
        {
            var browserDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //Set Chrome to start with maximized window
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");

            //Open Chrome
            using (var chromeDriver = new ChromeDriver(browserDriverPath, options))
            { 
                //Assign google.com to variable named url
                var url = "http://localhost:5000";
                //Go to Google.com
                chromeDriver.Navigate().GoToUrl(url);

                var wait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 1, 0));

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("ver")));

                var versionNum = chromeDriver.FindElementByName("ver").Text;

                Assert.IsTrue(versionNum==_expectedVersionNumber);

                chromeDriver.Close();
            }
        }
    }
}
