using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    internal class ResponseToQuestions_Page5 : BaseSettings
    {
        public ResponseToQuestions_Page5(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By doesThisReferralInvolveSpecificPatientDropdn = By.XPath("//select[@id='vpIsParticipant']");
        private readonly By patientFNfield = By.XPath("//input[@id='paFirstName']");
        private readonly By patientLNfield = By.XPath("//input[@id='paLastName']");
        private readonly By memberIDfield = By.XPath("//input[@id='paID']");
        private readonly By dateOfBirthfield = By.XPath("//input[@name='paDOB']");
        private readonly By program_Or_Plan_Type_Field = By.XPath("//input[@id='paPlanType']");
        private readonly By phoneNumberField = By.XPath("//input[@id='paPhone']");
        private readonly By emailField = By.XPath("//input[@id='paEmail']");
        private readonly By address1Field = By.XPath("//input[@id='paAddress1']");
        private readonly By address2Field = By.XPath("//input[@id='paAddress2']");
        private readonly By cityField = By.XPath("//input[@id='paCity']");
        private readonly By stateDropdown = By.XPath("//select[@id='paState']");
        private readonly By countyDropdown = By.XPath("//select[@id='paCounty']");
        private readonly By zipCodeField = By.XPath("//input[@id='paZip']");
        private readonly By countryField = By.XPath("//input[@id='paCountry']");
       
        private readonly By question1 = By.XPath("//textarea[@id='questionTxt1']");
        private readonly By question2 = By.XPath("//textarea[@id='questionTxt2']");
        private readonly By question3 = By.XPath("//textarea[@id='questionTxt3']");
        private readonly By submitReferralButton = By.XPath("//button[text()=' Submit Referral ']");

        #endregion

        public void SelectDoesThisReferralInvolveSpecificPatient(string doesThisReferralInvolveSpecificPatient)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, doesThisReferralInvolveSpecificPatientDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(doesThisReferralInvolveSpecificPatientDropdn), doesThisReferralInvolveSpecificPatient);
        }
        public void EnterPatientFirstName(string patientFirstName)
        {
            Driver.FindElement(patientFNfield).SendKeys(patientFirstName);
        }
        public void EnterPatientLastName(string patientLastName)
        {
            Driver.FindElement(patientLNfield).SendKeys(patientLastName);

        }

        public void EnterMemberID(string memberID)
        {
            Driver.FindElement(memberIDfield).SendKeys(memberID);
        }
        public void EnterDateOfBirth(string dateOfBirth)
        {
            Driver.FindElement(dateOfBirthfield).SendKeys(dateOfBirth);
        }

        public void EnterProgram_Or_Plan_Type(string program_Or_Plan_Type)
        {
            Driver.FindElement(program_Or_Plan_Type_Field).SendKeys(program_Or_Plan_Type);
        }
        public void EnterPhoneNumber(string phoneNumber)
        {
            Driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
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
       

        public void EnterQuestion1Response(string response1)
        {
            Driver.FindElement(question1).SendKeys(response1);
        }
        public void EnterQuestion2Response(string response2)
        {
            Driver.FindElement(question2).SendKeys(response2);
        }
        public void EnterQuestion3Response(string response3)
        {
            Driver.FindElement(question3).SendKeys(response3);
        }
        public void ClickSubmitReferralButton()
        {
            Driver.FindElement(submitReferralButton).Click();
        }
    }
}