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
        private readonly By StateField = By.XPath("//select[@name='neiState']");
        private readonly By CountyField = By.XPath("//select[@id='neiCounty']");
        private readonly By NameSuffixField = By.XPath("//input[@id='neiNameSuffix']");
        private readonly By ZipField = By.XPath("//input[@id='neiZip']");
        private readonly By DesignationField1 = By.XPath("//input[@id='neiDesignation']");
        private readonly By CountryField = By.XPath("//input[@name='neiCountry']");
        private readonly By PrimaryPhoneField = By.XPath("//input[@id='neiPrimaryPhone']");
        private readonly By SecondaryPhoneField = By.XPath("//input[@id='neiSecondaryPhone']");
        private readonly By SsnField = By.XPath("//input[@id='neiSsn']");
        private readonly By OtherIdField = By.XPath("//input[@id='neiOtherId']");
        private readonly By EmailField = By.XPath("//input[@id='neiEmail']");
        private readonly By OtherField = By.XPath("//input[@id='neiOther']");
        private readonly By DOBField = By.XPath("//input[@name='neiDateOfBirth']");
        

        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(.,'Go to Previous Section')]");
        private readonly By continue_with_Involved_Party_Selection_Button = By.XPath("//button[contains(.,'Continue with Involved Party Selection ')]");

        private readonly By finishInvolvedPartySelectionAndProceedToNectSectionButton = By.XPath("//button[contains(.,'Finish Involved Party Selection and Proceed to Next Section ')]");

       
        private readonly By EditButton = By.XPath("//button[contains(.,'Edit')]");
        private readonly By SaveButton = By.XPath("//button[contains(.,'Save')]");


        #endregion

        public void SelectState(string State)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, StateField, 100);

            var dropdown = new SelectElement(Driver.FindElement(StateField));
            dropdown.SelectByText(State);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);    


        }

        public void FillDOBField(string DOB)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DOBField, 100);
            Driver.FindElement(DOBField).SendKeys(DOB);
        }
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
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        public void SelectPleaseSelectTheAdditionalInvolvedPartyType(string additionalInvolvedPartyType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollToElement(Driver, pleaseSelectTheAdditionalInvolvedPartyTypeDropdn);
            Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn), additionalInvolvedPartyType);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }
        public void SelectIsThisInvolvedPartyAnExternalReferringParty(string isAnotherExternalInvolvedPartyAvailable)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            //CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 100);
            CommonHelpers.ScrollToElement(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn);
            Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn), isAnotherExternalInvolvedPartyAvailable);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

        }

        public void ClickContinueWithInvolvedPartySelectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            CommonHelpers.ScrollToElement(Driver, finishInvolvedPartySelectionAndProceedToNectSectionButton);
            Driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
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
            CommonHelpers.WaitForElementVisiblity(Driver, FirstNameField, 100); 
            Driver.FindElement(FirstNameField).Clear();
            Driver.FindElement(FirstNameField).SendKeys(FirstName1);
        }
        public void FillLastNameField(string LastName1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LastNameField, 100);
            Driver.FindElement(LastNameField).Clear();
            Driver.FindElement(LastNameField).SendKeys(LastName1);
        }
        public void FillMiddleNameField(string MiddleName1)
        {
            Driver.FindElement(MiddleNameField).Clear();
            Driver.FindElement(MiddleNameField).SendKeys(MiddleName1);
        }
        public void FillNamePrefixField(string NamePrefix)
        {
            Driver.FindElement(NamePrefixField).Clear();
            Driver.FindElement(NamePrefixField).SendKeys(NamePrefix);
        }
        public void FillStreetAddress1Field(string StreetAddress3)
        { 

            CommonHelpers.WaitForElementVisiblity(Driver, StreetAddress1Field, 100);
            Driver.FindElement(StreetAddress1Field).Clear();
            Driver.FindElement(StreetAddress1Field).SendKeys(StreetAddress3);
        }
        public void FillStreetAddress2Field(string StreetAddress4)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, StreetAddress2Field, 100);
            Driver.FindElement(StreetAddress2Field).Clear();
          
            Driver.FindElement(StreetAddress2Field).SendKeys(StreetAddress4);
        }
        public void FillCityField(string City)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CityField, 100);
            Driver.FindElement(CityField).Clear();
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
            CommonHelpers.WaitForElementVisiblity(Driver, CountyField, 100);
            var dropdown = new SelectElement(Driver.FindElement(CountyField));
            dropdown.SelectByText(County);


        }
        public void FillNameSuffixField(string NameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, NameSuffixField, 100);
            Driver.FindElement(NameSuffixField).Clear();
            Driver.FindElement(NameSuffixField).SendKeys(NameSuffix);
        }
        public void FillZipField(string Zip)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ZipField, 100);
            Driver.FindElement(ZipField).Clear();
            Driver.FindElement(ZipField).SendKeys(Zip);
        }
        public void FillDesignationField1(string Designation1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DesignationField1, 100);
            Driver.FindElement(DesignationField1).Clear();
            Driver.FindElement(DesignationField1).SendKeys(Designation1);
        }
        public void FillCountryField(string Country)
        {
            Driver.FindElement(CountryField).Click();
            Driver.FindElement(CountryField).SendKeys(Country);
        }
        public void FillPrimaryPhoneField(string PrimaryPhone)
        {
            Driver.FindElement(PrimaryPhoneField).Clear();
            Driver.FindElement(PrimaryPhoneField).SendKeys(PrimaryPhone);
        }
        public void FillSecondaryPhoneField(string SecondaryPhone)
        {
           CommonHelpers.WaitForElementVisiblity(Driver, SecondaryPhoneField, 100);
            Driver.FindElement(SecondaryPhoneField).Clear();
            Driver.FindElement(SecondaryPhoneField).SendKeys(SecondaryPhone);
        }
        public void FillSsnField(string Ssn)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SsnField, 100);
            Driver.FindElement(SsnField).Clear();
            Driver.FindElement(SsnField).SendKeys(Ssn);
        }
        public void FillOtherIdField(string OtherId)
        {
            
            CommonHelpers.WaitForElementVisiblity(Driver, OtherIdField, 100);
            Driver.FindElement(OtherIdField).Clear();
            Driver.FindElement(OtherIdField).SendKeys(OtherId);
        }
        public void FillEmailField(string Email1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, EmailField, 100);
            Driver.FindElement(EmailField).Clear();
            Driver.FindElement(EmailField).SendKeys(Email1);
        }
        public void FillOtherField(string Other)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, OtherField, 100);
            Driver.FindElement(OtherField).Clear();
            Driver.FindElement(OtherField).SendKeys(Other);
        }

        public void ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            CommonHelpers.WaitForElementVisiblity(Driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            Driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();

        }


        public void ClickEditButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, EditButton, 100);
            Driver.FindElement(EditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        public void updateOrganizationField(string organization)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 300);");
            CommonHelpers.WaitForElementVisiblity(Driver, OrganizationField, 1000);


            Driver.FindElement(OrganizationField).Clear();
            Driver.FindElement(OrganizationField).SendKeys(organization);
        }

        public void clickSaveButton()
        {
            CommonHelpers.WaitForPageToLoad(Driver, 100);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            CommonHelpers.WaitForElementVisiblity(Driver, SaveButton, 100);
            Driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }
        public string getOrganizationName()
        {
            Console.WriteLine("Organization Name: " + Driver.FindElement(OrganizationField).GetAttribute("value"));
            return Driver.FindElement(OrganizationField).GetAttribute("value");
        }

        public string GetOrganizationFieldValue()
        {
            return getOrganizationName();
        }

        public void clickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);
            Driver.FindElement(Go_To_Previous_SectionButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 100);
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 300);

            //CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 100);
            CommonHelpers.ScrollToElement(Driver, continue_with_Involved_Party_Selection_Button);
            Driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            //CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);

        }

        public string getWitnessadditionalDropdownValue()
        {
            CommonHelpers.ScrollUp(Driver);
            CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 30);
            var dropdown = new SelectElement(Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn));
            var option = dropdown.SelectedOption.Text;
            return option;

        }




    }
}


