using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

using Maveric.OpenERMApplication.OpenERMBase;
using Maveric.OpenEMRApplication.OpenERMPages;
using OpenEMRApplication.OpenERMPages;

namespace Maveric.OpenEMRApplication
{
    class LoginTest : WebDriverWrapper
    {
        //public static object[] ValidTest()
        //{
        //    object[] temp1 = new object[4];
        //    temp1[0] = "admin";
        //    temp1[1] = "pass";
        //    temp1[2] = "English (Indian)";
        //    temp1[3] = "Flow Board";

        //    object[] temp2 = new object[4];
        //    temp1[0] = "admin";
        //    temp1[1] = "pass";
        //    temp1[2] = "Dutch";
        //    temp1[3] = "Flow Board";

        //    object[] main = new object[2];
        //    main[0] = temp1;
        //    main[1] = temp2;
        //    return main;
        //}

        [Test]
      //  [TestCase("admin","pass", "English (Indian)", "Flow Board")]
      //[TestCaseSource("ValidTest")]
        public void ValidCredentialTest(String userName,string passWord,string language,string expectedValue)
        {
            LoginPage.EnterUsername(driver, userName);
            LoginPage.EnterPassword(driver, passWord);
            LoginPage.SelectLanguageByText(driver, language);
            LoginPage.ClickOnLogin(driver);

            String actualValue = DashboardPage.GetFlowBoardText(driver);
            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
         [TestCase("admin12", "pass", "English (Indian)", "Invalid username or password")]
        //public static object[] InValidCredentialData()
        //{

        //}
        public void InValidCredentialTest(String userName, string passWord, string language, string expectedValue)
        {
            LoginPage.EnterUsername(driver, userName);
            LoginPage.EnterPassword(driver, passWord);
            LoginPage.SelectLanguageByText(driver, language);
            LoginPage.ClickOnLogin(driver);

            String actualValue = LoginPage.GetErrorMessage(driver);
            Assert.AreEqual(expectedValue, actualValue);
        }




        

    }
}
