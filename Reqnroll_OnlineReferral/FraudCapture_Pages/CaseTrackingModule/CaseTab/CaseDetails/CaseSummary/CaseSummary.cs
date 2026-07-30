using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Case
{
    public class CaseSummary : BaseSettings
    {
        public CaseSummary(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By caseTab = By.XPath("//*[@id='caseTabId']");
        private readonly By caseSummaryTab = By.XPath("//*[@id='summaryTabId']");
        private readonly By subjectNewTab = By.XPath("//*[@id='subjectNewTabId']");

        private readonly By relatedCasesTab = By.XPath("//*[@id='relatedCasesId']");
        private readonly By auditLogTab = By.XPath("//*[@id='auditlogTabId']");
        private readonly By editSubjectBtn = By.XPath("//*[@id='SubjectsNew0C110C20']");
        private readonly By deleteSubjectBtn = By.XPath("//*[@id='SubjectsNew0C110C21']");
        private readonly By caseViewSummaryAssignedToGorupDDL = By.XPath("//*[@id='caseViewSummaryAssignedToGroup']");
        private readonly By caseViewSummaryReferencedTxt = By.XPath("//*[@id='caseViewSummaryReferenceId']");
        private readonly By caseAssignedSupervisorDDL = By.XPath("//*[@id='caseAssignedSupervisorDisplayname']");
        private readonly By BeginEditingButton = By.XPath("//*[@id='caseViewEditEndButton']");
        private readonly By EndEditingButton = By.XPath("//*[@id='caseViewEditBeginButton']");

        //case Summary Fields 
        private readonly By caseIDField = By.XPath("//input[@id='caseViewSummaryCaseId']");
        private readonly By alternateCaseIDField = By.XPath("//input[@id='caseViewSummaryReferenceId']");
        private readonly By CaseTypeDropdown = By.XPath("//select[@id='caseViewSummaryCaseTypeNR']");
        private readonly By CaseStatusDropdown = By.XPath("//select[@id='caseViewSummaryCaseStatusInfoNR']");
        private readonly By subjectNameField = By.XPath("*//tbody/tr/td/span/a");

        private readonly By AssignedToDropdownButtonField = By.XPath("//button[@id='dropdownMenuCaseAssigned']");
        //private readonly By AssignedToDropdownValueField = By.XPath("//div[@id='caseViewAssignedToDiv']/ul/li/a[contains(.,'" + keyword + "')]");
        private readonly By AssignedsupervisorDropdownButtonField = By.XPath("//button[@id='dropDownMenuCaseAssignedSupervisor']");
        //private readonly By AssignedsupervisorDropdownvalueField = By.XPath("//div[@id='dropDownMenuCaseAssignedSupervisor']/ul/li/a[contains(.,'" + keyword + "')]");
        private readonly By Department_Or_DivisionDropdownButtonField = By.XPath("//div[@id='caseViewDepartmentsDivisons']/button");
        //private readonly By Department_Or_DivisionDropdownValueField = By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a[contains(.,'" + keyword + "')]");

        private readonly By Section_Or_Teams_Button_Field = By.XPath("//div[@id='caseViewSections']/button");
        // private readonly By Section_Or_Teams_Value_Field = By.XPath("//div[@id='caseViewSections']/ul/li/a[contains(.,'" + keyword + "')]");
        private readonly By ProjectField = By.XPath("//input[@id='projectName']");
        private readonly By LineOFBusinessCheckBox = By.XPath("//*[@id='caseViewSummaryCaseTypeNR']");

        private readonly By CaseCreatedDateField = By.XPath("//input[@id='caseViewSummaryCaseCreatedDatereadonly']");
        private readonly By CaseClosedDateField = By.XPath("//input[@id='caseViewSummaryCaseClosedDate']");
        private readonly By AssociatedLeadField = By.XPath("//a[@id='caseViewSummaryLeadId']");
        private readonly By SourceField = By.XPath("//input[@id='caseViewSummarySource']");
        private readonly By DetectionMethodField = By.XPath("//*[@id='caseViewSummaryDetectionMethod']");
        private readonly By PrimaryReasonField = By.XPath("//*[@id='caseViewSummaryreason']");
        private readonly By SaveButton = By.XPath("//button[@id='caseViewSaveButton']");

        private readonly By caseViewSummaryCaseStatusDDL = By.XPath("//*[@id='caseViewSummaryCaseStatusInfoNR']");

        private readonly By addSubjectBtn = By.XPath("//*[@id='subjectNew']/form/div/div[1]/button");


        #endregion


        public void ClickeditSubject()
        {
            Driver.FindElement(editSubjectBtn).Click();
        }
        public void ClickdeleteSubject()
        {
            Driver.FindElement(deleteSubjectBtn).Click();
        }
        public void ClickaddSubject()
        {
            Driver.FindElement(addSubjectBtn).Click();
        }
        public void SelectcaseViewSummaryAssignedToGorup(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseViewSummaryAssignedToGorupDDL), assignedTo);
        }
        public void SelectcaseAssignedSupervisor(string supervisor)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseAssignedSupervisorDDL), supervisor);
        }

        public void SelectcaseViewSummaryCaseStatus(string status)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseViewSummaryCaseStatusDDL), status);
        }

        public void EntercaseViewSummaryReferenced(string refId)
        {
            Driver.FindElement(caseViewSummaryReferencedTxt).SendKeys(refId);
        }
        public void ClickauditLogTab()
        {
            Driver.FindElement(auditLogTab).Click();
        }
        public void ClicksubjectNewTab()
        {
            Driver.FindElement(subjectNewTab).Click();
        }
        public void ClickrelatedCasesTab()
        {
            Driver.FindElement(relatedCasesTab).Click();
        }
        public void ClickCaseTab()
        {
            Driver.FindElement(caseTab).Click();
        }
        public void ClickcaseSummaryTab()
        {
            Driver.FindElement(caseSummaryTab).Click();
        }

        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, BeginEditingButton, 30);
            Driver.FindElement(BeginEditingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public void ClickEndEditing()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, EndEditingButton, 30);
            Driver.FindElement(EndEditingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public string GetCaseID()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, caseIDField, 30);
            return Driver.FindElement(caseIDField).GetAttribute("value");
        }

        public string GetAlternateCaseID()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, alternateCaseIDField, 30);
            return Driver.FindElement(alternateCaseIDField).GetAttribute("value");
        }

        public void alertCaseID(string altCaseID)
        {
            Driver.FindElement(alternateCaseIDField).Clear();
            Driver.FindElement(alternateCaseIDField).SendKeys(altCaseID);
        }

        public void SelectCaseType(string caseType)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CaseTypeDropdown, 30);
            CommonHelpers.selectOptionByValue(Driver.FindElement(CaseTypeDropdown), caseType);
        }

        public void SelectCaseStatus(string caseStatus)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CaseStatusDropdown, 30);
            CommonHelpers.selectOptionByValue(Driver.FindElement(CaseStatusDropdown), caseStatus);
        }

        public string GetSubjectName()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, subjectNameField, 30);
            return Driver.FindElement(subjectNameField).Text;
        }

        public void SelectAssignedToDropdown(string AssignedTo)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AssignedToDropdownButtonField, 30);
            Driver.FindElement(AssignedToDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            Driver.FindElement(By.XPath("//div[@id='caseViewAssignedToDiv']/ul/li/a[contains(.,'" + AssignedTo + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public string GetAssignedToDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AssignedToDropdownButtonField, 30);
            return Driver.FindElement(AssignedToDropdownButtonField).Text;
        }

        public void SelectAssignedSupervisorDropdown(string AssignedSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AssignedsupervisorDropdownButtonField, 30);
            Driver.FindElement(AssignedsupervisorDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            Driver.FindElement(By.XPath("//div[@id='dropDownMenuCaseAssignedSupervisor']/ul/li/a[contains(.,'" + AssignedSupervisor + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }
        public string GetAssignedSupervisorDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AssignedsupervisorDropdownButtonField, 30);
            return Driver.FindElement(AssignedsupervisorDropdownButtonField).Text;
        }

        public void SelectDepartmentOrDivisionDropdown(string DepartmentOrDivision)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Department_Or_DivisionDropdownButtonField, 30);
            Driver.FindElement(Department_Or_DivisionDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            Driver.FindElement(By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a[contains(.,'" + DepartmentOrDivision + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public string GetDepartmentOrDivisionDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Department_Or_DivisionDropdownButtonField, 30);
            return Driver.FindElement(Department_Or_DivisionDropdownButtonField).Text;
        }

        public void SelectSectionOrTeamsDropdown(string SectionOrTeams)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Section_Or_Teams_Button_Field, 30);
            Driver.FindElement(Section_Or_Teams_Button_Field).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            Driver.FindElement(By.XPath("//div[@id='caseViewSectionsDivisions']/ul/li/a[contains(.,'" + SectionOrTeams + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public string GetSectionOrTeamsDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, Section_Or_Teams_Button_Field, 30);
            return Driver.FindElement(Section_Or_Teams_Button_Field).Text;
        }
        public void EnterProject(string project)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, ProjectField, 30);
            Driver.FindElement(ProjectField).Clear();
            Driver.FindElement(ProjectField).SendKeys(project);
        }
        public bool IsLineOfBusinessChecked()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LineOFBusinessCheckBox, 30);
            return Driver.FindElement(LineOFBusinessCheckBox).Selected;
        }
        public string GetLineOfBusinessChecked()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LineOFBusinessCheckBox, 30);
            return Driver.FindElement(LineOFBusinessCheckBox).GetAttribute("value");
        }

        public string GetCaseCreatedDate()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CaseCreatedDateField, 30);
            return Driver.FindElement(CaseCreatedDateField).GetAttribute("value");
        }

        public string GetCaseClosedDate()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, CaseClosedDateField, 30);
            return Driver.FindElement(CaseClosedDateField).GetAttribute("value");
        }

        public string GetAssociatedLead()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AssociatedLeadField, 30);
            return Driver.FindElement(AssociatedLeadField).Text;
        }

        public string GetSource()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SourceField, 30);
            return Driver.FindElement(SourceField).GetAttribute("value");
        }

        public string GetDetectionMethod()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, DetectionMethodField, 30);
            return Driver.FindElement(DetectionMethodField).GetAttribute("value");
        }

        public string GetPrimaryReason()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, PrimaryReasonField, 30);
            return Driver.FindElement(PrimaryReasonField).GetAttribute("value");
        }


        public void ClickSaveButton()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, SaveButton, 30);
            Driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }
    }
}

