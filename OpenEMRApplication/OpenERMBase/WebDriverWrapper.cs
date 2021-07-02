using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OpenERMApplication.OpenERMBase
{ 
    class WebDriverWrapper
    {
        protected IWebDriver driver;
        //Browser Launch
        [SetUp]
        public void OpenERMSetUp()
        {
            string browser = "ch";

            if (browser.ToLower().Equals("ff"))
            {
                driver = new FirefoxDriver();
            }
            else if (browser.ToLower().Equals("ie"))
            {
                driver = new InternetExplorerDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/interface/login/login.php?site=default";
        }

        //Browser End Activities
        [TearDown]
        public void OpenERMTearDown()
        {
            driver.Quit();
        }
    }
}