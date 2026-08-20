using FC_OnlineReferral;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Claims;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using HeaderComponentType = FC_OnlineReferral.FraudCapture_Pages.HeaderComponent.HeaderComponent;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab
{
    public class CaseEditPage : BaseSettings
    {
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        public CaseEditPage(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, DefaultTimeout);
        }

        #region Elements

        #region Case Summary Section Locators

        private readonly By BeginEditingButton = By.Id("caseViewEditEndButton");

        private readonly By BeginEditingLeadButton = By.Id("leadViewEditEndButton");

        private readonly By SaveButton = By.Id("caseViewSaveButton");

        private readonly By CaseIdInput = By.Id("caseViewSummaryCaseId");

        private readonly By AlternateCaseIdInput = By.Id("caseViewSummaryReferenceId");

        private readonly By CaseTypeDropdown = By.XPath("//select[@aria-label='caseViewSummaryCaseTypeNR']");

        private readonly By CaseStatusDropdown = By.XPath("//select[@aria-label='caseViewSummaryCaseStatusInfoNR']");

        private readonly By AssignedToDropdown = By.Id("dropdownMenuCaseAssigned");

        private readonly By AssignedSupervisorDropdown = By.Id("dropDownMenuCaseAssignedSupervisor");

        private readonly By DivisionsDepartmentsDropdown = By.Id("caseViewDropdownMenuDepartment");

        private readonly By CaseSummaryTab = By.Id("summaryTabId");

        private readonly By CaseTab = By.Id("caseTabId");

        private readonly By AlertMessage = By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right']/div");

        private readonly By AlertMessageClose = By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right']/child::button");

        #endregion

        #region Tabs Section Locators

        private readonly By AmountsTab = By.Id("recoveryTabId");

        private readonly By SubjectsTab = By.Id("subjectTabId");

        private readonly By RelatedCasesAndLeadsTab = By.XPath("//a[@id='leadRelatedCaseAndLeadTabId']");

        private readonly By ActivitiesTab = By.Id("activityTabId");

        private readonly By AuditLogTab = By.Id("auditlogTabId");

        private readonly By AttachmentTab = By.Id("attachmentTabId");

        private readonly By FindingsTab = By.Id("findingTabId");

        private readonly By CaseClaimTab = By.XPath("//*[@id='caseClaimTabId']");



        #region Subjects Section Locators

        private readonly By AddSubjectButton = By.XPath("//button[contains(text(),'Add Subject')]");

        private readonly By AddSubjectOptionsDropdown = By.XPath("//button[text()='Options']");

        private readonly By ManualAddSubjectOption = By.XPath("//span[@class='dropdown ng-scope open']/child::ul/li/a[text()=' Manually Enter Subject']");

        private readonly By SearchForSubjectOption = By.XPath("//a[contains(text(),'Search For Subject')]");

        private readonly By SubjectIDInput = By.XPath("//input[@id='ViewSubjectId']");

        private readonly By FirstNameInput = By.XPath("//input[@id='ViewSubjectFirstName']");

        private readonly By LastNameInput = By.XPath("//input[@id='ViewSubjectLastName']");

        private readonly By SaveSubjectButton = By.XPath("//button[@id='btnEditSave']");

        private readonly By SearchSubjectButton = By.XPath("//button[@id='subjectSearchBtn']");

        private readonly By FirstNameSearchInput = By.XPath("//input[@ng-model='$parent.searchFname']");

        private readonly By LastNameSearchInput = By.XPath("//input[@ng-model='$parent.searchLname']");

        private readonly By SearchButton = By.XPath("//button[@ng-disabled='!isCriteriaSelected']");

        private readonly By AddSelectedSubjectsButton = By.XPath("//button[text()='Add Subject(s)']");

        private readonly By ConfirmAddSubject = By.XPath("//button[contains(text(),'Continue')]");

        private readonly By SubjectSelectCriteria = By.XPath("//div[@id='caseSubjectColladpsedDiv']/child::div/div/div/select[@id='criteria']");

        private readonly By AddSubjectCheckbox = By.XPath("//input[@ng-click='checkUncheckAll()']");

        private readonly By UpdateCasePrimarySubject = By.XPath("//button[@ng-click='ok()']");

        private readonly By NPIValue = By.XPath("//div[@class='HmsInsideContainer']/child::span/button/span[@class='ng-binding ng-scope']");

        #endregion

        #region Activity Section Locators

        private readonly By AddActivityButton = By.Id("addActivityId");

        private readonly By ActivityNameDropdown = By.Id("name");

        private readonly By CreateActivityButton = By.XPath("//span[contains(text(),'Create Activity')]");

        private readonly By SaveActivityButton = By.XPath("//span[contains(text(),'Save')]");

        private readonly By ExitActivityButton = By.XPath("//*[@id='activitydetail']//button[contains(text(),'Exit Activity')]");

        private readonly By CloseActivityButton = By.XPath("//*[@id='noteAttachmentWidgetId']/div[1]/div[2]/img");

        private readonly By DueDateInput = By.XPath("//input[@name='dueDate']");

        private readonly By ActivityExpenseAmount = By.XPath("//*[@id='expenses']");

        private readonly By ActivityContinueButton = By.XPath("//button/span[text()='Continue']");

        private readonly By ActivityDetailTab = By.XPath("//*[@id='activityDetailTabId']");

        private readonly By ActivityTableCreatedDateColumn = By.XPath("//table[@class='table  table-striped table-hover table-responsive tableMarginBottom']/thead/tr/th[3]");

        private readonly By ActivityAssignedToDropdown = By.XPath("//button[@id='dropdownMenuActivityUser']");

        private readonly By ActivityAssignedToValue = By.XPath("//ul[@id='actViewAssignedTo']/li/a[text()='Jha, Narottam ']");

        private readonly By GetAssigneeValue = By.XPath("//table/tbody/tr[@ng-repeat='row in caseActivityTableData.rows'][2]/td[2]");

        private readonly By ActivityReassignedToValue = By.XPath("//ul[@id='actViewAssignedTo']/li/a[text()='D, Jayapradha ']");

        private readonly By GetStatusValue = By.XPath("//table/tbody/tr[@ng-repeat='row in caseActivityTableData.rows'][2]/td[3]");

        private readonly By ExitActivity = By.XPath("//button[@alt='Exit Activity']");

        private readonly By AutoGenActivityEditButton = By.XPath("//table/tbody/tr[@ng-repeat='row in caseActivityTableData.rows'][2]/td/button[@id='editActivityId']");

        private readonly By ActivitiesStartDate = By.XPath("//input[@id='startDate']");

        private readonly By EditActivityTime = By.Id("activityTime");

        private readonly By ActivityCompletionDate = By.Id("completionDate");

        private readonly By EditActivityExpenseTime = By.Id("expenses");

        private readonly By EditActivitySaveButton = By.XPath("//button/span[text()='Save']");

        private readonly By EditActivityNoteButton = By.XPath("//div[@ng-show='hasActivity']/div/button[contains(text(),'Add')]");

        private readonly By EditActivityAddingNotes = By.XPath("//label[text()='Notes']/following::trix-editor");

        private readonly By EditActivitySaveAddedNotes = By.XPath("//div[@class='well well-sm']/button[@id='btnSave'] ");

        private readonly By EditActivityConfirmSaveAddedNotes = By.XPath("//div[@class='modal-footer']/button[text()='Save'] ");

        private readonly By ActivityAttachmentsTab = By.XPath("//*[@id='attachmentTabId']");

        private readonly By AddActivityAttachmentsButton = By.XPath("//div[@class='well-sm white']/button[@ng-click='onAddClick()']");

        private readonly By ActivityBackButton = By.XPath("//div[@class='well well-sm ']/button[@ng-click='onBackClickAttachement()']");

        #endregion

        #region Attachments and Notes Section Locators

        private readonly By AddAttachmentButton = By.XPath("//button[contains(text(),'Add Attachment')]");

        private readonly By AttachmentTitleInput = By.XPath("//input[@id='attachmentTitle']");

        private readonly By AttachmentFileInput = By.XPath("//input[@type='file']");

        private readonly By UploadAttachmentButton = By.XPath("//button[contains(text(),'Upload')]");

        private readonly By NotesTab = By.Id("notesTabId");

        private readonly By ActivityNoteTextarea = By.XPath("//textarea[@ng-model='activityNote']");

        private readonly By AddNoteButton = By.CssSelector("#activitydetail > div.row > div > button:nth-child(2)");

        private readonly By NoteInput = By.Id("notes");

        private readonly By SaveNoteButton = By.XPath("//*[@id='noteEditForm']//button[contains(text(),'Save')]");

        private readonly By DeleteNoteButton = By.XPath("//button[contains(@ng-click,'deleteNote')]");

        private readonly By NoteContent = By.XPath("//div[contains(@class,'note-content')]");

        #endregion

        #region Download Attachment Manager Locators

        private readonly By DownloadAllAttachmentsButton = By.XPath("//button[contains(text(),'Download All Attachments')]");

        private readonly By ActivityLevelDownloadAttachmentManagerButton = By.XPath("//*[@id='attachment']/div[1]/button[3]");

        private readonly By CaseLevelDownloadAttachmentManagerButton = By.XPath("//*[@id='addActivityDivId']/button[4]");

        private readonly By CaseLevelDownloadAttachmentManagerDropdown = By.XPath("//*[@id='activityTableTools']");

        private readonly By DownloadAttachmentManagerButton = By.XPath("//button[@id='downloadAttachmentManager']");

        private readonly By DownloadSelectedButton = By.XPath("//button[contains(text(),'Download Selected')]");

        private readonly By SelectAllAttachmentsCheckbox = By.XPath("//input[@type='checkbox' and contains(@ng-model,'selectAll')]");

        private readonly By CloseDownloadManagerButton = By.XPath("//button[contains(text(),'Close')]");

        #endregion

        #region Claims Section Locators

        private readonly By ClaimsButton = By.XPath("//*[text()='Claims']");

        private readonly By CaseClaimDetailButton = By.XPath("//*[contains(text(),'Case Claims Detail')]");

        private readonly By CaseClaimDetailData = By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[7]/td[5]/child::div");

        private readonly By CaseClaimDetailsReportViewExcel = By.XPath("//*[@id='reportViewer_ctl09_ctl04_ctl00_ButtonLink']");

        private readonly By CaseClaimDetailsReportViewExcelData = By.XPath("//*[@id='reportViewer_ctl09_ctl04_ctl00_Menu']/child::div/a[text()='Excel']");

        private readonly By CaseClaimStatusAsCompleted = By.XPath("//div[@id='ClaimId']/child::div[@class='HmsTableContainer']/div/div/div/table/tbody/tr/td[11]");

        private readonly By CaseClaimStatusAsRevisionInProgress = By.XPath("//div[@id='ClaimId']/child::div[@class='HmsTableContainer']/div/div/div/table/tbody/tr[1]/td[11]");

        private readonly By ClaimSelector = By.XPath("//button[text()='Claim Selector']");

        private readonly By ClaimSelectAllButton = By.XPath("//*[@id='providerSubjectSelectAllId']");

        private readonly By ClaimNextButton = By.XPath("//form/button[contains(text(),'Next')]");

        private readonly By SelectClaimsFromAList = By.XPath("//*[@id='executeQueryButton']");

        private readonly By ClaimSearchButton = By.XPath("//form/div/div/div[1]/div/div[5]/button[@id='searchStartButton']");

        private readonly By ClaimClearButton = By.XPath("//form/div/div/div[1]/div/div[5]/button[@id='searchClearButton']");

        private readonly By ClaimsSearchDropdown = By.XPath("//form[@name='claimForm']/descendant::select[@name='selectedCriteria']");

        private readonly By SearchInput = By.XPath("//form/div/div/div[1]/div/div[2]/input[@id='searchId']");

        private readonly By ClaimSelectorButton = By.XPath("//button[@id='claimSelectorButton']");

        private readonly By ClaimNumberInput = By.XPath("//input[@id='claimNumberInput']");

        private readonly By SearchClaimButton = By.XPath("//button[@id='searchClaimButton']");

        private readonly By ClearClaimButton = By.XPath("//button[@id='clearClaimButton']");

        private readonly By CaseClaimLink = By.XPath("//a[contains(@class,'claim-link')]");

        private readonly By ClaimLinePreviewPopup = By.XPath("//div[@id='claimLinePreviewPopup']");

        private readonly By DownloadClaimsDetailButton = By.XPath("//button[@id='downloadClaimsDetailButton']");

        private readonly By ClaimDropdown = By.XPath("//select[@ng-model='selectedClaim']");

        private readonly By CloseClaimLinesPopup = By.XPath("//*[@id='selectorClaimLineModal']/descendant::img");

        private readonly By ClaimsDenyViewButton = By.XPath("//div[@id='ClaimId']/child::div[@class='HmsTableContainer']/div/div/div/table/tbody/tr/td/button[text()='View']");

        private readonly By ClaimReviewProfessionalEditButton = By.XPath("//div[@class='well well-sm HmsInsideContainer']/button[@ng-click='edit()']");

        private readonly By ClaimReviewProfessionalCancelButton = By.XPath("//div[@class='row']/div/img[@ng-click='cancel()']");

        private readonly By ClaimReviewProfessionalSaveButton = By.XPath("//div[@class='well well-sm HmsInsideContainer']/button[@ng-click='ok()']");

        #endregion

        #region Findings Section Locators

        private readonly By AddFindingButton = By.XPath("//div/button[@title='Add Finding']");

        private readonly By FindingReason = By.XPath("//*[@id='findingReasonId']");

        private readonly By FindingSubject = By.XPath("//select[@name='subjectId']");

        private readonly By TotalUnderpaymentAmount = By.XPath("//*[@id='totalUnderpayment']");

        private readonly By TotalOverpaymentAmount = By.XPath("//*[@id='totalOverpayment']");

        private readonly By TotalSoftSavingAmount = By.XPath("//*[@id='totalSoftSaving']");

        private readonly By NumberOfMembersInPopulationWithFindings = By.XPath("//*[@id='numberOfMembersFindings']");

        private readonly By NumberOfClaimsInPopulationWithFindings = By.XPath("//*[@id='numberOfClaimsFindings']");

        private readonly By NumberOfLinesInPopulationWithFindings = By.XPath("//*[@id='numberOfLinesFindings']");

        private readonly By NumberOfProvidersInPopulationWithFindings = By.XPath("//*[@id='numberOfProvidersFindings']");

        private readonly By Comments = By.XPath("//textarea[@id='Comments']");

        private readonly By FindingLineOfBusiness = By.XPath("//select[@name='LOB']");

        private readonly By AddFindingsSaveButton = By.XPath("//*[@id='CaseFindingForm']/div[2]/div[1]/button[contains(.,'Save')]");

        private readonly By FindingsRevisionPlusButton = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr/td[25]/button");

        private readonly By FindingsRevisionMinusButton = By.XPath("//div[@class='well-sm HmsInsideContainer']/div/div/table/tbody/tr[3]/td[25]/button");

        private readonly By FindingRevisionFindingDropdown = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[21]/select");

        private readonly By RevisionClaimLinesCPTORHCPCSORRatesORHIPPS = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[8]/input");

        private readonly By RevisionClaimLinesMod2 = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[11]/input");

        private readonly By RevisionClaimLinesUnits = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[16]/input");

        private readonly By RevisionClaimLinesFindingDropDown = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[21]/select");

        private readonly By RevisionClaimLinesReasonDropDown = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[22]/select");

        private readonly By RevisionClaimLinesComments = By.XPath("//div[@ng-repeat='row in nonRevisedClaimLines'][1]/child::div/table/tbody/tr[3]/td[24]/textarea");

        #endregion

        #region Reports Section Locators

        private readonly By PatientHistoriesReportButton = By.XPath("//button[contains(text(), 'Patient Histories')]");

        private readonly By RunReportButton = By.XPath("//button[@id='runReportButton']");

        private readonly By DownloadExcelReportButton = By.XPath("//button[@id='downloadExcelReportButton']");

        private readonly By ReportContent = By.XPath("//div[@id='reportContent']");

        private readonly By CloseReportButton = By.XPath("//button[@id='closeReportButton']");

        #endregion

        #region Common Buttons and Controls

        private readonly By ConfirmationPopup = By.XPath("//button[text()='OK']");

        private readonly By OkButton = By.XPath("//button[contains(text(),'OK')]");

        private readonly By CancelButton = By.XPath("//button[contains(text(),'Cancel')]");

        private readonly By ConfirmButton = By.XPath("//button[contains(text(),'Confirm')]");

        private readonly By CloseButton = By.XPath("//button[contains(text(),'Close')]");

        private readonly By ModalDialog = By.XPath("//div[@class='modal-dialog']");

        private readonly By SuccessAlert = By.XPath("//div[@class='alert alert-success']");

        private readonly By ErrorAlert = By.XPath("//div[@class='alert alert-danger']");
        private readonly By  selectAssignActivityTo = (By.Id("dropdownMenuActivityUser"));
        #endregion

        #region Grid and Table Locators

        private readonly By SubjectsTable = By.Id("Subjects");

        private readonly By AuditLogTable = By.Id("AuditLog");

        private readonly By RecoveriesTable = By.Id("Recoveries");

        private readonly By ActivitiesTable = By.XPath("//table[@class='table  table-striped table-hover table-responsive tableMarginBottom']");

        private readonly By FirstActivityRow = By.XPath("//table[@class='table  table-striped table-hover table-responsive tableMarginBottom']/tbody/tr[1]");

        private readonly By HasNoteAttachmentColumn = By.XPath("//th[contains(text(),'Has Note/Attachment')]");

        private readonly By NoteAttachmentIcon = By.XPath("//i[contains(@class,'fa-paperclip') or contains(@class,'fa-sticky-note')]");

        private readonly By TooltipText = By.XPath("//div[@class='tooltip-inner']");

        #endregion

        #region Dynamic Locators (Methods)

        public IWebElement GetActivityByName(string activityName)
        {
            return driver.FindElement(By.XPath($"//table[@class='table  table-striped table-hover table-responsive tableMarginBottom']/tbody/tr[contains(.,'{activityName}')]"));
        }

        public IWebElement GetAttachmentByTitle(string title)
        {
            return driver.FindElement(By.XPath($"//table//tr[contains(.,'{title}')]"));
        }

        public IWebElement GetClaimByNumber(string claimNumber)
        {
            return driver.FindElement(By.XPath($"//table//tr[contains(.,'{claimNumber}')]"));
        }

        public IWebElement GetFindingBySubject(string subject)
        {
            return driver.FindElement(By.XPath($"//table//tr[contains(.,'{subject}')]"));
        }

        public IWebElement GetColumnHeaderByText(string headerText)
        {
            return driver.FindElement(By.XPath($"//th[contains(text(),'{headerText}')]"));
        }

        public IWebElement GetSubjectRow(string firstName, string lastName)
        {
            var subjectName = firstName + ' ' + lastName;
            return driver.FindElement(By.XPath($"//table[@id='Subjects']//tr[contains(.,'{subjectName}')]"));
        }

        public IWebElement GetActivityEditButton(string activityName)
        {
            return driver.FindElement(By.XPath($"//table//tr[contains(td[1],'{activityName}')]//button[@id='editActivityId']"));
        }
        public decimal GetFirstAmount
        {
            get
            {
                var amountString = driver.FindElement(By.XPath("//*[@id='Recoveries']/tbody/tr[1]/td[4]/small")).Text;
                return decimal.Parse(amountString, System.Globalization.NumberStyles.Currency);
            }
        }

        /// <summary>
        /// Returns true if the subjects table element is visible
        /// </summary>
        /// <returns></returns>
        public bool CanViewSubjects()
        {
            try
            {
                var subjectsTable = driver.FindElement(By.Id("Subjects"));
                return driver.FindElement(SubjectsTable).Displayed;
            }
            catch (NoSuchElementException) { }

            return false;

        }

        /// <summary>
        /// Returns true if the audit log table element is visible
        /// </summary>
        /// <returns></returns>
        public bool CanViewAuditLog()
        {
            try
            {
                var auditLogTable = driver.FindElement(By.Id("AuditLog"));
                return driver.FindElement(AuditLogTable).Displayed;
            }
            catch (NoSuchElementException) { }

            return false;
        }

        public void ShowCaseSummary()
        {
            driver.FindElement(CaseSummaryTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        /// <summary>
        /// Clicks on the audit log tab then waits for loading to finish.
        /// </summary>
        public void ShowAuditLog()
        {
            driver.FindElement(AuditLogTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void BeginEditingCase()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);
            try
            {
                if (driver.FindElement(BeginEditingButton).Displayed)
                {
                    WaitForXPathElement("//button[@id='caseViewEditEndButton']");
                    driver.FindElement(BeginEditingButton).Click();
                    CommonHelpers.WaitForPageLoading(driver);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void BeginEditingLead()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);
            try
            {
                if (driver.FindElement(BeginEditingLeadButton).Displayed)
                {
                    WaitForXPathElement("//button[@id='leadViewEditEndButton']");
                    driver.FindElement(BeginEditingLeadButton).Click();
                    CommonHelpers.WaitForPageLoading(driver);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void clickClaimsButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            driver.FindElement(ClaimsButton).Click();

        }
        /// <summary>
        /// Clicks the save button then returns true if the notification received tells us the save was successful
        /// </summary>
        /// <returns></returns>
        public bool SaveEditing()
        {
            driver.FindElement(SaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            var alert = driver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right ng-star-inserted']"));
            var alertMessage = alert.FindElement(By.XPath(".//div"));
            CommonHelpers.CloseAlert(driver);
            return driver.FindElement(AlertMessage).Text == "Changes have been saved.";
        }

        public void SetAlternateCaseId(string alternateCaseId)
        {
            //WaitForXPathElement("//input[@id='caseViewSummaryReferenceId']");
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AlternateCaseIdInput).Clear();
            driver.FindElement(AlternateCaseIdInput).SendKeys(alternateCaseId);
        }

        /// <summary>
        /// Clicks on the Subjects tab then waits for loading to finish.
        /// </summary>
        public void ShowSubjects()
        {
            driver.FindElement(SubjectsTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void AddSubjectManually(string subjectID, string firstName, string lastName)
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AddSubjectButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AddSubjectOptionsDropdown).Click();
            driver.FindElement(ManualAddSubjectOption).Click();
            driver.FindElement(SubjectIDInput).Clear();
            driver.FindElement(SubjectIDInput).SendKeys(subjectID);
           driver.FindElement( FirstNameInput).Clear();
            driver.FindElement(FirstNameInput).SendKeys(firstName);
            driver.FindElement(LastNameInput).Clear();
            driver.FindElement(LastNameInput).SendKeys(lastName);
            driver.FindElement(SaveSubjectButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AlertMessageClose).Click();

        }

        public void SearchAndAddSubject(string Providername, string firstName, string lastName)
        {
            driver.FindElement(AddSubjectButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AddSubjectOptionsDropdown).Click();
            driver.FindElement(SearchForSubjectOption).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            var selectCriteria = new SelectElement(driver.FindElement(SubjectSelectCriteria));
            selectCriteria.SelectByText(Providername);
            driver.FindElement(LastNameSearchInput).SendKeys(lastName);
            driver.FindElement(FirstNameSearchInput).SendKeys(firstName);
            driver.FindElement(SearchButton).Click();
           CommonHelpers.WaitForSearchResultsLoading(driver,30);
            driver.FindElement(AddSubjectCheckbox).Click();
            driver.FindElement(AddSelectedSubjectsButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ConfirmAddSubject).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);
        }

        public bool NewSubjectAppears(string firstName, string lastName)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var waitForSubject = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var subjectName = firstName + ' ' + lastName;
            string caseSubjectName = string.Empty;
            waitForSubject.Until(d =>
            {
                try
                {
                    var subjectsRow = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'row in tableData.rows')]"));
                    var selectedSubject = subjectsRow.Where(row =>
                    {
                        var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();

                        return subjectName == selectedSubjectName;
                    }).FirstOrDefault();

                    caseSubjectName = selectedSubject.FindElements(By.TagName("small"))[1].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseSubjectName))
            {
                return false;
            }
            else
            {
                DeleteSubject(firstName, lastName);
                return true;
            }
        }

        public void DeleteSubject(string firstName, string lastName)
        {
            var subjectName = firstName + ' ' + lastName;
            var subjectsRow = driver.FindElements(By.XPath("//*[@ng-repeat='row in tableData.rows']"));
            var selectedSubject = subjectsRow.Where(row =>
            {
                var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();

                return subjectName == selectedSubjectName;
            }).First();

            var buttons = selectedSubject.FindElements(By.TagName("small")).Last();
            var deleteSubjectButton = buttons.FindElement(By.XPath("//table[@id='Subjects']/tbody/tr[2]/td[10]/small/span/button[contains(text(),'Delete')]"));
            deleteSubjectButton.Click();
           CommonHelpers.WaitForPageLoading(driver);
            var confirmDeleteSubjectButton = driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));
            confirmDeleteSubjectButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void NavigateToSubjectProfile()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'row in tableData.rows')]"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var subjectMasterId = firstRowData.ElementAt(0).FindElement(By.XPath(".//a"));
            subjectMasterId.Click();
        }

        public void ShowRelatedCasesAndLeads()
        {
            CommonHelpers.WaitForPageLoading(driver); 
            driver.FindElement(RelatedCasesAndLeadsTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void SearchRelatedCase(string relatedCaseId)
        {
            //WaitForXPathElement("//select[@id='relatedCasesSearchType']");
            CommonHelpers.WaitForPageLoading(driver);
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("relatedCasesSearchType")));
            selectCriteria.SelectByText("Case/Lead ID");
            var caseIdInput = driver.FindElement(By.Id("relatedCasesSearchTxt"));
            driver.FindElement(CaseIdInput).SendKeys(relatedCaseId);
            CommonHelpers.WaitForPageLoading(driver);
            var searchButton = driver.FindElement(By.XPath(""));
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public bool AddRelatedCase()
        {
            var relateToCase = driver.FindElement(By.XPath("//a[contains(text(),'Relate to Case/Lead')]"));
            CommonHelpers.ScrollByElementCoordinates(driver,relateToCase);
            relateToCase.Click();
            CommonHelpers.WaitForPageLoading(driver);
            var alert = driver.FindElement(By.XPath("//*[contains(@ng-repeat,'m in notification.queue')]"));
            var alertMessageText = alert.FindElement(By.XPath(".//div")).Text;
            var removeRelatedCase = driver.FindElement(By.XPath("//tbody/tr[2]/td[3]/a[1]"));
            CommonHelpers.ScrollByElementCoordinates(driver, removeRelatedCase);
            removeRelatedCase.Click();
            CommonHelpers.WaitForPageLoading(driver);
            var confirmRemoveCaseButton = driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));
            confirmRemoveCaseButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
            return alertMessageText == "Case/Lead IDDEMO0701202104is related to the lead!";
        }

        public void ShowActivities()
        {
            driver.FindElement(ActivitiesTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void AddActivity(string activityName, string assignedTo)
        {
            try
            {
                WaitForWidgetLoading();
                driver.FindElement(AddActivityButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                var selectActivityName = new SelectElement(driver.FindElement(ActivityNameDropdown));
                selectActivityName.SelectByText(activityName);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                var continueButton = driver.FindElement(By.XPath("//button/span[text()='Continue']"));
                continueButton.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                //var selectAssignActivityTo = driver.FindElement(By.Id("dropdownMenuActivityUser"));
                //selectAssignActivityTo.Click();
               // driver.FindElement(By.XPath($"//*[normalize-space()='Jha,Narottam']")).Click();
                //var list = driver.FindElements(By.XPath("//ul[@id='actViewAssignedTo']//li/a"));
                //foreach (IWebElement element in list)
                //{
                //    if (element.Text.Contains(assignedTo))
                //    {
                //        element.Click();
                //        CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                //        break;
                //    }
                //}
                CommonHelpers.WaitForElementVisiblity(driver, selectAssignActivityTo, 30);
                driver.FindElement(selectAssignActivityTo).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                var trimmedAssignedTo = (assignedTo ?? string.Empty).Trim();
                driver.FindElement(By.XPath("//button[@id='dropdownMenuActivityUser']/following-sibling::ul//a[normalize-space()='"+trimmedAssignedTo+"' or contains(normalize-space(),'"+trimmedAssignedTo+"')]")).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

                driver.FindElement(SaveActivityButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(ExitActivityButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        public string downloadCaseClaimsDetailAndValidateDataPopulates()
        {
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(CaseClaimDetailButton).Click();
            switchwindow();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            var text = driver.FindElement(CaseClaimDetailData).Text.Substring(1);
            Console.WriteLine(text);
            return text;
        }
        public void sortActivitesCreatedDateColumn()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElement(By.XPath("//*[@name='activityForm']//table/thead/tr"));
            var firstRow = tableRows;
            var firstRowData = firstRow.FindElements(By.TagName("th"));

            firstRowData.ElementAt(3).FindElement(By.XPath(".//span")).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public bool NewActivityAppears(string activityName)
        {
            var waitForActivity = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string caseActivityName = string.Empty;

            waitForActivity.Until(d =>
            {
                try
                {
                    var activitiesRow = driver.FindElements(By.XPath("//*[@name='activityForm']//table/tbody/tr"));
                    var selectedActivity = activitiesRow.Where(row =>
                    {
                        row.FindElements(By.TagName("td"))[0].Text.Trim();
                        var selectedActivityName = row.FindElements(By.TagName("td"))[0].Text.Trim();

                        return activityName == selectedActivityName;
                    }).First();

                    caseActivityName = selectedActivity.FindElements(By.TagName("td"))[0].Text.Trim();
                    Console.WriteLine(caseActivityName);
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseActivityName))
            {
                return false;
            }
            else
            {
                DeleteActivity(activityName);
                return true;
            }
        }

        public void DeleteActivity(string activityName)
        {
            try
            {
                var activitiesRow = driver.FindElements(By.XPath("//*[@name='activityForm']//table/tbody/tr"));
                var selectedActivity = activitiesRow.Where(row =>
                {
                    var selectedActivityName = row.FindElements(By.TagName("td"))[0].Text.Trim();

                    return activityName == selectedActivityName;
                }).First();

                var buttons = selectedActivity.FindElements(By.TagName("td")).Last();
                var editActivityButton = buttons.FindElement(By.Id("editActivityId"));
                CommonHelpers.ScrollByElementCoordinates(driver, editActivityButton);
                editActivityButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
                var otherActivityOptionsDropdown = driver.FindElement(By.XPath("//select[@id='activityOption']"));
                CommonHelpers.ScrollAndCenterElement(driver, otherActivityOptionsDropdown);
                CommonHelpers.WaitForPageLoading(driver);
                otherActivityOptionsDropdown.Click();
                var deleteActivityOption = driver.FindElement(By.XPath("//option[contains(text(),'Delete Activity')]"));
                deleteActivityOption.Click();
                CommonHelpers.WaitForPageLoading(driver);
                var confirmDeleteActivityButton = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
                confirmDeleteActivityButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        public void SortOnCaseActivitiesGrid()
        {
            var dueDateColumn = driver.FindElement(By.XPath("//b[contains(text(),'Due Date')]"));
            dueDateColumn.Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public string GetCaseActivityDueDate()
        {
            var waitForCaseActivityRow = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string caseActivityDueDate = string.Empty;
            waitForCaseActivityRow.Until(d =>
            {
                try
                {
                    var caseActivityRow = driver.FindElement(By.XPath("//*[@ng-repeat='row in caseActivityTableData.rows']"));
                    caseActivityDueDate = caseActivityRow.FindElements(By.TagName("td"))[3].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseActivityDueDate))
                throw new Exception("Could not retrieve case activity due date");

            return caseActivityDueDate;
        }

        public string GetCaseActivityStatus(string activityName)
        {
            string caseActivityStatus = string.Empty;

            var activitiesRow = driver.FindElements(By.XPath("//*[@name='activityForm']//table/tbody/tr"));
            var selectedActivity = activitiesRow.Where(row =>
            {
                var selectedActivityName = row.FindElements(By.TagName("td"))[0].Text.Trim();
                return activityName == selectedActivityName;
            }).First();

            caseActivityStatus = selectedActivity.FindElements(By.TagName("td"))[2].Text.Trim();

            if (string.IsNullOrWhiteSpace(caseActivityStatus))
                throw new Exception("Could not retrieve case activity status");

            return caseActivityStatus;
        }

        public void SelectFirstActivity()
        {
            var firstActivityEditButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[9]/button[1]"));
            firstActivityEditButton.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,50);
        }

        public void CloseActivity()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,50);

            driver.FindElement(CloseActivityButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,50);
        }

        public void HoveingOverAttachmentAndNotesColumn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var iconElement = driver.FindElement(By.XPath("//*[@id='activity']/form/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[8]/span/i"));

            new Actions(driver).MoveToElement(iconElement).Perform();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            By.CssSelector("[class*='mat-tooltip'], [class*='mat-mdc-tooltip'], .cdk-overlay-container .mdc-tooltip__surface");
            // adjust selector based on actual tooltip markup, e.g. ".tooltip-inner" for Bootstrap


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
        public void clickFindingsTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            driver.FindElement(FindingsTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
        }
        public string GetAttachmentAndNotesColumnText()
        {
            var AttahmentAndNotestext = driver.FindElement(By.XPath("//*[@id='activity']/form/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[8]/span/i"));

            AppConstants.NotesandAttachmenttext = AttahmentAndNotestext.GetAttribute("title");
            Console.WriteLine(AppConstants.NotesandAttachmenttext);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            return AppConstants.NotesandAttachmenttext;
        }



        public void CloseActivityForHandlingConfirmationPopup()
        {
            try
            {
                CommonHelpers.WaitForPageLoading(driver);
                driver.FindElement(CloseActivityButton).Click();
                var confirmSaveButton = driver.FindElement(By.XPath("//fc-app-confirmation/div[@class='modal-footer']/button[text()='Yes']"));
                if(confirmSaveButton.Displayed && confirmSaveButton.Enabled)
                {
                    confirmSaveButton.Click();
                    driver.FindElement(CloseActivityButton).Click();
                }
                
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
        public void AddNewNote(string note)
        {
            try
            {
                CommonHelpers.ScrollAndCenterElement(driver, driver.FindElement(ActivityDetailTab));
                driver.FindElement(ActivityDetailTab).Click();
                CommonHelpers.WaitForPageLoading(driver);
                CommonHelpers.ScrollByElementCoordinates(driver, driver.FindElement(AddNoteButton));
                driver.FindElement(AddNoteButton).Click();
                driver.FindElement(NoteInput).SendKeys(note);
                CommonHelpers.WaitForPageLoading(driver);
                driver.FindElement(SaveNoteButton).Click();
                CommonHelpers.WaitForPageLoading(driver);
                var confirmSaveButton = driver.FindElement(By.XPath("//button[contains(.,'Yes')]"));
                confirmSaveButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }



        public string GetActivityNote()
        {
            string noteText = string.Empty;

            try
            {
                CommonHelpers.WaitForPageLoading(driver);
                var selectOptionDropdown = driver.FindElement(By.XPath("//select[@id='noteOption']"));
                selectOptionDropdown.Click();
                CommonHelpers.WaitForPageLoading(driver);
                noteText = driver.FindElement(By.XPath("//*[@id='activitydetail']/div[3]/div[2]/div/div/div")).Text;

                if (string.IsNullOrWhiteSpace(noteText))
                {
                    throw new Exception("Could not retrieve activity note");
                }
                else
                {
                    DeleteNote();
                    return noteText;
                }
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                return noteText;
                throw new Exception(e.Message);
            }
        }

        public void DeleteNote()
        {
            try
            {
                var selectActivityOption = new SelectElement(driver.FindElement(By.XPath("//select[@id='noteOption']")));
                selectActivityOption.SelectByText("Delete Note");

                var confirmDeleteNoteButton = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
                confirmDeleteNoteButton.Click();
                CommonHelpers.CloseAlert(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }


        public void AddNewAttachment()
        {
            try
            {
                CommonHelpers.ScrollAndCenterElement(driver, driver.FindElement(AttachmentTab));
                driver.FindElement(AttachmentTab).Click();
                CommonHelpers.WaitForPageLoading(driver);
                try
                {
                    if (NewAttachmentAppearsInTheList("TestFile.txt"))
                    {
                        SelectFirstActivity();
                        CommonHelpers.ScrollAndCenterElement(driver, driver.FindElement(AttachmentTab));
                        driver.FindElement(AttachmentTab).Click();
                        CommonHelpers.WaitForPageLoading(driver);
                    }
                }
                catch (InvalidOperationException)
                {
                    //No existing attachment. Move along.
                }

                driver.FindElement(AddAttachmentButton).Click();
                CommonHelpers.WaitForPageLoading(driver);
                var fileUploadArea = driver.FindElement(By.Id("fileLabel"));
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "");
                var fileName = Path.Combine(path, "TestFile.txt");
                DropFile(fileUploadArea, fileName);
                WaitForAttachmentUpload(120);
                CommonHelpers.WaitForSearchResultsLoading(driver, 20);
                var backButton = driver.FindElement(By.XPath("//*[@id='attachmentAddForm']//button[contains(text(),'Back')]"));
                backButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
                driver.FindElement(AttachmentTab).Click();
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;";

        public void DropFile(IWebElement target, string filePath, double offsetX = 0, double offsetY = 0)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
            input.SendKeys(filePath);
        }

        public bool NewAttachmentAppearsInTheList(string title)
        {
            var waitForAttachment = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string attachmentTitle = string.Empty;
            waitForAttachment.Until(d =>
            {
                try
                {
                    var attachments = driver.FindElements(By.XPath("//*[@id='attachmentTableId']/div/table/tbody/tr"));
                    var selectedAttachment = attachments.Where(row =>
                    {
                        var selectedTitle = row.FindElements(By.TagName("td"))[1].Text;
                        return title == selectedTitle;
                    }).First();

                    attachmentTitle = selectedAttachment.FindElements(By.TagName("td"))[1].Text;
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(attachmentTitle))
            {
                return false;
            }
            else
            {
                DeleteAttachment(title);
                return true;
            }
        }

        public void DeleteAttachment(string title)
        {
            try
            {
                var attachments = driver.FindElements(By.XPath("//*[@id='attachmentTableId']/div/table/tbody/tr"));
                var selectedAttachment = attachments.Where(row =>
                {
                    var selectedTitle = row.FindElements(By.TagName("td"))[1].Text;
                    return title == selectedTitle;
                }).First();

                var deleteAttachmentButton = selectedAttachment.FindElement(By.XPath("//tbody/tr[1]/td[5]/div/button[4]"));
                deleteAttachmentButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
                var confirmDeleteAttachmentButton = driver.FindElement(By.XPath("//button[2][contains(text(),'Yes')]"));
                confirmDeleteAttachmentButton.Click();
                CommonHelpers.CloseAlert(driver);
                CloseActivity();
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        private void WaitForAttachmentUpload(int seconds)
        {
            By alertDismissBtn = By.XPath("//button[@aria-label='Close']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(alertDismissBtn));
        }

        /// <summary>
        /// Clicks the Amounts tab then waits for loading to finish.
        /// </summary>
        public void ShowAmounts()
        {
            driver.FindElement(AmountsTab).Click();
           CommonHelpers.WaitForPageLoading(driver);
        }

        /// <summary>
        /// Selects the first available amount in the Amounts tab
        /// </summary>
        public void SelectFirstAmount()
        {
            //var firstAmountEditButton = Driver.FindElement(By.XPath("//*[@id='Recoveries0C18C20']/img"));
            var firstAmountEditButton = driver.FindElement(By.XPath("//tr[1]//td[11]//small[1]//span[1]//span[1]//img[1]"));
            firstAmountEditButton.Click();
            //WaitForModuleLoading();
        }

        /// <summary>
        /// Sets the amount for the payment to the given amount
        /// </summary>
        /// <param name="amount"></param>
        public void SetAmount(decimal amount)
        {
            //AmountInput.Clear();
            //AmountInput.SendKeys(amount.ToString());
        }

        /// <summary>
        /// Clicks the save button for the amount currently being edited then waits for the module to finish loading.
        /// </summary>
        public void SaveAmount()
        {
            //AmountSaveButton.Click();
           CommonHelpers.WaitForPageLoading(driver);
        }
        public bool RunSummaryReport(string expectedData)
        {
            string actualData = string.Empty;

            try
            {
                var reportsDropdown = driver.FindElement(By.XPath("//*[@id='caseDetailsTab']/div[1]/div/span/button"));
                reportsDropdown.Click();
                var SummaryReportButton = driver.FindElement(By.XPath("//a[contains(text(),'Summary Report')]"));
                SummaryReportButton.Click();
                Task.Delay(5000).Wait();
                CommonHelpers.SwitchtoNewWindow(driver);
                CommonHelpers.WaitForReportLoading(driver, 120);
                actualData = driver.FindElement(By.XPath("//table/tbody/tr[2]/td[5]/table/tbody/tr[6]/td[2]/div/div")).Text;
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return actualData.Equals(expectedData);
            }
            catch (WebDriverException)
            {
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return (actualData.Equals(expectedData));
                throw new Exception("Could not retrieve actual data from the report");
            }

        }
        public bool RunChronologyReport(string expectedData)
        {
            string actualData = string.Empty;

            try
            {
                var reportsDropdown = driver.FindElement(By.XPath("//*[@id='caseDetailsTab']/div[1]/div/span/button"));
                reportsDropdown.Click();
                var ChronologyReportButton = driver.FindElement(By.XPath("//a[contains(text(),'Chronology Report')]"));
                ChronologyReportButton.Click();
                Task.Delay(5000).Wait();
                CommonHelpers.WaitForWindowHandles(driver);
                CommonHelpers.WaitForReportLoading(driver, 120);
                actualData = driver.FindElement(By.XPath("//td[2]/div/div[contains(text(),'(DO NOT MODIFY) Automated Investigative Workflow')]")).Text;
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return actualData.Equals(expectedData);
            }
            catch (WebDriverException)
            {
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return (actualData.Equals(expectedData));
                throw new Exception("Could not retrieve actual data from the report");
            }
        }

        public bool RunMonitoringReport(string providerId, string subjectName, string baselinePaidDateFrom, string baselinePaidDateTo, string monitoringPaidDateFrom, string monitoringPaidDateTo, string serviceCode1, string serviceCode2, string expectedData)
        {
            string actualData = string.Empty;

            try
            {
                var reportsDropdown = driver.FindElement(By.XPath("//*[@id='caseDetailsTab']/div[1]/div/span/button"));
                reportsDropdown.Click();
                var MonitoringReportButton = driver.FindElement(By.XPath("//a[contains(text(),'Monitoring Report')]"));
                MonitoringReportButton.Click();
                Task.Delay(5000).Wait();
                CommonHelpers.WaitForWindowHandles(driver);
                WaitForXPathElement("//input[@name='reportViewer$ctl08$ctl03$txtValue']");
                var providerIdInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl03$txtValue']"));
                providerIdInput.SendKeys(providerId);
                var subjectNameInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl05$txtValue']"));
                subjectNameInput.SendKeys(subjectName);
                var baselinePaidDateFromInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl07$txtValue']"));
                baselinePaidDateFromInput.SendKeys(baselinePaidDateFrom);
                var baselinePaidDateToInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl09$txtValue']"));
                baselinePaidDateToInput.SendKeys(baselinePaidDateTo);
                var monitoringPaidDateFromInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl11$txtValue']"));
                monitoringPaidDateFromInput.SendKeys(monitoringPaidDateFrom);
                var monitoringPaidDateToInput = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl13$txtValue']"));
                monitoringPaidDateToInput.SendKeys(monitoringPaidDateTo);
                var serviceCode1Input = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl15$txtValue']"));
                serviceCode1Input.SendKeys(serviceCode1);
                var serviceCode2Input = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl27$txtValue']"));
                serviceCode2Input.SendKeys(serviceCode2);
                var viewReportButton = driver.FindElement(By.XPath("//input[@name='reportViewer$ctl08$ctl00']"));
                viewReportButton.Click();
                CommonHelpers.WaitForReportLoading(driver, 120);
                actualData = driver.FindElement(By.XPath("//div[contains(text(),'45')]")).Text;
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return actualData.Equals(expectedData);
            }
            catch (WebDriverException)
            {
                CommonHelpers.CloseWindowHandles(driver);
                CommonHelpers.CloseWindowHandles(driver);
                return (actualData.Equals(expectedData));
                throw new Exception("Could not retrieve actual data from the report");
            }
        }

        public bool SubjectIsPresentInSubjectNamesTable(string firstName, string lastName)
        {
            var subjectNamesTable = driver.FindElement(By.Id("caseViewSummarySubjectNameInfo"));
            var tableRows = subjectNamesTable.FindElements(By.XPath("//*[@id='caseViewSummarySubjectNameInfo']/tbody/tr"));
            try
            {
                var selectedRow = tableRows.Where(row =>
                {
                    var subjectNameText = row.FindElements(By.TagName("td"))[0].Text.Trim();
                    return subjectNameText.Contains(firstName + " " + lastName);
                }).First();

                CommonHelpers.CloseWindowHandles(driver     );
                var headerComponent = new HeaderComponentType(driver);
                headerComponent.CloseQuickSearch();
                return true;
            }
            catch (NoSuchElementException)
            {
                CommonHelpers.CloseWindowHandles(driver);
                var headerComponent = new HeaderComponentType(driver);
                headerComponent.CloseQuickSearch();
                return false;
            }
        }

        public void WaitForXPathElement(string elementLocator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(180));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementLocator)));
        }

        private void WaitForWidgetLoading()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => !d.FindElements(By.XPath("//div[contains(@class,'widget-loading')]")).Any(e => e.Displayed));
        }

        private void WaitForLoaderToDisappear()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => !d.FindElements(By.XPath("//div[contains(@class,'loader')]")).Any(e => e.Displayed));
        }

        private void SelectDropDownOption(By dropdownLocator, string optionText)
        {
            var dropdown = new SelectElement(driver.FindElement(dropdownLocator));
            dropdown.SelectByText(optionText);
        }

        public string GetCaseId()
        {
            CommonHelpers.WaitForPageLoading(driver);
            AppConstants.CaseId = driver.FindElement(CaseIdInput).GetAttribute("value");
            return AppConstants.CaseId;
        }

        public string GetCaseType()
        {
            SelectElement selectCaseType = new SelectElement(driver.FindElement(CaseTypeDropdown));
            var caseType = selectCaseType.SelectedOption.Text.Trim();
            return caseType;
        }

        public string GetCaseStatus()
        {
            SelectElement selectCaseStatus = new SelectElement(driver.FindElement(CaseStatusDropdown));
            var caseStatus = selectCaseStatus.SelectedOption.Text.Trim();
            return caseStatus;
        }

        public string GetAssignedTo()
        {
            var assignedToText = driver.FindElement(By.XPath("//*[@id='dropdownMenuCaseAssigned']/span[1]")).Text.Trim();
            return assignedToText;
        }

        public string GetAssignedSupervisor()
        {
            var assignedSupervisorText = driver.FindElement(By.XPath("//*[@id='dropDownMenuCaseAssignedSupervisor']/span[1]")).Text.Trim();
            return assignedSupervisorText;
        }

        public string GetAssignedDivisionDepartment()
        {
            var assignedDivisionDepartmentText = driver.FindElement(By.XPath("//*[@id='caseViewDropdownMenuDepartment']/span[1]")).Text.Trim();
            return assignedDivisionDepartmentText;
        }

        public void NavigateToCaseSummary()
        {
            driver.FindElement(CaseTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(CaseSummaryTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void AssignCaseType(string caseTypeTitle)
        {
            driver.FindElement(CaseTypeDropdown).Click();
            var caseType = driver.FindElements(By.XPath("//select[@aria-label='caseViewSummaryCaseTypeNR']/option"))
                .Where(e => e.Text.Equals(caseTypeTitle, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            caseType.Click();
            WaitForWidgetLoading();
        }

        public void AssignCaseStatus(string statusTitle)
        {
            driver.FindElement(CaseStatusDropdown).Click();
            var caseStatus = driver.FindElements(By.XPath("//select[@aria-label='caseViewSummaryCaseStatusInfoNR']/option"))
                .Where(e => e.Text.Equals(statusTitle, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            caseStatus.Click();
            WaitForWidgetLoading();
        }

        public string RunPatientHistoriesReport()
        {
            string actualData = string.Empty;

            try
             {
                var patientHistoriesReport = driver.FindElement(By.XPath("//button[contains(text(), 'Patient Histories')]"));
                patientHistoriesReport.Click();

                CommonHelpers.WaitForWindowHandles(driver);
                CommonHelpers.WaitForReportLoading(driver, 120);
                CommonHelpers.WaitForElementVisiblity(driver, By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]/div"), 120);
                actualData = driver.FindElement(By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]/div")).Text.ToString();
                Console.WriteLine(actualData);
                CommonHelpers.CloseWindowHandles(driver);
              
            }
            catch (WebDriverException)
            {
                
                throw new Exception("Could not retrieve actual data from the report");
            }
            return actualData;
        }

        public string DownloadPatientHistoriesExcelReport()
        {
            string actualData = string.Empty;

            try
            {
                var patientHistoriesReport = driver.FindElement(By.XPath("//button[contains(text(), 'Patient Histories')]"));
                patientHistoriesReport.Click();

                CommonHelpers.WaitForWindowHandles(driver);
                CommonHelpers.WaitForReportLoading(driver, 120);
                CommonHelpers.WaitForElementVisiblity(driver, By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]/div"), 120);
                actualData = driver.FindElement(By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]/div")).Text.ToString();
                Console.WriteLine(actualData);
                CommonHelpers.WaitForElementVisiblity(driver, CaseClaimDetailsReportViewExcel, 120);
                driver.FindElement(CaseClaimDetailsReportViewExcel).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver,100);
                driver.FindElement(CaseClaimDetailsReportViewExcelData).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
               
                CommonHelpers.CloseWindowHandles(driver);
                
            }
            catch (WebDriverException)
            {
                throw new Exception("Could not retrieve actual data from the report");
            }
            return actualData;
        }


        public void AssignCase(string name)
        {
            driver.FindElement(AssignedToDropdown).Click();
            var user = driver.FindElements(By.XPath("//*[@id='caseViewAssignedToDiv']//li"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();
            WaitForWidgetLoading();
        }

        public void AssignSupervisor(string name)
        {
            //var supervisor = dateTime.ToString("MMddyyyy") + " " + name;

            driver.FindElement(AssignedSupervisorDropdown).Click();
            var supervisor = driver.FindElements(By.XPath("//*[@id='caseViewAssignedToSupervisorDiv']//li"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            supervisor.Click();
            WaitForWidgetLoading();
        }

        public void AssignDivisionDepartment(string name)
        {
            //var divisionDepartment = dateTime.ToString("MMddyyyy") + " " + name;

            driver.FindElement(DivisionsDepartmentsDropdown).Click();
            var department = driver.FindElements(By.XPath("//*[@id='caseDepartmentDropdown']/li"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            department.Click();
            WaitForWidgetLoading();
        }

        public void OpenActivity(string activityName)
        {
            var activitiesRow = driver.FindElements(By.XPath("//*[@name='activityForm']//table/tbody/tr"));
            var selectedActivity = activitiesRow.Where(row =>
            {
                var selectedActivityName = row.FindElements(By.TagName("td"))[0].Text.Trim();
                return selectedActivityName.Contains(activityName);
            }).First();

            var editSelectedActivityButton = selectedActivity.FindElement(By.XPath(".//button[contains(text(),'Edit')]"));
            CommonHelpers.ScrollByElementCoordinates(driver, editSelectedActivityButton);
            editSelectedActivityButton.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void AddCompletionDate()
        {
            try
            {
                var calendarButton = driver.FindElement(By.XPath("//*[@id='completionDate']/span/button"));
                calendarButton.Click();
                var todayButton = driver.FindElement(By.XPath("//span[contains(text(),'Today')]"));
                todayButton.Click();
                //var completionDateInput = driver.FindElement(By.XPath("//*[@id='completionDate']//input"));
                //completionDateInput.Clear();
                //completionDateInput.SendKeys(dateTime.ToString("MM/dd/yyyy"));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(SaveActivityButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(ExitActivityButton).Click();
                CommonHelpers.WaitForPageLoading(driver);
                CommonHelpers.CloseAlert(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        public void ClearCompletionDate()
        {
            try
            {
                var calendarButton = driver.FindElement(By.XPath("//*[@id='completionDate']/span/button"));
                calendarButton.Click();
                var clearButton = driver.FindElement(By.XPath("//span[contains(text(),'Clear')]"));
                clearButton.Click();
                //var completionDateInput = driver.FindElement(By.XPath("//*[@id='completionDate']//input"));
                //completionDateInput.Clear();
                //completionDateInput.SendKeys("0");
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(SaveActivityButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(ExitActivityButton).Click();
                CommonHelpers.WaitForPageLoading(driver);
                CommonHelpers.CloseAlert(driver);
            }
            catch (WebDriverException e)
            {
                CloseActivity();
                throw new Exception(e.Message);
            }
        }

        public bool AutoGeneratedActivityAppears(string activityName)
        {
            var waitForActivity = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string caseActivityName = string.Empty;
            string caseActivityStatus = string.Empty;
            waitForActivity.Until(d =>
            {
                try
                {
                    var activitiesRow = driver.FindElements(By.XPath("//*[@name='activityForm']//table/tbody/tr"));
                    var selectedActivity = activitiesRow.Where(row =>
                    {
                        var selectedActivityName = row.FindElements(By.TagName("td"))[0].Text.Trim();

                        return selectedActivityName.Contains(activityName);
                    }).First();

                    caseActivityName = selectedActivity.FindElements(By.TagName("td"))[0].Text.Trim();
                    caseActivityStatus = selectedActivity.FindElements(By.TagName("td"))[2].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseActivityName) || !caseActivityStatus.Equals("Closed"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ActivityNameFieldIsLocked()
        {
            if (!driver.FindElement(ActivityNameDropdown).Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DueDateFieldIsLocked()
        {
            if (!driver.FindElement(DueDateInput).Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String AddedSubjectIsPresent(string firstName, string lastName)
        {
            WaitForWidgetLoading();
            var waitForSubject = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var subjectName = firstName + ' ' + lastName;
            string caseSubjectName = string.Empty;
            waitForSubject.Until(d =>
            {
                try
                {
                    var subjectsRow = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'row in tableData.rows')]"));
                    var selectedSubject = subjectsRow.Where(row =>
                    {
                        var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();

                        return subjectName == selectedSubjectName;
                    }).FirstOrDefault();

                    caseSubjectName = selectedSubject.FindElements(By.TagName("small"))[1].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });
            return caseSubjectName;
        }

        public void ChangeThePrimarySubject()
        {

            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//table[@id='Subjects']/tbody/tr"));
            var firstRow = tableRows[1];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var element = firstRowData.ElementAt(8).FindElement(By.XPath(".//input"));
            element.Click();
            driver.FindElement(UpdateCasePrimarySubject).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }
        public void ChangeUnCheckThePrimarySubject()
        {

            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//table[@id='Subjects']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var element = firstRowData.ElementAt(8).FindElement(By.XPath(".//input"));
            element.Click();
            driver.FindElement(UpdateCasePrimarySubject).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }



        public String VerifingPrimarySubjectChange()
        {
            var popuptext = driver.FindElement(AlertMessage).Text;
            Console.WriteLine(popuptext);
            return popuptext;
        }

        //Link to Profile from Subjects Tab works correctly

        public string linktoprofilefromSubjectsTab()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var npivalue = "";
            try
            {
                var tableRows = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'row in tableData.rows')]"));
                var firstRow = tableRows[0];
                var firstRowData = firstRow.FindElements(By.TagName("td"));
                var element = firstRowData.ElementAt(0).FindElement(By.XPath(".//a"));
                Actions action = new Actions(driver);
                action.ContextClick(element).Click().Perform();

                CommonHelpers.WaitForPageLoading(driver);
                npivalue = driver.FindElement(NPIValue).Text.Trim().Substring(6);
                CommonHelpers.WaitForPageLoading(driver);
            }
            catch (Exception ex) { }

            return npivalue;
        }

        //
        //Verify that all Subjects are displayed in the Provider Profile in the SIU Activity widget

        public string verifyAllSubjectsAreDisplayedInSIUActivityWidget()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var firstViewButton = driver.FindElement(By.XPath("//div[@class='row panel-heading HmsContainer']/span[contains(text(),'SIU Activity')]"));
            CommonHelpers.ScrollByElementCoordinates(driver, firstViewButton);
            //firstViewButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'row in tableData.rows')]"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var element = firstRowData.ElementAt(0).FindElement(By.XPath(".//small"));
            var caseID = element.Text;
            Console.WriteLine(caseID);
            return caseID;
        }

        public void sortingSubjetsGridWorks()
        {
            var tableRows = driver.FindElements(By.XPath("//table[@id='Subjects']/thead/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("th"));
            var element = firstRowData.ElementAt(1).FindElement(By.XPath(".//small"));
            element.Click();

        }

        public string verifySortingSubjetsGridWorks()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//table[@id='Subjects']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var element = firstRowData.ElementAt(1).FindElement(By.XPath(".//small"));
            var subjectFL = element.Text;
            Console.WriteLine(subjectFL);
            return subjectFL;

        }

        public void navigateToCaseSummaryTab()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(CaseSummaryTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void verifyDeletedSubject()
        {
            var tableRows = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'data in summary.subjects')]"));
            Console.WriteLine(tableRows.Count());
            var totalRows = tableRows.Count();
            for (int i = 0; i < totalRows; i++)
            {

                var firstRow = tableRows[i];
                var firstRowData = firstRow.FindElements(By.TagName("td"));
                var text = firstRowData.ElementAt(0).FindElement(By.XPath(".//a")).Text;
                if (!text.Contains("FN3708"))
                {
                    Console.WriteLine("Validated");
                    break;

                }
                else
                {
                    Console.WriteLine("not Validated");
                }

            }
        }

        public CaseEditPage switchwindow()
        {
            CommonHelpers.WaitForPageLoading(driver);

            String currWindowHandle = driver.CurrentWindowHandle;

            IList<string> totWindowHandles = new List<string>(driver.WindowHandles);

            CommonHelpers.WaitForPageLoading(driver);

            foreach (String WindowHandle in totWindowHandles)

            {

                if (!WindowHandle.Equals(currWindowHandle))

                {

                    driver.SwitchTo().Window(WindowHandle);

                }

            }

            return this;


        }

        public String downloadExcelsheetAndVerfyData()
        {
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(CaseClaimDetailButton).Click();
            switchwindow();
            CommonHelpers.WaitForPageLoading(driver);
            var text = driver.FindElement(CaseClaimDetailData).Text.Substring(1);
            Console.WriteLine(text);

            driver.FindElement(CaseClaimDetailsReportViewExcel).Click();

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(CaseClaimDetailsReportViewExcelData).Click();

            CommonHelpers.WaitForPageLoading(driver);


            return text;
        }

        public String verifyfinalizeFindingsStatus()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var text = driver.FindElement(CaseClaimStatusAsCompleted).Text;
            Console.WriteLine(text);
            return text;

        }

        public String verifyselectInitiateRevisions()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var text = driver.FindElement(CaseClaimStatusAsCompleted).Text;
            Console.WriteLine(text);
            return text;

        }

        public String selectPlusSignAndEnterANewRevisionFinding(String pay)
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimsDenyViewButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimReviewProfessionalEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Thread.Sleep(2000);

            driver.FindElement(FindingsRevisionPlusButton).Click();

            CommonHelpers.WaitForPageLoading(driver);


            SelectElement findingDropDown = new SelectElement(driver.FindElement(FindingRevisionFindingDropdown));
            findingDropDown.SelectByText(pay);
            IWebElement divisionText = findingDropDown.SelectedOption;

            String divisionText1 = findingDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            return divisionText1;
        }

        public String ViewAddAndEditIndividualRevisionClaims(string Cptvalue, string Mod2, string claimsunit, string pay, string reason, string comments)
        {

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimsDenyViewButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimReviewProfessionalEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Thread.Sleep(2000);

            driver.FindElement(FindingsRevisionPlusButton).Click();

            CommonHelpers.WaitForPageLoading(driver);


            driver.FindElement(RevisionClaimLinesCPTORHCPCSORRatesORHIPPS).Clear();
            driver.FindElement(RevisionClaimLinesCPTORHCPCSORRatesORHIPPS).SendKeys(Cptvalue);

            driver.FindElement(RevisionClaimLinesMod2).Clear();
            driver.FindElement(RevisionClaimLinesMod2).SendKeys(Mod2);

            driver.FindElement(RevisionClaimLinesUnits).Clear();
            driver.FindElement(RevisionClaimLinesUnits).SendKeys(claimsunit);


            SelectElement findingDropDown = new SelectElement(driver.FindElement(RevisionClaimLinesFindingDropDown));
            findingDropDown.SelectByText(pay);
            IWebElement divisionText = findingDropDown.SelectedOption;

            String divisionText1 = findingDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);

            SelectElement ReasonDropDown = new SelectElement(driver.FindElement(RevisionClaimLinesReasonDropDown));
            ReasonDropDown.SelectByText(reason);

            driver.FindElement(RevisionClaimLinesComments).Clear();
            driver.FindElement(RevisionClaimLinesComments).SendKeys(comments);

            //driver.FindElement(FindingsRevisionMinusButton).Click();    
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            CommonHelpers.WaitForPageLoading(driver);


            return divisionText1;

        }

        public void editActivityAndReassignTheActivity()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AutoGenActivityEditButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            driver.FindElement(ActivityAssignedToDropdown).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ActivityReassignedToValue).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivityAssignedToDropdown).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ActivityAssignedToValue).Click();
            driver.FindElement(EditActivitySaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ExitActivity).Click();
            CommonHelpers.WaitForPageLoading(driver);

        }

        public string verifyActivityIsReassigned()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var assignename = driver.FindElement(GetAssigneeValue).Text;
            Console.Write(assignename);
            return assignename;
        }

        public void addingActivityCompletionDate(string completiondate)
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AutoGenActivityEditButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            driver.FindElement(ActivityCompletionDate).Clear();
            driver.FindElement(ActivityCompletionDate).SendKeys(completiondate);

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivitySaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ExitActivity).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public string verifyActivityStatus()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var status = driver.FindElement(GetStatusValue).Text;
            Console.Write(status);

            driver.FindElement(AutoGenActivityEditButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            driver.FindElement(ActivityCompletionDate).Clear();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivitySaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ExitActivity).Click();
            CommonHelpers.WaitForPageLoading(driver);
            return status;
        }

        public void editAndCompleteAutoGenActivity(String starttime, String activityTime, String note)
        {


            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AutoGenActivityEditButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            driver.FindElement(ActivitiesStartDate).Clear();
            driver.FindElement(ActivitiesStartDate).SendKeys(starttime);
            Thread.Sleep(5000);

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityTime).Clear();
            driver.FindElement(EditActivityTime).SendKeys(activityTime);
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(EditActivityNoteButton).Click();

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityAddingNotes).Clear();
            driver.FindElement(EditActivityAddingNotes).SendKeys(note);
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivitySaveAddedNotes).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityConfirmSaveAddedNotes).Click();

            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(EditActivitySaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivityAttachmentsTab).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(AddActivityAttachmentsButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ActivityBackButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivitiesTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ExitActivity).Click();
            CommonHelpers.WaitForPageLoading(driver);


        }

        public void nonInvCaseAutoGenActivity()
        {

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AutoGenActivityEditButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            if (!driver.FindElement(EditActivitySaveButton).Displayed)
            {
                Console.WriteLine("Mandatory fields are not enabled");
            }
            else
            {
                Console.WriteLine("Mandatory fields are  enabled");
            }




        }

        //creating an Activity

        public void createActivityAddNotesAndAttachments(string activityname, String starttime, String activityTime, string expenseTime, String note)
        {
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(AddActivityButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            SelectElement activitynameDropDown = new SelectElement(driver.FindElement(ActivityNameDropdown));
            activitynameDropDown.SelectByText(activityname);

            driver.FindElement(ActivityContinueButton).Click();

            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivitiesStartDate).Clear();
            driver.FindElement(ActivitiesStartDate).SendKeys(starttime);
            Thread.Sleep(5000);

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityTime).Clear();
            driver.FindElement(EditActivityTime).SendKeys(activityTime);
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivityExpenseAmount).Clear();
            driver.FindElement(ActivityExpenseAmount).SendKeys(expenseTime);

            driver.FindElement(EditActivityNoteButton).Click();

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityAddingNotes).Clear();
            driver.FindElement(EditActivityAddingNotes).SendKeys(note);
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivitySaveAddedNotes).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(EditActivityConfirmSaveAddedNotes).Click();

            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(EditActivitySaveButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivityAttachmentsTab).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(AddActivityAttachmentsButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ActivityBackButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            driver.FindElement(ActivitiesTab).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ExitActivity).Click();
            CommonHelpers.WaitForPageLoading(driver);


        }

        public bool GetActivityName()
        {
            CommonHelpers.WaitForPageLoading(driver);
            Thread.Sleep(5000);
            driver.FindElement(ActivityTableCreatedDateColumn).Click();
            CommonHelpers.WaitForPageLoading(driver);
            var tableRows = driver.FindElements(By.XPath("//*[@ng-repeat='row in caseActivityTableData.rows']"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var activityname = firstRowData.ElementAt(0).Text;

            //CommonHelpers.WaitForPageLoading(driver);
            //firstRow.FindElements(By.TagName("td"));
            //var activityname = firstRowData.ElementAt(0).Text;
            Console.WriteLine(activityname);


            return true;

        }


        public void clickCaseClaimTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);

            driver.FindElement(CaseClaimTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);
        }


        public void SearchByCaseId(String claimnumber, String claimvalue)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimsSearchDropdown, 100); 
           // driver.FindElement(ClaimsSearchDropdown).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(ClaimsSearchDropdown), claimnumber);
            SelectDropDownOption(ClaimsSearchDropdown, claimnumber);
            driver.FindElement(SearchInput).Clear();
            driver.FindElement(SearchInput).SendKeys(claimvalue);
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimSearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver, 30);
            driver.FindElement(ClaimClearButton).Click();
        }



        public void DownloadFromActivityLevelDownloadAttachmentManager()
        {
            driver.FindElement(ActivityLevelDownloadAttachmentManagerButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,100);
            driver.FindElement(DownloadAllAttachmentsButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,150);
            var confirmDownload = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            confirmDownload.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,150);
        }

        public void DeleteDownload(string activityName)
        {
            var downloads = driver.FindElements(By.XPath("//*[@id='allAttachmentManagerTbl']/tbody/tr"));
            var selectedDownload = downloads.FirstOrDefault(row =>
            {
                var smallElements = row.FindElements(By.TagName("small"));
                if (smallElements.Count == 0)
                    return false;
                var selectedActivityName = smallElements[0].Text.Trim();
                return activityName == selectedActivityName;
            });

            if (selectedDownload == null)
                throw new NoSuchElementException($"Could not find a download row for activity '{activityName}' in the attachment manager.");

            var deleteSelectedDownloadButton = selectedDownload.FindElement(By.XPath("//table/tbody/tr/td[6]/small/button[2]"));
            deleteSelectedDownloadButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
            var closeDownloadAttachmentManagerButton = driver.FindElement(By.XPath("//*[@id='attachmentManagerForm']/div[1]/div[2]/img"));
            closeDownloadAttachmentManagerButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
        }
        public bool NewDownloadAppearsInDownloadAttachmentManager(string activityName)
        {
            CommonHelpers.WaitForPageLoading(driver);
            var waitForDownload = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string downloadStatus = string.Empty;
            waitForDownload.Until(d =>
            {
                try
                {
                    var downloads = driver.FindElements(By.XPath("//*[@id='allAttachmentManagerTbl']/tbody/tr"));
                    var selectedDownload = downloads.Where(row =>
                    {
                        var selectedActivityName = row.FindElements(By.TagName("small"))[0].Text.Trim();
                        return activityName == selectedActivityName;
                    }).First();

                    var rowData = selectedDownload.FindElements(By.TagName("td"));
                    downloadStatus = rowData.ElementAt(4).FindElement(By.XPath(".//small")).Text;
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });
            while (!downloadStatus.Equals("Complete"))
            {
                var refreshButton = driver.FindElement(By.XPath("//*[@id='attachmentManagerActions']/div/button[2]"));
                refreshButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
                var downloads = driver.FindElements(By.XPath("//*[@id='allAttachmentManagerTbl']/tbody/tr"));
                var firstRow = downloads[0];
                var rowData = firstRow.FindElements(By.TagName("td"));
                downloadStatus = rowData.ElementAt(4).FindElement(By.XPath(".//small")).Text;
            }

            if (downloadStatus.Equals("Complete"))
            {
                CommonHelpers.CloseAlert(driver);
                DeleteDownload(activityName);
                return true;
            }
            else
            {
                return false;
            }
        }


        public string verifyClaimStatusAsRevisionInProgress()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var text = driver.FindElement(CaseClaimStatusAsRevisionInProgress).Text;
            Console.WriteLine(text);
            return text;

        }

        public void DownloadFromCaseLevelDownloadAttachmentManager()
        {
            // SelectDropDownOption(CaseLevelDownloadAttachmentManagerDropdown, "Download Attachment Manager");
            CommonHelpers.WaitForElementVisiblity(driver, CaseLevelDownloadAttachmentManagerDropdown, 30);
            driver.FindElement(CaseLevelDownloadAttachmentManagerDropdown).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(By.XPath("//button[@id='activityTableTools']/following-sibling::ul//a[normalize-space()='Download Attachment Manager' or contains(normalize-space(), 'Download Attachment Manager')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            //driver.FindElement(CaseLevelDownloadAttachmentManagerButton).Click();
            //CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(DownloadAllAttachmentsButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,150);
            CommonHelpers.WaitForElementVisiblity(driver, By.XPath("//button[contains(text(),'Yes')]"), 100);
            var confirmDownload = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            confirmDownload.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver,150);
        }

        public bool caseClaimInputField()
        {
            if (!driver.FindElement(SearchInput).Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool caseClaimSearchButton()
        {
            if (!driver.FindElement(ClaimSearchButton).Selected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addFindingsButtonAndCreateTheForm(string findingSubject, string findingReason, string lineOfBusiness,
            string totalUnderpayment, string totalOverpayment, string totalSoftSaving,
            string numberOfMembers, string numberOfClaims, string numberOfLines, string numberOfProviders, string comments)
        {

            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(AddFindingButton).Click();
            CommonHelpers.WaitForPageLoading(driver);

            CommonHelpers.selectOptionByValue(driver.FindElement(FindingSubject), findingSubject);
            CommonHelpers.selectOptionByValue(driver.FindElement(FindingReason), findingReason);
            CommonHelpers.selectOptionByValue(driver.FindElement(FindingLineOfBusiness), lineOfBusiness);
            driver.FindElement(TotalUnderpaymentAmount).Clear();
            driver.FindElement(TotalUnderpaymentAmount).SendKeys(totalUnderpayment);

            driver.FindElement(TotalOverpaymentAmount).Clear();
            driver.FindElement(TotalOverpaymentAmount).SendKeys(totalOverpayment);

            driver.FindElement(TotalSoftSavingAmount).Clear();
            driver.FindElement(TotalSoftSavingAmount).SendKeys(totalSoftSaving);

            driver.FindElement(NumberOfMembersInPopulationWithFindings).Clear();
            driver.FindElement(NumberOfMembersInPopulationWithFindings).SendKeys(numberOfMembers);

            driver.FindElement(NumberOfClaimsInPopulationWithFindings).Clear();
            driver.FindElement(NumberOfClaimsInPopulationWithFindings).SendKeys(numberOfClaims);


            driver.FindElement(NumberOfLinesInPopulationWithFindings).Clear();
            driver.FindElement(NumberOfLinesInPopulationWithFindings).SendKeys(numberOfLines);

            driver.FindElement(NumberOfProvidersInPopulationWithFindings).Clear();
            driver.FindElement(NumberOfProvidersInPopulationWithFindings).SendKeys(numberOfProviders);

            driver.FindElement(Comments).Clear();
            driver.FindElement(Comments).SendKeys(comments);

            driver.FindElement(AddFindingsSaveButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void clickOnClaimSelectorButton()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimSelectorButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void selectingTheClaims()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimSelectAllButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(ClaimNextButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void ClickCaseClaimLink()
        {
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(CaseClaimLink).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public bool GetTotatalUnderpaymentvalue()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var underPaymentvalue = driver.FindElement(By.XPath("//*[@id='findingReasonTbl']/table/tbody/tr/td[5]"));
            return underPaymentvalue.Text == "100.00%";
        }

        public bool GetTotatalOverPaymenvalue()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var overPaymentvalue = driver.FindElement(By.XPath("//*[@id='findingReasonTbl']/table/tbody/tr/td[7]"));
            return overPaymentvalue.Text == "100.00%";
        }

        public void DeleteFindings()
        {
            CommonHelpers.WaitForPageLoading(driver);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();

            var tableRows = driver.FindElements(By.XPath("//table[@id='Findings']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(10).FindElement(By.XPath("small")).FindElement(By.XPath("//button[contains(text(),'Delete')]")).Click();
            driver.FindElement(ConfirmationPopup).Click();
        }

        public bool reviewCaseClaimReview()
        {
            CommonHelpers.WaitForPageLoading(driver);
            return driver.FindElement(ClaimLinePreviewPopup).Displayed;
        }

        public bool caseClaimReviewColumnNamesreNotRepeated()
        {
            CommonHelpers.WaitForPageLoading(driver);
            var headers = driver.FindElements(By.XPath("//div[@id='claimLinePreviewPopup']//table/thead/tr/th"));
            var headerTexts = headers.Select(h => h.Text).ToList();
            return headerTexts.Count == headerTexts.Distinct().Count();
        }

        public void CloseWindowHandles()
        {
            CommonHelpers.CloseWindowHandles(driver);
        }
        #endregion
        #endregion
        #endregion
    }
}
