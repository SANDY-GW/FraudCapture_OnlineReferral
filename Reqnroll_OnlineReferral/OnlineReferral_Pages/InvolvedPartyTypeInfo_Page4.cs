using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FC_OnlineReferral.CommonData;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class InvolvedPartyTypeInfo_Page4 : BaseSettings
    {
        public InvolvedPartyTypeInfo_Page4(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By witness_Or_ExternalReferringPartydrp = By.XPath("//select[@id='isExternalReferal']");
        private readonly By orgNameField = By.XPath("//input[@id='pOrgName']");
        private readonly By namePrefixField = By.XPath("//input[@id='pNamePrefix']");
        private readonly By firstNameField = By.XPath("//input[@id='pFirstName']");
        private readonly By middleNameField = By.XPath("//input[@id='pMiddleName']");
        private readonly By lastNameField = By.XPath("//input[@id='pLastName']");
        private readonly By nameSuffixField = By.XPath("//input[@id='pNameSuffix']");
        private readonly By Designation_or_TitleField = By.XPath("//input[@id='pDesignation']");
        private readonly By dobField = By.XPath("//input[@placeholder='MM/DD/YYYY']");
        private readonly By SSNField = By.XPath("//input[@id='pSsn']");
        private readonly By LicenseNofield = By.XPath("//input[@id='pLicenseNo']");
        private readonly By IDTestfield = By.XPath("//input[@id='pProviderID']");
        private readonly By NPIfield = By.XPath("//input[@id='pNPInumber']");
        private readonly By TINfield = By.XPath("//input[@id='pTIN']");
        private readonly By MedicaidIDfield = By.XPath("//input[@id='pMedicaidId']");
        private readonly By MedicareIDfield = By.XPath("//input[@id='pMedicareId']");
        private readonly By otherIDField = By.XPath("//input[@id='pOtherId']");
        private readonly By ProviderTypeField = By.XPath("//input[@id='pType']");
        private readonly By ProviderSpecialtyField = By.XPath("//input[@id='pSpecialty']");
        private readonly By TaxonomyField = By.XPath("//input[@id='pTaxonomy']");
        private readonly By otherField = By.XPath("//input[@id='pOther'] ");
        private readonly By PhoneNumberField = By.XPath("//input[@id='pPhone']");
        private readonly By faxField = By.XPath("//input[@id='pFax']");
        private readonly By emailField = By.XPath("//input[@id='pEmail']");
        private readonly By address1Field = By.XPath("//input[@id='pStreetAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='pStreetAddress2']");
        private readonly By cityField = By.XPath("//input[@id='pCity']");
        private readonly By stateDropdown = By.XPath("//select[@id='pState']");
        private readonly By countyDropdown = By.XPath("//select[@id='pCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='pZip']");
        private readonly By countryField = By.XPath("//input[@id='pCountry']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[text()='Go To Previous Section']");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[text()='Proceed to Next Section']");

        private readonly DateTime dateTime = DateTime.Now;





        #endregion

        //public void SelectWitness_Or_ExternalReferringParty(string witness_Or_ExternalReferringParty)
        //{
        //    CommonHelpers.WaitForElementVisiblity(Driver, witness_Or_ExternalReferringPartydrp, 10);
        //    CommonHelpers.selectOptionByValue(Driver.FindElement(witness_Or_ExternalReferringPartydrp), witness_Or_ExternalReferringParty);
        //}
        public void EnterOrgName(string orgName)
        {
          
            var latestOrgname = dateTime.ToString("HH:mm ") + dateTime.ToString("MM dd yyyy") + " " + orgName;
            dateTime.ToString("yyyyMMddHHmmssffff");
            CommonHelpers.WaitForElementVisiblity(Driver, orgNameField, 10);

            Driver.FindElement(orgNameField).SendKeys(latestOrgname);

        }
        public void EnterNamePrefix(string namePrefix)
        {
            Driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }

        public void EnterFirstName(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, firstNameField, 10);
            Driver.FindElement(firstNameField).SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, lastNameField, 10);
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
        public void EnterPhoneNumber(string primaryPhoneNumber)
        {
            Driver.FindElement(PhoneNumberField).SendKeys(primaryPhoneNumber);
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

        public void ClickGoToPreviousSection()
        {
            Driver.FindElement(Go_To_Previous_SectionButton).Click();
        }
        public void ClickProceedToNextSection()
        {
            Driver.FindElement(proceed_To_Next_SectionButton).Click();

        }
        public void EnterLicenseNo(string licenseNo)
        {
            Driver.FindElement(LicenseNofield).SendKeys(licenseNo);
        }
        public void EnterIDTest(string idTest)
        {
            Driver.FindElement(IDTestfield).SendKeys(idTest);
        }
        public void EnterNPI(string npi)
        {
            Driver.FindElement(NPIfield).SendKeys(npi);
        }
        public void EnterTIN(string tin)
        {
            Driver.FindElement(TINfield).SendKeys(tin);
        }

        public void EnterMedicaidID(string medicaidID)
        {
            Driver.FindElement(MedicaidIDfield).SendKeys(medicaidID);
        }
        public void EnterMedicareID(string medicareID)
        {
            Driver.FindElement(MedicareIDfield).SendKeys(medicareID);
        }

        public void EnterProviderType(string providerType)
        {
            Driver.FindElement(ProviderTypeField).SendKeys(providerType);
        }

        public void EnterProviderSpecialty(string providerSpecialty)
        {
            Driver.FindElement(ProviderSpecialtyField).SendKeys(providerSpecialty);
        }
        public void EnterTaxonomy(string taxonomy)
        {
            Driver.FindElement(TaxonomyField).SendKeys(taxonomy);
        }

    }

}


