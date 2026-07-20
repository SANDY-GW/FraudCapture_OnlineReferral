using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        private readonly By Captcha = By.XPath("//span[@id='recaptcha-anchor']");

        private readonly By titletxtbx = By.XPath("//input[@id='title']");
        private readonly By phonenumber_And_ExtensionField = By.XPath("//input[@id='phone']");
        private readonly By mailingStreetAddress1Field = By.XPath("//input[@id='address1']");
        private readonly By mailingStreetAddress2Field = By.XPath("//input[@id='address2']");
        private readonly By mailingAddressCityField = By.XPath("//input[@id='city']");
        private readonly By mailingAddressstate_Or_Territorydropdown = By.XPath("//select[@id='state']");
        private readonly By mailingAddresszipCodeField = By.XPath("//input[@id='zip']");
        private readonly By emailverification = By.XPath("//div/h4[text()='Email Verification']");
        private readonly By goToPreviousSectionButton = By.XPath("//button[text()='Go to Previous Section']");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[contains(.,'Proceed to Next Section')]");
        private readonly By logo = By.XPath("*//img[@title='Header Image']");
        private readonly By instructionsButton = By.XPath("//button[contains(.,'Instructions')]");


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
        public bool VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(Driver, Driver.FindElement(mailingAddressstate_Or_Territorydropdown));
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
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.localStorage.setItem('useTestData', 'true');localStorage.setItem('validatedEmail', '" + emailValue + "');localStorage.setItem('emailValidated', 'true')");

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


            Driver.FindElement(mailingAddressstate_Or_Territorydropdown).Click();
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

        public void clickProceedToNextSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, proceed_To_Next_SectionButton, 10);
            Driver.FindElement(proceed_To_Next_SectionButton).Click();
        }

        public void waitForEmailNotification()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, emailverification, 100);

            CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 120);

        }

        //instructions button

        public void clickInstructionsButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, instructionsButton, 30);
            Driver.FindElement(instructionsButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver,30);
        }

        public string validateInstructionsModalData()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//div[@class='modal-content']"), 10);
         var modaltext= Driver.FindElement(By.XPath("//div[@class='modal-content']")).Text;
            Console.WriteLine(modaltext);
            CommonHelpers.ScrollDown(Driver);

            IWebElement downloadButton = Driver.FindElement(
                By.XPath("//button[contains(text(),'Download')]"));

            ((IJavaScriptExecutor)Driver).ExecuteScript(
                "arguments[0].scrollIntoView({block:'center'});",
                downloadButton);


            
            return modaltext;
        }
        public void clickcloseInstructionsModalButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//button[contains(text(),'Close')]"), 10);
            Driver.FindElement(By.XPath("//button[contains(text(),'Close')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }


        // Locator (adjust if needed)


        public IWebElement GetLogo()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, logo, 10);
            return Driver.FindElement(logo);
        }

        public bool IsLogoDisplayed()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 70);
            CommonHelpers.ScrollUp(Driver);
            return GetLogo().Displayed;
        }

        //getting the title of the page
        public string GetPageTitle()
        {
            return Driver.Title;
        }

        // ✅ Check if logo is at TOP CENTER
        public bool IsLogoAtTopCenter()
        {
            var logoElement = GetLogo();

            int logoCenterX = logoElement.Location.X + (logoElement.Size.Width / 2);
            
            int pageCenterX = Driver.Manage().Window.Size.Width / 2;
            

            int logoTopY = logoElement.Location.Y;
            
            // Conditions:
            bool isHorizontallyCentered = Math.Abs(pageCenterX - logoCenterX) <= 20;
            bool isAtTop = logoTopY < 150; // threshold for "top"

            return isHorizontallyCentered && isAtTop;
        }


        // ✅ Check if logo is LEFT aligned
        public bool IsLogoLeftAligned()
        {
            var logoElement = GetLogo();

            int logoX = logoElement.Location.X;

            return logoX <= 50; // near left edge
        }

        public bool verifyrequiredfieldsinpage1()
        {
            var eleList = Driver.FindElements(By.XPath("//label[contains(.,'(Required)')]"));
            if (eleList.Count > 0)
            {
                foreach (IWebElement elem in eleList)
                {
                    if (!CommonData.dic.ContainsKey(elem.GetAttribute("for")))
                    {
                        Console.WriteLine();
                        return false;


                    }


                }
                return true;
            }
            else
            {
                Console.WriteLine("No required fields found");
                return false;
            }


        }

        public bool VerifyBGColorOnRequiredFieldsPage1()
        {

            var eleList = Driver.FindElements(By.XPath("//label[contains(.,'(Required)')]"));
            var allReqFieldsID = Driver.FindElements(By.XPath("//*[@id=//label[contains(.,'(Required)') and @for]/@for]"));
            bool bgcolormatch = true;

            if (eleList.Count > 0)
            {
                foreach (IWebElement elem in allReqFieldsID)
                {
                    
                    if (!elem.GetAttribute("class").ToString().Contains("ng-valid"))
                    {
                        if (elem.GetCssValue("border-color").Equals("rgb(0, 134, 113)"))//Green Color
                        {
                            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

                            js.ExecuteScript(
                                "window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });");

                            TestContext.Out.WriteLine(elem.GetAttribute("id") + ": Required field with expected green border color");


                        }
                        else if (elem.GetCssValue("border-color").Equals("rgb(206, 212, 218)"))//Non required fields with no border color
                        {

                            // if((elem.GetAttribute("ng-reflect-model") is null or "") )
                            //Console.WriteLine("first if");

                            if ((elem.GetAttribute("class").Contains("ng-invalid")))

                                Assert.Fail(elem.GetAttribute("ng-reflect-model") + ":Required field with no border color");
                            // Assert.Warn(elem.GetAttribute("id") + ":Required field with no border color and data populated");
                            //if ((elem.GetAttribute("ng-reflect-model") is null or "") || (elem.GetAttribute("class").Contains("form-select ng-untouched ng-pristine ng-invalid")))

                            //

                            // bgcolormatch = false;
                        }
                        else
                        {
                            Assert.Warn("Fail: Required field does not have the expected green border color or non-required field does not have the expected no border color");
                            bgcolormatch = false;
                        }

                    }


                }
                return bgcolormatch;
            }
            else
            {

                return false;
            }

        }

        public string GetValidationErrorMessage()
        {
            return CommonHelpers.GetValidationErrorText(Driver);
        }

        public bool IsValidationErrorDisplayed()
        {
            return CommonHelpers.ValidationerrorExists(Driver);
        }
    }
}