//using FWA_PI_Portal.Constants;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using Protractor;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Threading;
//using Actions = OpenQA.Selenium.Interactions.Actions;

//namespace FWA_PI_Portal.Pages
//{
//    /// <summary>
//    /// Page Object Model for Lead Edit functionality
//    /// Follows BDD Cucumber structure with organized locators and methods
//    /// </summary>
//    public class LeadEditPage_BDD : BasePage
//    {
//        private readonly string FileDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
//        private readonly DateTime dateTime = DateTime.Now;

//        public LeadEditPage_BDD(NgWebDriver driver) : base(driver)
//        {
//        }

//        #region Page Locators - Lead Summary and Main Actions

//        // Edit Mode Controls
//        private IWebElement BeginEditingButton => Driver.WrappedDriver.FindElement(By.Id("leadViewEditEndButton"));
//        private IWebElement EndEditingButton => Driver.WrappedDriver.FindElement(By.XPath("//button[@id='leadViewEditBeginButton']"));
//        private IWebElement SaveButton => Driver.WrappedDriver.FindElement(By.Id("leadSaveButton"));

//        // Main Tabs
//        private IWebElement LeadTab => Driver.WrappedDriver.FindElement(By.Id("leadDetailsId"));
//        private IWebElement SubjectsTab => Driver.WrappedDriver.FindElement(By.Id("SubjectDetailsTabId"));
//        private IWebElement ReferralsTab => Driver.WrappedDriver.FindElement(By.Id("referralDetailsTabId"));
//        private IWebElement AuditLogTab => Driver.WrappedDriver.FindElement(By.Id("auditlogTabId"));
//        private IWebElement ActivitiesTab => Driver.WrappedDriver.FindElement(By.Id("activitiesDetailsTabId"));

//        // Lead Summary Fields
//        private IWebElement LeadCreatedDateInput => Driver.WrappedDriver.FindElement(By.Id("leadDate"));
//        private IWebElement LeadStatus => Driver.WrappedDriver.FindElement(By.XPath("//select[@id='leadCaseTypeEditNR']"));
//        private IWebElement LeadPriority => Driver.WrappedDriver.FindElement(By.XPath("//*[@name='leadpriority']/following::label"));
//        private IWebElement findingsInput => Driver.WrappedDriver.FindElement(By.Id("leadFindings"));
//        private IWebElement LeadDescription => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='leadDescription']"));
//        private IWebElement LeadTypeDropdown => Driver.WrappedDriver.FindElement(By.XPath("//select[@id='leadCaseTypeEditNR']"));
//        private IWebElement LeadStatusDropdown => Driver.WrappedDriver.FindElement(By.XPath("//select[@aria-labelledby='leadStatus']"));
//        private IWebElement AssignedToDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownMenuLeadAssign"));
//        private IWebElement AssignedSupervisorDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownMenuLeadSupervisorAssign"));
//        private IWebElement DivisionsDepartmentsDropdown => Driver.WrappedDriver.FindElement(By.Name("departmentKey"));

//        // Alert Messages
//        private IWebElement alertMessageClose => Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right']/child::button"));
//        private IWebElement alertMessage => Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right']/div"));

//        #endregion

//        #region Page Locators - Activities

