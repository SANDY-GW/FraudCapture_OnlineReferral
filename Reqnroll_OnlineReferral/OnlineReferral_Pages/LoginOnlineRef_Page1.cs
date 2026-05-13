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
        private readonly By AdvancedSearch = By.XPath("//button[text()='Search']");
        private readonly By SearchCriteriaDropDown = By.XPath("//select[@class='form-control darkNavy-fc ng-pristine ng-valid ng-touched']");
        private readonly By SearchButton = By.XPath("//button[@id='btnSearch']");


        #endregion

        public void Login(string URL)
        {
            FC_OnlineReferralLogin(URL);
            IWebElement dashboardElement = WaitUntilElementClickable(Driver, By.Id("welcomeMessage"), 20);
        }

        public void EnterUserFName(string UserFN)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, userFnameField, 10);
            Driver.FindElement(userFnameField).Clear();
            Driver.FindElement(userFnameField).SendKeys(UserFN);

        }
        public void EnterUserLastName(string UserLN)
        {
            Driver.FindElement(userLnameField).Clear();
            Driver.FindElement(userLnameField).SendKeys(UserLN);

        }

        public void SelectOrgAgency(string OrgAgency)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, userFnameField, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(orgAgencyDropdn), OrgAgency);

        }
        public bool VerifyBGColorOnRequiredFields() 
        {

            var eleList = Driver.FindElements(By.XPath("//label[contains(.,'(Required)')]"));
            var allReqFieldsID = Driver.FindElements(By.XPath("//*[@id=//label[contains(.,'(Required)') and @for]/@for]"));

            foreach (IWebElement elem in allReqFieldsID)
            {

                if (elem.GetCssValue("border-color").Equals("rgb(0, 134, 113)"))//Green Color
                {
                    Console.WriteLine("Required");
                }
                else if (elem.GetCssValue("border-color").Equals("rgb(206, 212, 218)"))//Non required fields with no border color
                {
                    Console.WriteLine("Optional");
                }
                else
                {
                    Console.WriteLine("Fail");
                }

            }

            foreach (IWebElement elem in allReqFieldsID)
            {

                if (elem.GetAttribute("type").Equals("text"))
                {
                    Console.WriteLine("text");
                }
                else if (elem.GetAttribute("type").Equals("email"))
                {
                    Console.WriteLine("email");
                }
                else if (elem.GetAttribute("type").Equals("select-one"))
                {
                    Console.WriteLine("select-one");
                }
            }

            //*[@id=//label[contains(normalize-space(.),'(Required)') and @for]/@for]

            //label[contains(normalize-space(.),'(Required)') and @for]
            return false;
        }

        public void EnterUserEmailName(string emailValue)
        {
            Driver.FindElement(emailtxtbx).Clear();
            Driver.FindElement(emailtxtbx).SendKeys(emailValue);

        }
        public void EnterUserTitle(string UserTitle)
        {
            Driver.FindElement(titletxtbx).Clear();
            Driver.FindElement(titletxtbx).SendKeys(UserTitle);
        }

        public void EnterPhoneNumberAndExtension(string PhoneNumber)
        {
            Driver.FindElement(phonenumber_And_ExtensionField).Clear();
            Driver.FindElement(phonenumber_And_ExtensionField).SendKeys(PhoneNumber);
        }
        public void EnterMailingStreetAddress1(string StreetAddress1)
        {
            Driver.FindElement(mailingStreetAddress1Field).Clear();
            Driver.FindElement(mailingStreetAddress1Field).SendKeys(StreetAddress1);
        }
        public void EnterMailingStreetAddress2(string StreetAddress2)
        {
            Driver.FindElement(mailingStreetAddress2Field).Clear();
            Driver.FindElement(mailingStreetAddress2Field).SendKeys(StreetAddress2);
        }
        public void EnterMailingAddressCity(string CityName)
        {
            Driver.FindElement(mailingAddressCityField).Clear();
            Driver.FindElement(mailingAddressCityField).SendKeys(CityName);
        }
        public void SelectState_Or_Territory(string StateName)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(mailingAddressstate_Or_Territorydropdown), StateName);
        }
        public void EnterMailingAddressZipCode(string ZipCode)
        {
            Driver.FindElement(mailingAddresszipCodeField).Clear();
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

        public void ClickSearchButton()
        {
            Driver.FindElement(AdvancedSearch).Click();
        }

        public void waitQuickSearchWindow(string ProviderID)
        {
            Driver.FindElement(SearchCriteriaDropDown).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(SearchCriteriaDropDown), ProviderID);
            Driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, SearchButton, 100);
        }


    }
}
