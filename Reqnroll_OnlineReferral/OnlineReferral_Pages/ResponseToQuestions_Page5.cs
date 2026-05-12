using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class ResponseToQuestions_Page5 : BaseSettings
    {
        public ResponseToQuestions_Page5(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements
        private readonly By doesThisReferralInvolveSpecificPatientDropdn = By.XPath("//select[@id='vpIsParticipant']");
        private readonly By IstheMemberSamePersonAsTheWitnessPartyDropdn = By.XPath("//select[@id='vpIsreferring']");
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
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[text()='Proceed to Next Section']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//b[text()='Go to Previous Section']");

        private readonly By question1 = By.XPath("//select[@id='questiondDrDown1']");
        private readonly By question1TextBox = By.XPath("//textarea[@id='questionTxt1']");

        private readonly By question2 = By.XPath("//textarea[@id='questionTxt2']");
        private readonly By question3 = By.XPath("//select[@id='questiondDrDown3']");
        private readonly By question3Textbox = By.XPath("//textarea[@id='questionTxt3']");
        private readonly By question4 = By.XPath("//textarea[@id='questionTxt4']");
        private readonly By question5 = By.XPath("//select[@id='questiondDrDown5']");
        private readonly By question6 = By.XPath("//textarea[@id='questionTxt6']");
        private readonly By submitReferralButton = By.XPath("//button[text()=' Submit Referral ']");
        private readonly By enterNewReferral = By.XPath("//button[text()='Enter New Referral']");

        #endregion

        public void SelectDoesThisReferralInvolveSpecificPatient(string doesThisReferralInvolveSpecificPatient)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, doesThisReferralInvolveSpecificPatientDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(doesThisReferralInvolveSpecificPatientDropdn), doesThisReferralInvolveSpecificPatient);
        }

        public void SelectIsThisPersonSameASWitness_Or_ExternalParty(string isThePersonsameAswitnessParty)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, IstheMemberSamePersonAsTheWitnessPartyDropdn, 50);
            CommonHelpers.selectOptionByValue(Driver.FindElement(IstheMemberSamePersonAsTheWitnessPartyDropdn), isThePersonsameAswitnessParty);

        }


        public void EnterPatientFirstName(string patientFirstName)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, patientFNfield, 10);
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

        public void SelectQuestion1Dropdown(string answer)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(question1), answer);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 100);");
        }
        public void SelectQuestion1Test(string answer)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, question1TextBox, 100);
            Driver.FindElement(question1TextBox).SendKeys(answer);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 100);");
        }

        public void EnterQuestion2(string answer)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, question2, 100);
            Driver.FindElement(question2).SendKeys(answer);
            
           
            
        }
        public void SelectQuestion3dropdown(string answer)
        {
            
            CommonHelpers.selectOptionByValue(Driver.FindElement(question3), answer);
        }
        public void SelectQuestion3Test(string answer)
        {
            
            CommonHelpers.WaitForElementVisiblity(Driver, question3Textbox, 100);
            Driver.FindElement(question3Textbox).SendKeys(answer);

            

        }
        public void EnterQuestion4(string answer)
        {
            Actions actions = new Actions(Driver);
           // new Actions(Driver).KeyDown(Keys.Control).SendKeys(Keys.PageDown).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 500);");
            CommonHelpers.WaitForElementVisiblity(Driver, question4, 100);

            //Driver.FindElement(question4).Click();
            Driver.FindElement(question4).SendKeys(answer);
            Thread.Sleep(5000);
            
            //CommonHelpers.WaitForElementVisiblity(Driver, question4, 5000);

        }

        public void SelectQuestion5(string answer)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, question5, 100);

            CommonHelpers.selectOptionByValue(Driver.FindElement(question5), answer);
            }
       
        public void EnterQuestion6(string answer)
        {
            Actions actions = new Actions(Driver);
            //new Actions(Driver).KeyDown(Keys.Control).SendKeys(Keys.PageDown).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0, 1000);");
            CommonHelpers.WaitForElementVisiblity(Driver, question6, 100);
           // Driver.FindElement(question6).Click();
            Driver.FindElement(question6).SendKeys(answer);
            Thread.Sleep(5000);


        }


        public void ClickSubmitReferralButton()
        {
            // Instantiate IJavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            // Execute script to scroll to the bottom of the page
            //js.ExecuteScript("window.scrollBy(0, document.body.scrollHeight);");

            Actions actions = new Actions(Driver);
            new Actions(Driver).KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
            Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0, document.body.scrollHeight);");
            Thread.Sleep(5000);
            CommonHelpers.WaitForElementVisiblity(Driver, submitReferralButton, 5000);
            Driver.FindElement(submitReferralButton).Submit();
            CommonHelpers.WaitForElementVisiblity(Driver, enterNewReferral, 5000);
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(Driver);
            CommonHelpers.WaitForElementVisiblity(Driver, proceed_To_Next_SectionButton, 5000);

            Driver.FindElement(proceed_To_Next_SectionButton).Click();
            Thread.Sleep(10000);
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 50000);

        }
    }
}