//        private IWebElement AddActivityButton => Driver.WrappedDriver.FindElement(By.Id("addActivityId"));
//        private IWebElement ActivityNameDropdown => Driver.WrappedDriver.FindElement(By.Id("name"));
//        private IWebElement CreateActivityButton => Driver.WrappedDriver.FindElement(By.XPath("//sapn[contains(text(),'Create Activity')]"));
//        private IWebElement SaveActivityButton => Driver.WrappedDriver.FindElement(By.XPath("//span[contains(text(),'Save')]"));
//        private IWebElement ExitActivityButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='activitydetail']//button[contains(text(),'Exit Activity')]"));
//        private IWebElement CloseActivityButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='noteAttachmentWidgetId']/div[1]/div[2]/img"));
//        private IWebElement ActivityTab => Driver.WrappedDriver.FindElement(By.Id("activityDetailTabId"));
//        private IWebElement AddNoteButton => Driver.WrappedDriver.FindElement(By.CssSelector("#activitydetail > div.row > div > button:nth-child(2)"));
//        private IWebElement NoteInput => Driver.WrappedDriver.FindElement(By.Id("notes"));
//        private IWebElement SaveNoteButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='noteEditForm']//button[contains(text(),'Save')]"));
//        private IWebElement DueDateInput => Driver.WrappedDriver.FindElement(By.XPath("//input[@name='dueDate']"));
//        private IWebElement ActivityTimeInput => Driver.WrappedDriver.FindElement(By.Id("activityTime"));
//        private IWebElement ExpenseAmountInput => Driver.WrappedDriver.FindElement(By.Id("expenses"));
//        private IWebElement ActivityTableToolsDropdown => Driver.WrappedDriver.FindElement(By.Id("activityTableTools"));
//        private IWebElement DownloadAllAttachmentsButton => Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Download All Attachments')]"));

//        #endregion

//        #region Page Locators - Activity Attachments

//        private IWebElement AttachmentTab => Driver.WrappedDriver.FindElement(By.Id("attachmentTabId"));
//        private IWebElement AddAttachmentButton => Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Add Attachment')]"));
//        private IWebElement ActivityLevelDownloadAttachmentManagerButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='attachment']/div[1]/button[3]"));
//        private IWebElement ActivityAttachmentTitle => Driver.WrappedDriver.FindElement(By.XPath("//*[@name='title']"));
//        private IWebElement ActivityAttachmentDescription => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='fileDesciption']"));
//        private IWebElement ActivityAttachmentreceivedFrom => Driver.WrappedDriver.FindElement(By.XPath("//*[@name='receivedFrom']"));
//        private IWebElement ActivityAttachmentEditSavebutton => Driver.WrappedDriver.FindElement(By.XPath("//form[@id='attachmentEditForm']/descendant::button[contains(text(),' Save ')]"));
//        private IWebElement confirmEditAttachmentButton => Driver.WrappedDriver.FindElement(By.XPath("//button[2][contains(text(),'Yes')]"));

//        #endregion

//        #region Page Locators - Subjects

//        private IWebElement AddSubjectButton => Driver.WrappedDriver.FindElement(By.XPath("//button[@id='addSubjectDropDownId']"));
//        private IWebElement SubjectTypeOptionsDropdown => Driver.WrappedDriver.FindElement(By.Id("subjectType"));
//        private IWebElement AddSubjectOptionsDropdown => Driver.WrappedDriver.FindElement(By.Id("criteria"));
//        private IWebElement FirstNameSearchInput => Driver.WrappedDriver.FindElement(By.Id("firstName"));
//        private IWebElement LastNameSearchInput => Driver.WrappedDriver.FindElement(By.Id("lastName"));
//        private IWebElement SearchButton => Driver.WrappedDriver.FindElement(By.Id("subjectSearchId"));
//        private IWebElement AddSelectedSubjectsButton => Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Add Selected']"));
//        private IWebElement ConfirmAddSubject => Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
//        private IWebElement manualAddSubjectOption => Driver.WrappedDriver.FindElement(By.XPath("//span[@class='dropdown ng-scope open']/child::ul/li/a[text()=' Manually Enter Subject']"));
//        private IWebElement searchForSubjectOption => Driver.WrappedDriver.FindElement(By.XPath("//a[contains(text(),'Search For Subject')]"));
//        private IWebElement subjectselectCriteria => Driver.WrappedDriver.FindElement(By.Id("criteria"));
//        private IWebElement addSubjectCheckbox => Driver.WrappedDriver.FindElement(By.XPath("//input[@ng-click='checkUncheckAll()']"));
//        private IWebElement CancelSubjectButton => Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Cancel']"));

//        // Subject Details
//        private IWebElement SubjectPhoneTab => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ViewSubjectPhone']"));
//        private IWebElement NamePrefixInput => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ViewSubjectNamePrefix']"));
//        private IWebElement TIN_OR_EIN_ID => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ViewSubjectFederalTIN']"));
//        private IWebElement ProviderNPI => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ViewSubjectNPI']"));

