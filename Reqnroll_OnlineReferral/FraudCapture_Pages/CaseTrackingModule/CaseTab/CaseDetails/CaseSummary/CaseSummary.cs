using NUnit.Framework.Constraints;
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
        private readonly By GetCaseStatusDropdown = By.XPath("//select[@id='caseViewSummaryCaseStatusInfoNR']");
        private readonly By CaseStatusDropdown = By.XPath("//select[@id='caseViewSummaryCaseStatusInfoR']");
        private readonly By subjectNameField = By.XPath("*//tbody/tr/td/span/a");

        private readonly By AssignedToDropdownButtonField = By.XPath("//button[@id='dropdownMenuCaseAssigned']");
        private readonly By AssignedToDisplayField = By.XPath("//button[@id='dropdownMenuCaseAssigned']//span");
        private readonly By AssignedsupervisorDropdownButtonField = By.XPath("//button[@id='dropDownMenuCaseAssignedSupervisor']");
        private readonly By AssignedSupervisorDisplayField = By.XPath("//button[@id='dropDownMenuCaseAssignedSupervisor']//span");
        private readonly By Department_Or_DivisionDropdownButtonField = By.XPath("//button[@id='caseViewDropdownMenuDepartment']");
        private readonly By DepartmentOrDivisionDisplayField = By.XPath("//button[@id='caseViewDropdownMenuDepartment']//span");

        private readonly By Section_Or_Teams_Button_Field = By.XPath("//button[@id='caseViewDropdownMenuSection']");
        private readonly By SectionOrTeamsDisplayField = By.XPath("//button[@id='caseViewDropdownMenuSection']//span");
        private readonly By ProjectField = By.XPath("//input[@id='projectName']");
        private readonly By LineOfBusinessOptionByLabel = By.XPath("//label[normalize-space(.)='LOB1']/preceding-sibling::input[@type='checkbox']");

        private readonly By CaseCreatedDateField = By.XPath("//input[@id='caseViewSummaryCaseCreatedDatereadonly']");
        private readonly By CaseClosedDateField = By.XPath("//input[@id='caseViewSummaryCaseClosedDate']");
        private readonly By AssociatedLeadField = By.XPath("//a[@id='caseViewSummaryLeadId']");
        private readonly By SourceField = By.XPath("//input[@id='caseViewSummarySource']");
        private readonly By DetectionMethodField = By.XPath("//*[@id='caseViewSummaryDetectionMethod']");
        private readonly By PrimaryReasonField = By.XPath("//*[@id='caseViewSummaryreason']");
        private readonly By SaveButton = By.XPath("//button[@id='caseViewSaveButton']");
        private readonly By workflowTypeDropdownButton = By.XPath("//button[@id='dropdownMenuWorkflowType']");
        private readonly By leadReasonDropdownButton = By.XPath("//button[@id='dropdownMenuLeadReason']");
        private readonly By assignWorkflowToDropdownButton = By.XPath("//button[@id='dropdownMenuCaseUser']");
        private readonly By assignSupervisorDropdownButton = By.XPath("//button[@id='dropdownMenuCaseSupervisor']");
        private readonly By departmentDivisionDropdownButton = By.XPath("//button[@id='niDropdownMenuDepartment']");
        private readonly By sectionTeamDropdownButton = By.XPath("//button[@id='niDropdownMenuSection']");
        private readonly By createCaseButton = By.XPath("//div[@id='CreateLeadFromCase']/descendant::button[contains(.,'Create Case')]");

        private readonly By caseViewSummaryCaseStatusDDL = By.XPath("//*[@id='caseViewSummaryCaseStatusInfoNR']");

        private readonly By addSubjectBtn = By.XPath("//*[@id='subjectNew']/form/div/div[1]/button");


        #endregion


        public void ClickeditSubject()
        {
            driver.FindElement(editSubjectBtn).Click();
        }
        public void ClickdeleteSubject()
        {
            driver.FindElement(deleteSubjectBtn).Click();
        }
        public void ClickaddSubject()
        {
            driver.FindElement(addSubjectBtn).Click();
        }
        public void SelectcaseViewSummaryAssignedToGorup(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(caseViewSummaryAssignedToGorupDDL), assignedTo);
        }
        public void SelectcaseAssignedSupervisor(string supervisor)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(caseAssignedSupervisorDDL), supervisor);
        }

        public void SelectcaseViewSummaryCaseStatus(string status)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(caseViewSummaryCaseStatusDDL), status);
        }

        public void EntercaseViewSummaryReferenced(string refId)
        {
            driver.FindElement(caseViewSummaryReferencedTxt).SendKeys(refId);
        }
        public void ClickauditLogTab()
        {
            driver.FindElement(auditLogTab).Click();
        }
        public void ClicksubjectNewTab()
        {
            driver.FindElement(subjectNewTab).Click();
        }
        public void ClickrelatedCasesTab()
        {
            driver.FindElement(relatedCasesTab).Click();
        }
        public void ClickCaseTab()
        {
            driver.FindElement(caseTab).Click();
        }
        public void ClickcaseSummaryTab()
        {
            driver.FindElement(caseSummaryTab).Click();
        }

        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForElementVisiblity(driver, BeginEditingButton, 30);
            driver.FindElement(BeginEditingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void ClickEndEditing()
        {
            CommonHelpers.WaitForElementVisiblity(driver, EndEditingButton, 30);
            driver.FindElement(EndEditingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public string GetCaseID()
        {
            CommonHelpers.WaitForElementVisiblity(driver, caseIDField, 30);
            return driver.FindElement(caseIDField).GetAttribute("value");
        }

        public string GetAlternateCaseID()
        {
            CommonHelpers.WaitForElementVisiblity(driver, alternateCaseIDField, 30);
            return driver.FindElement(alternateCaseIDField).GetAttribute("value");
        }
        public void RemoveAlternativeCaseID(string alternateCaseId)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(alternateCaseIDField).Clear();
        }
        public void UnSelectLOB(string lobName)
        {
            var lineOfBusinessCheckBox = By.XPath("//*[@id='summary']/div[2]/form/div/div[2]/div[6]/div/div[1]/label[contains(.,'" + lobName + "')]/preceding-sibling::input[@type='checkbox']");
            CommonHelpers.WaitForElementVisiblity(driver, lineOfBusinessCheckBox, 30);
            var element = driver.FindElement(lineOfBusinessCheckBox);
            if (element.Selected)
            {
                element.Click();
            }
        }
        public void alertCaseID(string altCaseID)
        {
            var alternateLeadIdText = DateTime.Now.ToString("MMddyyyy") + " " + altCaseID;

         CommonHelpers.WaitForLoadingOverlayToDisappear(driver,100);
            driver.FindElement(alternateCaseIDField).Clear();
            driver.FindElement(alternateCaseIDField).SendKeys(alternateLeadIdText);
        }

        public void SelectCaseType(string caseType)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseTypeDropdown, 30);
            var select = new SelectElement(driver.FindElement(CaseTypeDropdown));
            var option = select.Options.FirstOrDefault(x => string.Equals(x.Text.Trim(), caseType.Trim(), StringComparison.OrdinalIgnoreCase));

            if (option == null)
            {
                throw new NoSuchElementException($"Case Type option not found: {caseType}");
            }

            select.SelectByText(option.Text);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void SelectCaseStatus(string caseStatus)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseStatusDropdown, 30);
            var select = new SelectElement(driver.FindElement(CaseStatusDropdown));
            var option = select.Options.FirstOrDefault(x => string.Equals(x.Text.Trim(), caseStatus.Trim(), StringComparison.OrdinalIgnoreCase));

            if (option == null)
            {
                throw new NoSuchElementException($"Case Status option not found: {caseStatus}");
            }

            select.SelectByText(option.Text);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public string GetCaseType()
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseTypeDropdown, 30);
            var select = new SelectElement(driver.FindElement(CaseTypeDropdown));
            return select.SelectedOption.Text.Trim();
        }

        public string GetCaseStatus()
        {
            CommonHelpers.WaitForElementVisiblity(driver, GetCaseStatusDropdown, 30);
            var select = new SelectElement(driver.FindElement(GetCaseStatusDropdown));
            return select.SelectedOption.Text.Trim();
        }

        public string GetSubjectName()
        {
            CommonHelpers.WaitForElementVisiblity(driver, subjectNameField, 30);
            return driver.FindElement(subjectNameField).Text;
        }

        public void SelectAssignedToDropdown(string AssignedTo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, AssignedToDropdownButtonField, 30);
            driver.FindElement(AssignedToDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//button[@id='dropdownMenuCaseAssigned']/following-sibling::ul//a[normalize-space()='" + AssignedTo + "' or contains(normalize-space(), '" + AssignedTo + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public string GetAssignedToDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(driver, AssignedToDisplayField, 30);
            return driver.FindElement(AssignedToDisplayField).Text.Trim();
        }

        public void SelectAssignedSupervisorDropdown(string AssignedSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(driver, AssignedsupervisorDropdownButtonField, 30);
            driver.FindElement(AssignedsupervisorDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//button[@id='dropDownMenuCaseAssignedSupervisor']/following-sibling::ul//a[normalize-space()='" + AssignedSupervisor + "' or contains(normalize-space(), '" + AssignedSupervisor + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
        public string GetAssignedSupervisorDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(driver, AssignedSupervisorDisplayField, 30);
            return driver.FindElement(AssignedSupervisorDisplayField).Text.Trim();
        }

        public void SelectDepartmentOrDivisionDropdown(string DepartmentOrDivision)
        {
            CommonHelpers.WaitForElementVisiblity(driver, Department_Or_DivisionDropdownButtonField, 30);
            driver.FindElement(Department_Or_DivisionDropdownButtonField).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//button[@id='caseViewDropdownMenuDepartment']/following-sibling::ul//a[normalize-space()='" + DepartmentOrDivision + "' or contains(normalize-space(), '" + DepartmentOrDivision + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public string GetDepartmentOrDivisionDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(driver, DepartmentOrDivisionDisplayField, 30);
            return driver.FindElement(DepartmentOrDivisionDisplayField).Text.Trim();
        }

        public void SelectSectionOrTeamsDropdown(string SectionOrTeams)
        {
            CommonHelpers.WaitForElementVisiblity(driver, Section_Or_Teams_Button_Field, 30);
            driver.FindElement(Section_Or_Teams_Button_Field).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//button[@id='caseViewDropdownMenuSection']/following-sibling::ul//a[normalize-space()='" + SectionOrTeams + "' or contains(normalize-space(), '" + SectionOrTeams + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public string GetSectionOrTeamsDropdownValue()
        {
            CommonHelpers.WaitForElementVisiblity(driver, SectionOrTeamsDisplayField, 30);
            return driver.FindElement(SectionOrTeamsDisplayField).Text.Trim();
        }
        public void EnterProject(string project)
        {
            CommonHelpers.WaitForElementVisiblity(driver, ProjectField, 30);
            driver.FindElement(ProjectField).Clear();
            driver.FindElement(ProjectField).SendKeys(project);
        }
        public void SelectLineOfBusiness(string lobName)
        {
            var lineOfBusinessCheckBox = By.XPath("//*[@id='summary']/div[2]/form/div/div[2]/div[6]/div/div[1]/label[contains(.,'" + lobName + "')]/preceding-sibling::input[@type='checkbox']");
            CommonHelpers.WaitForElementVisiblity(driver, lineOfBusinessCheckBox, 30);
            var element = driver.FindElement(lineOfBusinessCheckBox);

            if (!element.Selected)
            {
                element.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            }
        }

        public bool IsLineOfBusinessChecked(string lobName)
        {
            var lineOfBusinessCheckBox = By.XPath("//*[@id='summary']/div[2]/form/div/div[2]/div[6]/div/div[1]/label[contains(.,'" + lobName + "')]/preceding-sibling::input[@type='checkbox']");
            CommonHelpers.WaitForElementVisiblity(driver, lineOfBusinessCheckBox, 30);
            return driver.FindElement(lineOfBusinessCheckBox).Selected;
        }

        public string GetCaseCreatedDate()
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseCreatedDateField, 30);
            return driver.FindElement(CaseCreatedDateField).GetAttribute("value");
        }

        public string GetCaseClosedDate()
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseClosedDateField, 30);
            return driver.FindElement(CaseClosedDateField).GetAttribute("value");
        }

        public string GetAssociatedLead()
        {
            CommonHelpers.WaitForElementVisiblity(driver, AssociatedLeadField, 30);
            return driver.FindElement(AssociatedLeadField).Text.Trim();
        }

        public string GetSource()
        {
            CommonHelpers.WaitForElementVisiblity(driver, SourceField, 30);
            return driver.FindElement(SourceField).GetAttribute("value");
        }

        public string GetDetectionMethod()
        {
            CommonHelpers.WaitForElementVisiblity(driver, DetectionMethodField, 30);
            return driver.FindElement(DetectionMethodField).GetAttribute("value");
        }

        public string GetPrimaryReason()
        {
            CommonHelpers.WaitForElementVisiblity(driver, PrimaryReasonField, 30);
            return driver.FindElement(PrimaryReasonField).GetAttribute("value");
        }

        public void SelectFirstWorkflowType(string workflowType)
        {
            CommonHelpers.WaitForElementVisiblity(driver, workflowTypeDropdownButton, 30);
            driver.FindElement(workflowTypeDropdownButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//div[@id='caseWorkflowType']/ul/li/a[contains(.,'" + workflowType + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            
        }

        public void SelectFirstCaseReason(string caseReason)
        {
            CommonHelpers.WaitForElementVisiblity(driver, leadReasonDropdownButton, 30);
            driver.FindElement(leadReasonDropdownButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//div[@id='reasons']/ul/li/a[contains(.,'" + caseReason + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void SelectFirstAssignWorkflowTo(string assignWorkflowTo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, assignWorkflowToDropdownButton, 30);
            driver.FindElement(assignWorkflowToDropdownButton).Click();
           
            driver.FindElement(By.XPath("//div[@id='investigativeCaseAssignedTo']/ul/li/a[contains(.,'" + assignWorkflowTo + "')]")).Click();
           
            
        }

        public void SelectFirstAssignSupervisor(string assignSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(driver, assignSupervisorDropdownButton, 30);
            driver.FindElement(assignSupervisorDropdownButton).Click();
            driver.FindElement(By.XPath("//div[@id='investigativeCaseSupervisorAssignedTo']/ul/li/a[contains(.,'" + assignSupervisor + "')]")).Click();
        }

        public void SelectFirstDepartmentOrDivision(string departmentOrDivision)
        {
            CommonHelpers.WaitForElementVisiblity(driver, departmentDivisionDropdownButton, 30);
            driver.FindElement(departmentDivisionDropdownButton).Click();
            driver.FindElement(By.XPath("//div[@id='caseDepartmentAssignTo']/ul/li/a[contains(.,'" + departmentOrDivision + "')]")).Click();
        }

        public void SelectFirstSectionOrTeam(string sectionOrTeam)
        {
            CommonHelpers.WaitForElementVisiblity(driver, sectionTeamDropdownButton, 30);
            driver.FindElement(sectionTeamDropdownButton).Click();
            driver.FindElement(By.XPath("//div[@id='caseSectionAssignTo']/ul/li/a[contains(.,'" + sectionOrTeam + "')]")).Click();
        }

        public void ClickCreateCaseButton()
        {
            CommonHelpers.WaitForElementVisiblity(driver, createCaseButton, 30);
            driver.FindElement(createCaseButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        //private void SelectFirstDropdownOption(string buttonId, By buttonLocator)
        //{
        //    CommonHelpers.WaitForElementVisiblity(Driver, buttonLocator, 30);
        //    Driver.FindElement(buttonLocator).Click();

        //    var optionLocator = By.XPath($"//button[@id='{buttonId}']/following-sibling::ul//a[normalize-space()!='' and not(contains(@class,'disabled'))][1]");
        //    CommonHelpers.WaitForElementVisiblity(Driver, optionLocator, 30);
        //    Driver.FindElement(optionLocator).Click();
        //    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        //}

        private void SelectDropdownButtonOption(string buttonId, string optionText)
        {
            var button = By.Id(buttonId);
            CommonHelpers.WaitForElementVisiblity(driver, button, 30);
            var buttonElement = driver.FindElement(button);

            if (buttonElement.Text.Trim().Contains(optionText.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            buttonElement.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            var option = By.XPath("//button[@id='" + buttonId + "']/following-sibling::ul//a[normalize-space()='" + optionText + "' or contains(normalize-space(), '" + optionText + "')]");
            CommonHelpers.WaitForElementVisiblity(driver, option, 30);
            driver.FindElement(option).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void ClickSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, SaveButton, 30);
            driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
    }
}





