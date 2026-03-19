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

        #endregion
        //referring party dropdown
        public void SelectIsExternalReferringPartyFromDropdown(string option)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, isExtRefDropdn, 1000);
            var dropdown = new SelectElement(Driver.FindElement(isExtRefDropdn));
            dropdown.SelectByText(option);
        }


        //Name prefix field
        public void FillNamePrefixField(string namePrefix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, namePrefixField, 1000);
            Driver.FindElement(namePrefixField).SendKeys(namePrefix);
        }


        //First name field
        public void FillFirstNameField(string firstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, firstNameField, 1000);
            Driver.FindElement(firstNameField).SendKeys(firstName);
        }

        //Middle name field
        public void FillMiddleNameField(string middleName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, middleNameField, 1000);
            Driver.FindElement(middleNameField).SendKeys(middleName);
        }

        //Last name field
        public void FillLastNameField(string lastName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, lastNameField, 1000);
            Driver.FindElement(lastNameField).SendKeys(lastName);
        }

        //Name suffix field
        public void FillNameSuffixField(string nameSuffix)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, nameSuffixField, 1000);
            Driver.FindElement(nameSuffixField).SendKeys(nameSuffix);
        }

        //Gender field

        public void FillGenderField(string designation)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, genderField, 1000);
            Driver.FindElement(genderField).SendKeys(designation);
        }

        //DOB field
        public void FillDOBField(string dob)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DOBField, 1000);
            Driver.FindElement(DOBField).SendKeys(dob);
        }

        //other field
        public void FillOtherField(string other)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, OtherField, 1000);
            Driver.FindElement(OtherField).SendKeys(other);
        }

        // ID field
        public void FillIDField(string id)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, IDField, 1000);
            Driver.FindElement(IDField).SendKeys(id);
        }

        //SSN field
        public void FillSSNField(string ssn)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SSNField, 1000);
            Driver.FindElement(SSNField).SendKeys(ssn);
        }

        //How did this external referring party report this? 
        public void FillHowDidThisExternalReferringPartyreportThisTextarea(string report)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, HowDidThisExternalReferringPartyreportThisTextarea, 1000);
            Driver.FindElement(HowDidThisExternalReferringPartyreportThisTextarea).SendKeys(report);
        }

        //Any additional information regarding the witness or external referring party
        public void FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(string additionalInfo)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea, 1000);
            Driver.FindElement(AnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea).SendKeys(additionalInfo);
        }


        //Medicaid ID field
        public void FillMedicaidIDField(string medicaidId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, medicaidIDField, 1000);
            Driver.FindElement(medicaidIDField).SendKeys(medicaidId);
        }

        //Medicare ID field
        public void FillMedicareIDField(string medicareId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, medicareIDField, 1000);
            Driver.FindElement(medicareIDField).SendKeys(medicareId);
        }

        //Other ID field
        public void FillOtherIDField(string otherId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, OtherIDField, 1000);
            Driver.FindElement(OtherIDField).SendKeys(otherId);
        }

        //Plan field
        public void FillPlanField(string plan)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, PlanField, 1000);
            Driver.FindElement(PlanField).SendKeys(plan);
        }

        //program field
        public void FillProgramField(string program)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ProgramField, 1000);
            Driver.FindElement(ProgramField).SendKeys(program);
        }

        //LOB field
        public void FillLOBField(string lob)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LOBField, 1000);
            Driver.FindElement(LOBField).SendKeys(lob);
        }
        //Group field
        public void FillGroupField(string group)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, GroupField, 1000);
            Driver.FindElement(GroupField).SendKeys(group);
        }

        //Address1 field
        public void FillAddress1Field(string address1)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address1Field, 1000);
            Driver.FindElement(address1Field).SendKeys(address1);
        }
        //Address2 field
        public void FillAddress2Field(string address2)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, address2Field, 1000);
            Driver.FindElement(address2Field).SendKeys(address2);
        }
        //City field
        public void FillCityField(string city)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, cityField, 5000);
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
            Driver.FindElement(zipCodeField).SendKeys(zipCode);
        }

        //primary phone number field
        public void FillPrimaryPhoneNumberField(string primaryPhoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, primaryPhoneNumberField, 1000);
            Driver.FindElement(primaryPhoneNumberField).SendKeys(primaryPhoneNumber);
        }

        //Secondary phone number field
        public void FillSecondaryPhoneNumberField(string secondaryPhoneNumber)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, secondaryPhoneNumberField, 1000);
            Driver.FindElement(secondaryPhoneNumberField).SendKeys(secondaryPhoneNumber);
        }

        //Email field
        public void FillEmailField(string email)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, emailField, 1000);
            Driver.FindElement(emailField).SendKeys(email);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
            Thread.Sleep(5000);

        }

        //Click on  continue_with_Involved_Party_Selection_Button

        public void ClickProceedToNextSectionButton()
        {
            Thread.Sleep(5000);

            CommonHelpers.WaitForElementVisiblity(Driver, continue_with_Involved_Party_Selection_Button, 5000);

            Driver.FindElement(continue_with_Involved_Party_Selection_Button).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 10000);

        }



    }
}
