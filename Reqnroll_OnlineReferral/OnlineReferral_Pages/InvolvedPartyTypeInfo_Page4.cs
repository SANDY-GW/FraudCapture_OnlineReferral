using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class InvolvedPartyTypeInfo_Page4 : BaseSettings
    {
        public InvolvedPartyTypeInfo_Page4(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By witness_Or_ExternalReferringPartydrp = By.XPath("//select[@id='isExternalReferal']");
        private readonly By orgNameField = By.XPath("//input[@id='nepOrgName']");
        private readonly By namePrefixField = By.XPath("//input[@id='nepNamePrefix']");
        private readonly By firstNameField = By.XPath("//input[@id='nepFirstName']");
        private readonly By middleNameField = By.XPath("//input[@id='nepMiddleName']");
        private readonly By lastNameField = By.XPath("//input[@id='nepLastName']");
        private readonly By nameSuffixField = By.XPath("//input[@id='nepNameSuffix']");
        private readonly By Designation_or_TitleField = By.XPath("//input[@id='nepDesignation']");
        private readonly By dobField = By.XPath("//input[@placeholder='MM/DD/YYYY']");
        private readonly By SSNField = By.XPath("//input[@id='nepSsn']");
        private readonly By otherIDField = By.XPath("//input[@id='nepOtherId']");
        private readonly By otherField = By.XPath("//input[@id='nepOther']");
        private readonly By primaryPhoneNumberField = By.XPath("//input[@id='nepPrimaryPhone']");
        private readonly By secondaryPhoneNumberField = By.XPath("//input[@id='nepSecondaryPhone']");
        private readonly By faxField = By.XPath("//input[@id='nepFax']");
        private readonly By emailField = By.XPath("//input[@id='nepEmail']");
        private readonly By address1Field = By.XPath("//input[@id='nepStreetAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='nepStreetAddress2']");
        private readonly By cityField = By.XPath("//input[@id='nepCity']");
        private readonly By stateDropdown = By.XPath("//select[@id='nepState']");
        private readonly By countyDropdown = By.XPath("//select[@id='nepCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='nepZip']");
        private readonly By countryField = By.XPath("//input[@id='nepCountry']");
       






        #endregion

        public void SelectWitness_Or_ExternalReferringParty(string witness_Or_ExternalReferringParty)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, witness_Or_ExternalReferringPartydrp, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(witness_Or_ExternalReferringPartydrp), witness_Or_ExternalReferringParty);
        }
        public void EnterOrgName(string orgName)
        {
            Driver.FindElement(orgNameField).SendKeys(orgName);
        }
        public void EnterNamePrefix(string namePrefix)
        {
            Driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }

        public void EnterFirstName(string firstName)
        {
            Driver.FindElement(firstNameField).SendKeys(firstName);


        }
        public void EnterLastName(string lastName)
        {
            Driver.FindElement(lastNameField).SendKeys(lastName);
        }
        public void EnterMiddleName(string middleName)
        {
            Driver.FindElement(middleNameField).SendKeys(middleName);
        }
        public void EnterNameSuffix(string nameSuffix)
        {
            Driver.FindElement(nameSuffixField).SendKeys(nameSuffix);
        }
        public void EnterDesignation_or_Title(string designation_or_Title)
        {
            Driver.FindElement(Designation_or_TitleField).SendKeys(designation_or_Title);
        }
        public void EnterDOB(string dob)
        {
            Driver.FindElement(dobField).SendKeys(dob);
        }
        public void EnterSSN(string ssn)
        {
            Driver.FindElement(SSNField).SendKeys(ssn);
        }
        public void EnterOtherID(string otherID)
        {
            Driver.FindElement(otherIDField).SendKeys(otherID);
        }

        public void EnterOther(string other)
        {
            Driver.FindElement(otherField).SendKeys(other);
        }
        public void EnterPrimaryPhoneNumber(string primaryPhoneNumber)
        {
            Driver.FindElement(primaryPhoneNumberField).SendKeys(primaryPhoneNumber);
        }
        public void EnterSecondaryPhoneNumber(string secondaryPhoneNumber)
        {
            Driver.FindElement(secondaryPhoneNumberField).SendKeys(secondaryPhoneNumber);
        }
        public void EnterFax(string fax)
        {
            Driver.FindElement(faxField).SendKeys(fax);
        }
        public void EnterEmail(string email)
        {
            Driver.FindElement(emailField).SendKeys(email);
        }
        public void EnterAddress1(string address1)
        {
            Driver.FindElement(address1Field).SendKeys(address1);
        }
        public void EnterAddress2(string address2)
        {
            Driver.FindElement(address2Field).SendKeys(address2);
        }
        public void EnterCity(string city)
        {
            Driver.FindElement(cityField).SendKeys(city);
        }
        public void SelectState(string state)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(stateDropdown), state);
        }
        public void SelectCounty(string county)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(countyDropdown), county);
        }
        public void EnterZipCode(string zipCode)
        {
            Driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        public void EnterCountry(string country)
        {
            Driver.FindElement(countryField).SendKeys(country);
        }
       
    }
}


