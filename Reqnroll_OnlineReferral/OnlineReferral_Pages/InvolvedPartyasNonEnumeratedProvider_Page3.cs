using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class InvolvedPartyasNonEnumeratedProvider_Page3 : BaseSettings
    {
        public InvolvedPartyasNonEnumeratedProvider_Page3(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By organizationField = By.XPath("//input[@id='nepOrgName']");
        private readonly By namePrefixField = By.XPath("//input[@id='nepNamePrefix']");
        private readonly By firstNameField = By.XPath("//input[@id='nepFirstName']");
        private readonly By middleNameField = By.XPath("//input[@id='nepMiddleName']");
        private readonly By lastNameField = By.XPath("//input[@id='nepLastName']");
        private readonly By nameSuffixField = By.XPath("//input[@id='nepNameSuffix']");
        private readonly By DesignationField = By.XPath("//input[@id='nepDesignation']");
        private readonly By DOBField = By.XPath("//input[@name='nepDateOfBirth']");
        private readonly By SSNField = By.XPath("//input[@id='nepSsn']");
        private readonly By LicenseNumberField = By.XPath("//input[@id='nepLicenseNo']");
        private readonly By otherIDField = By.XPath("//input[@id='nepOtherId']");
        private readonly By otherField = By.XPath("//input[@id='nepOther']");
        private readonly By address1Field = By.XPath("//input[@id='nepStreetAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='nepStreetAddress2']");
        private readonly By cityField = By.XPath("//input[@id='nepCity']");
        private readonly By stateDrpdn = By.XPath("//select[@id='nepState']");
        private readonly By countyDrpdn = By.XPath("//select[@id='nepCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='nepZip']");
        private readonly By countryField = By.XPath("//input[@id='nepCountry']");
        private readonly By primaryphoneNumberField = By.XPath("//input[@id='nepPrimaryPhone']");
        private readonly By secondaryphoneNumberField = By.XPath("//input[@id='nepSecondaryPhone']");
        private readonly By faxField = By.XPath("//input[@id='nepFax']");
        private readonly By emailField = By.XPath("//input[@id='nepEmail']");
        private readonly By HowDidThisExternalReferringPartyreportThisTextarea = By.XPath("//textarea[@id='externalReferalReport']");
        private readonly By AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea = By.XPath("//textarea[@id='externalReferalAddInfo']");

        #endregion

        public void EnterOrganization(string Organization)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, organizationField, 10);
            Driver.FindElement(organizationField).Clear();
            Driver.FindElement(organizationField).SendKeys(Organization);
        }
        public void EnterNamePrefix(string NamePrefix)
        {
            Driver.FindElement(namePrefixField).Clear();
            Driver.FindElement(namePrefixField).SendKeys(NamePrefix);
        }
        public void EnterFirstName(string FirstName)
        {
            Driver.FindElement(firstNameField).Clear();
            Driver.FindElement(firstNameField).SendKeys(FirstName);
        }
        public void EnterMiddleName(string MiddleName)
        {
            Driver.FindElement(middleNameField).Clear();
            Driver.FindElement(middleNameField).SendKeys(MiddleName);
        }
        public void EnterLastName(string LastName)
        {
            Driver.FindElement(lastNameField).Clear();
            Driver.FindElement(lastNameField).SendKeys(LastName);
        }
        public void EnterNameSuffix(string NameSuffix)
        {
            Driver.FindElement(nameSuffixField).Clear();
            Driver.FindElement(nameSuffixField).SendKeys(NameSuffix);
        }
        public void EnterDesignation(string Designation)
        {
            Driver.FindElement(DesignationField).Clear();
            Driver.FindElement(DesignationField).SendKeys(Designation);
        }
        public void EnterDOB(string DOB)
        {
            Driver.FindElement(DOBField).Clear();
            Driver.FindElement(DOBField).SendKeys(DOB);
        }

        //How did this external referring party report this? 
        public void FillHowDidThisExternalReferringPartyreportThisTextarea(string report)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 1000);
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Clear();
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }
        //Any additional information regarding the witness or external referring party
        public void FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string additionalInfo)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 1000);
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Clear();
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }
        public void EnterSSN(string SSN)
        {
            Driver.FindElement(SSNField).Clear();
            Driver.FindElement(SSNField).SendKeys(SSN);
        }
        public void EnterLicenseNumber(string LicenseNumber)
        {
            Driver.FindElement(LicenseNumberField).Clear();
            Driver.FindElement(LicenseNumberField).SendKeys(LicenseNumber);

        }


        public void EnterOtherID(string OtherID)
        {
            Driver.FindElement(otherIDField).Clear();
            Driver.FindElement(otherIDField).SendKeys(OtherID);
        }

        public void EnterOther(string Other)
        {
            Driver.FindElement(otherField).Clear();
            Driver.FindElement(otherField).SendKeys(Other);
        }

        public void EnterPrimaryPhoneNumber(string PrimaryPhoneNumber)
        {
            Driver.FindElement(primaryphoneNumberField).Clear();
            Driver.FindElement(primaryphoneNumberField).SendKeys(PrimaryPhoneNumber);
        }

        public void EnterSecondaryPhoneNumber(string SecondaryPhoneNumber)
        {
            Driver.FindElement(secondaryphoneNumberField).Clear();
            Driver.FindElement(secondaryphoneNumberField).SendKeys(SecondaryPhoneNumber);
        }

        public void EnterFax(string Fax)
        {
            Driver.FindElement(faxField).Clear();
            Driver.FindElement(faxField).SendKeys(Fax);
        }
        public void EnterEmail(string Email)
        {
            Driver.FindElement(emailField).Clear();
            Driver.FindElement(emailField).SendKeys(Email);
        }
        public void EnterAddress1(string Address1)
        {
            Driver.FindElement(address1Field).Clear();
            Driver.FindElement(address1Field).SendKeys(Address1);
        }
        public void EnterAddress2(string Address2)
        {
            Driver.FindElement(address2Field).Clear();
            Driver.FindElement(address2Field).SendKeys(Address2);
        }
        public void EnterCity(string City)
        {
            Driver.FindElement(cityField).Clear();
            Driver.FindElement(cityField).SendKeys(City);
        }
        public void SelectState(string State)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(stateDrpdn), State);
        }
        public void SelectCounty(string County)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(countyDrpdn), County);
        }
        public void EnterZipCode(string ZipCode)
        {
            Driver.FindElement(zipCodeField).Clear();
            Driver.FindElement(zipCodeField).SendKeys(ZipCode);
        }
        public void EnterCountry(string Country)
        {
            Driver.FindElement(countryField).Clear();
            Driver.FindElement(countryField).SendKeys(Country);
        }
    }
}