//        #endregion

//        #region Page Locators - Referrals

//        private IWebElement ReferralFirstNameInput => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ReferralFirstName']"));
//        private IWebElement ReferringPartyID => Driver.WrappedDriver.FindElement(By.XPath("//input[@id='ReferralID']"));

//        #endregion

//        #region Page Locators - Lead Reasons

//        private IWebElement addNewLeadReasonButton => Driver.WrappedDriver.FindElement(By.XPath("//button[@id='leadReasonAddButton']"));
//        private IWebElement DetectiomMethodDropdown => Driver.WrappedDriver.FindElement(By.XPath("//select[@id='leadSource']"));
//        private IWebElement SourceTypeDropdown => Driver.WrappedDriver.FindElement(By.XPath("//button[@id='dropdownMenuLeadSourceType']"));
//        private IWebElement SourceTypeDropdownValue => Driver.WrappedDriver.FindElement(By.XPath("//div[@id='leadReasonSourceTypeDiv']/child::ul/li/a[contains(text(),' (DO NOT MODIFY) Automated Testing Lead Source')]"));
//        private IWebElement ReasonDropdown => Driver.WrappedDriver.FindElement(By.XPath("//div[@id='leadReasonNewDiv']/button"));
//        private IWebElement ReasonDropdownValue => Driver.WrappedDriver.FindElement(By.XPath("//div[@id='leadReasonNewDiv']/ul/li/a[text()=' (DO NOT MODIFY) Automated Testing Lead Reason ']"));
//        private IWebElement ReasonCommentTextbox => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='comment']"));

//        #endregion

//        #region Page Locators - Close Lead and Create Case

//        private IWebElement CloseLeadCreateCaseButton => Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Close the Lead & Create a Case']"));
//        private IWebElement CaseWorkflowTypeDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownMenuWorkflowType"));
//        private IWebElement PrimaryLeadReasonDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownMenuLeadReason"));
//        private IWebElement CreateCaseButton => Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Create Case']"));

//        #endregion

//        #region Page Properties

//        public bool IsAt => Driver.WrappedDriver.FindElement(By.Id("leadId")).Displayed;

//        #endregion

//        #region Page Actions - Edit Mode

//        public void BeginEditingLead()
//        {
//            try
//            {
//                if (BeginEditingButton.Displayed)
//                {
//                    BeginEditingButton.Click();
//                    WaitForPageLoading();
//                }
//            }
//            catch (NoSuchElementException)
//            {
//                // Already in Edit mode, move along
//            }
//        }

//        public void EndEditing_Lead()
//        {
//            try
//            {
//                if (BeginEditingButton.Displayed)
//                {
//                    BeginEditingButton.Click();
//                    WaitForPageLoading();
//                }
//            }
//            catch (NoSuchElementException)
//            {
//                // Already in Edit mode, move along
//            }

//            try
//            {
//                if (EndEditingButton.Displayed)
//                {
//                    EndEditingButton.Click();
//                    WaitForPageLoading();
//                }
//            }
//            catch (NoSuchElementException)
//            {
//                // End editing button not found
//            }
//        }

//        /// <summary>
//        /// Clicks the save button then returns true if the notification received tells us the save was successful
//        /// </summary>
//        /// <returns></returns>
//        public bool SaveEditing()
//        {
//            ScrollAndCenterElement(SaveButton);
//            SaveButton.Click();
//            WaitForLoaderToDisappear();
//            var alert = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right ng-star-inserted']"));
//            var alertMessage = alert.FindElement(By.XPath(".//div"));
//            CloseAlert();
//            return alertMessage.Text == "Changes have been saved.";
//        }

//        public void CloseAlert()
//        {
//            try
//            {
//                if (alertMessageClose.Displayed)
//                {
//                    alertMessageClose.Click();
//                }
//            }
//            catch (NoSuchElementException)
//            {
//                // Alert not present
//            }
//        }

