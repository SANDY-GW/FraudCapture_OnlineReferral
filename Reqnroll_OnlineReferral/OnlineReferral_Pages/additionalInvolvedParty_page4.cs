using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CommonHelpers.WaitForElementVisiblity(Driver, isThereAnotherInvolvedPartyDropdn, 100);
            CommonHelpers.selectOptionByValue(Driver.FindElement(isThereAnotherInvolvedPartyDropdn), isAnotherInvolvedPartyAvailable);
            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 1000);
        }

        //public void SelectPleaseSelectTheAdditionalInvolvedPartyType(string additionalInvolvedPartyType)
        //{
        //    CommonHelpers.WaitForElementVisiblity(Driver, pleaseSelectTheAdditionalInvolvedPartyTypeDropdn, 10);
        //    CommonHelpers.selectOptionByValue(Driver.FindElement(pleaseSelectTheAdditionalInvolvedPartyTypeDropdn), additionalInvolvedPartyType);
        //}
        //public void SelectIsThisInvolvedPartyAnExternalReferringParty(string isAnotherExternalInvolvedPartyAvailable)
        //{
        //    CommonHelpers.WaitForElementVisiblity(Driver, isThisInvolvedPartyAnExternalReferringPartyDropdn, 10);
        //    CommonHelpers.selectOptionByValue(Driver.FindElement(isThisInvolvedPartyAnExternalReferringPartyDropdn), isAnotherExternalInvolvedPartyAvailable);

        //}

        public void ClickContinueWithInvolvedPartySelectionButton()
        {
            new CommonHelpers(Driver).WaitForLoadingOverlayToDisappear();
            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 70000);
            Driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            Thread.Sleep(5000);
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 70000);

        }
    }
}


