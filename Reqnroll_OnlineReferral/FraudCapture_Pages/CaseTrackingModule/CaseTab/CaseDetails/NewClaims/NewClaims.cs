using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.NewClaims
{
    public class NewClaims : BaseSettings
    {
        public NewClaims(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By newClaimsBtn = By.XPath("//*[@id='btnNewClaims']");
        private readonly By claimsBtn = By.XPath("//*[@id='ClaimNewTabId']");

        private readonly By samplingAndSelectionHistoryBtn = By.XPath("//*[@id='samplingTabId']");
        private readonly By subjectAndClaimsSelectionBtn = By.XPath("//*[@id=\"claimNewTab\"]/div/div[2]/div[1]/div[1]/button");
        private readonly By caseClaimsDetailsAndFindingsBtn = By.XPath("//*[@id=\"claimNewTab\"]/div/div[2]/div[2]/div/button[1]");
        private readonly By ThreeYearsPatientClaimsHistory = By.XPath("//*[@id=\"claimNewTab\"]/div/div[2]/div[2]/div/button[2]");
        private readonly By applySameFindingsToCaseLevel = By.XPath("//*[@id=\"claimNewTab\"]/div/div[3]/div/button[1]");
        private readonly By ReSelectClaims = By.XPath("//*[@id='reselectClaimsBtn']");
        private readonly By refresh = By.XPath("//*[@id='refreshBtn']");
        private readonly By ClaimsReviewAssignment = By.XPath("//*[@id=\"claimsReviewAssignmentButton\"]");


        private readonly By assignedToDDL = By.XPath("//*[@id=\"dropdownActivityListUser\"]");
        private readonly By subjectDDL = By.XPath("//*[@id='dropdownclaimsSubject']");
        private readonly By statusDDL = By.XPath("//*[@id='claimStatus']");
        private readonly By reApplyDefaultFilters = By.XPath("//*[@id=\"reapplyActivityFiltersId\"]");

        private readonly By claimsCriteriaDDL = By.XPath("//*[@id=\"relatedCasesSearchType\"]/option[1]");
        /* private readonly By subjectDDL = By.XPath("//*[@id='dropdownclaimsSubject']");
         private readonly By statusDDL = By.XPath("//*[@id='claimStatus']");
         private readonly By reApplyDefaultFilters = By.XPath("//*[@id=\"reapplyActivityFiltersId\"]");
 */
        #endregion

        public void ClickApplySameFindingsToCaseLevel()
        {
            driver.FindElement(applySameFindingsToCaseLevel).Click();
        }
        public void ClickReSelectClaims()
        {
            driver.FindElement(ReSelectClaims).Click();
        }
        public void ClickClaimsReviewAssignment()
        {
            driver.FindElement(ClaimsReviewAssignment).Click();
        }
        public void SelectClaimsCriteria(string criteria)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(claimsCriteriaDDL), criteria);
        }
        public void ClickReApplyDefaultFilters()
        {
            driver.FindElement(reApplyDefaultFilters).Click();
        }
        public void SelectStatus(string status)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(statusDDL), status);
        }

        public void SelectSubject(string subject)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(subjectDDL), subject);
        }
        public void SelectAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(assignedToDDL), assignedTo);
        }
        public void ClickRefresh()
        {
            driver.FindElement(refresh).Click();
        }
        public void ClickSubjectAndClaimsSelection()
        {
            driver.FindElement(subjectAndClaimsSelectionBtn).Click();
        }
        public void ClickThreeYearsPatientClaimsHistory()
        {
            driver.FindElement(ThreeYearsPatientClaimsHistory).Click();
        }
        public void ClickCaseClaimsDetailsAndFindings()
        {
            driver.FindElement(caseClaimsDetailsAndFindingsBtn).Click();
        }
        public void ClickSamplingAndSelectionHistory()
        {
            driver.FindElement(samplingAndSelectionHistoryBtn).Click();
        }
        public void ClickClaims()
        {
            driver.FindElement(claimsBtn).Click();
        }
        public void ClickNewClaimsBtn()
        {
            driver.FindElement(newClaimsBtn).Click();
        }
    }
}