//        #endregion

//        #region Page Actions - Lead Summary

//        public void EditLeadSummary(string leadDescription, string findings, string leadType)
//        {
//            BeginEditingLead();
//            WaitForPageLoading();

//            if (!string.IsNullOrEmpty(leadDescription))
//            {
//                LeadDescription.Clear();
//                LeadDescription.SendKeys(leadDescription);
//            }

//            if (!string.IsNullOrEmpty(findings))
//            {
//                findingsInput.Clear();
//                findingsInput.SendKeys(findings);
//            }

//            if (!string.IsNullOrEmpty(leadType))
//            {
//                var selectLeadType = new SelectElement(LeadTypeDropdown);
//                selectLeadType.SelectByText(leadType);
//            }

//            SaveEditing();
//        }

//        public void UpdateLeadStatus(string status)
//        {
//            BeginEditingLead();
//            var selectStatus = new SelectElement(LeadStatusDropdown);
//            selectStatus.SelectByText(status);
//            SaveEditing();
//        }

//        public void UpdateLeadAssignment(string assignedTo)
//        {
//            BeginEditingLead();
//            AssignedToDropdown.Click();
//            WaitForLoadingOverlayToDisappear();
//            var assignedToOption = Driver.WrappedDriver.FindElement(By.XPath($"//ul[@id='leadViewAssignedTo']//a[contains(text(),'{assignedTo}')]"));
//            assignedToOption.Click();
//            WaitForLoadingOverlayToDisappear();
//            SaveEditing();
//        }

//        public void UpdateLeadSupervisor(string supervisor)
//        {
//            BeginEditingLead();
//            AssignedSupervisorDropdown.Click();
//            WaitForLoadingOverlayToDisappear();
//            var supervisorOption = Driver.WrappedDriver.FindElement(By.XPath($"//ul[@id='leadViewSupervisorAssignedTo']//a[contains(text(),'{supervisor}')]"));
//            supervisorOption.Click();
//            WaitForLoadingOverlayToDisappear();
//            SaveEditing();
//        }

//        public string GetLeadPriority()
//        {
//            return LeadPriority.Text.Trim();
//        }

//        public bool VerifyLeadFieldsLocked()
//        {
//            try
//            {
//                return !LeadDescription.Enabled || LeadDescription.GetAttribute("readonly") != null;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        #endregion

//        #region Page Actions - Activities

//        public void ShowActivities()
//        {
//            WaitForPageLoading();
//            ActivitiesTab.Click();
//            WaitForWidgetLoading();
//        }

//        public void AddActivity(string activityName, string assignedTo)
//        {
//            try
//            {
//                WaitForWidgetLoading();
//                AddActivityButton.Click();
//                WaitForLoadingOverlayToDisappear();
//                var selectActivityName = new SelectElement(ActivityNameDropdown);
//                selectActivityName.SelectByText(activityName);
//                WaitForLoadingOverlayToDisappear();
//                var continueButton = Driver.WrappedDriver.FindElement(By.XPath("//button/span[text()='Continue']"));
//                continueButton.Click();
//                WaitForLoadingOverlayToDisappear();
//                var selectAssignActivityTo = Driver.WrappedDriver.FindElement(By.Id("dropdownMenuActivityUser"));
//                selectAssignActivityTo.Click();

//                var list = Driver.WrappedDriver.FindElements(By.XPath("//ul[@id='actViewAssignedTo']//li/a"));
//                foreach (IWebElement element in list)
//                {
//                    if (element.Text.Contains(assignedTo))
//                    {
//                        element.Click();
//                        WaitForLoadingOverlayToDisappear();
//                        break;
//                    }
//                }

//                SaveActivityButton.Click();
//                WaitForLoadingOverlayToDisappear();
//                ExitActivityButton.Click();
//                WaitForPageLoading();
//            }
//            catch (WebDriverException e)
//            {
//                CloseActivity();
//                throw new Exception(e.Message);
//            }
//        }

