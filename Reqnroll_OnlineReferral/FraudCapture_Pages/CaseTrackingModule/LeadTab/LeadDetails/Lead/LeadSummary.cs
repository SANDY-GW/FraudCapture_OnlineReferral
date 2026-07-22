using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadSummary : BaseSettings
    {
        public LeadSummary(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By alternateLeadIdTxt = By.XPath("//*[@id='altleadId']");
        private readonly By leadTypeDDL = By.XPath("//*[@id='leadCaseTypeEditNR']");
        private readonly By leadStatusDDL = By.XPath("//*[@id='leadStatusNR']");
        private readonly By leadAssignedToDDL = By.XPath("//*[@id=\"dropdownMenuLeadAssign\"]");
        private readonly By leadSupervisorDDL = By.XPath("//*[@id='dropdownMenuLeadSupervisorAssign']");
        private readonly By leadDivDeptDDL = By.XPath("//*[@id='divisiondep']");
        private readonly By leadSectionTeamDDL = By.XPath("//*[@id='SectionId']");
        private readonly By summaryTab = By.XPath("//*[self::a or self::button][normalize-space()='Summary']");
        private readonly By leadCreatedDate = By.XPath("//label[contains(normalize-space(.),'Lead Created Date')]/following::input[1]");
        private readonly By suspectActivityFrom = By.XPath("//label[contains(normalize-space(.),'Suspect Activity From')]/following::input[1]");
        private readonly By suspectActivityTo = By.XPath("//label[contains(normalize-space(.),'Suspect Activity To')]/following::input[1]");
        private readonly By potentialOverpaymentAmount = By.XPath("//label[contains(normalize-space(.),'Potential Overpayment Amount')]/following::input[1]");
        //private readonly By primarySubjectRow = By.XPath("//table[.//th[contains(normalize-space(.),'Subject')]]/tbody/tr[1]");
        private readonly By primarySubjectTable = By.XPath("//table[@id='caseViewSummarySubjectName']//tbody");
        private readonly By primarySubjectRow = By.XPath("//table[@id='caseViewSummarySubjectName']//tbody/tr[1]");

        #endregion
        public void ClickSummaryTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, summaryTab, 100);
            Driver.FindElement(summaryTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        public string GetLeadCreatedDate() => GetValue(leadCreatedDate);
        public string GetSuspectActivityFrom() => GetValue(suspectActivityFrom);
        public string GetSuspectActivityTo() => GetValue(suspectActivityTo);
        public string GetPotentialOverpaymentAmount() => GetValue(potentialOverpaymentAmount);

        public string GetPrimarySubjectRowText()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, primarySubjectRow, 30);

            var rows = Driver.FindElements(By.XPath("//table[@id='caseViewSummarySubjectName']//tbody/tr"));
            if (rows.Count > 1)
            {
                for (int i = 1; i <= rows.Count; i++)
                {
                    var rowNum = Driver.FindElement(By.XPath($"//table[@id='caseViewSummarySubjectName']//tbody/tr[{i}]/td[2]"));
                    if (rowNum.Text.Trim().Contains("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        return rows[i - 1].Text.Trim();
                    }
                }
            }
            

            return Driver.FindElement(primarySubjectRow).Text.Trim();



        }

        private string GetValue(By locator)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, locator, 30);
            IWebElement element = Driver.FindElement(locator);
            return (element.GetAttribute("value") ?? element.Text).Trim();
        }

        public void SelectSectionTeam(string sectionId)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSectionTeamDDL), sectionId);
        }
        public void EnterAlernateLeadID(string altLeadID)
        {
            Driver.FindElement(alternateLeadIdTxt).SendKeys(altLeadID);
        }
        public void SelectLeadType(string leadType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadTypeDDL), leadType);
        }
        public void SelectLeadStatus(string leadStatus)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadStatusDDL), leadStatus);
        }
        public void SelectAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadAssignedToDDL), assignedTo);
        }
        public void SelectSuperVisior(string supervisior)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSupervisorDDL), supervisior);
        }
        public void SelectDivDept(string divDept)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadDivDeptDDL), divDept);
        }
    }
}
