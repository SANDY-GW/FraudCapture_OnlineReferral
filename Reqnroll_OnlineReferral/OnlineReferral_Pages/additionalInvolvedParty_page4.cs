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
            CommonHelpers.WaitForElementVisiblity(driver, StateField, 100);

            var dropdown = new SelectElement(driver.FindElement(StateField));
            dropdown.SelectByText(State);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);    


        }

        public void FillDOBField(string DOB)
        {
            CommonHelpers.WaitForElementVisiblity(driver, DOBField, 100);
            driver.FindElement(DOBField).SendKeys(DOB);
        }
        public void SelectisThereAnotherInvolvedParty(string isAnotherInvolvedPartyAvailable)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 300);
            CommonHelpers.ScrollToElement(driver, isThereAnotherInvolvedPartyDropdn);
            driver.FindElement(isThereAnotherInvolvedPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable);

        }
        public void FillisThereAnotherInvolvedParty(string isAnotherInvolvedPartyAvailable1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.ScrollToElement(driver, isThereAnotherInvolvedPartyDropdn);
            driver.FindElement(isThereAnotherInvolvedPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable1);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public void SelectPleaseSelectTheAdditionalInvolvedPartyType(string additionalInvolvedPartyType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.ScrollToElement(driver, pleaseSelectTheAdditionalInvolvedPartyTypeDropdn);
            driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn), additionalInvolvedPartyType);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }
        public void SelectIsThisInvolvedPartyAnExternalReferringParty(string isAnotherExternalInvolvedPartyAvailable)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            //CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 100);
            CommonHelpers.ScrollToElement(driver, isThisInvolvedPartyAnExternalReferringPartyDropdn);
            driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn), isAnotherExternalInvolvedPartyAvailable);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }

        public void ClickContinueWithInvolvedPartySelectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 20);
            CommonHelpers.WaitForElementVisiblity(driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            CommonHelpers.ScrollToElement(driver, finishInvolvedPartySelectionAndProceedToNectSectionButton);
            driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 100);

        }
        public void FillOrganizationField(string Organization1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 20);
            CommonHelpers.ScrollToElement(driver, OrganizationField);
            driver.FindElement(OrganizationField).Click();
            driver.FindElement(OrganizationField).SendKeys(Organization1);
        }
        public void FillFirstNameField(string FirstName1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, FirstNameField, 100); 
            driver.FindElement(FirstNameField).Clear();
            driver.FindElement(FirstNameField).SendKeys(FirstName1);
        }
        public void FillLastNameField(string LastName1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LastNameField, 100);
            driver.FindElement(LastNameField).Clear();
            driver.FindElement(LastNameField).SendKeys(LastName1);
        }
        public void FillMiddleNameField(string MiddleName1)
        {
            driver.FindElement(MiddleNameField).Clear();
            driver.FindElement(MiddleNameField).SendKeys(MiddleName1);
        }
        public void FillNamePrefixField(string NamePrefix)
        {
            driver.FindElement(NamePrefixField).Clear();
            driver.FindElement(NamePrefixField).SendKeys(NamePrefix);
        }
        public void FillStreetAddress1Field(string StreetAddress3)
        { 

            CommonHelpers.WaitForElementVisiblity(driver, StreetAddress1Field, 100);
            driver.FindElement(StreetAddress1Field).Clear();
            driver.FindElement(StreetAddress1Field).SendKeys(StreetAddress3);
        }
        public void FillStreetAddress2Field(string StreetAddress4)
        {
            CommonHelpers.WaitForElementVisiblity(driver, StreetAddress2Field, 100);
            driver.FindElement(StreetAddress2Field).Clear();
          
            driver.FindElement(StreetAddress2Field).SendKeys(StreetAddress4);
        }
        public void FillCityField(string City)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CityField, 100);
            driver.FindElement(CityField).Clear();
            driver.FindElement(CityField).SendKeys(City);
        }
        public void FillStateField(string State)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 10);
            CommonHelpers.WaitForElementVisiblity(driver, StateField, 100);
            driver.FindElement(StateField).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(StateField), State);
        }
        public void SelectCountyField(string County)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CountyField, 100);
            var dropdown = new SelectElement(driver.FindElement(CountyField));
            dropdown.SelectByText(County);


        }
        public void FillNameSuffixField(string NameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, NameSuffixField, 100);
            driver.FindElement(NameSuffixField).Clear();
            driver.FindElement(NameSuffixField).SendKeys(NameSuffix);
        }
        public void FillZipField(string Zip)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ZipField, 100);
            driver.FindElement(ZipField).Clear();
            driver.FindElement(ZipField).SendKeys(Zip);
        }
        public void FillDesignationField1(string Designation1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, DesignationField1, 100);
            driver.FindElement(DesignationField1).Clear();
            driver.FindElement(DesignationField1).SendKeys(Designation1);
        }
        public void FillCountryField(string Country)
        {
            driver.FindElement(CountryField).Click();
            driver.FindElement(CountryField).SendKeys(Country);
        }
        public void FillPrimaryPhoneField(string PrimaryPhone)
        {
            driver.FindElement(PrimaryPhoneField).Clear();
            driver.FindElement(PrimaryPhoneField).SendKeys(PrimaryPhone);
        }
        public void FillSecondaryPhoneField(string SecondaryPhone)
        {
           CommonHelpers.WaitForElementVisiblity(driver, SecondaryPhoneField, 100);
            driver.FindElement(SecondaryPhoneField).Clear();
            driver.FindElement(SecondaryPhoneField).SendKeys(SecondaryPhone);
        }
        public void FillSsnField(string Ssn)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SsnField, 100);
            driver.FindElement(SsnField).Clear();
            driver.FindElement(SsnField).SendKeys(Ssn);
        }
        public void FillOtherIdField(string OtherId)
        {
            
            CommonHelpers.WaitForElementVisiblity(driver, OtherIdField, 100);
            driver.FindElement(OtherIdField).Clear();
            driver.FindElement(OtherIdField).SendKeys(OtherId);
        }
        public void FillEmailField(string Email1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, EmailField, 100);
            driver.FindElement(EmailField).Clear();
            driver.FindElement(EmailField).SendKeys(Email1);
        }
        public void FillOtherField(string Other)
        {
            CommonHelpers.WaitForElementVisiblity(driver, OtherField, 100);
            driver.FindElement(OtherField).Clear();
            driver.FindElement(OtherField).SendKeys(Other);
        }

        public void ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, finishInvolvedPartySelectionAndProceedToNectSectionButton, 100);
            driver.FindElement(finishInvolvedPartySelectionAndProceedToNectSectionButton).Click();

        }


        public void ClickEditButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, EditButton, 100);
            driver.FindElement(EditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public void updateOrganizationField(string organization)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 300);");
            CommonHelpers.WaitForElementVisiblity(driver, OrganizationField, 1000);


            driver.FindElement(OrganizationField).Clear();
            driver.FindElement(OrganizationField).SendKeys(organization);
            CommonHelpers.ScrollUp(driver);
        }

        public void clickSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            CommonHelpers.ScrollUp(driver);
            CommonHelpers.WaitForElementVisiblity(driver, SaveButton, 100);
            driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }
        public string getOrganizationName()
        {
            Console.WriteLine("Organization Name: " + driver.FindElement(OrganizationField).GetAttribute("value"));
            return driver.FindElement(OrganizationField).GetAttribute("value");
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

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 300);

            //CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 100);
            CommonHelpers.ScrollToElement(driver, continue_with_Involved_Party_Selection_Button);
            driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            //CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);

        }

        public string getWitnessadditionalDropdownValue()
        {
            CommonHelpers.ScrollUp(driver);
            CommonHelpers.WaitForElementVisiblity(driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 30);
            var dropdown = new SelectElement(driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn));
            var option = dropdown.SelectedOption.Text;
            return option;

        }
       



    }
}


