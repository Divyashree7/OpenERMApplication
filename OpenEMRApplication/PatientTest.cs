using Maveric.OpenEMRApplication.OpenERMPages;
using Maveric.OpenERMApplication.OpenERMBase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenEMRApplication
{
    class PatientTest : WebDriverWrapper
    {
        [Test]
        public void AddPatientlTest()
        {
            LoginPage.EnterUsername(driver, "admin");
            LoginPage.EnterPassword(driver, "pass");
            LoginPage.SelectLanguageByText(driver, "English (Indian)");
            LoginPage.ClickOnLogin(driver);

           

        }

        [Test]
        public void DeletePatientlTest()
        {
            LoginPage.EnterUsername(driver, "admin");
            LoginPage.EnterPassword(driver, "pass");
            LoginPage.SelectLanguageByText(driver, "English (Indian)");
            LoginPage.ClickOnLogin(driver);

           
        }


    }
}
