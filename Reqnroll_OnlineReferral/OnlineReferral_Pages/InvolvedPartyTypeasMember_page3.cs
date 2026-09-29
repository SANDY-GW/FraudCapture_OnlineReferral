using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public  class InvolvedPartyTypeasMember_page3 : BaseSettings
    {
        public InvolvedPartyTypeasMember_page3(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By isExtRefDropdn = By.XPath("//select[@id='isExternalReferal']");

        private readonly By namePrefixField = By.XPath("//input[@id='mNamePrefix']");
        private readonly By firstNameField = By.XPath("//input[@id='mFirstName']");
        private readonly By middleNameField = By.XPath("//input[@id='mMiddleName']");
        private readonly By lastNameField = By.XPath("//input[@id='mLastName']");
        private readonly By nameSuffixField = By.XPath("//input[@id='mNameSuffix']");
        private readonly By DOBField = By.XPath("//input[@name='mDateOfBirth']");
        private readonly By genderField = By.XPath("//input[@name='mGender']");
        private readonly By OtherField = By.XPath("//input[@name='mOther']");
        private readonly By HowDidThisExternalReferringPartyreportThisTextarea = By.XPath("//textarea[@id='externalReferalReport']");
        private readonly By AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea = By.XPath("//textarea[@id='externalReferalAddInfo']");
        private readonly By IDField = By.XPath("//input[@id='mID']");

        private readonly By SSNField = By.XPath("//input[@id='mSSN']");

        private readonly By medicaidIDField = By.XPath("//input[@id='mMedicaidId']");
        private readonly By medicareIDField = By.XPath("//input[@id='mMedicareId']");
        private readonly By OtherIDField = By.XPath("//input[@id='mOtherId']");
        private readonly By PlanField = By.XPath("//input[@id='mPlan']");
        private readonly By ProgramField = By.XPath("//input[@id='mProgram']");
        private readonly By LOBField = By.XPath("//input[@id='mLOB']");
        private readonly By GroupField = By.XPath("//input[@id='mGroup']");
        private readonly By address1Field = By.XPath("//input[@id='mAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='mAddress2']");
        private readonly By cityField = By.XPath("//input[@id='mCity']");
        private readonly By stateDrpdn = By.XPath("//select[@id='mState']");
        private readonly By countyDrpdn = By.XPath("//select[@id='mCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='mZip']");


        private readonly By primaryPhoneNumberField = By.XPath("//input[@id='mPrimaryPhone']");
        private readonly By secondaryPhoneNumberField = By.XPath("//input[@id='mSecondaryPhone']");
        private readonly By emailField = By.XPath("//input[@id='mEmail']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(.,'Go to Previous Section')]");
        private readonly By continue_with_Involved_Party_Selection_Button = By.XPath("//button[contains(.,'Continue with Involved Party Selection ')]");
        private readonly By EditButton = By.XPath("//button[contains(.,'Edit')]");
        private readonly By SaveButton = By.XPath("//button[contains(.,'Save')]");

        #endregion
        //referring party dropdown
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(driver, isExtRefDropdn, 100);
            var dropdown = new SelectElement(driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }


        //Name prefix field
        public void FillNamePrefixField(string namePrefix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, namePrefixField, 100);
            driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }


        //First name field
        public void FillFirstNameField(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, firstNameField, 100);
            driver.FindElement(firstNameField).SendKeys(firstName);
        }

        //Middle name field
        public void FillMiddleNameField(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, middleNameField, 100);
            driver.FindElement(middleNameField).SendKeys(middleName);
        }

        //Last name field
        public void FillLastNameField(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(driver, lastNameField, 100);
            driver.FindElement(lastNameField).SendKeys(lastName);
        }

        //Name suffix field
        public void FillNameSuffixField(string nameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(driver, nameSuffixField, 100);
            driver.FindElement(nameSuffixField).SendKeys(nameSuffix);
        }

        //Gender field

        public void FillGenderField(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(driver, genderField, 100);
            driver.FindElement(genderField).SendKeys(designation);
        }

        //DOB field
        public void FillDOBField(string dob)
        {
            CommonHelpers.WaitForElementVisiblity(driver, DOBField, 100);
            driver.FindElement(DOBField).SendKeys(dob);
        }

        //other field
        public void FillOtherField(string other)
        {
            CommonHelpers.WaitForElementVisiblity(driver, OtherField, 100);
            driver.FindElement(OtherField).SendKeys(other);
        }

        // ID field
        public void FillIDField(string id)
        {
            CommonHelpers.WaitForElementVisiblity(driver, IDField, 100);
            driver.FindElement(IDField).SendKeys(id);
        }

        //SSN field
        public void FillSSNField(string ssn)
        {
            CommonHelpers.WaitForElementVisiblity(driver, SSNField, 100);
            driver.FindElement(SSNField).SendKeys(ssn);
        }

        //How did this external referring party report this? 
        public void FillHowDidThisExternalReferringPartyreportThisTextarea(string report)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            //CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 100);
            CommonHelpers.ScrollToElement(driver, HowDidThisExternalReferringPartyreportThisTextarea);
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Click();
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }
        public void SelectHowDidThisExternalReferringPartyreportThisTextarea(string report1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            //CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 100);
            CommonHelpers.ScrollToElement(driver, HowDidThisExternalReferringPartyreportThisTextarea);
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).Click();
            driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report1);
        }

        //Any additional information regarding the witness or external referring party
        public void FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string additionalInfo)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            //CommonHelpers.WaitForElementVisiblity(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 100);
            CommonHelpers.ScrollToElement(driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea);
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Click();
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }
        public void SelectAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string additionalInfo1)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            //CommonHelpers.WaitForElementVisiblity(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 100);
            CommonHelpers.ScrollToElement(driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea);
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).Click();
            driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo1);
        }


        //Medicaid ID field
        public void FillMedicaidIDField(string medicaidId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, medicaidIDField, 100);
            driver.FindElement(medicaidIDField).SendKeys(medicaidId);
        }

        //Medicare ID field
        public void FillMedicareIDField(string medicareId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, medicareIDField, 100);
            driver.FindElement(medicareIDField).SendKeys(medicareId);
        }

        //Other ID field
        public void FillOtherIDField(string otherId)
        {
            CommonHelpers.WaitForElementVisiblity(driver, OtherIDField, 100);
            driver.FindElement(OtherIDField).SendKeys(otherId);
        }

        //Plan field
        public void FillPlanField(string plan)
        {
            CommonHelpers.WaitForElementVisiblity(driver, PlanField, 100);
            driver.FindElement(PlanField).SendKeys(plan);
        }

        //program field
        public void FillProgramField(string program)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ProgramField, 100);
            driver.FindElement(ProgramField).SendKeys(program);
        }

        //LOB field
        public void FillLOBField(string lob)
        {
            CommonHelpers.WaitForElementVisiblity(driver, LOBField, 100);
            driver.FindElement(LOBField).SendKeys(lob);
        }
        //Group field
        public void FillGroupField(string group)
        {
            CommonHelpers.WaitForElementVisiblity(driver, GroupField, 100);
            driver.FindElement(GroupField).SendKeys(group);
        }

        //Address1 field
        public void FillAddress1Field(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address1Field, 100);
            driver.FindElement(address1Field).SendKeys(address1);
        }
        //Address2 field
        public void FillAddress2Field(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(driver, address2Field, 100);
            driver.FindElement(address2Field).SendKeys(address2);
        }
        //City field
        public void FillCityField(string city)
        {
            CommonHelpers.WaitForElementVisiblity(driver, cityField, 100);
            driver.FindElement(cityField).SendKeys(city);

        }

        //State dropdown
        public void SelectStateFromDropdown(string state)
        {
            CommonHelpers.WaitForElementVisiblity(driver, stateDrpdn, 100);

            var dropdown = new SelectElement(driver.FindElement(stateDrpdn));
            dropdown.SelectByText(state);
            Thread.Sleep(5000);
            CommonHelpers.WaitForPageToLoad(driver, 100);
        }

        //County dropdown
        public void SelectCountyFromDropdown(string county)
        {
            CommonHelpers.WaitForElementVisiblity(driver, countyDrpdn, 100);
            var dropdown = new SelectElement(driver.FindElement(countyDrpdn));
            dropdown.SelectByText(county);
        }

        //Zip code field
        public void FillZipCodeField(string zipCode)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 500);");

            CommonHelpers.WaitForElementVisiblity(driver, zipCodeField, 100);
            driver.FindElement(zipCodeField).SendKeys(zipCode);
        }

        //primary phone number field
        public void FillPrimaryPhoneNumberField(string primaryPhoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, primaryPhoneNumberField, 100);
            driver.FindElement(primaryPhoneNumberField).SendKeys(primaryPhoneNumber);
        }

        //Secondary phone number field
        public void FillSecondaryPhoneNumberField(string secondaryPhoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(driver, secondaryPhoneNumberField, 100);
            driver.FindElement(secondaryPhoneNumberField).SendKeys(secondaryPhoneNumber);
        }

        //Email field
        public void FillEmailField(string email)
        {
            CommonHelpers.WaitForElementVisiblity(driver, emailField, 100);
            driver.FindElement(emailField).SendKeys(email);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            Thread.Sleep(5000);

        }

        //Click on  continue_with_Involved_Party_Selection_Button

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,300);
            
            //CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 100);
            CommonHelpers.ScrollToElement(driver, continue_with_Involved_Party_Selection_Button);
            driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            //CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 100);

        }
        public void ClickEditButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, EditButton, 100);
            driver.FindElement(EditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public void updateMiddleNameField(string firstName)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 300);");
            CommonHelpers.WaitForElementVisiblity(driver, firstNameField, 1000);


            driver.FindElement(middleNameField).Clear();
            driver.FindElement(middleNameField).SendKeys(firstName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.ScrollUp(driver);
        }

        public void clickSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.ScrollUp(driver);
            
           
            CommonHelpers.WaitForElementVisiblity(driver, SaveButton, 100);
            driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }
        public string getMiddleName()
        {
            Console.WriteLine("Middle Name: " + driver.FindElement(middleNameField).GetAttribute("value"));
            return driver.FindElement(middleNameField).GetAttribute("value");
        }

        public string GetFirstNameFieldValue()
        {
            return getMiddleName();
        }

        public void clickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 100);
            driver.FindElement(Go_To_Previous_SectionButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, continue_with_Involved_Party_Selection_Button, 100);
        }



        public string getWitnessDropdownValue()
        {
            CommonHelpers.ScrollUp(driver);
            CommonHelpers.WaitForElementVisiblity(driver, isExtRefDropdn, 30);
            var dropdown = new SelectElement(driver.FindElement(isExtRefDropdn));
            var option = dropdown.SelectedOption.Text;
            return option;

        }

    }
}
