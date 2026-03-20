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
        private readonly By detectedField = By.XPath("//textarea[@id='detected']");
        private readonly By referralSummaryField = By.XPath("//textarea[@id='referralSummary']");
        private readonly By case_Or_Reference_Or_TrackingNumberField = By.XPath("//input[@id='trackingNumber']");
        private readonly By estimatedAmountField = By.XPath("//input[@id='estimatedAmount']");
        private readonly By originalDetectionDateField = By.XPath("//input[@name='originalDetectionDt']");
        private readonly By incidentStartDateField = By.XPath("//input[@name='incidentStartDt']");
        private readonly By incidentEndDateField = By.XPath("//input[@name='incidentEndDt']");
        private readonly By state_Or_TerritoryDropdowm = By.XPath("//select[@id='state']");
        private readonly By County_Or_DistrictDropdn = By.XPath("//select[@id='county']");
        private readonly By Go_To_Previous_SectionButton = By.XPath("//button[contains(text(),'Go to Previous Section')]");
        private readonly By proceed_To_Next_SectionButton = By.XPath("//button[contains(text(),'Proceed to Next Section')]");
        private readonly By proceed_To_Next_SectionButton_end = By.XPath("//form[@class='userForm ng-dirty ng-valid ng-touched']//button[contains(text(),'Proceed to Next Section')]");
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

        public void EnterHowWasThisDetected(string Detected)
        {
            Driver.FindElement(detectedField).Clear();
            Driver.FindElement(detectedField).SendKeys(Detected);
        }
        public void EnterReferralSummary(string ReferralSummary)
        {
            Driver.FindElement(referralSummaryField).Clear();
            Driver.FindElement(referralSummaryField).SendKeys(ReferralSummary);
        }
        public void EnterCase_Or_Reference_Or_TrackingNumber(string Case_Or_Reference_Or_TrackingNumber)
        {
            Driver.FindElement(case_Or_Reference_Or_TrackingNumberField).Clear();
            Driver.FindElement(case_Or_Reference_Or_TrackingNumberField).SendKeys(Case_Or_Reference_Or_TrackingNumber);
        }

        public void EnterEstimatedAmount(string EstimatedAmount)
        {
            Driver.FindElement(estimatedAmountField).Clear();
            Driver.FindElement(estimatedAmountField).SendKeys(EstimatedAmount);
        }

        public void EnterOriginalDetectionDate(string OriginalDetectionDate)
        {
            Driver.FindElement(originalDetectionDateField).Clear();
            Driver.FindElement(originalDetectionDateField).SendKeys(OriginalDetectionDate);
        }
        public void EnterIncidentStartDate(string IncidentStartDate)
        {
            Driver.FindElement(incidentStartDateField).Clear();
            Driver.FindElement(incidentStartDateField).SendKeys(IncidentStartDate);
        }

        public void EnterIncidentEndDate(string IncidentEndDate)
        {
            Driver.FindElement(incidentEndDateField).Clear();
            Driver.FindElement(incidentEndDateField).SendKeys(IncidentEndDate);
        }

        public void SelectState_Or_Territory(string State_Or_Territory)

        {
            CommonHelpers.WaitForElementVisiblity(Driver, state_Or_TerritoryDropdowm, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(state_Or_TerritoryDropdowm), State_Or_Territory);
        }
        public void SelectCounty_Or_District(string County_Or_District)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, County_Or_DistrictDropdn, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(County_Or_DistrictDropdn), County_Or_District);
        }

        public void ClickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 20);
            Driver.FindElement(Go_To_Previous_SectionButton).Click();
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(Driver);
            //CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 500);
            CommonHelpers.WaitForElementVisiblity(Driver, proceed_To_Next_SectionButton, 70);
            CommonHelpers.ScrollToElement(Driver, proceed_To_Next_SectionButton);
            Driver.FindElement(proceed_To_Next_SectionButton).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, Go_To_Previous_SectionButton, 70);

        }


        public void ClickInstructionsButton()
        {
            CommonHelpers.WaitForInstructionsButton(Driver, 10);
            Driver.FindElement(instructionsButton).Click();
        }
    }
}
