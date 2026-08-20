using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class OnlineReferral_Referral_Page_Organization : BaseSettings
    {
        public OnlineReferral_Referral_Page_Organization(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By isExtRefDropdn = By.XPath("//select[@id='isExternalReferal']");
        private readonly By organizationField = By.XPath("//input[@id='neoOrgName']");
        private readonly By TIN_OR_EIN = By.XPath("//input[@id='neoTIN']");
        private readonly By LicenseNumberfield = By.XPath("//input[@id='neoLicenseNo']");
        private readonly By Otherfield = By.XPath("//input[@id='neoOther']");
        private readonly By OtherIDfield = By.XPath("//input[@id='neoOtherId']");

        private readonly By contactnameprefixfield = By.XPath("//input[@id='neoContactNamePrefix']");
        private readonly By contactfirstnamefield = By.XPath("//input[@id='neoContactFirstName']");
        private readonly By contactmiddlenamefield = By.XPath("//input[@id='neoContactMiddleName']");
        private readonly By contactlastnamefield = By.XPath("//input[@id='neoContactLastName']");
        private readonly By contactDesignation = By.XPath("//input[@id='neoContactDesignation']");
        private readonly By HowDidThisExternalReferringPartyreportThisTextarea = By.XPath("//textarea[@id='externalReferalReport']");
        private readonly By AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea = By.XPath("//textarea[@id='externalReferalAddInfo']");

        private readonly By address1Field = By.XPath("//input[@id='neoStreetAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='neoStreetAddress2']");
        private readonly By cityField = By.XPath("//input[@id='neoCity']");
        private readonly By stateDrpdn = By.XPath("//select[@id='neoState']");
        private readonly By countyDrpdn = By.XPath("//select[@id='neoCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='neoZip']");
        private readonly By countryField = By.XPath("//input[@id='neoCountry']");
        private readonly By phoneNumberField = By.XPath("//input[@id='neoPhone']");
        private readonly By faxField = By.XPath("//input[@id='neoFax']");
        private readonly By emailField = By.XPath("//input[@id='neoEmail']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(.,'Go to Previous Section')]");
        private readonly By continue_with_Involved_Party_Selection_Button = By.XPath("//button[contains(.,'Continue with Involved Party Selection ')]");

        
        private readonly By EditButton = By.XPath("//button[contains(.,'Edit')]");
        private readonly By SaveButton = By.XPath("//button[contains(.,'Save')]");
        #endregion
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(driver, isExtRefDropdn, 1000);
            var dropdown = new SelectElement(driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }

        public void EnterOrganizationName(string organizationName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, organizationField, 1000);
            driver.FindElement(organizationField).Clear();
            driver.FindElement(organizationField).SendKeys(organizationName);
        }

        public void EnterTIN_OR_EIN(string tinOrEin)
        {
            CommonHelpers.WaitForElementVisiblity(driver, TIN_OR_EIN, 1000);
            driver.FindElement(TIN_OR_EIN).Clear();
            driver.FindElement(TIN_OR_EIN).SendKeys(tinOrEin);
        }

        public void EnterLicenseNumber(string licenseNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LicenseNumberfield, 1000);
            driver.FindElement(LicenseNumberfield).Clear();
            driver.FindElement(LicenseNumberfield).SendKeys(licenseNumber);
        }

        public void EnterOther(string other)
        {
            CommonHelpers.WaitForElementVisiblity(driver, Otherfield, 1000);
            driver.FindElement(Otherfield).Clear();
            driver.FindElement(Otherfield).SendKeys(other);
        }

        public void EnterOtherID(string otherID)
        {
            CommonHelpers.WaitForElementVisiblity(driver, OtherIDfield, 1000);
            driver.FindElement(OtherIDfield).Clear();
            driver.FindElement(OtherIDfield).SendKeys(otherID);
        }

        public void EnterContactNamePrefix(string prefix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, contactnameprefixfield, 1000);
            driver.FindElement(contactnameprefixfield).Clear();
            driver.FindElement(contactnameprefixfield).SendKeys(prefix);
        }

        public void EnterContactFirstName(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, contactfirstnamefield, 1000);
            driver.FindElement(contactfirstnamefield).Clear();
            driver.FindElement(contactfirstnamefield).SendKeys(firstName);
        }

        public void EnterContactMiddleName(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, contactmiddlenamefield, 1000);
            driver.FindElement(contactmiddlenamefield).Clear();
            driver.FindElement(contactmiddlenamefield).SendKeys(middleName);
        }

        public void EnterContactLastName(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, contactlastnamefield, 1000);
            driver.FindElement(contactlastnamefield).Clear();
            driver.FindElement(contactlastnamefield).SendKeys(lastName);
        }

        public void EnterContactDesignation(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(driver, contactDesignation, 1000);
            driver.FindElement(contactDesignation).Clear();
            driver.FindElement(contactDesignation).SendKeys(designation);
        }

        public void EnterHowDidThisExternalReferringPartyReportThis(string report)
        {
            CommonHelpers.WaitForElementVisiblity(driver, HowDidThisExternalReferringPartyreportThisTextarea, 1000);
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Clear();
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }

        public void EnterAnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty(string additionalInfo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 1000);
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Clear();
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }

        public void EnterAddress1(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address1Field, 1000);
            driver.FindElement(address1Field).Clear();
            driver.FindElement(address1Field).SendKeys(address1);
        }
        public void EnterAddress2(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address2Field, 1000);
            driver.FindElement(address2Field).Clear();
            driver.FindElement(address2Field).SendKeys(address2);
        }

        public void EnterCity(string city)
        {
            CommonHelpers.WaitForElementVisiblity(driver, cityField, 1000);
            driver.FindElement(cityField).Clear();
            driver.FindElement(cityField).SendKeys(city);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void EnterState(string state)
        {
            CommonHelpers.WaitForElementVisiblity(driver, stateDrpdn, 1000);
            var dropdown = new SelectElement(driver.FindElement(stateDrpdn));
            dropdown.SelectByText(state);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
        public void EnterCounty(string county)
        {
            CommonHelpers.WaitForElementVisiblity(driver, countyDrpdn, 1000);
            var dropdown = new SelectElement(driver.FindElement(countyDrpdn));
            dropdown.SelectByText(county);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

        }
        public void EnterZipCode(string zipCode)
        {
            CommonHelpers.WaitForElementVisiblity(driver, zipCodeField, 1000);
            driver.FindElement(zipCodeField).Clear();
            driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        public void EnterCountry(string country)
        {
            CommonHelpers.WaitForElementVisiblity(driver, countryField, 1000);
            driver.FindElement(countryField).Clear();
            driver.FindElement(countryField).SendKeys(country);
        }
        public void EnterPhoneNumber(string phoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, phoneNumberField, 1000);
            driver.FindElement(phoneNumberField).Clear();
            driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }
        public void EnterFax(string fax)
        {
            CommonHelpers.WaitForElementVisiblity(driver, faxField, 1000);
            driver.FindElement(faxField).Clear();
            driver.FindElement(faxField).SendKeys(fax);
        }
        public void EnterEmail(string email)
        {
            CommonHelpers.WaitForElementVisiblity(driver, emailField, 1000);
            driver.FindElement(emailField).Clear();
            driver.FindElement(emailField).SendKeys(email);
        }


        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(driver);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, -500);");

            CommonHelpers.WaitForElementVisiblity(driver, continue_with_Involved_Party_Selection_Button, 5000);

            driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 10000);

        }



        public string GetValidationDateErrorMessage()
        {
            return CommonHelpers.GetValidationDateErrorText(driver);
        }

        public bool IsValidationDateErrorDisplayed()
        {
            return CommonHelpers.ValidationDateerrorExists(driver);
        }

        public bool VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(driver, driver.FindElement(stateDrpdn));
        }

        public string GetValidationErrorMessage()
        {
            return CommonHelpers.GetValidationErrorText(driver);
        }

        public bool IsValidationErrorDisplayed()
        {
            return CommonHelpers.ValidationerrorExists(driver);
        }



        public void ClickEditButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, EditButton, 100);
            driver.FindElement(EditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public void updateOrganizationField(string organizationName )
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 300);");
            CommonHelpers.WaitForElementVisiblity(driver, organizationField, 1000);


            driver.FindElement(organizationField).Clear();
            driver.FindElement(organizationField).SendKeys(organizationName);
            CommonHelpers.ScrollUp(driver); 

        }

        public void clickSaveButton()
        {
            CommonHelpers.WaitForPageToLoad(driver, 200);
            CommonHelpers.ScrollUp(driver);


            CommonHelpers.WaitForElementVisiblity(driver, SaveButton, 100);
            driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }
        public string getOrganizationName()
        {
            Console.WriteLine("organization Name: " + driver.FindElement(organizationField).GetAttribute("value"));
            return driver.FindElement(organizationField).GetAttribute("value");
        }

        public string GetOrganizationFieldValue()
        {
            return getOrganizationName();
        }

        public void clickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 100);
            driver.FindElement(Go_To_Previous_SectionButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, continue_with_Involved_Party_Selection_Button, 100);
        }

    }
}