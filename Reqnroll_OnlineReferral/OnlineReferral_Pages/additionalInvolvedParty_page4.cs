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
        private readonly By StateField = By.XPath("//select[@id='neiState']");
        private readonly By CountyField = By.XPath("//select[@id='neiCounty']");
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

        private readonly By dobField = By.XPath("//input[@name='neiDateOfBirth']");

        

        private readonly By organizationFieldprovider = By.XPath("//input[@id='pOrgName']");
        private readonly By namePrefixFieldprovider = By.XPath("//input[@id='pNamePrefix']");
        private readonly By firstNameFieldprovider = By.XPath("//input[@id='pFirstName']");
        private readonly By middleNameFieldprovider = By.XPath("//input[@id='pMiddleName']");
        private readonly By lastNameFieldprovider = By.XPath("//input[@id='pLastName']");
        private readonly By nameSuffixFieldprovider = By.XPath("//input[@id='pNameSuffix']");
        private readonly By DesignationFieldprovider = By.XPath("//input[@id='pDesignation']");
        private readonly By DOBFieldprovider = By.XPath("//input[@name='pDateOfBirth']");
        private readonly By SSNFieldprovider = By.XPath("//input[@id='pSsn']");
        private readonly By LicenseNumberFieldprovider = By.XPath("//input[@id='pLicenseNo']");


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
        private readonly By IDFieldprovider = By.XPath("//input[@id='pProviderID']");
        private readonly By NPIFieldprovider = By.XPath("//input[@id='pNPInumber']");
        private readonly By TIN_EINFieldprovider = By.XPath("//input[@id='pTIN']");
        private readonly By medicaidIDFieldprovider = By.XPath("//input[@id='pMedicaidId']");
        private readonly By medicareIDFieldprovider = By.XPath("//input[@id='pMedicareId']");
        private readonly By OtherIDFieldprovider = By.XPath("//input[@id='pOtherId']");
        private readonly By ProviderTypeFieldprovider = By.XPath("//input[@id='pType']");
        private readonly By ProviderSpecialtyFieldprovider = By.XPath("//input[@id='pSpecialty']");
        private readonly By TaxonomyFieldprovider = By.XPath("//input[@id='pTaxonomy']");
        private readonly By otherFieldprovider = By.XPath("//input[@id='pOther']");
        private readonly By address1Fieldprovider = By.XPath("//input[@id='pStreetAddress1']");
        private readonly By address2Fieldprovider = By.XPath("//input[@id='pStreetAddress2']");
        private readonly By cityFieldprovider = By.XPath("//input[@id='pCity']");
        private readonly By stateDrpdnprovider = By.XPath("//select[@id='pState']");
        private readonly By countyDrpdnprovider = By.XPath("//select[@id='pCounty']");
        private readonly By zipCodeFieldprovider = By.XPath("//input[@id='pZip']");
        private readonly By countryFieldprovider = By.XPath("//input[@id='pCountry']");
        private readonly By phoneNumberFieldprovider = By.XPath("//input[@id='pPhone']");
        private readonly By faxFieldprovider = By.XPath("//input[@id='pFax']");
        private readonly By emailFieldprovider = By.XPath("//input[@id='pEmail']");
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
            //Driver.FindElement(isThereAnotherInvolvedPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable1);

        }

        public void SelectPleaseSelectTheAdditionalInvolvedPartyType(string additionalInvolvedPartyType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, pleaseSelectTheAdditionalInvolvedPartyTypeDropdn);
            //Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn), additionalInvolvedPartyType);
        }
        public void SelectIsThisInvolvedPartyAnExternalReferringParty(string isAnotherExternalInvolvedPartyAvailable)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            //CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 100);
            CommonHelpers.ScrollToElement(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn);
            //Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn).Click();
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
        public void FillOrganizationFieldLawer(string OrganizationLawer)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.ScrollToElement(Driver, OrganizationField);
            Driver.FindElement(OrganizationField).Click();
            Driver.FindElement(OrganizationField).SendKeys(OrganizationLawer);
        }
        //public void FillIDField(string idLawer)
        //{
        //    CommonHelpers.WaitForElementVisiblity(Driver, IDField, 1000);
        //    Driver.FindElement(IDField).Clear();
        //    Driver.FindElement(IDField).SendKeys(idLawer);
        //}
        public void FillFirstNameField(string FirstName1)
        {
            Driver.FindElement(FirstNameField).Click();
            Driver.FindElement(FirstNameField).SendKeys(FirstName1);
        }
        public void FillFirstNameFieldLawer(string FirstNameLawer)
        {
            Driver.FindElement(FirstNameField).Click();
            Driver.FindElement(FirstNameField).SendKeys(FirstNameLawer);
        }
        public void FillLastNameField(string LastName1)
        {
            Driver.FindElement(LastNameField).Click();
            Driver.FindElement(LastNameField).SendKeys(LastName1);
        }
        public void FillLastNameFieldLawer(string LastNameLawer)
        {
            Driver.FindElement(LastNameField).Click();
            Driver.FindElement(LastNameField).SendKeys(LastNameLawer);
        }
        public void FillMiddleNameField(string MiddleName1)
        {
            Driver.FindElement(MiddleNameField).Click();
            Driver.FindElement(MiddleNameField).SendKeys(MiddleName1);
        }
        public void FillMiddleNameFieldLawer(string MiddleNameLawer)
        {
            Driver.FindElement(MiddleNameField).Click();
            Driver.FindElement(MiddleNameField).SendKeys(MiddleNameLawer);
        }
        public void FillNamePrefixField(string NamePrefix)
        {
            Driver.FindElement(NamePrefixField).Click();
            Driver.FindElement(NamePrefixField).SendKeys(NamePrefix);
        }
        public void FillNamePrefixFieldLawer(string NamePrefixLawer)
        {
            Driver.FindElement(NamePrefixField).Click();
            Driver.FindElement(NamePrefixField).SendKeys(NamePrefixLawer);
        }
        public void FillStreetAddress1Field(string StreetAddress3)
        {
            CommonHelpers.ScrollToElement(Driver, StreetAddress1Field);
            Driver.FindElement(StreetAddress1Field).Click();
            Driver.FindElement(StreetAddress1Field).SendKeys(StreetAddress3);
        }
        public void FillStreetAddress1FieldLawer(string StreetAddressLawer)
        {
            CommonHelpers.ScrollToElement(Driver, StreetAddress1Field);
            Driver.FindElement(StreetAddress1Field).Click();
            Driver.FindElement(StreetAddress1Field).SendKeys(StreetAddressLawer);
        }
        public void FillStreetAddress2Field(string StreetAddress4)
        {
            CommonHelpers.ScrollToElement(Driver, StreetAddress2Field);
            Driver.FindElement(StreetAddress2Field).Click();
            Driver.FindElement(StreetAddress2Field).SendKeys(StreetAddress4);
        }
        public void FillStreetAddress2FieldLawer(string StreetAddressLawer)
        {
            CommonHelpers.ScrollToElement(Driver, StreetAddress2Field);
            Driver.FindElement(StreetAddress2Field).Click();
            Driver.FindElement(StreetAddress2Field).SendKeys(StreetAddressLawer);
        }
        public void FillCityField(string City)
        {
            CommonHelpers.ScrollToElement(Driver, CityField);  
            Driver.FindElement(CityField).Click();
            Driver.FindElement(CityField).SendKeys(City);
        }
        public void FillCityFieldLawer(string CityLawer)
        {
            CommonHelpers.ScrollToElement(Driver, CityField);
            Driver.FindElement(CityField).Click();
            Driver.FindElement(CityField).SendKeys(CityLawer);
        }
        
        public void SelectStateField(string State)
        {
            
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, StateField);
            //Driver.FindElement(StateField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(StateField), State);

        }
        public void SelectStateFieldLawer(string StateLawer)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, StateField);
            //Driver.FindElement(StateField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(StateField), StateLawer);

        }
        public void SelectCountyField(string County)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, CountyField, 100);
            Driver.FindElement(CountyField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(CountyField), County);

        }
        public void SelectCountyFieldLawer(string CountyLawer)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, CountyField, 100);
            //Driver.FindElement(CountyField).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(CountyField), CountyLawer);

        }
        public void FillNameSuffixField(string NameSuffix)
        {
            CommonHelpers.ScrollToElement(Driver, NameSuffixField);
            Driver.FindElement(NameSuffixField).Click();
            Driver.FindElement(NameSuffixField).SendKeys(NameSuffix);
        }
        public void FillNameSuffixFieldLawer(string NameSuffixLawer)
        {
            CommonHelpers.ScrollToElement(Driver, NameSuffixField);
            Driver.FindElement(NameSuffixField).Click();
            Driver.FindElement(NameSuffixField).SendKeys(NameSuffixLawer);
        }
        public void FillZipField(string Zip)
        {
            CommonHelpers.ScrollToElement(Driver, ZipField);
            Driver.FindElement(ZipField).Click();
            Driver.FindElement(ZipField).SendKeys(Zip);
        }
        public void FillZipFieldLawer(string ZipLawer)
        {
            CommonHelpers.ScrollToElement(Driver, ZipField);
            Driver.FindElement(ZipField).Click();
            Driver.FindElement(ZipField).SendKeys(ZipLawer);
        }
        public void FillDesignationField1(string Designation1)
        {
            CommonHelpers.ScrollToElement(Driver, DesignationField1);
            Driver.FindElement(DesignationField1).Click();
            Driver.FindElement(DesignationField1).SendKeys(Designation1);
        }
        public void FillDesignationField1Lawer(string Designation1Lawer)
        {
            CommonHelpers.ScrollToElement(Driver, DesignationField1);
            Driver.FindElement(DesignationField1).Click();
            Driver.FindElement(DesignationField1).SendKeys(Designation1Lawer);
        }
        public void FillCountryField(string Country)
        {
            CommonHelpers.ScrollToElement(Driver, CountryField);
            Driver.FindElement(CountryField).Click();
            Driver.FindElement(CountryField).SendKeys(Country);
        }
        public void FillCountryFieldLawer(string CountryLawer)
        {
            CommonHelpers.ScrollToElement(Driver, CountryField);
            Driver.FindElement(CountryField).Click();
            Driver.FindElement(CountryField).SendKeys(CountryLawer);
        }
        public void FilldobField(string dob)
        {
            CommonHelpers.ScrollToElement(Driver, dobField);
            Driver.FindElement(dobField).Click();
            Driver.FindElement(dobField).SendKeys(dob);
        }
        public void FilldobFieldLawer(string dobLawer)
        {
            CommonHelpers.ScrollToElement(Driver, dobField);
            Driver.FindElement(dobField).Click();
            Driver.FindElement(dobField).SendKeys(dobLawer);
        }

        public void FillPrimaryPhoneField(string PrimaryPhone)
        {
            CommonHelpers.ScrollToElement(Driver, PrimaryPhoneField);
            Driver.FindElement(PrimaryPhoneField).Click();
            Driver.FindElement(PrimaryPhoneField).SendKeys(PrimaryPhone);
        }
        public void FillPrimaryPhoneFieldLawer(string PrimaryPhoneLawer)
        {
            CommonHelpers.ScrollToElement(Driver, PrimaryPhoneField);
            Driver.FindElement(PrimaryPhoneField).Click();
            Driver.FindElement(PrimaryPhoneField).SendKeys(PrimaryPhoneLawer);
        }
        public void FillSecondaryPhoneField(string SecondaryPhone)
        {
            CommonHelpers.ScrollToElement(Driver, SecondaryPhoneField);
            Driver.FindElement(SecondaryPhoneField).Click();
            Driver.FindElement(SecondaryPhoneField).SendKeys(SecondaryPhone);
        }
        public void FillSecondaryPhoneFieldLawer(string SecondaryPhoneLawer)
        {
            CommonHelpers.ScrollToElement(Driver, SecondaryPhoneField);
            Driver.FindElement(SecondaryPhoneField).Click();
            Driver.FindElement(SecondaryPhoneField).SendKeys(SecondaryPhoneLawer);
        }
        public void FillSsnField(string Ssn)
        {
            CommonHelpers.ScrollToElement(Driver, SsnField);
            Driver.FindElement(SsnField).Click();
            Driver.FindElement(SsnField).SendKeys(Ssn);
        }
        public void FillSsnFieldLawer(string SsnLawer)
        {
            CommonHelpers.ScrollToElement(Driver, SsnField);
            Driver.FindElement(SsnField).Click();
            Driver.FindElement(SsnField).SendKeys(SsnLawer);
        }
        public void FillOtherIdField(string OtherId)
        {
            CommonHelpers.ScrollToElement(Driver, OtherIdField);
            Driver.FindElement(OtherIdField).Click();
            Driver.FindElement(OtherIdField).SendKeys(OtherId);
        }
        public void FillOtherIdFieldLawer(string OtherIdLawer)
        {
            CommonHelpers.ScrollToElement(Driver, OtherIdField);
            Driver.FindElement(OtherIdField).Click();
            Driver.FindElement(OtherIdField).SendKeys(OtherIdLawer);
        }
        public void FillEmailField(string Email1)
        {
            CommonHelpers.ScrollToElement(Driver, EmailField);
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(Email1);
        }
        public void FillEmailFieldLawer(string EmailLawer)
        {
            CommonHelpers.ScrollToElement(Driver, EmailField);
            Driver.FindElement(EmailField).Click();
            Driver.FindElement(EmailField).SendKeys(EmailLawer);
        }
        public void FillOtherField(string Other)
        {
            CommonHelpers.ScrollToElement(Driver, OtherField);
            Driver.FindElement(OtherField).Click();
            Driver.FindElement(OtherField).SendKeys(Other);
        }
        public void FillOtherFieldLawer(string OtherLawer)
        {
            CommonHelpers.ScrollToElement(Driver, OtherField);
            Driver.FindElement(OtherField).Click();
            Driver.FindElement(OtherField).SendKeys(OtherLawer);
        }
        public void FillorganizationFieldprovider(string OrganizationProvider)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, organizationFieldprovider,100);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.ScrollToElement(Driver, organizationFieldprovider);
            Driver.FindElement(organizationFieldprovider).Click();
            Driver.FindElement(organizationFieldprovider).SendKeys(OrganizationProvider);
        }
        public void FillnamePrefixFieldprovider(string namePrefixProvider)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.ScrollToElement(Driver, namePrefixFieldprovider);
            Driver.FindElement(namePrefixFieldprovider).Click();
            Driver.FindElement(namePrefixFieldprovider).SendKeys(namePrefixProvider);
        }
        public void FillfirstNameFieldprovider(string firstNameProvider)
        {
            CommonHelpers.ScrollToElement(Driver, firstNameFieldprovider);
            Driver.FindElement(firstNameFieldprovider).Click();
            Driver.FindElement(firstNameFieldprovider).SendKeys(firstNameProvider);
        }
        public void FillmiddleNameFieldprovider(string middleNameProvider)
        {
            CommonHelpers.ScrollToElement(Driver, middleNameFieldprovider);
            Driver.FindElement(middleNameFieldprovider).Click();
            Driver.FindElement(middleNameFieldprovider).SendKeys(middleNameProvider);
        }
        public void FilllastNameFieldprovider(string lastNameProvider)
        {
            CommonHelpers.ScrollToElement(Driver, lastNameFieldprovider);
            Driver.FindElement(lastNameFieldprovider).Click();
            Driver.FindElement(lastNameFieldprovider).SendKeys(lastNameProvider);
        }
        public void FillnameSuffixFieldprovider(string nameSuffixProvider)
        {
            CommonHelpers.ScrollToElement(Driver, nameSuffixFieldprovider);
            Driver.FindElement(nameSuffixFieldprovider).Click();
            Driver.FindElement(nameSuffixFieldprovider).SendKeys(nameSuffixProvider);
        }
        public void FillDesignationFieldprovider(string DesignationProvider)
        {
            CommonHelpers.ScrollToElement(Driver, DesignationFieldprovider);
            Driver.FindElement(DesignationFieldprovider).Click();
            Driver.FindElement(DesignationFieldprovider).SendKeys(DesignationProvider);
        }
        public void FillDOBFieldprovider(string DOBProvider)
        {

            CommonHelpers.ScrollToElement(Driver, DOBFieldprovider);
            Driver.FindElement(DOBFieldprovider).Click();
            Driver.FindElement(DOBFieldprovider).SendKeys(DOBProvider);
        }
        public void FillSSNFieldprovider(string SSNProvider)
        {
            //CommonHelpers.ScrollToElement(Driver, SSNFieldprovider);
            Driver.FindElement(SSNFieldprovider).Click();
            Driver.FindElement(SSNFieldprovider).SendKeys(SSNProvider);
        }
        public void FillLicenseNumberFieldprovider(string LicenseNumberProvider)
        {
            CommonHelpers.ScrollToElement(Driver, LicenseNumberFieldprovider);
            Driver.FindElement(LicenseNumberFieldprovider).Click();
            Driver.FindElement(LicenseNumberFieldprovider).SendKeys(LicenseNumberProvider);
        }
        public void FillHowDidThisExternalReferringPartyreportThisTextarea(string HowDidThisExternalReferringPartyreportThis)
        {
            CommonHelpers.ScrollToElement(Driver, HowDidThisExternalReferringPartyreportThisTextarea);
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Click();
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(HowDidThisExternalReferringPartyreportThis);
        }
        public void FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string AnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty)
        {
            CommonHelpers.ScrollToElement(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea);
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Click();
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty);
        }
        public void FillIDFieldprovider(string IDProvider)
        {
            CommonHelpers.ScrollToElement(Driver, IDFieldprovider);
            Driver.FindElement(IDFieldprovider).Click();
            Driver.FindElement(IDFieldprovider).SendKeys(IDProvider);
        }
        public void FillNPIFieldprovider(string NPIProvider)
        {
         
            Driver.FindElement(NPIFieldprovider).Click();
            Driver.FindElement(NPIFieldprovider).SendKeys(NPIProvider);
        }
        public void FillTIN_EINFieldprovider(string TIN_EINProvider)
        {
           
            Driver.FindElement(TIN_EINFieldprovider).Click();
            Driver.FindElement(TIN_EINFieldprovider).SendKeys(TIN_EINProvider);
        }
        public void FillmedicaidIDFieldprovider(string medicaidIDProvider)
        {
            
            Driver.FindElement(medicaidIDFieldprovider).Click();
            Driver.FindElement(medicaidIDFieldprovider).SendKeys(medicaidIDProvider);
        }
        public void FillmedicareIDFieldprovider(string medicareIDProvider)
        {
            
            Driver.FindElement(medicareIDFieldprovider).Click();
            Driver.FindElement(medicareIDFieldprovider).SendKeys(medicareIDProvider);
        }
        public void FillOtherIDFieldprovider(string OtherIDProvider)
        {
            CommonHelpers.ScrollToElement(Driver, OtherIDFieldprovider);
            Driver.FindElement(OtherIDFieldprovider).Click();
            Driver.FindElement(OtherIDFieldprovider).SendKeys(OtherIDProvider);
        }
        public void FillProviderTypeFieldprovider(string ProviderTypeProvider)
        {
           
            Driver.FindElement(ProviderTypeFieldprovider).Click();
            Driver.FindElement(ProviderTypeFieldprovider).SendKeys(ProviderTypeProvider);
        }
        public void FillProviderSpecialtyFieldprovider(string ProviderSpecialtyProvider)
        {

          
            Driver.FindElement(ProviderSpecialtyFieldprovider).Click();
            Driver.FindElement(ProviderSpecialtyFieldprovider).SendKeys(ProviderSpecialtyProvider);
        }
        public void FillTaxonomyFieldprovider(string TaxonomyProvider)
        {
            
            Driver.FindElement(TaxonomyFieldprovider).Click();
            Driver.FindElement(TaxonomyFieldprovider).SendKeys(TaxonomyProvider);
        }
        public void FillotherFieldprovider(string otherProvider)
        {
           
            Driver.FindElement(otherFieldprovider).Click();
            Driver.FindElement(otherFieldprovider).SendKeys(otherProvider);
        }
        public void Filladdress1Fieldprovider(string address1Provider)
        {
            CommonHelpers.ScrollToElement(Driver, address1Fieldprovider);
            Driver.FindElement(address1Fieldprovider).Click();
            Driver.FindElement(address1Fieldprovider).SendKeys(address1Provider);
        }
        public void Filladdress2Fieldprovider(string address2Provider)
        {
            CommonHelpers.ScrollToElement(Driver, address2Fieldprovider);
            Driver.FindElement(address2Fieldprovider).Click();
            Driver.FindElement(address2Fieldprovider).SendKeys(address2Provider);
        }
        public void FillcityFieldprovider(string cityProvider)
        {
            CommonHelpers.ScrollToElement(Driver, cityFieldprovider);
            Driver.FindElement(cityFieldprovider).Click();
            Driver.FindElement(cityFieldprovider).SendKeys(cityProvider);
        }
        public void SelectstateDrpdnprovider(string stateProvider)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, stateDrpdnprovider);
            CommonHelpers.selectOptionByValue(Driver.FindElement(stateDrpdnprovider), stateProvider);
           
        }
        public void SelectcountyDrpdnprovider(string countyProvider)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, countyDrpdnprovider);
            CommonHelpers.selectOptionByValue(Driver.FindElement(countyDrpdnprovider), countyProvider);
            
        }
        public void FillzipCodeFieldprovider(string zipCodeProvider)
        {
            CommonHelpers.ScrollToElement(Driver, zipCodeFieldprovider);
            Driver.FindElement(zipCodeFieldprovider).Click();
            Driver.FindElement(zipCodeFieldprovider).SendKeys(zipCodeProvider);
        }
        public void FillcountryFieldprovider(string countryProvider)
        {
            CommonHelpers.ScrollToElement(Driver, countryFieldprovider);
            Driver.FindElement(countryFieldprovider).Click();
            Driver.FindElement(countryFieldprovider).SendKeys(countryProvider);
        }
        public void FillphoneNumberFieldprovider(string phoneNumberProvider)
        {
            CommonHelpers.ScrollToElement(Driver, phoneNumberFieldprovider);
            Driver.FindElement(phoneNumberFieldprovider).Click();
            Driver.FindElement(phoneNumberFieldprovider).SendKeys(phoneNumberProvider);
        }
        public void FillfaxFieldprovider(string faxProvider)
        {
            CommonHelpers.ScrollToElement(Driver, faxFieldprovider);
            Driver.FindElement(faxFieldprovider).Click();
            Driver.FindElement(faxFieldprovider).SendKeys(faxProvider);
        }
        public void FillemailFieldprovider(string emailProvider)
        {
            CommonHelpers.ScrollToElement(Driver, emailFieldprovider);
            Driver.FindElement(emailFieldprovider).Click();
            Driver.FindElement(emailFieldprovider).SendKeys(emailProvider);
        }









        
       
        














        public void ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            CommonHelpers.WaitForElementVisiblity(Driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            Driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();

        }
    }
}


