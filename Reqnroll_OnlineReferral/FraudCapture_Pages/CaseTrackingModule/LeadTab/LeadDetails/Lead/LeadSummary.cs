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
        private readonly By primarySubjectRow = By.XPath("//table[.//th[contains(normalize-space(.),'Subject')]]/tbody/tr[1]");
        private readonly By primarySubjectTable = By.XPath("//table[@id='caseViewSummarySubjectName']//tbody");
        //private readonly By primarySubjectRow = By.XPath("//table[@id='caseViewSummarySubjectName']//tbody/tr[1]");



        // Lead Summary Fields
        private readonly By leadIdField = By.XPath("//label[contains(normalize-space(.),'Lead ID')]/following::input[1]");
        private readonly By leadTypeField = By.XPath("//label[contains(normalize-space(.),'Lead Type')]/following::select[1]");
        private readonly By leadStatusField = By.XPath("//label[contains(normalize-space(.),'Lead Status')]/following::select[1]");
        private readonly By subjectField = By.XPath("//label[contains(normalize-space(.),'Subject')]/following::input[1]");
        private readonly By assignedToField = By.XPath("//label[contains(normalize-space(.),'Assigned To')]/following::select[1]");
        private readonly By assignedSupervisorField = By.XPath("//label[contains(normalize-space(.),'Assigned Supervisor')]/following::select[1]");
        private readonly By departmentDivisionField = By.XPath("//label[contains(normalize-space(.),'Department/Division')]/following::select[1]");
        private readonly By sectionTeamField = By.XPath("//label[contains(normalize-space(.),'Section/Team')]/following::select[1]");
        private readonly By leadPriorityField = By.XPath("//label[contains(normalize-space(.),'Lead Priority')]/following::input[1]");
        private readonly By lineOfBusinessField = By.XPath("//label[contains(normalize-space(.),'Line Of Business')]/following::input[1]");
        private readonly By leadDescriptionField = By.XPath("//label[contains(normalize-space(.),'Lead Description')]/following::textarea[1]");
        private readonly By leadCreatedDateField = By.XPath("//label[contains(normalize-space(.),'Lead Created Date')]/following::input[1]");
        private readonly By leadClosedDateField = By.XPath("//label[contains(normalize-space(.),'Lead Closed Date')]/following::input[1]");
        private readonly By suspectActivityFromField = By.XPath("//label[contains(normalize-space(.),'Suspect Activity From')]/following::input[1]");
        private readonly By suspectActivityToField = By.XPath("//label[contains(normalize-space(.),'Suspect Activity To')]/following::input[1]");
        private readonly By potentialOverpaymentAmountField = By.XPath("//label[contains(normalize-space(.),'Potential Overpayment Amount')]/following::input[1]");


        #endregion



        

        public void ClickSummaryTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, summaryTab, 100);
            Driver.FindElement(summaryTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        public string GetLeadCreatedDate() => GetValue(leadCreatedDateField);
        public string GetSuspectActivityFrom() => GetValue(suspectActivityFromField);
        public string GetSuspectActivityTo() => GetValue(suspectActivityToField);
        public string GetPotentialOverpaymentAmount() => GetValue(potentialOverpaymentAmountField);

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

        // Getter methods for all fields
        public string GetLeadId() => GetFieldValue(leadIdField);
        public string GetLeadType() => GetFieldValue(leadTypeField);
        public string GetLeadStatus() => GetFieldValue(leadStatusField);
        public string GetSubject() => GetFieldValue(subjectField);
        public string GetAssignedTo() => GetFieldValue(leadAssignedToDDL);
        public string GetAssignedSupervisor() => GetFieldValue(leadSupervisorDDL);
        public string GetDepartmentDivision() => GetFieldValue(leadDivDeptDDL);
        public string GetSectionTeam() => GetFieldValue(leadSectionTeamDDL);
        public string GetLeadPriority() => GetFieldValue(leadPriorityField);
        public string GetLineOfBusiness() => GetFieldValue(lineOfBusinessField);
        public string GetLeadDescription() => GetFieldValue(leadDescriptionField);
        public string GetleadCreatedDateField() => GetFieldValue(leadCreatedDate);
        public string GetLeadClosedDate() => GetFieldValue(leadClosedDateField);
        public string GetSuspectActivityFromField() => GetFieldValue(suspectActivityFromField);
        public string GetSuspectActivityToField() => GetFieldValue(suspectActivityToField);
        public string GetPotentialOverpaymentAmountField() => GetFieldValue(potentialOverpaymentAmountField);

        private string GetFieldValue(By locator)
        {
            try
            {
                CommonHelpers.WaitForElementVisiblity(Driver, locator, 10);
                IWebElement element = Driver.FindElement(locator);
                return (element.GetAttribute("value") ?? element.Text).Trim();
            }
            catch
            {
                return string.Empty;
            }
        }

        // Dictionary method to get all dropdown values
        public Dictionary<string, string> GetAllLeadSummaryData()
        {
            return new Dictionary<string, string>
            {
                { "Lead ID", GetLeadId() },
                { "Lead Type", GetLeadType() },
                { "Lead Status", GetLeadStatus() },
                { "Subject", GetSubject() },
                { "Assigned To", GetAssignedTo() },
                { "Assigned Supervisor", GetAssignedSupervisor() },
                { "Department/Division", GetDepartmentDivision() },
                { "Section/Team", GetSectionTeam() },
                { "Lead Priority", GetLeadPriority() },
                { "Line Of Business", GetLineOfBusiness() },
                { "Lead Description", GetLeadDescription() },
                { "Lead Created Date", GetLeadCreatedDate() },
                { "Lead Closed Date", GetLeadClosedDate() },
                { "Suspect Activity From", GetSuspectActivityFrom() },
                { "Suspect Activity To", GetSuspectActivityTo() },
                { "Potential Overpayment Amount", GetPotentialOverpaymentAmount() }
            };
        }
    }
}
