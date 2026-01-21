using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class OnlineReferral_Referral_Page2 : BaseSettings
    {
        public OnlineReferral_Referral_Page2(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        #region Elements

        private readonly By refTypeDropdn = By.XPath("//select[@id='referalType']");
        private readonly By involvedPartyTypeDropdn = By.XPath("//select[@id='involvedType']");
        private readonly By detectedField = By.XPath("//input[@id='detected']");
        private readonly By referralSummaryField = By.XPath("//input[@id='referralSummary']");
        private readonly By case_Or_Reference_Or_TrackingNumberField = By.XPath("//input[@id='trackingNumber']");
        private readonly By estimatedAmountField = By.XPath("//input[@id='estimatedAmount']");
        private readonly By originalDetectionDateField = By.XPath("//input[@name='originalDetectionDt']");
        private readonly By incidentStartDateField = By.XPath("//input[@name='incidentStartDt']");
        private readonly By incidentEndDateField = By.XPath("//input[@name='incidentEndDt']");
        private readonly By state_Or_TerritoryDropdowm = By.XPath("//select[@id='state']");
        private readonly By County_Or_DistrictDropdn = By.XPath("//select[@id='county']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[text()='Go to Previous Section']");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[text()='Proceed to Next Section']");
        private readonly By instructionsButton = By.XPath("//button[text()='Instructions']");

        #endregion


        public void SelectRefType(string RefType)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, refTypeDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(refTypeDropdn), RefType);

        }
        public void SelectInvolvedPartyType(string InvolvedPartyType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(involvedPartyTypeDropdn), InvolvedPartyType);
        }

        public void EnterDetectedDate(string DetectedDate)
        {
            Driver.FindElement(detectedField).SendKeys(DetectedDate);
        }
        public void EnterReferralSummary(string ReferralSummary)
        {
            Driver.FindElement(referralSummaryField).SendKeys(ReferralSummary);
        }
        public void EnterCase_Or_Reference_Or_TrackingNumber(string Case_Or_Reference_Or_TrackingNumber)
        {
            Driver.FindElement(case_Or_Reference_Or_TrackingNumberField).SendKeys(Case_Or_Reference_Or_TrackingNumber);
        }

        public void EnterEstimatedAmount(string EstimatedAmount)
        {
            Driver.FindElement(estimatedAmountField).SendKeys(EstimatedAmount);
        }

        public void EnterOriginalDetectionDate(string OriginalDetectionDate)
        {
            Driver.FindElement(originalDetectionDateField).SendKeys(OriginalDetectionDate);
        }
        public void EnterIncidentStartDate(string IncidentStartDate)
        {
            Driver.FindElement(incidentStartDateField).SendKeys(IncidentStartDate);
        }

        public void EnterIncidentEndDate(string IncidentEndDate)
        {
            Driver.FindElement(incidentEndDateField).SendKeys(IncidentEndDate);
        }

        public void SelectState_Or_Territory(string State_Or_Territory)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(state_Or_TerritoryDropdowm), State_Or_Territory);
        }
        public void SelectCounty_Or_District(string County_Or_District)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(County_Or_DistrictDropdn), County_Or_District);
        }

        public void ClickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForInstructionsButton(Driver, 10);
            Driver.FindElement(Go_To_Previous_SectionButton).Click();
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.WaitForInstructionsButton(Driver, 10);
            Driver.FindElement(proceed_To_Next_SectionButton).Click();
        }


        public void ClickInstructionsButton()
        {
            CommonHelpers.WaitForInstructionsButton(Driver, 10);
            Driver.FindElement(instructionsButton).Click();
        }
    }
}