//        public bool NewActivityAppears(string activityName)
//        {
//            var waitForActivity = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(120));
//            string leadActivityName = string.Empty;
//            waitForActivity.Until(d =>
//            {
//                try
//                {
//                    var activitiesRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activityForm']//table/tbody/tr"));
//                    var selectedActivity = activitiesRow.Where(row =>
//                    {
//                        var selectedActivityName = row.FindElement(By.XPath(".//td[@id='activityCell']")).Text.Trim();
//                        return activityName == selectedActivityName;
//                    }).First();

//                    leadActivityName = selectedActivity.FindElement(By.XPath(".//td[@id='activityCell']")).Text.Trim();
//                    return true;
//                }
//                catch (WebDriverTimeoutException)
//                {
//                    return false;
//                }
//            });

//            return !string.IsNullOrWhiteSpace(leadActivityName);
//        }

//        public void DeleteActivity(string activityName)
//        {
//            var activitiesRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activityForm']//table/tbody/tr"));
//            var selectedActivity = activitiesRow.Where(row =>
//            {
//                var selectedActivityName = row.FindElement(By.XPath(".//td[@id='activityCell']")).Text.Trim();
//                return activityName == selectedActivityName;
//            }).First();

//            var deleteButton = selectedActivity.FindElement(By.XPath(".//button[text()='Delete']"));
//            deleteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            var confirmDeleteButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Yes']"));
//            confirmDeleteButton.Click();
//            WaitForPageLoading();
//        }

//        public void OpenActivity(string activityName)
//        {
//            var activitiesRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activityForm']//table/tbody/tr"));
//            var selectedActivity = activitiesRow.Where(row =>
//            {
//                var selectedActivityName = row.FindElement(By.XPath(".//td[@id='activityCell']")).Text.Trim();
//                return activityName == selectedActivityName;
//            }).First();

//            var activityLink = selectedActivity.FindElement(By.XPath(".//td[@id='activityCell']/a"));
//            activityLink.Click();
//            WaitForPageLoading();
//        }

//        public void ReassignActivity(string activityName, string newAssignee)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            var reassignDropdown = Driver.WrappedDriver.FindElement(By.Id("dropdownMenuActivityUser"));
//            reassignDropdown.Click();

//            var list = Driver.WrappedDriver.FindElements(By.XPath("//ul[@id='actViewAssignedTo']//li/a"));
//            foreach (IWebElement element in list)
//            {
//                if (element.Text.Contains(newAssignee))
//                {
//                    element.Click();
//                    WaitForLoadingOverlayToDisappear();
//                    break;
//                }
//            }

//            SaveActivityButton.Click();
//            WaitForLoadingOverlayToDisappear();
//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void AddNoteToActivity(string activityName, string noteText)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            AddNoteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            NoteInput.SendKeys(noteText);
//            SaveNoteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void UpdateActivityDueDate(string activityName, string dueDate)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            DueDateInput.Clear();
//            DueDateInput.SendKeys(dueDate);

//            SaveActivityButton.Click();
//            WaitForLoadingOverlayToDisappear();
//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void UpdateActivityTimeAndExpenses(string activityName, string time, string expenses)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            if (!string.IsNullOrEmpty(time))
//            {
//                ActivityTimeInput.Clear();
//                ActivityTimeInput.SendKeys(time);
//            }

//            if (!string.IsNullOrEmpty(expenses))
//            {
//                ExpenseAmountInput.Clear();
//                ExpenseAmountInput.SendKeys(expenses);
//            }

//            SaveActivityButton.Click();
//            WaitForLoadingOverlayToDisappear();
//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void CloseActivity()
//        {
//            try
//            {
//                CloseActivityButton.Click();
//                WaitForPageLoading();
//                var confirmButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Yes']"));
//                confirmButton.Click();
//                WaitForPageLoading();
//            }
//            catch (NoSuchElementException)
//            {
//                // Activity already closed
//            }
//        }

//        public void SortActivitiesByColumn(string columnName)
//        {
//            var columnHeader = Driver.WrappedDriver.FindElement(By.XPath($"//th[contains(text(),'{columnName}')]"));
//            columnHeader.Click();
//            WaitForLoadingOverlayToDisappear();
//        }

