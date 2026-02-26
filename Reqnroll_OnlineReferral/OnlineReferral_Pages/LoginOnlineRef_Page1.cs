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
        private readonly By titletxtbx = By.XPath("//input[@id='title']");
        private readonly By phonenumber_And_ExtensionField = By.XPath("//input[@id='phone']");
        private readonly By mailingStreetAddress1Field = By.XPath("//input[@id='address1']");
        private readonly By mailingStreetAddress2Field = By.XPath("//input[@id='address2']");
        private readonly By mailingAddressCityField = By.XPath("//input[@id='city']");
        private readonly By mailingAddressstate_Or_Territorydropdown = By.XPath("//select[@id='state']");
        private readonly By mailingAddresszipCodeField = By.XPath("//input[@id='zip']");
        private readonly By emailverification = By.XPath("//div/h4[text()='Email Verification']");
        private readonly By goToPreviousSectionButton = By.XPath("//button[text()='Go to Previous Section']");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[text()=' Proceed to Next Section ']");


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
            CommonHelpers.WaitForElementVisiblity(Driver, userFnameField, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(orgAgencyDropdn), OrgAgency);

        }

        public void EnterUserEmailName(string emailValue)
        {

            Driver.FindElement(emailtxtbx).SendKeys(emailValue);

        }
        public void EnterUserTitle(string UserTitle)
        {
            Driver.FindElement(titletxtbx).SendKeys(UserTitle);
        }

        public void EnterPhoneNumberAndExtension(string PhoneNumber)
        {
            Driver.FindElement(phonenumber_And_ExtensionField).SendKeys(PhoneNumber);
        }
        public void EnterMailingStreetAddress1(string StreetAddress1)
        {
            Driver.FindElement(mailingStreetAddress1Field).SendKeys(StreetAddress1);
        }
        public void EnterMailingStreetAddress2(string StreetAddress2)
        {
            Driver.FindElement(mailingStreetAddress2Field).SendKeys(StreetAddress2);
        }
        public void EnterMailingAddressCity(string CityName)
        {
            Driver.FindElement(mailingAddressCityField).SendKeys(CityName);
        }
        public void SelectState_Or_Territory(string StateName)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(mailingAddressstate_Or_Territorydropdown), StateName);
        }
        public void EnterMailingAddressZipCode(string ZipCode)
        {
            Driver.FindElement(mailingAddresszipCodeField).SendKeys(ZipCode);
        }

        public void clickEmailAddressVerificationButton()
        {
            Driver.FindElement(emailVerificationBtn).Click();
        }

        public void waitForEmailNotification()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, emailverification, 100);

            CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 20000);

        }
       

    }
}
