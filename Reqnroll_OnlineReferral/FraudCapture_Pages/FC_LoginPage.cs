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
            //CommonHelpers.WaitForPageToLoad(Driver, 100);

            var emailInput = Driver.FindElement(Login_UserEmail);

            emailInput.Click();
            emailInput.Clear();
            emailInput = Driver.FindElement(Login_UserEmail);
            emailInput.SendKeys(userEmail);

        }
        public void EnterPingUsername(string pingUsername)
        {
            Driver.FindElement(Login_PingUsername).SendKeys(pingUsername);
        }
        public void EnterPingPassword(string pingPassword)
        {
            Driver.FindElement(Login_PingPswd).SendKeys(pingPassword);
        }
        public void EnterPingPassCode(string pingPassCode)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Login_PassCode, 100);
            Driver.FindElement(Login_PassCode).SendKeys(pingPassCode);
        }

        public void ClickProceedToLogin()
        {
            Driver.FindElement(Login_ProceedToLogin).Click();
        }
        public void ClickAmaIAgree()
        {
            Driver.FindElement(Login_AmaIAgree).Click();
        }
        public void ClickAmaCancel()
        {
            Driver.FindElement(Login_AmaCancel).Click();
        }
        public void ClickPingOneSignOnButton()
        {
            Driver.FindElement(Login_PingOneSignOnButton).Click();
        }
        public void ClickPingOnePassCodeSignOnButton()
        {
            Driver.FindElement(Login_PingOnePassCodeSignOnButton).Click();
        }

        public void waitForPingOnePassCodeSignOnButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Login_PingOnePassCodeSignOnButton, 100);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForIAgreeButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Login_AmaIAgree, 30000);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }

    }

}
