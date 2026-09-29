using NUnit.Framework.Constraints;
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
        private readonly By EditButton = By.XPath("//button[contains(.,'Edit')]");
        private readonly By SaveButton = By.XPath("//button[contains(.,'Save')]");
        #endregion
        //referring party dropdown
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(driver, isExtRefDropdn, 30);
            var dropdown = new SelectElement(driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }



        //Organization field
        public void FillOrganizationField(string organization)
        {
            CommonHelpers.WaitForElementVisiblity(driver, organizationField, 30);
            CommonHelpers.enterTextValue(driver.FindElement(organizationField), organization);
            //Driver.FindElement(organizationField).Clear();
            //Driver.FindElement(organizationField).SendKeys(organization);
        }
        //Name prefix field
        public void FillNamePrefixField(string namePrefix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, namePrefixField, 30);
            driver.FindElement(namePrefixField).Clear();
            driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }
        //First name field
        public void FillFirstNameField(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, firstNameField, 30);
            driver.FindElement(firstNameField).Clear();
            driver.FindElement(firstNameField).SendKeys(firstName);
        }
        //Middle name field
        public void FillMiddleNameField(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, middleNameField, 30);
            driver.FindElement(middleNameField).Clear();
            driver.FindElement(middleNameField).SendKeys(middleName);
        }
        //Last name field
        public void FillLastNameField(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, lastNameField, 30);
            driver.FindElement(lastNameField).Clear();
            driver.FindElement(lastNameField).SendKeys(lastName);
        }
        //Name suffix field
        public void FillNameSuffixField(string nameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, nameSuffixField, 30);
            driver.FindElement(nameSuffixField).Clear();
            driver.FindElement(nameSuffixField).SendKeys(nameSuffix);
        }
        //Designation field

        public void FillDesignationField(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(driver, DesignationField, 30);
            driver.FindElement(DesignationField).Clear();
            driver.FindElement(DesignationField).SendKeys(designation);
        }
        //DOB field
        public void FillDOBField(string dob)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 60);
            //CommonHelpers.WaitForElementVisiblity(Driver, DOBField, 10);
            CommonHelpers.ScrollToElement(driver, DOBField);
            var element = driver.FindElement(DOBField);
            element.Click();
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            element.SendKeys(dob);
        }

        //SSN field
        public void FillSSNField(string ssn)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SSNField, 30);
            driver.FindElement(SSNField).Clear();
            driver.FindElement(SSNField).SendKeys(ssn);
        }
        //License number field
        public void FillLicenseNumberField(string licenseNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LicenseNumberField, 30);
            driver.FindElement(LicenseNumberField).Clear();
            driver.FindElement(LicenseNumberField).SendKeys(licenseNumber);
        }
        //How did this external referring party report this? 
        public void FillHowDidThisExternalReferringPartyreportThisTextarea(string report)
        {
            CommonHelpers.WaitForElementVisiblity(driver, HowDidThisExternalReferringPartyreportThisTextarea, 30);
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Clear();
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }

        public string getWitnessDropdownValue()
        {
            CommonHelpers.ScrollUp(driver);
            CommonHelpers.WaitForElementVisiblity(driver, isExtRefDropdn, 30);
            var dropdown = new SelectElement(driver.FindElement(isExtRefDropdn));
            var option= dropdown.SelectedOption.Text;
            return option;

        }

        //Any additional information regarding the witness or external referring party
        public void FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string additionalInfo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 30);
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Clear();
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }
        //ID/Test field
        public void FillIDTestField(string idTest)
        {
            CommonHelpers.WaitForElementVisiblity(driver, IDTestField, 30);
            driver.FindElement(IDTestField).Clear();
            driver.FindElement(IDTestField).SendKeys(idTest);
        }
        //NPI field
        public void FillNPIField(string npi)
        {
            CommonHelpers.WaitForElementVisiblity(driver, NPIField, 30);
            driver.FindElement(NPIField).Clear();
            driver.FindElement(NPIField).SendKeys(npi);
        }
        //TIN/EIN field
        public void FillTIN_EINField(string tinEin)
        {
            CommonHelpers.WaitForElementVisiblity(driver, TIN_EINField, 30);
            driver.FindElement(TIN_EINField).Clear();
            driver.FindElement(TIN_EINField).SendKeys(tinEin);
        }
        //Medicaid ID field
        public void FillMedicaidIDField(string medicaidId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, medicaidIDField, 30);
            driver.FindElement(medicaidIDField).Clear();
            driver.FindElement(medicaidIDField).SendKeys(medicaidId);
        }
        //Medicare ID field
        public void FillMedicareIDField(string medicareId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, medicareIDField, 30);
            driver.FindElement(medicareIDField).Clear();
            driver.FindElement(medicareIDField).SendKeys(medicareId);
        }
        //Other ID field
        public void FillOtherIDField(string otherId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, OtherIDField, 30);
            driver.FindElement(OtherIDField).Clear();
            driver.FindElement(OtherIDField).SendKeys(otherId);
        }
        //Provider type field
        public void FillProviderTypeField(string providerType)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ProviderTypeField, 30);
            driver.FindElement(ProviderTypeField).Clear();
            driver.FindElement(ProviderTypeField).SendKeys(providerType);
        }
        //Provider specialty field
        public void FillProviderSpecialtyField(string providerSpecialty)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ProviderSpecialtyField, 30);
            driver.FindElement(ProviderSpecialtyField).Clear();
            driver.FindElement(ProviderSpecialtyField).SendKeys(providerSpecialty);
        }
        //Taxonomy field
        public void FillTaxonomyField(string taxonomy)
        {
            CommonHelpers.WaitForElementVisiblity(driver, TaxonomyField, 30);
            driver.FindElement(TaxonomyField).Clear();
            driver.FindElement(TaxonomyField).SendKeys(taxonomy);
        }
        //Other field
        public void FillOtherField(string other)
        {
            CommonHelpers.WaitForElementVisiblity(driver, otherField, 30);
            driver.FindElement(otherField).Clear();
            driver.FindElement(otherField).SendKeys(other);
        }
        //Address1 field
        public void FillAddress1Field(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address1Field, 1000);
            driver.FindElement(address1Field).Clear();
            driver.FindElement(address1Field).SendKeys(address1);
        }
        //Address2 field
        public void FillAddress2Field(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address2Field, 30);
            driver.FindElement(address2Field).Clear();
            driver.FindElement(address2Field).SendKeys(address2);
        }
        //City field
        public void FillCityField(string city)
        {
            CommonHelpers.WaitForElementVisiblity(driver, cityField, 30);
            driver.FindElement(cityField).Clear();
            driver.FindElement(cityField).SendKeys(city);

        }
        //State dropdown
        public void SelectStateFromDropdown(string state)
        {
            CommonHelpers.WaitForElementVisiblity(driver, stateDrpdn, 30);

            var dropdown = new SelectElement(driver.FindElement(stateDrpdn));
            dropdown.SelectByText(state);
            Thread.Sleep(5000);
            CommonHelpers.WaitForPageToLoad(driver, 10000);
        }
        //County dropdown
        public void SelectCountyFromDropdown(string county)
        {
            CommonHelpers.WaitForElementVisiblity(driver, countyDrpdn, 30);
            var dropdown = new SelectElement(driver.FindElement(countyDrpdn));
            dropdown.SelectByText(county);
        }
        //Zip code field
        public void FillZipCodeField(string zipCode)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 500);");

            CommonHelpers.WaitForElementVisiblity(driver, zipCodeField, 30);
            driver.FindElement(zipCodeField).Clear();
            driver.FindElement(zipCodeField).SendKeys(zipCode);
        }
        //Country field
        public void FillCountryField(string country)
        {
            CommonHelpers.WaitForElementVisiblity(driver, countryField, 30);
            driver.FindElement(countryField).Clear();
            driver.FindElement(countryField).SendKeys(country);
        }
        //Phone number field
        public void FillPhoneNumberField(string phoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, phoneNumberField, 30);
            driver.FindElement(phoneNumberField).Clear();
            driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }
        //Fax field
        public void FillFaxField(string fax)
        {
            CommonHelpers.WaitForElementVisiblity(driver, faxField, 30);
            driver.FindElement(faxField).Clear();
            driver.FindElement(faxField).SendKeys(fax);
        }
        //Email field
        public void FillEmailField(string email)
        {
            CommonHelpers.WaitForElementVisiblity(driver, emailField, 30);
            driver.FindElement(emailField).Clear(); 
            driver.FindElement(emailField).SendKeys(email);
            CommonHelpers.WaitForPageToLoad(driver, 10000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0);");


        }
        //Click on  continue_with_Involved_Party_Selection_Button

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(driver);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, -500);");

            CommonHelpers.WaitForElementVisiblity(driver, continue_with_Involved_Party_Selection_Button, 100);

            driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 100);

        }



        public string GetValidationDateErrorMessage()
        {
            return CommonHelpers.GetValidationDateErrorText(driver);
        }

        public bool IsValidationDateErrorDisplayed()
        {
           
                return CommonHelpers.ValidationDateerrorExists(driver);
            
            
        }

        public bool VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(driver, driver.FindElement(stateDrpdn));
        }

        public bool VerifyIfCountyDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(driver, driver.FindElement(countyDrpdn));
        }


        public string GetValidationErrorMessage()
        {
            return CommonHelpers.GetValidationErrorText(driver);
        }

        public bool IsValidationErrorDisplayed()
        {
            return CommonHelpers.ValidationerrorExists(driver);
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
            CommonHelpers.WaitForElementVisiblity(driver, organizationField, 100);
            
        
        driver.FindElement(organizationField).Clear();
            driver.FindElement(organizationField).SendKeys(organization);
        }

        public void clickSaveButton()
        {
            CommonHelpers.WaitForPageToLoad(driver, 100);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            CommonHelpers.WaitForElementVisiblity(driver, SaveButton, 100);
            driver.FindElement(SaveButton).Click();
           CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }
        public string getOrganizationName()
        {
            Console.WriteLine("Organization Name: " + driver.FindElement(organizationField).GetAttribute("value"));
            return driver.FindElement(organizationField).GetAttribute("value");
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
    }
}