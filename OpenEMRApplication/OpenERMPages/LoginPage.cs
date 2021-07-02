using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OpenEMRApplication.OpenERMPages
{
    class LoginPage
    {
        private static By usernameLocator = By.CssSelector("#authUser");
        private static By PasswordLocator = By.CssSelector("#clearPass");
        private static By loginLocator = By.CssSelector("[type='submit']");
        private static By languageLocator = By.CssSelector("[name='languageChoice']");
        private static By errorlocator = By.XPath("//div[contains(text(),'Invalid username or password')]");

        public static void EnterUsername(IWebDriver driver, String username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }
        public static void EnterPassword(IWebDriver driver, String password)
        {
            driver.FindElement(PasswordLocator).SendKeys("pass");
        }
        public static void ClickOnLogin(IWebDriver driver)
        {



            driver.FindElement(loginLocator).Click();

        }
        public static void SelectLanguageByText(IWebDriver driver, string language)
        { 
        SelectElement select = new SelectElement(driver.FindElement(languageLocator));
        select.SelectByText(language);
            }

        public static string  GetErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(errorlocator).Text;
                
        }
      
    }
}


