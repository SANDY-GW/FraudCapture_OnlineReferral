using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class InvolvedParties_Page3 : BaseSettings
    {


        public InvolvedParties_Page3(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By isExtRefDropdn = By.XPath("//select[@id='isExternalReferal']");
        private readonly By organizationField = By.XPath("//input[@id='pOrgName']");
        private readonly By namePrefixField = By.XPath("//input[@id='pNamePrefix']");
        private readonly By firstNameField = By.XPath("//input[@id='pFirstName']");
        private readonly By middleNameField = By.XPath("//input[@id='pMiddleName']");
        private readonly By lastNameField = By.XPath("//input[@id='pLastName']");
        private readonly By nameSuffixField = By.XPath("//input[@id='pNameSuffix']");
        private readonly By DesignationField = By.XPath("//input[@id='pDesignation']");
        private readonly By DOBField = By.XPath("//input[@name='pDateOfBirth']");
        private readonly By SSNField = By.XPath("//input[@id='pSsn']");
        private readonly By LicenseNumberField = By.XPath("//input[@id='pLicenseNo']");
        private readonly By HowDidThisExternalReferringPartyreportThisTextarea = By.XPath("//textarea[@id='externalReferalReport']");
        private readonly By AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea = By.XPath("//textarea[@id='externalReferalAddInfo']");
        private readonly By IDTestField = By.XPath("//input[@id='pProviderID']");
        private readonly By NPIField = By.XPath("//input[@id='pNPInumber']");
        private readonly By TIN_EINField = By.XPath("//input[@id='pTIN']");
        private readonly By medicaidIDField = By.XPath("//input[@id='pMedicaidId']");
        private readonly By medicareIDField = By.XPath("//input[@id='pMedicareId']");
        private readonly By OtherIDField = By.XPath("//input[@id='pOtherId']");
        private readonly By ProviderTypeField = By.XPath("//input[@id='pType']");
        private readonly By ProviderSpecialtyField = By.XPath("//input[@id='pSpecialty']");
        private readonly By TaxonomyField = By.XPath("//input[@id='pTaxonomy']");
        private readonly By otherField = By.XPath("//input[@id='pOther']");
        private readonly By address1Field = By.XPath("//input[@id='pStreetAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='pStreetAddress2']");
        private readonly By cityField = By.XPath("//input[@id='pCity']");
        private readonly By stateDrpdn = By.XPath("//select[@id='pState']");
        private readonly By countyDrpdn = By.XPath("//select[@id='pCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='pZip']");
        private readonly By countryField = By.XPath("//input[@id='pCountry']");
        private readonly By phoneNumberField = By.XPath("//input[@id='pPhone']");
        private readonly By faxField = By.XPath("//input[@id='pFax']");
        private readonly By emailField = By.XPath("//input[@id='pEmail']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(.,'Go to Previous Section')]");
        private readonly By continue_with_Involved_Party_Selection_Button = By.XPath("//button[contains(.,'Continue with Involved Party Selection ')]");

        #endregion
        //referring party dropdown
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, isExtRefDropdn, 1000);
            var dropdown = new SelectElement(Driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }



        //Organization field
        public void FillOrganizationField(string organization)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, organizationField, 1000);
            CommonHelpers.enterTextValue(Driver.FindElement(organizationField), organization);
            //Driver.FindElement(organizationField).Clear();
            //Driver.FindElement(organizationField).SendKeys(organization);
        }
        //Name prefix field
        public void FillNamePrefixField(string namePrefix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, namePrefixField, 1000);
            Driver.FindElement(namePrefixField).Clear();
            Driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }
        //First name field
        public void FillFirstNameField(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, firstNameField, 1000);
            Driver.FindElement(firstNameField).Clear();
            Driver.FindElement(firstNameField).SendKeys(firstName);
        }
        //Middle name field
        public void FillMiddleNameField(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, middleNameField, 1000);
            Driver.FindElement(middleNameField).Clear();
            Driver.FindElement(middleNameField).SendKeys(middleName);
        }
        //Last name field
        public void FillLastNameField(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, lastNameField, 1000);
            Driver.FindElement(lastNameField).Clear();
            Driver.FindElement(lastNameField).SendKeys(lastName);
        }
        //Name suffix field
        public void FillNameSuffixField(string nameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, nameSuffixField, 1000);
            Driver.FindElement(nameSuffixField).Clear();
            Driver.FindElement(nameSuffixField).SendKeys(nameSuffix);
        }
        //Designation field

        public void FillDesignationField(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DesignationField, 1000);
            Driver.FindElement(DesignationField).Clear();
            Driver.FindElement(DesignationField).SendKeys(designation);
        }
        //DOB field
        public void FillDOBField(string dob)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DOBField, 1000);
            Driver.FindElement(DOBField).Clear();
            Driver.FindElement(DOBField).SendKeys(dob);
        }
        //SSN field
        public void FillSSNField(string ssn)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SSNField, 1000);
            Driver.FindElement(SSNField).Clear();
            Driver.FindElement(SSNField).SendKeys(ssn);
        }
        //License number field
        public void FillLicenseNumberField(string licenseNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LicenseNumberField, 1000);
            Driver.FindElement(LicenseNumberField).Clear();
            Driver.FindElement(LicenseNumberField).SendKeys(licenseNumber);
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
        //ID/Test field
        public void FillIDTestField(string idTest)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, IDTestField, 1000);
            Driver.FindElement(IDTestField).Clear();
            Driver.FindElement(IDTestField).SendKeys(idTest);
        }
        //NPI field
        public void FillNPIField(string npi)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, NPIField, 1000);
            Driver.FindElement(NPIField).Clear();
            Driver.FindElement(NPIField).SendKeys(npi);
        }
        //TIN/EIN field
        public void FillTIN_EINField(string tinEin)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, TIN_EINField, 1000);
            Driver.FindElement(TIN_EINField).Clear();
            Driver.FindElement(TIN_EINField).SendKeys(tinEin);
        }
        //Medicaid ID field
        public void FillMedicaidIDField(string medicaidId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, medicaidIDField, 1000);
            Driver.FindElement(medicaidIDField).Clear();
            Driver.FindElement(medicaidIDField).SendKeys(medicaidId);
        }
        //Medicare ID field
        public void FillMedicareIDField(string medicareId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, medicareIDField, 1000);
            Driver.FindElement(medicareIDField).Clear();
            Driver.FindElement(medicareIDField).SendKeys(medicareId);
        }
        //Other ID field
        public void FillOtherIDField(string otherId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, OtherIDField, 1000);
            Driver.FindElement(OtherIDField).Clear();
            Driver.FindElement(OtherIDField).SendKeys(otherId);
        }
        //Provider type field
        public void FillProviderTypeField(string providerType)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ProviderTypeField, 1000);
            Driver.FindElement(ProviderTypeField).Clear();
            Driver.FindElement(ProviderTypeField).SendKeys(providerType);
        }
        //Provider specialty field
        public void FillProviderSpecialtyField(string providerSpecialty)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ProviderSpecialtyField, 1000);
            Driver.FindElement(ProviderSpecialtyField).Clear();
            Driver.FindElement(ProviderSpecialtyField).SendKeys(providerSpecialty);
        }
        //Taxonomy field
        public void FillTaxonomyField(string taxonomy)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, TaxonomyField, 1000);
            Driver.FindElement(TaxonomyField).Clear();
            Driver.FindElement(TaxonomyField).SendKeys(taxonomy);
        }
        //Other field
        public void FillOtherField(string other)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, otherField, 1000);
            Driver.FindElement(otherField).Clear();
            Driver.FindElement(otherField).SendKeys(other);
        }
        //Address1 field
        public void FillAddress1Field(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address1Field, 1000);
            Driver.FindElement(address1Field).Clear();
            Driver.FindElement(address1Field).SendKeys(address1);
        }
        //Address2 field
        public void FillAddress2Field(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address2Field, 1000);
            Driver.FindElement(address2Field).Clear();
            Driver.FindElement(address2Field).SendKeys(address2);
        }
        //City field
        public void FillCityField(string city)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, cityField, 5000);
            Driver.FindElement(cityField).Clear();
            Driver.FindElement(cityField).SendKeys(city);

        }
        //State dropdown
        public void SelectStateFromDropdown(string state)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, stateDrpdn, 50000);

            var dropdown = new SelectElement(Driver.FindElement(stateDrpdn));
            dropdown.SelectByText(state);
            Thread.Sleep(5000);
            CommonHelpers.WaitForPageToLoad(Driver, 10000);
        }
        //County dropdown
        public void SelectCountyFromDropdown(string county)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, countyDrpdn, 50000);
            var dropdown = new SelectElement(Driver.FindElement(countyDrpdn));
            dropdown.SelectByText(county);
        }
        //Zip code field
        public void FillZipCodeField(string zipCode)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 500);");

            CommonHelpers.WaitForElementVisiblity(Driver, zipCodeField, 1000);
            Driver.FindElement(zipCodeField).Clear();
            Driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        //Country field
        public void FillCountryField(string country)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, countryField, 1000);
            Driver.FindElement(countryField).Clear();
            Driver.FindElement(countryField).SendKeys(country);
        }
        //Phone number field
        public void FillPhoneNumberField(string phoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, phoneNumberField, 1000);
            Driver.FindElement(phoneNumberField).Clear();
            Driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }
        //Fax field
        public void FillFaxField(string fax)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, faxField, 1000);
            Driver.FindElement(faxField).Clear();
            Driver.FindElement(faxField).SendKeys(fax);
        }
        //Email field
        public void FillEmailField(string email)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, emailField, 1000);
            Driver.FindElement(emailField).SendKeys(email);
            CommonHelpers.WaitForPageToLoad(Driver, 10000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            

        }
        //Click on  continue_with_Involved_Party_Selection_Button

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



    }
}
