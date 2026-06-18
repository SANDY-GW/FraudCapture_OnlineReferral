using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class additionalInvolvedParty_page4 : BaseSettings
    {
        public additionalInvolvedParty_page4(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By isThereAnotherInvolvedPartyDropdn = By.XPath("//select[@id='isAnotherInvolvedParty']");
        private readonly By pleaseSelectTheAdditionalInvolvedPartyTypeDropdn = By.XPath("//select[@id='additionalInvolvedType']");
        private readonly By isThisInvolvedPartyAnExternalReferringPartyDropdn = By.XPath("//select[@id='isAnotherExternalInvolvedParty']");

        private readonly By OrganizationField = By.XPath("//input[@id='neiAssociatedOrg']");
        private readonly By FirstNameField = By.XPath("//input[@id='neiFirstName']");
        private readonly By MiddleNameField = By.XPath("//input[@id='neiMiddleName']");
        private readonly By LastNameField = By.XPath("//input[@id='neiLastName']");
        private readonly By NamePrefixField = By.XPath("//input[@id='neiNamePrefix']");
        private readonly By StreetAddress1Field = By.XPath("//input[@id='neiStreetAddress1']");
        private readonly By StreetAddress2Field = By.XPath("//input[@id='neiStreetAddress2']");
        private readonly By CityField = By.XPath("//input[@id='neiCity']");
        private readonly By StateField = By.XPath("//input[@id='neiState']");
        private readonly By CountyField = By.XPath("//input[@id='neiCounty']");
        private readonly By NameSuffixField = By.XPath("//input[@id='neiNameSuffix']");
        private readonly By ZipField = By.XPath("//input[@id='neiZip']");
        private readonly By DesignationField1 = By.XPath("//input[@id='neiDesignation']");
        private readonly By CountryField = By.XPath("//input[@id='neiCountry']");
        private readonly By PrimaryPhoneField = By.XPath("//input[@id='neiPrimaryPhone']");
        private readonly By SecondaryPhoneField = By.XPath("//input[@id='neiSecondaryPhone']");
        private readonly By SsnField = By.XPath("//input[@id='neiSsn']");
        private readonly By OtherIdField = By.XPath("//input[@id='neiOtherId']");
        private readonly By EmailField = By.XPath("//input[@id='neiEmail']");
        private readonly By OtherField = By.XPath("//input[@id='neiOther']");
        
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
        private readonly By continue_with_Involved_Party_Selection_Button = By.XPath("//button[contains(.,'Finish Involved Party Selection and Proceed to Next Section ')]");

        private readonly By finishInvolvedPartySelectionAndProceedToNectSectionButton = By.XPath("//button[contains(.,'Finish Involved Party Selection and Proceed to Next Section ')]");

        #endregion

        public void SelectisThereAnotherInvolvedParty(string isAnotherInvolvedPartyAvailable)
        {
            
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 300);
            CommonHelpers.ScrollToElement(Driver, isThereAnotherInvolvedPartyDropdn);
            Driver.FindElement(isThereAnotherInvolvedPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable);
            
        }
        public void FillisThereAnotherInvolvedParty(string isAnotherInvolvedPartyAvailable1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, isThereAnotherInvolvedPartyDropdn);
            Driver.FindElement(isThereAnotherInvolvedPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable1);
            
        }

        public void SelectPleaseSelectTheAdditionalInvolvedPartyType(string additionalInvolvedPartyType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, pleaseSelectTheAdditionalInvolvedPartyTypeDropdn);
            Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn), additionalInvolvedPartyType);
        }
        public void SelectIsThisInvolvedPartyAnExternalReferringParty(string isAnotherExternalInvolvedPartyAvailable)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            //CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 100);
            CommonHelpers.ScrollToElement(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn);
            Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn), isAnotherExternalInvolvedPartyAvailable);

        }

        public void ClickContinueWithInvolvedPartySelectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 100);
            CommonHelpers.ScrollToElement(Driver, continue_with_Involved_Party_Selection_Button);
            Driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            Thread.Sleep(5000);
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);

        }
        public void FillOrganizationField(string Organization1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, OrganizationField);
            Driver.FindElement(OrganizationField).Click();
            Driver.FindElement(OrganizationField).SendKeys(Organization1);
        }
        public void FillFirstNameField(string FirstName1)
        {
            Driver.FindElement(FirstNameField).Click();
            Driver.FindElement(FirstNameField).SendKeys(FirstName1);
        }
        public void FillLastNameField(string LastName1)
        {
            Driver.FindElement(LastNameField).Click();
            Driver.FindElement(LastNameField).SendKeys(LastName1);  
        }
        public void FillMiddleNameField(string MiddleName1)
        {
            Driver.FindElement(MiddleNameField).Click();
            Driver.FindElement(MiddleNameField).SendKeys(MiddleName1);
        }
        public void FillNamePrefixField(string NamePrefix)
        {
            Driver.FindElement(NamePrefixField).Click();
            Driver.FindElement(NamePrefixField).SendKeys(NamePrefix);
        }
        public void FillStreetAddress1Field(string StreetAddress3)
        {
            Driver.FindElement(StreetAddress1Field).Click();
            Driver.FindElement(StreetAddress1Field).SendKeys(StreetAddress3);
        }
        public void FillStreetAddress2Field(string StreetAddress4)
        {
            Driver.FindElement(StreetAddress2Field).Click();
            Driver.FindElement(StreetAddress2Field).SendKeys(StreetAddress4);
        }
        public void FillCityField(string City)
        {
            Driver.FindElement(CityField).Click();
            Driver.FindElement(CityField).SendKeys(City);
        }
        public void FillStateField(string State)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, StateField, 100);
            Driver.FindElement(StateField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(StateField), State);
        }
        public void SelectCountyField(string County)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, CountyField, 100);
            Driver.FindElement(CountyField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(CountyField), County);
                
        }
        public void FillNameSuffixField(string NameSuffix)
        {
            Driver.FindElement(NameSuffixField).Click();
            Driver.FindElement(NameSuffixField).SendKeys(NameSuffix);
        }
        public void FillZipField(string Zip)
        {
            Driver.FindElement(ZipField).Click();
            Driver.FindElement(ZipField).SendKeys(Zip);
        }
        public void FillDesignationField1(string Designation1)
        {
            CommonHelpers.ScrollToElement(Driver, DesignationField1);
            Driver.FindElement(DesignationField1).Click();
            Driver.FindElement(DesignationField1).SendKeys(Designation1);
        }
        public void FillCountryField(string Country)
        {
            Driver.FindElement(CountryField).Click();
            Driver.FindElement(CountryField).SendKeys(Country);
        }
        public void FillPrimaryPhoneField(string PrimaryPhone)
        {
            Driver.FindElement(PrimaryPhoneField).Click();
            Driver.FindElement(PrimaryPhoneField).SendKeys(PrimaryPhone);
        }
        public void FillSecondaryPhoneField(string SecondaryPhone)
        {
            Driver.FindElement(SecondaryPhoneField).Click();
            Driver.FindElement(SecondaryPhoneField).SendKeys(SecondaryPhone);
        }
        public void FillSsnField(string Ssn)
        {
            Driver.FindElement(SsnField).Click();
            Driver.FindElement(SsnField).SendKeys(Ssn);
        }
        public void FillOtherIdField(string OtherId)
        {
            CommonHelpers.ScrollToElement(Driver, OtherIdField);
            Driver.FindElement(OtherIdField).Click();
            Driver.FindElement(OtherIdField).SendKeys(OtherId);
        }
        public void FillEmailField(string Email1)
        {
            CommonHelpers.ScrollToElement(Driver, EmailField);
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(Email1);
        }
        public void FillOtherField(string Other)
        {
            Driver.FindElement(OtherField).Click();
            Driver.FindElement(OtherField).SendKeys(Other);
        }













        
            

        public void ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            CommonHelpers.WaitForElementVisiblity(Driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            Driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();
            
        }
    }
}