//        #endregion

//        #region Page Actions - Activity Attachments

//        public void AddAttachmentToActivity(string activityName, string fileName, string title, string description)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            AttachmentTab.Click();
//            WaitForLoadingOverlayToDisappear();

//            AddAttachmentButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            var fileInput = Driver.WrappedDriver.FindElement(By.XPath("//input[@type='file']"));
//            var filePath = Path.Combine(FileDirectoryPath, "TestData", fileName);
//            fileInput.SendKeys(filePath);
//            WaitForLoadingOverlayToDisappear();

//            if (!string.IsNullOrEmpty(title))
//            {
//                ActivityAttachmentTitle.SendKeys(title);
//            }

//            if (!string.IsNullOrEmpty(description))
//            {
//                ActivityAttachmentDescription.SendKeys(description);
//            }

//            ActivityAttachmentEditSavebutton.Click();
//            WaitForLoadingOverlayToDisappear();

//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void EditActivityAttachment(string activityName, string newTitle, string newDescription)
//        {
//            OpenActivity(activityName);
//            WaitForLoadingOverlayToDisappear();

//            AttachmentTab.Click();
//            WaitForLoadingOverlayToDisappear();

//            var editButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Edit']"));
//            editButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            if (!string.IsNullOrEmpty(newTitle))
//            {
//                ActivityAttachmentTitle.Clear();
//                ActivityAttachmentTitle.SendKeys(newTitle);
//            }

//            if (!string.IsNullOrEmpty(newDescription))
//            {
//                ActivityAttachmentDescription.Clear();
//                ActivityAttachmentDescription.SendKeys(newDescription);
//            }

//            ActivityAttachmentEditSavebutton.Click();
//            WaitForLoadingOverlayToDisappear();

//            confirmEditAttachmentButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            ExitActivityButton.Click();
//            WaitForPageLoading();
//        }

//        public void DownloadAllActivityAttachments()
//        {
//            ActivityLevelDownloadAttachmentManagerButton.Click();
//            WaitForLoadingOverlayToDisappear();
//            DownloadAllAttachmentsButton.Click();
//            WaitForLoadingOverlayToDisappear();
//        }

//        #endregion

//        #region Page Actions - Subjects

//        public void ShowSubjects()
//        {
//            WaitForPageLoading();
//            SubjectsTab.Click();
//            WaitForWidgetLoading();
//        }

//        public void SearchAndAddSubject(string firstName, string lastName)
//        {
//            try
//            {
//                AddSubjectButton.Click();
//                WaitForPageLoading();
//                SubjectTypeOptionsDropdown.Click();
//                var subjectOption = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='subjectType']//option[contains(text(),'Chiropractor')]"));
//                subjectOption.Click();
//                AddSubjectOptionsDropdown.Click();
//                var searchForSubjectOption = Driver.WrappedDriver.FindElement(By.XPath("//option[contains(text(),' Search by Name')]"));
//                searchForSubjectOption.Click();
//                FirstNameSearchInput.SendKeys(firstName);
//                LastNameSearchInput.SendKeys(lastName);
//                SearchButton.Click();
//                WaitForSearchResultsLoading(30);
//                var subjectCheckbox = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='resultTable']/tbody/tr[1]/td[1]/span/input"));
//                subjectCheckbox.Click();

//                if (AddSelectedSubjectsButton.Enabled)
//                {
//                    AddSelectedSubjectsButton.Click();
//                }

//                WaitForPageLoading();
//                ConfirmAddSubject.Click();
//                WaitForWidgetLoading();
//            }
//            catch (WebDriverException e)
//            {
//                CloseAddSubjectForm();
//                var confirmCancelButton = Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
//                confirmCancelButton.Click();
//                throw new Exception(e.Message);
//            }
//        }

