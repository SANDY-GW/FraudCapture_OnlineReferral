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
        

        #endregion

    }
}
