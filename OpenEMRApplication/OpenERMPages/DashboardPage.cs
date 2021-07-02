using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication.OpenERMPages
{
    class DashboardPage
    {
        private static By flowBoardLocator = By.XPath("//div[contains(text(),'Flow Board')]");

            public static string  GetFlowBoardText(IWebDriver driver)
        {
            return driver.FindElement(flowBoardLocator).Text;
                
        }

        public static void ClickOnFlowBoard(IWebDriver driver)
        {
            driver.FindElement(flowBoardLocator).Click();
        }
    }
}