//        public bool NewSubjectAppears(string firstName, string lastName)
//        {
//            var waitForSubject = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(120));
//            var subjectName = firstName + ' ' + lastName;
//            string leadSubjectName = string.Empty;
//            waitForSubject.Until(d =>
//            {
//                try
//                {
//                    var subjectsRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='SubjectsNew']/tbody/tr"));
//                    var selectedSubject = subjectsRow.Where(row =>
//                    {
//                        var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();
//                        return subjectName == selectedSubjectName;
//                    }).First();

//                    leadSubjectName = selectedSubject.FindElements(By.TagName("small"))[1].Text.Trim();
//                    return true;
//                }
//                catch (WebDriverTimeoutException)
//                {
//                    return false;
//                }
//            });

//            if (string.IsNullOrWhiteSpace(leadSubjectName))
//            {
//                return false;
//            }
//            else
//            {
//                DeleteSubject(firstName, lastName);
//                return true;
//            }
//        }

//        public void DeleteSubject(string firstName, string lastName)
//        {
//            var subjectName = firstName + ' ' + lastName;
//            var subjectsRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='SubjectsNew']/tbody/tr"));
//            var selectedSubject = subjectsRow.Where(row =>
//            {
//                var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();
//                return subjectName == selectedSubjectName;
//            }).First();

//            var deleteButton = selectedSubject.FindElement(By.XPath(".//button[text()='Delete']"));
//            deleteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            var confirmDeleteButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Yes']"));
//            confirmDeleteButton.Click();
//            WaitForPageLoading();
//        }

//        public void CloseAddSubjectForm()
//        {
//            try
//            {
//                CancelSubjectButton.Click();
//                WaitForPageLoading();
//            }
//            catch (NoSuchElementException)
//            {
//                // Form already closed
//            }
//        }

//        public bool VerifyProviderSubjectDisplayed(string organizationName)
//        {
//            try
//            {
//                var subjectsRow = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='SubjectsNew']/tbody/tr"));
//                var providerSubject = subjectsRow.FirstOrDefault(row =>
//                {
//                    try
//                    {
//                        var orgName = row.FindElement(By.XPath(".//small[contains(text(),'Organization:')]")).Text;
//                        return orgName.Contains(organizationName);
//                    }
//                    catch
//                    {
//                        return false;
//                    }
//                });

//                return providerSubject != null;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        #endregion

//        #region Page Actions - Referrals

//        public void ShowReferrals()
//        {
//            WaitForPageLoading();
//            ReferralsTab.Click();
//            WaitForWidgetLoading();
//        }

//        public void AddReferral(string firstName, string partyId)
//        {
//            var addReferralButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Add Referral']"));
//            addReferralButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            ReferralFirstNameInput.SendKeys(firstName);
//            ReferringPartyID.SendKeys(partyId);

//            var saveReferralButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Save']"));
//            saveReferralButton.Click();
//            WaitForLoadingOverlayToDisappear();
//        }

//        #endregion

//        #region Page Actions - Lead Reasons

//        public void AddLeadReason(string detectionMethod, string sourceType, string reason, string comment)
//        {
//            BeginEditingLead();
//            addNewLeadReasonButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            if (!string.IsNullOrEmpty(detectionMethod))
//            {
//                var selectDetectionMethod = new SelectElement(DetectiomMethodDropdown);
//                selectDetectionMethod.SelectByText(detectionMethod);
//                WaitForLoadingOverlayToDisappear();
//            }

//            if (!string.IsNullOrEmpty(sourceType))
//            {
//                SourceTypeDropdown.Click();
//                WaitForLoadingOverlayToDisappear();
//                SourceTypeDropdownValue.Click();
//                WaitForLoadingOverlayToDisappear();
//            }

//            if (!string.IsNullOrEmpty(reason))
//            {
//                ReasonDropdown.Click();
//                WaitForLoadingOverlayToDisappear();
//                ReasonDropdownValue.Click();
//                WaitForLoadingOverlayToDisappear();
//            }

//            if (!string.IsNullOrEmpty(comment))
//            {
//                ReasonCommentTextbox.SendKeys(comment);
//            }

//            var saveReasonButton = Driver.WrappedDriver.FindElement(By.XPath("//button[@id='leadReasonSaveButton']"));
//            saveReasonButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            SaveEditing();
//        }

