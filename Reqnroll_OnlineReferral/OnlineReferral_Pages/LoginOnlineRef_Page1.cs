using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class LoginOnlineRef_Page1 : BaseSettings
    {
        public LoginOnlineRef_Page1(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By userFnameField = By.XPath("//input[@id='firstName']");
        private readonly By userLnameField = By.XPath("//input[@id='lastName']");
        private readonly By orgAgencyDropdn = By.XPath("//select[@id='orgName']");
        private readonly By emailtxtbx = By.XPath("//input[@id='email']");
        private readonly By emailVerificationBtn = By.XPath("//button[contains(.,'Email Address Verification')]");

        #endregion

        public void Login(string URL)
        {
            FC_OnlineReferralLogin(URL);
            IWebElement dashboardElement = WaitUntilElementClickable(Driver, By.Id("welcomeMessage"), 20);
        }

        public void EnterUserFName(string UserFN)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, userFnameField, 10);
            Driver.FindElement(userFnameField).SendKeys(UserFN);

        }
        public void EnterUserLastName(string UserLN)
        {
            Driver.FindElement(userLnameField).SendKeys(UserLN);

        }

        public void SelectOrgAgency(string OrgAgency)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(orgAgencyDropdn), OrgAgency);

        }

        public void EnterUserEmailName(string emailValue)
        {
            Driver.FindElement(emailtxtbx).SendKeys(emailValue);

        }
        public void ClickEmailAddressVerification()
        {
            Driver.FindElement(By.XPath("//button[contains(.,'Email Address Verification')]")).Click();
        }
    }
}
