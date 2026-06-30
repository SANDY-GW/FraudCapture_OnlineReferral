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
        #endregion
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, isExtRefDropdn, 1000);
            var dropdown = new SelectElement(Driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }

        public void EnterOrganizationName(string organizationName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, organizationField, 1000);
            Driver.FindElement(organizationField).Clear();
            Driver.FindElement(organizationField).SendKeys(organizationName);
        }

        public void EnterTIN_OR_EIN(string tinOrEin)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, TIN_OR_EIN, 1000);
            Driver.FindElement(TIN_OR_EIN).Clear();
            Driver.FindElement(TIN_OR_EIN).SendKeys(tinOrEin);
        }

        public void EnterLicenseNumber(string licenseNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LicenseNumberfield, 1000);
            Driver.FindElement(LicenseNumberfield).Clear();
            Driver.FindElement(LicenseNumberfield).SendKeys(licenseNumber);
        }

        public void EnterOther(string other)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Otherfield, 1000);
            Driver.FindElement(Otherfield).Clear();
            Driver.FindElement(Otherfield).SendKeys(other);
        }

        public void EnterOtherID(string otherID)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, OtherIDfield, 1000);
            Driver.FindElement(OtherIDfield).Clear();
            Driver.FindElement(OtherIDfield).SendKeys(otherID);
        }

        public void EnterContactNamePrefix(string prefix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, contactnameprefixfield, 1000);
            Driver.FindElement(contactnameprefixfield).Clear();
            Driver.FindElement(contactnameprefixfield).SendKeys(prefix);
        }

        public void EnterContactFirstName(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, contactfirstnamefield, 1000);
            Driver.FindElement(contactfirstnamefield).Clear();
            Driver.FindElement(contactfirstnamefield).SendKeys(firstName);
        }

        public void EnterContactMiddleName(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, contactmiddlenamefield, 1000);
            Driver.FindElement(contactmiddlenamefield).Clear();
            Driver.FindElement(contactmiddlenamefield).SendKeys(middleName);
        }

        public void EnterContactLastName(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, contactlastnamefield, 1000);
            Driver.FindElement(contactlastnamefield).Clear();
            Driver.FindElement(contactlastnamefield).SendKeys(lastName);
        }

        public void EnterContactDesignation(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, contactDesignation, 1000);
            Driver.FindElement(contactDesignation).Clear();
            Driver.FindElement(contactDesignation).SendKeys(designation);
        }

        public void EnterHowDidThisExternalReferringPartyReportThis(string report)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 1000);
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Clear();
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }

        public void EnterAnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty(string additionalInfo)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 1000);
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Clear();
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }

        public void EnterAddress1(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address1Field, 1000);
            Driver.FindElement(address1Field).Clear();
            Driver.FindElement(address1Field).SendKeys(address1);
        }
        public void EnterAddress2(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address2Field, 1000);
            Driver.FindElement(address2Field).Clear();
            Driver.FindElement(address2Field).SendKeys(address2);
        }

        public void EnterCity(string city)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, cityField, 1000);
            Driver.FindElement(cityField).Clear();
            Driver.FindElement(cityField).SendKeys(city);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public void EnterState(string state)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, stateDrpdn, 1000);
            var dropdown = new SelectElement(Driver.FindElement(stateDrpdn));
            dropdown.SelectByText(state);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }
        public void EnterCounty(string county)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, countyDrpdn, 1000);
            var dropdown = new SelectElement(Driver.FindElement(countyDrpdn));
            dropdown.SelectByText(county);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);

        }
        public void EnterZipCode(string zipCode)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, zipCodeField, 1000);
            Driver.FindElement(zipCodeField).Clear();
            Driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        public void EnterCountry(string country)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, countryField, 1000);
            Driver.FindElement(countryField).Clear();
            Driver.FindElement(countryField).SendKeys(country);
        }
        public void EnterPhoneNumber(string phoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, phoneNumberField, 1000);
            Driver.FindElement(phoneNumberField).Clear();
            Driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }
        public void EnterFax(string fax)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, faxField, 1000);
            Driver.FindElement(faxField).Clear();
            Driver.FindElement(faxField).SendKeys(fax);
        }
        public void EnterEmail(string email)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, emailField, 1000);
            Driver.FindElement(emailField).Clear();
            Driver.FindElement(emailField).SendKeys(email);
        }


        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(Driver);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, -500);");

            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 5000);

            Driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 10000);

        }



        public string GetValidationDateErrorMessage()
        {
            return CommonHelpers.GetValidationDateErrorText(Driver);
        }

        public bool IsValidationDateErrorDisplayed()
        {
            return CommonHelpers.ValidationDateerrorExists(Driver);
        }

        public bool VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(Driver, Driver.FindElement(stateDrpdn));
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