//        public bool VerifyLeadReasonExists(string reason)
//        {
//            try
//            {
//                var reasonRow = Driver.WrappedDriver.FindElement(By.XPath($"//td[contains(text(),'{reason}')]"));
//                return reasonRow.Displayed;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        public void DeleteLeadReason(string reason)
//        {
//            BeginEditingLead();
//            var reasonRow = Driver.WrappedDriver.FindElement(By.XPath($"//td[contains(text(),'{reason}')]/ancestor::tr"));
//            var deleteButton = reasonRow.FindElement(By.XPath(".//button[text()='Delete']"));
//            deleteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            var confirmDeleteButton = Driver.WrappedDriver.FindElement(By.XPath("//button[text()='Yes']"));
//            confirmDeleteButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            SaveEditing();
//        }

//        #endregion

//        #region Page Actions - Audit Log

//        public void ShowAuditLog()
//        {
//            WaitForPageLoading();
//            AuditLogTab.Click();
//            WaitForWidgetLoading();
//        }

//        public bool VerifyAuditLogEntry(string action, string user)
//        {
//            try
//            {
//                var auditRows = Driver.WrappedDriver.FindElements(By.XPath("//table[@id='auditLogTable']//tbody/tr"));
//                var matchingRow = auditRows.FirstOrDefault(row =>
//                {
//                    var actionCell = row.FindElement(By.XPath(".//td[2]")).Text;
//                    var userCell = row.FindElement(By.XPath(".//td[3]")).Text;
//                    return actionCell.Contains(action) && userCell.Contains(user);
//                });

//                return matchingRow != null;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        #endregion

//        #region Page Actions - Close Lead and Create Case

//        public void CloseLeadAndCreateCase(string workflowType, string leadReason)
//        {
//            BeginEditingLead();
//            CloseLeadCreateCaseButton.Click();
//            WaitForLoadingOverlayToDisappear();

//            CaseWorkflowTypeDropdown.Click();
//            var workflowOption = Driver.WrappedDriver.FindElement(By.XPath($"//ul[@id='caseWorkflowType']//a[contains(text(),'{workflowType}')]"));
//            workflowOption.Click();
//            WaitForLoadingOverlayToDisappear();

//            PrimaryLeadReasonDropdown.Click();
//            var reasonOption = Driver.WrappedDriver.FindElement(By.XPath($"//ul[@id='leadReasonListDiv']//a[contains(text(),'{leadReason}')]"));
//            reasonOption.Click();
//            WaitForLoadingOverlayToDisappear();

//            CreateCaseButton.Click();
//            WaitForPageLoading();
//        }

//        #endregion

//        #region Page Actions - Search and Export

//        public void SearchLeadById(string leadId)
//        {
//            var searchInput = Driver.WrappedDriver.FindElement(By.XPath("//input[@placeholder='Search Leads']"));
//            searchInput.Clear();
//            searchInput.SendKeys(leadId);
//            searchInput.SendKeys(Keys.Enter);
//            WaitForPageLoading();
//        }

//        public void ExportLeadToExcel()
//        {
//            ActivityTableToolsDropdown.Click();
//            var exportButton = Driver.WrappedDriver.FindElement(By.XPath("//a[contains(text(),'Export to Excel')]"));
//            exportButton.Click();
//            WaitForLoadingOverlayToDisappear();
//        }

//        #endregion

//        #region Helper Methods

//        private void WaitForSearchResultsLoading(int timeoutInSeconds)
//        {
//            var wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(timeoutInSeconds));
//            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='resultTable']/tbody/tr")));
//        }

//        private void WaitForLoaderToDisappear()
//        {
//            try
//            {
//                var wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(30));
//                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='loader']")));
//            }
//            catch (WebDriverTimeoutException)
//            {
//                // Loader already disappeared
//            }
//        }

//        private void ScrollAndCenterElement(IWebElement element)
//        {
//            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.WrappedDriver;
//            js.ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", element);
//            Thread.Sleep(500);
//        }

//        #endregion
//    }
//}
