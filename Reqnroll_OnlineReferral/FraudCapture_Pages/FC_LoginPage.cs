using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class FC_LoginPage : BaseSettings
    {
        public FC_LoginPage(IWebDriver driver) : base(driver) { }

        #region Elements
        private readonly By Login_UserEmail = By.XPath("//input[@id='userID']");
        private readonly By Login_ProceedToLogin = By.XPath("//*[contains(text(),'Proceed to Login')]");
        private readonly By Login_PassCode = By.XPath("//*[@id='submit-button']");
        private readonly By Login_PingOneSignOnButton = By.XPath("//*[@id='otp-code']");
        private readonly By Login_PingOnePassCodeSignOnButton = By.XPath("//*[@id='sign-on']");

        private readonly By Login_PingUsername = By.XPath("//input[@id='username']");
        private readonly By Login_PingPswd = By.XPath("//input[@id='password']");
        private readonly By Login_AmaIAgree = By.XPath("//*[@title='I Agree AMA Copyright']");
        private readonly By Login_AmaCancel = By.XPath("//button[@id='btnAmaEulaCancel']");


        #endregion
        public void EnterLoginUserEmail(string userEmail)
        {
            CommonHelpers.WaitForPageToLoad(driver, 100);

            var emailInput = driver.FindElement(Login_UserEmail);
           
                emailInput.Click();
                emailInput.Clear();
                CommonHelpers.WaitForElementVisiblity(driver, Login_UserEmail, 100);
                emailInput = driver.FindElement(Login_UserEmail);
                emailInput.SendKeys(userEmail);
                
            

        }
        public void EnterPingUsername(string pingUsername)
        {
            driver.FindElement(Login_PingUsername).SendKeys(pingUsername);
        }
        public void EnterPingPassword(string pingPassword)
        {
            driver.FindElement(Login_PingPswd).SendKeys(pingPassword);
        }
        public void EnterPingPassCode(string pingPassCode)
        {
            CommonHelpers.WaitForElementVisiblity(driver, Login_PassCode, 100);
            driver.FindElement(Login_PassCode).SendKeys(pingPassCode);
        }

        public void ClickProceedToLogin()
        {
            driver.FindElement(Login_ProceedToLogin).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 120);

        }
        public void ClickAmaIAgree()
        {
            driver.FindElement(Login_AmaIAgree).Click();
        }
        public void ClickAmaCancel()
        {
            driver.FindElement(Login_AmaCancel).Click();
        }
        public void ClickPingOneSignOnButton()
        {
            driver.FindElement(Login_PingOneSignOnButton).Click();
        }
        public void ClickPingOnePassCodeSignOnButton()
        {
            driver.FindElement(Login_PingOnePassCodeSignOnButton).Click();
        }

        public void waitForPingOnePassCodeSignOnButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, Login_PingOnePassCodeSignOnButton, 100);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForIAgreeButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, Login_AmaIAgree, 100);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }

    }

}
