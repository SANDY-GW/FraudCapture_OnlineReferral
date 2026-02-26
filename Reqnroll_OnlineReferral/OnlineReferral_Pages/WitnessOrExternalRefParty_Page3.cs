using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class WitnessOrExternalRefParty_Page3 : BaseSettings
    {
        public WitnessOrExternalRefParty_Page3(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By isExtRefDropdn = By.XPath("//select[@id='isExternalReferal']");
        private readonly By witnessFirstNameField = By.XPath("//input[@id='wFirstName']");
        private readonly By witnessLastNameField = By.XPath("//input[@id='wLastName']");
        private readonly By witnessorg_Or_AgencyNameField = By.XPath("//input[@id='wAgencyName']");
        private readonly By witnessRelationshipField = By.XPath("//input[@id='wRelationShip']");
        private readonly By witnessPhoneNumberField = By.XPath("//input[@id='phone']");
        private readonly By witnessEmailField = By.XPath("//input[@id='email']");
        private readonly By witnessAddress1 = By.XPath("//input[@id='wAddress1']");
        private readonly By witnessAddress2 = By.XPath("//input[@id='wAddress2']");
        private readonly By witnessCity = By.XPath("//input[@id='city']");
        private readonly By witnessState = By.XPath("//select[@id='state']");
        private readonly By witnessZipCode = By.XPath("//input[@id='zip']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(text(),'Go To Previous Section')]");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[contains(text(),'Proceed to Next Section')]");
        private readonly By orgNameField = By.XPath("//input[@id='pOrgName']");





        #endregion

        public void SelectisExtRefType(string isExtRefAvailable)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, isExtRefDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(isExtRefDropdn), isExtRefAvailable);

        }

        public void EnterWitnessFirstName(string firstName)
        {
            Driver.FindElement(witnessFirstNameField).SendKeys(firstName);
        }


        public void EnterWitnessLastName(string lastName)
        {
            Driver.FindElement(witnessLastNameField).SendKeys(lastName);

        }
        public void EnterWitnessOrgAgencyName(string orgAgencyName)
        {
            Driver.FindElement(witnessorg_Or_AgencyNameField).SendKeys(orgAgencyName);
        }
        public void EnterWitnessRelationship(string relationship)
        {
            Driver.FindElement(witnessRelationshipField).SendKeys(relationship);
        }
        public void EnterWitnessPhoneNumber(string phoneNumber)
        {
            Driver.FindElement(witnessPhoneNumberField).SendKeys(phoneNumber);
        }
        public void EnterWitnessEmail(string email)
        {
            Driver.FindElement(witnessEmailField).SendKeys(email);
        }
        public void EnterWitnessAddress1(string address1)
        {
            Driver.FindElement(witnessAddress1).SendKeys(address1);
        }
        public void EnterWitnessAddress2(string address2)
        {
            Driver.FindElement(witnessAddress2).SendKeys(address2);

        }
        public void EnterWitnessCity(string city)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, witnessCity, 10);
            Driver.FindElement(witnessCity).SendKeys(city);
        }

        public void SelectWitnessState(string state)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, witnessState, 100);
            CommonHelpers.selectOptionByValue(Driver.FindElement(witnessState), state);

        }
        public void EnterWitnessZipCode(string zipCode)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, witnessZipCode, 100);
            Driver.FindElement(witnessZipCode).SendKeys(zipCode);

        }
        public void ClickProceedToNextSectionButton()
        {

            CommonHelpers.WaitForElementVisiblity(Driver, proceed_To_Next_SectionButton, 500);

            Driver.FindElement(proceed_To_Next_SectionButton).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 5000);

        }



    }

}
