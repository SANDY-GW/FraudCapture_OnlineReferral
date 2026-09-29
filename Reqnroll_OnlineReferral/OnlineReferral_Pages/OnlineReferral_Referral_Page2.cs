using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private readonly By errorMessage = By.XPath("//span[@id='incidentEndDt_Error']");
        private readonly By errorMessageStartDate = By.XPath("//span[@id='incidentStartDt_Error']");


        // In GetOriginalDetectionDate, replace _wait with Wait and fix usage:


        #endregion

        public string GetOriginalDetectionDate()
        {
            var value = "";
            if (originalDetectionDateField != null)
            {
                CommonHelpers.WaitForElementVisiblity(driver, originalDetectionDateField, 30);

                value = driver.FindElement(originalDetectionDateField).GetAttribute("value")?.Trim();
                Console.WriteLine($"Original Detection Date field value: '{value}'");

            }


            return value;
        }

        public void SelectRefType(string RefType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, refTypeDropdn, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(refTypeDropdn), RefType);

        }



        public void SelectInvolvedPartyType(string InvolvedPartyType)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(involvedPartyTypeDropdn), InvolvedPartyType);
        }

        public void EnterHowWasThisDetected(string Detected)
        {
            driver.FindElement(detectedField).Clear();
            driver.FindElement(detectedField).SendKeys(Detected);
        }
        public void EnterReferralSummary(string ReferralSummary)
        {
            driver.FindElement(referralSummaryField).Clear();
            driver.FindElement(referralSummaryField).SendKeys(ReferralSummary);
        }
        public void EnterCase_Or_Reference_Or_TrackingNumber(string Case_Or_Reference_Or_TrackingNumber)
        {
            driver.FindElement(case_Or_Reference_Or_TrackingNumberField).Clear();
            driver.FindElement(case_Or_Reference_Or_TrackingNumberField).SendKeys(Case_Or_Reference_Or_TrackingNumber);
        }
        public bool VerifyIfCountyDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(driver, driver.FindElement(County_Or_DistrictDropdn));
        }

        public void EnterEstimatedAmount(string EstimatedAmount)
        {
            driver.FindElement(estimatedAmountField).Clear();
            driver.FindElement(estimatedAmountField).SendKeys(EstimatedAmount);
        }

        public void EnterOriginalDetectionDate(string OriginalDetectionDate)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 60);
            driver.FindElement(originalDetectionDateField).Click();
            var element = driver.FindElement(originalDetectionDateField);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Delete);
            driver.FindElement(originalDetectionDateField).SendKeys(OriginalDetectionDate);
        }
        public void EnterIncidentStartDate(string IncidentStartDate)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 60);
            CommonHelpers.EnterDate(driver.FindElement(incidentStartDateField), IncidentStartDate);
        }

        public void EnterIncidentEndDate(string IncidentEndDate)
        {
            CommonHelpers.WaitForElementVisiblity(driver, incidentEndDateField, 60);

            CommonHelpers.EnterDate(driver.FindElement(incidentEndDateField), IncidentEndDate);
        }


        public void SelectState_Or_Territory(string State_Or_Territory)

        {
            CommonHelpers.WaitForElementVisiblity(driver, state_Or_TerritoryDropdowm, 30);
            CommonHelpers.selectOptionByValue(driver.FindElement(state_Or_TerritoryDropdowm), State_Or_Territory);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
        public void SelectCounty_Or_District(string County_Or_District)
        {
            CommonHelpers.WaitForElementVisiblity(driver, County_Or_DistrictDropdn, 30);
            CommonHelpers.selectOptionByValue(driver.FindElement(County_Or_DistrictDropdn), County_Or_District);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void ClickGoToPreviousSectionButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 20);
            driver.FindElement(Go_To_Previous_SectionButton).Click();
        }

        public void ClickProceedToNextSectionButton()
        {
            CommonHelpers.ScrollUp(driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, proceed_To_Next_SectionButton, 70);
            CommonHelpers.ScrollToElement(driver, proceed_To_Next_SectionButton);
            driver.FindElement(proceed_To_Next_SectionButton).Click();
            CommonHelpers.WaitForElementVisiblity(driver, Go_To_Previous_SectionButton, 70);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 70);
        }


        public void ClickInstructionsButton()
        {
            CommonHelpers.WaitForInstructionsButton(driver, 10);
            driver.FindElement(instructionsButton).Click();
        }

        //Error Message Validation for Referral Incident Start Date and End Date


        public string GetErrorMessage()
        {
            return driver.FindElement(errorMessage).Text;
        }

        public string GetErrorMessageStartDate()
        {
            return driver.FindElement(errorMessageStartDate).Text;
        }



        // Method to get field value
        public string GetAmountValue()
        {
            return driver.FindElement(estimatedAmountField).GetAttribute("value");
        }
        public bool ValidateTheAmountField()
        {
            var PG2 = new OnlineReferral_Referral_Page2(driver);
            string value = PG2.GetAmountValue();
            return value.Contains("$");
        }

        public string GetValidationDateErrorMessage()
        {
            return CommonHelpers.GetValidationDateErrorText(driver);
        }

        public bool IsValidationDateErrorDisplayed()
        {
            return CommonHelpers.ValidationDateerrorExists(driver);
        }

        public bool VerifyIfReferralDropdownIsInAlphabeticalOrder()
        {
            return CommonHelpers.IsDropdoenListInAlphabeticOrder(driver, driver.FindElement(refTypeDropdn));
        }

    }
}