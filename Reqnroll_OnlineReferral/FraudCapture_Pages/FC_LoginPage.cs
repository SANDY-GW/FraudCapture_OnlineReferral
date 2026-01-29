using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    internal class FC_LoginPage:BaseSettings
    {
        public FC_LoginPage(IWebDriver driver) : base(driver) { }

        #region Elements
        private readonly By Login_UserEmail = By.XPath("//input[@id='userID']");
        private readonly By Login_PingUsername = By.XPath("//input[@id='username']");
        private readonly By Login_PingPswd = By.XPath("//input[@id='password']");
        private readonly By Login_AmaIAgree = By.XPath("//button[@id='btnAmaEulaAgree']");
        private readonly By Login_AmaCancel = By.XPath("//button[@id='btnAmaEulaCancel']");


        #endregion
        public void EnterLoginUserEmail(string userEmail)
        {
            Driver.FindElement(Login_UserEmail).SendKeys(userEmail);
        }
        public void EnterPingUsername(string pingUsername)
        {
            Driver.FindElement(Login_PingUsername).SendKeys(pingUsername);
        }
        public void EnterPingPassword(string pingPassword)
        {
            Driver.FindElement(Login_PingPswd).SendKeys(pingPassword);
        }
        public void ClickAmaIAgree()
        {
            Driver.FindElement(Login_AmaIAgree).Click();
        }
        public void ClickAmaCancel()
        {
            Driver.FindElement(Login_AmaCancel).Click();
        }

    }

}
