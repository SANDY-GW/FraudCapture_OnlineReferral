using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.AdministrativeCases
{
    public class AdministrativeCases : BaseSettings
    {
        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        public AdministrativeCases(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, DefaultTimeout);
        }

        #region Elements

        //Add xpath here
        private readonly By activityNameDDL = By.XPath("//*[@id=\"name\"]");
        private readonly By cancelBtn = By.XPath("//*[@id=\"activitydetail\"]/div/div[1]/button[1]");
        private readonly By continueBtn = By.XPath("//*[@id=\"activitydetail\"]/div/div[1]/button[2]/span");
        private readonly By otherActivityOptions = By.XPath("//*[@id=\"activitydetail\"]/div[1]/div[1]/button[1]");

        private readonly By createDocument = By.XPath("//*[@id=\"createDocumentButton\"]");
        private readonly By saveDocumentStatus = By.XPath("//*[@id=\"document\"]/fc-activity-note-attachment-document/div[3]/div[2]/button");

        private readonly By csvExport = By.XPath("//*[@id=\"attachment\"]/div[1]/button[2]");
        private readonly By downloadAttachmentManager = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");
        private readonly By referesh = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");
        private readonly By addAttachment = By.XPath("//*[@id=\"attachment\"]/div[1]/button[3]");




        private readonly By casesTab = By.Id("allCasesTabId");
        private readonly By tableSearchOptions = By.XPath("//select[@id='caseSearchCriteria']");
        private readonly By nonInvestigativeCaseButton = By.XPath("//button[text()='Create Administrative Case']");
        private readonly By projectName = By.XPath("//input[@id='caseProjectName']");
        private readonly By selectAdministrativeworkflowTypeDropdown = By.XPath("//button[@id='dropdownMenuWorkflowType']");
        private readonly By selectAdministrativeworkflowTypeDropdownvalue = By.XPath("//div[@id='caseWorkflowType']/child::ul/li/a");
        private readonly By caseTypeDropDown = By.Id("caseType");
        private readonly By assignworkflowToDropdown = By.XPath("//div[@id='investigativeCaseAssignedTo']/button[@id='dropdownMenuCaseAssigned']");
        private readonly By assignworkflowToDropdownvalue = By.XPath("//div[@id='investigativeCaseAssignedTo']/ul/li/a[text()=' D, Jayapradha ']");
        private readonly By createButton = By.XPath("//button[text()='Create A New Case']");
        private readonly By caseTypeFilterDropDown = By.XPath("//div[@id='caseTypeDiv']/button[@id='dropDownCaseType']");
        private readonly By nonInvestigativeCancelButton = By.XPath("//button[text()='Cancel']");
        private readonly By caseGridSearchInput = By.XPath("//input[@name='caseSearchText']");
        private readonly By caseGridSearchButton = By.XPath("//form[@id='CaseSearchForm']/div/button[@id='searchStartButton']");
        private readonly By caseBeginEditButton = By.XPath("//button[@title='Begin Editing']");
        private readonly By caseSummaryTab = By.XPath("//a[@id='summaryTabId']");
        private readonly By divisionsOrDepartmentsTab = By.XPath("//div[@id='caseViewDepartmentsDivisons']/button");
        private readonly By divisionsOrDepartmentsTabvalueedited = By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a[text()=' SIU Group ']");
        private readonly By divisionsOrDepartmentsTabvalue = By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a[text()=' (DO NOT MODIFY) Automated Testing Department ']");
        private readonly By caseViewSaveButton = By.XPath("//div[@id='CaseDetailContentId']/descendant::button[@id='caseViewSaveButton']");
        private readonly By caseEndEditButton = By.XPath("//button[@ng-click='onCloseEdit()']");
        private readonly By exitCaseButton = By.XPath("//div/button[text()='Exit Case']");
        private readonly By activitiesTabButton = By.XPath("//a[text()='Activities']");
        private readonly By autoGenActivityEditButton = By.XPath("//table/tbody/tr/td[9]/button[contains(text(),'Edit')]");
        private readonly By editActivityStartDateGrid = By.XPath("//span[@class='input-group-btn']/button[@id='btnstartdate']");
        private readonly By editActivityStartDate = By.XPath("//strong[text()='January 2024']/following::span[text()='30']");
        private readonly By editActivityCompletionDate = By.XPath("//strong[text()='February 2024']/following::span[text()='07']");
        private readonly By editActivityTime = By.Id("activityTime");
        private readonly By editActivityExpenseTime = By.Id("expenses");
        private readonly By editActivitySaveButton = By.XPath("//*[@id='activitydetail']/div[1]/div[1]/button[2]/span");
        private readonly By editActivityNoteButton = By.XPath("//div[@id='activitydetail']/descendant::button[contains(text(),'Add')]");
        private readonly By editActivityAddingNotes = By.XPath("//label[text()='Notes']/following::trix-editor");
        private readonly By editActivitySaveAddedNotes = By.XPath("//form[@id='noteEditForm']/descendant::div/button[text()=' Save '] ");
        private readonly By editActivityConfirmSaveAddedNotes = By.XPath("//div[@class='modal-footer']/button[text()='Yes']");
        private readonly By exitActivity = By.XPath("//button[@alt='Exit Activity']");
        private readonly By findingsTab = By.Id("findingTabId");
        private readonly By addFindingButton = By.XPath("//div/button[@title='Add Finding']");
        private readonly By findingReasonTab = By.XPath("//*[@id='findingReasonId']");
        private readonly By findingReasonText = By.XPath("//select[@id='findingReasonId']/option[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']");

        private readonly By findingLineofBusinessTab = By.XPath("//select[@name='LOB']");
        private readonly By addfindingsSaveButton = By.XPath("//*[@id='CaseFindingForm']/div[2]/div[1]/button[2]");
        private readonly By amountsTab = By.Id("recoveryTabId");
        private readonly By addAmountButton = By.XPath("//*[@title='Add Case Amount']");
        private readonly By amountType = By.XPath("//select[@name='amountType']");
        private readonly By amounteffectiveDateGrid = By.XPath("//input[@name='paymentDate']");
        private readonly By amounteffectiveTodayDate = By.XPath("//button/span[text()='Today']");
        private readonly By amountLineofBusinessTab = By.XPath("//select[@name='lineOfBusiness']");
        private readonly By addCaseAmountSaveButton = By.XPath("//*[@id='btnOk']");
        private readonly By Amount = By.XPath("//input[@id='paymentAmount']");
        // private readonly By FinalRecoupment = By.XPath("//*[@id='IsActiveFinalRecoup']");
        private readonly By CaseTypeStatusDropdownInvestigate = By.XPath("//*[@id='caseViewSummaryCaseStatusInfoNR']");
        private readonly By CaseTypeStatusDropdownNon_Investigate = By.XPath("//*[@id='caseViewSummaryCaseStatusInfoR']");
        private readonly By caseTracking = By.XPath("//*[@id='Case Tracking']/div/img");
        private readonly By AssignedTo = By.XPath("//button[@id='dropdownMenuCaseAssigned']");
        private readonly By AssignedToValue = By.XPath("//div[@id='caseViewAssignedToDiv']/ul/li/a[text()=' D, Jayapradha ']");
        private readonly By Non_Investigative_caseID = By.XPath("//div/h1[@class='darkNavy-fc title1 ng-binding']");
        private readonly By alertMessage = By.XPath("//div[@class='notification-enter alert alert-info alert-dismissible fade show']/div");
        private readonly By createNonIvestigativeHeader = By.XPath("//div/h1[contains(normalize-space(text()),'Create A New Administrative Case')]");
        private readonly By investigativeCaseType = By.XPath("//*[@id='caseViewSummaryCaseTypeNR']");
        private readonly By RelatedCasesAndLeadsTab = By.XPath("//a[@id='relatedCasesId']");
        private readonly By RelatedCasesAndLeadsTabPopUp = By.XPath("//div[@class='modal-footer']/button[text()='Yes']");
        private readonly By leadIdInput = By.Id("relatedCasesSearchTxt");
        private readonly By searchButton = By.XPath("//*[@id='relatedCases']/form/div/div[3]/div[2]/button[contains(.,'Search')]");
        private readonly By SearchAndAddRelatedCasesOrLeadsDropdown = By.Id("relatedCasesSearchType");
        private readonly By primarySubjectLastName = By.Id("relatedCasesSearchLastNameTxt");
        private readonly By primarySubjectfirstName = By.Id("relatedCasesSearchFirstNameTxt");
        private readonly By claimsButton = By.XPath("//*[text()='Claims']");
        private readonly By samplingButton = By.XPath("//*[text()='Sampling']");
        private readonly By addSamplingButton = By.XPath("//button[text()='Add Sampling']");
        private readonly By detailsTab = By.XPath("//a[@id='detailsTabId']");
        private readonly By samplingDate = By.XPath("//input[@name='samplingDate']");
        private readonly By unitDescription = By.XPath("//input[@id='unitDs']");
        private readonly By samplingSeedNumber = By.Id("seed");
        private readonly By samplingClaimConfidenceLower = By.Id("claimConfidenceLower");
        private readonly By samplingClaimConfidenceUpper = By.Id("claimConfidenceUpper");
        private readonly By SeedDateforSample = By.XPath("//input[@name='seedDateSample']");
        private readonly By ObtainedDate = By.XPath("//input[@name='obtainedDate']");
        private readonly By SamplingMethodologyDescription = By.XPath("//div/textarea[@id='methodologyDescription']");
        private readonly By metricsTab = By.XPath("//*[@id='metricsTabId']");
        private readonly By sampleTableOne = By.XPath("//div[@id='sampleDiv']/table[@id='sampleTable1']/tbody/tr");
        private readonly By sampleTableTwo = By.XPath("//div[@id='sampleDiv']/table[@id='sampleTable2']/tbody/tr");
        private readonly By universeTableOne = By.XPath("//div[@id='universeDiv']/table[@id='universeTable1']/tbody/tr");
        private readonly By universeTableTwo = By.XPath("//div[@id='universeDiv']/table[@id='sampleTable2']/tbody/tr");
        private readonly By saveSamplingButton = By.XPath("//div[@id='metricsTab']/div/button[@id='btnOk']");
        private readonly By removeAddedsamplings = By.XPath("//div[@id='tableContainer']/table[@id='Samplings']/tbody/tr/td[9]/small/span/button[contains(text(),'Delete')]");
        private readonly By confirmDeletionOfSampling = By.XPath("//*[@id='btnDelete']");
        private readonly By confirmAddedSampling = By.XPath("//div[@id='caseSamplingMetricTable']/descendant::span[text()='Summary Sample & Universe Metric Totals']");
        private readonly By saveDetailsSampling = By.XPath("//div[@id='detailsTab']/div/button[@id='btnOk']");
        private readonly By deletesamplingHeader = By.XPath("//*[text()='Delete Sampling']");
        private readonly By Total_Underpayment_Amount = By.XPath("//input[@id='totalUnderpayment']");
        private readonly By TotalOverpaymentAmount = By.XPath("//input[@id='totalOverpayment']");
        private readonly By TotalSoftSavingAmount = By.XPath("//input[@id='totalSoftSaving']");
        private readonly By Number_of_Members_in_Population_With_Findings = By.XPath("//input[@id='numberOfMembersFindings']");
        private readonly By Number_of_Claims_in_Population_With_Findings = By.XPath("//input[@id='numberOfClaimsFindings']");
        private readonly By Number_of_Lines_inPopulation_With_Findings = By.XPath("//input[@id='numberOfLinesFindings']");
        private readonly By Number_of_Providers_in_Population_With_Findings = By.XPath("//input[@id='numberOfProvidersFindings']");
        private readonly By Comments = By.XPath("//textarea[@id='Comments']");
        private readonly By AmountDateRangeFrom = By.XPath("//input[@name='dateFrom']");
        private readonly By FinalRecoupment = By.XPath("//*[@id='IsActiveFinalRecoup']");
        private readonly By AmountDateRangeTo = By.XPath("//input[@name='dateTo']");
        private readonly By AmountCommentArea = By.XPath("//textarea[@id='paymentComment']");
        private readonly By effectiveDataError = By.XPath("//div[@class='form-group']/span[text()='Not a valid date! e.g.12/31/2020']");
        private readonly By TotalPayments = By.XPath("//*[@id='recovery']/form/div/div[2]/div[2]/div[1]/span");
        private readonly By OutstandingBalance = By.XPath("//*[@id='recovery']/form/div/div[2]/div[1]/div[2]/span");

        private readonly By samplingMetricTable = By.XPath("//table[@id='SamplingsMetric']/tbody/tr");
        private readonly By recoveriesBody = By.XPath("//table[@id='Recoveries']/tbody/tr");
        private readonly By ConfirmationAmountPopup = By.XPath("//div[@id='ConfirmationModal']/following::button[text()='Yes']");
        private readonly By recoveriesHead = By.XPath("//table[@id='Recoveries']/thead/tr");
        private readonly By CasesHead = By.XPath("//div[@id='allCaselist-wrapper']/div/table[@class='table table-striped table-hover HmsTable']/thead/tr");
        private readonly By FindingBody = By.XPath("//table[@id='Findings']/tbody/tr");

        private readonly By FindingHead = By.XPath("//table[@id='Findings']/thead/tr");
        private readonly By samplingMetricHead = By.XPath("//table[@id='SamplingsMetric']/thead/tr");

        private readonly By samplingBody = By.XPath("//table[@id='Samplings']/tbody/tr");
        private readonly By editButton = By.XPath("span/button[contains(text(),'Edit')]");
        private readonly By activitesStartDate = By.XPath("//input[@name='startDate']");
        private readonly By activitesStartDatevalue = By.XPath("//button/span[text()='Today']");
        private readonly By caseButton = By.XPath("//*[text()='Case']");
        private readonly By auditLogButton = By.XPath("//*[text()='Audit Log']");
        private readonly By auditLogTable = By.XPath("//table[@id='AuditLog']/thead/tr");
        private readonly By TotalAmountPayments = By.XPath("//label[contains(text(),'Total Payments')]/following-sibling::span");
        private readonly By caseClaimTab = By.XPath("//*[@id='caseClaimTabId']");
        private readonly By claimSelector = By.XPath("//button[text()='Claim Selector']");
        private readonly By queryParameter = By.XPath("//div[@id='claimQueryColumnDiv']/button[@id='dropdownMenu1']");
        private readonly By queryParameterTextBox = By.XPath("//ul[@id='claimQueryColumnMenu']/li/a[text()=' RenderingProviderId ']");

        private readonly By queryparametervalue = By.XPath("//select[@id='idOperator1']");
        private readonly By queryparameterIdValue = By.XPath("//textarea");
        private readonly By selectClaimsFromTheList = By.XPath("//button[@id='executeQueryButton']");
        private readonly By addSelectedCaseToClaim = By.XPath("//button[@id='addSelectedClaimslId']");
        private readonly By selectClaimsFromTheConvenientSample = By.XPath("//button[@id='generatedConvenientSampleButton']");
        private readonly By getSampleSizeButton = By.XPath("//button[text()='Get Sample Size'][2]");
        private readonly By runOrGetSampleButton = By.XPath("//button[text()='Run/Get Sample']");
        private readonly By claimsRefreshButton = By.XPath("//button[text()='Refresh']");
        private readonly By claimsCount = By.XPath("//span[contains(text(),'Record Count: 5')]");
        private readonly By claimsHeadTable = By.XPath("//table[@id='caseClaimsTable']/thead/tr");
        private readonly By claimsBodyTable = By.XPath("//table[@id='caseClaimsTable']/tbody/tr");
        private readonly By claimsSearchDropDowm = By.XPath("//select[@name='selectedCriteria']");
        private readonly By SearchInput = By.XPath("//form[@name='claimForm']/descendant::input[@id='searchId']");
        private readonly By SearchButton = By.XPath("//div[@id='ClaimId']/descendant::button[@id='searchStartButton']");
        private readonly By claimViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr/td[12]/small/button[contains(text(),'View')]");
        private readonly By getClaimID = By.XPath("//div[@id='claimSidebar']/descendant::a");
        private readonly By clainReviewProfessionalCancelButton = By.XPath("//div/fc-case-claim-review/div/div[2]/div[1]/button[1]");
        private readonly By SearchLastName = By.XPath("//div[@id='ClaimId']/descendant::input[@id='searchLname']");
        private readonly By SearchFirstName = By.XPath("//div[@id='ClaimId']/descendant::input[@id='searchFname']");
        private readonly By patientname = By.XPath("//div[@id='claimSidebar']/descendant::b[8]");
        private readonly By getpatientid = By.XPath("//div[@id='claimSidebar']/descendant::a[2]");
        private readonly By getCPTorHCPCvalue = By.XPath("//table[@id='leftTable']/tbody/tr[1]/td[7]");
        private readonly By SearchStartDate = By.XPath("//input[@name='searchStartDate']");
        private readonly By SearchEndDate = By.XPath("//input[@name='searchendDate']");
        private readonly By getStartDate = By.XPath("//div[@id='ClaimId']/following::b[contains(text(),'DOS To:')]");
        private readonly By getServiceStartDateTo = By.XPath("//div[@id='ClaimId']/following::b[contains(text(),'DOS From:')]");
        private readonly By patientHistoriesButton = By.XPath("//button[contains(text(), 'Patient Histories')]");
        private readonly By caseClaimDetailsReportViewExcel = By.XPath("//*[@id='reportViewer_ctl09_ctl04_ctl00_ButtonLink']");
        private readonly By caseClaimDetailsReportViewExcelData = By.XPath("//*[@id='reportViewer_ctl09_ctl04_ctl00_Menu']/child::div/a[text()='Excel']");
        private readonly By caseClaimDetailsReportViewExcelProviderID = By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]/div");
        private readonly By ClaimReviewProfessionalEditButton = By.XPath("*//fc-case-claim-review/div/div[2]/div[1]/button[contains(.,'Edit')]");
        private readonly By claimsViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[3]/td/small/button[contains(text(),'View')]");
        private readonly By ClaimReviewProfessionalEditingFirstTable = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[9]/input");
        private readonly By ClaimReviewProfessionalEditingFourthTable = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[7]/input");
        private readonly By ClaimReviewProfessionalSaveButton = By.XPath("//div[2]/div/fc-case-claim-review/div/div[2]/div[1]/button[text()='Save']");
        private readonly By ClaimReviewProfessionalCancelButton = By.XPath("//div[2]/div/fc-case-claim-review/div/div[2]/div[1]/button[text()='Cancel']");
        private readonly By zeroPaidClaimLines = By.XPath("//div[@class='row claimLineDiv']/div[2]/child::div/table/tbody/tr[1]/td[15]");
        private readonly By reasonForZeroPaidClaims = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[18]/select");
        private readonly By reasonForPaidClaims = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[18]/select");
        private readonly By claimLinesRev = By.XPath("//div[@class='row claimLineDiv']/div[2]/child::div/table/tbody/tr[2]/td[5]/input");
        private readonly By claimLinesCPTORHCPCSORRatesORHIPPS = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[7]/input");
        private readonly By claimLinesMod2 = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[10]/input");
        private readonly By claimLinesUnits = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[13]/input");
        private readonly By claimLinesFindingDropDown = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[18]/select");
        private readonly By claimLinesReasonDropDown = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[19]/select");
        private readonly By claimLinesComments = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[21]/textarea");
        private readonly By claimLinesFindings = By.XPath("//select[@id='finding']");
        private readonly By claimLinesFindingsReason = By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect");
        private readonly By claimLinesFindingsReasonValue = By.XPath("//div/label[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']");
        private readonly By claimLinesFindingsComment = By.XPath("//textarea[@id='comment']");
        private readonly By applySameFindingtoAllLines = By.XPath("//button[text()='Apply Same  Finding  to All Lines ']");
        private readonly By applySameFindingtoAllLinesPopUp = By.XPath("//div[@class='modal-footer']/button[text()='Yes']");
        private readonly By applySameFindingtoAllLinesConfirmPopUp = By.XPath("//div[@class='modal-footer']/child::button[text()='Yes']");
        private readonly By viewClaimActivityButton = By.XPath("//button[@id='patientClaimActivityButton']");
        private readonly By getPatientNamefromViewClaimActivityPage = By.XPath("//*[@id='patientName']/b");
        private readonly By caseClaimDetailButton = By.XPath("//*[contains(text(),'Case Claims Detail')]");
        private readonly By caseClaimDetailData = By.XPath("//form/div[3]/div/div/table/tbody/tr[4]/td[3]/div/div[1]/div/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr[5]/td[5]/div/div");
        private readonly By caseClaimStatusAsCompleted = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[1]/td[11]");
        private readonly By claimsPayViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[1]/td[12]/small/button[contains(text(),'View')]");
        private readonly By claimsNRViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[5]/td[12]/small/button[contains(text(),'View')]");
        private readonly By claimsDenyViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[4]/td[12]/small/button[contains(text(),'View')]");
        private readonly By finalizeFindingsButton = By.XPath("//form[@name='claimForm']/descendant::button[text()='Finalize Findings']");
        private readonly By ApplyFindingstoCaseLevelButton = By.XPath("//button[text()='Apply Same Findings to Case Level']");
        private readonly By ApplySameLineLevelFindingtoAllClaimsinCase = By.XPath("//select[@id='finding']");
        private readonly By ApplySameLineLevelFindingtoAllClaimsinCaseReason = By.XPath("//*[@id='caseClaimFindingsForm']/descendant::p-multiselect");
        private readonly By ApplySameLineLevelFindingtoAllClaimsinCaseReasonSave = By.XPath("//div[@id='caseClaimFindingDiv']/descendant::button[text()='Save']");
        private readonly By ApplySameLineLevelFindingtoAllClaimsinCaseReasonConfirm = By.XPath("//button[text()='Confirm']");
        private readonly By finalizeFindingsPopup = By.XPath("//button[text()='Yes']");
        private readonly By initiateRevisionsButton = By.XPath("//button[text()='Initiate Revisions']");
        private readonly By findingsRevisionPlusButton = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[2]/td[22]/button");
        private readonly By findingRevisionFindingDropdown = By.XPath("//div[@class='row claimLineDiv']/div[1]/child::div/table/tbody/tr[3]/td[18]/select");
        private readonly By revisionClaimLinesRev = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[5]/input");
        private readonly By revisionclaimLinesCPTORHCPCSORRatesORHIPPS = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[7]/input");
        private readonly By revisionclaimLinesMod2 = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[10]/input");
        private readonly By revisionclaimLinesUnits = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[13]/input");
        private readonly By revisionclaimLinesFindingDropDown = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[18]/select");
        private readonly By revisionclaimLinesReasonDropDown = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[19]/select");
        private readonly By revisionclaimLinesComments = By.XPath("//div[@class='row claimLineDiv'][1]/child::div/div/table/tbody/tr[3]/td[21]/textarea");
        private readonly By revisionRefreshButton = By.XPath("//button[text()='Refresh']");
        private readonly By cancelRevisionhButton = By.XPath("//button[text()='Cancel Revision']");
        private readonly By cancelRevisionhButtonPopupConfirmation = By.XPath("//button[text()='OK']");
        private readonly By UndoFinalizeButton = By.XPath("//button[text()='Undo Finalize']");
        private readonly By claimsNVViewButton = By.XPath("//table[@id='caseClaimsTable']/tbody/tr[2]/td/small/span/button[contains(text(),'View')]");
        private readonly By CaseIdField = By.XPath("//*[@id='caseViewSummaryCaseId']");
        private readonly By ConfirmationPopup = By.XPath("//button[text()='Yes']");



        #endregion


        /// <summary>
        /// Clicks the NonInvestigative case button to open the form.
        /// </summary>
        /// 

        public void navigateToCaseTrackingAndClickOnCasesTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(casesTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void clickNonInvestigativeCaseButton()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, nonInvestigativeCaseButton, 100);
            CommonHelpers.ScrollAndCenterElement(driver, driver.FindElement(nonInvestigativeCaseButton));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", driver.FindElement(nonInvestigativeCaseButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);

        }
        ///
        /// /// <summary>
        ///  Non-Investigative page cancelling
        /// </summary>
        /// 

        /// <summary>
        /// validating Non-Investigative page is displayed or not
        /// </summary>

        public bool IsAt
        {
            get
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, createNonIvestigativeHeader, 30);
                return driver.FindElement(createNonIvestigativeHeader).Displayed;
            }
        }



        /// <summary>
        /// Creating Non-investigative Case Audit
        /// </summary>
        /// 
        public void CancelNonInvestigativeCaseForm()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, nonInvestigativeCancelButton, 30);
            var button = driver.FindElement(nonInvestigativeCancelButton);
            ScrollAndCenterElement(button);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            try
            {
                button.Click();
            }
            catch (ElementClickInterceptedException)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", button);
            }
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }

        public void CreateNonInvestigativeCaseAudit(string Projectname, string Casename, string AssignedTo)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, projectName, 100);
            driver.FindElement(projectName).Click();
            driver.FindElement(projectName).SendKeys(Projectname);
            driver.FindElement(selectAdministrativeworkflowTypeDropdown).Click();
            //selectAdministrativeworkflowTypeDropdownvalue.Click();
            IList<IWebElement> options = driver.FindElements(By.XPath("//div[@id='caseWorkflowType']/child::ul/li/a"));

            foreach (IWebElement option in options)

            {



                if (option.Text.Contains(Casename))

                {

                    option.Click();

                    break;

                }

            }
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            //driver.FindElement(assignworkflowToDropdown).Click();

            //IList<IWebElement> options1 = driver.FindElements(By.XPath("//div[@id='investigativeCaseAssignedTo']/ul/li/a"));

            //foreach (IWebElement option in options1)

            //{



            //    if (option.Text.Equals(AssignedTo))

            //    {

            //        Console.WriteLine(AssignedTo);
            //        option.Click();

            //        break;

            //    }

            //}


            driver.FindElement(createButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

        }


        /// <summary>
        /// Verifing Non-investigative Case Audit
        /// </summary>
        /// 


        public string CaseManagementAlert()
        {
            var message = "";

            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                //var alertMessage = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alerts']/div/div"));
                Thread.Sleep(5000);
                var getCaseAlertMessage = driver.FindElement(By.XPath("//div[@class='alerts']/div/div")).Text.Trim().Substring(21).Trim();
                Console.WriteLine(getCaseAlertMessage);
                message = getCaseAlertMessage;

            }
            catch (Exception ex)
            {

            }
            return message;

        }





        /// <summary>
        /// Getting NonInvestigativeCaseID in the NonInvestigativeform
        /// </summary>
        /// 

        public string GetNonInvestigativeCaseID()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            //var alertMessage = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alerts']/div/div"));

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var getCaseID = driver.FindElement(By.XPath("//div[@class='alerts']/div/div")).Text.Split(':')[1].Trim().Substring(0, 14);
            Console.WriteLine(getCaseID);
            return getCaseID;


        }

        /// <summary>
        /// Extracts the newly created Case ID from the success notification message.
        /// </summary>
        public string GetCreatedCaseId()
        {
            IWebElement notification = Wait.Until(d =>
            {
                try
                {
                    var element = d.FindElement(By.XPath("//div[contains(@class,'text-break')]"));
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            });

            string message = notification.Text;
            Console.WriteLine($"Notification message: {message}");

            // Example: "Case: DEMO0825202610 was successfully created."
            Match match = Regex.Match(message, @"Case:\s*([A-Za-z0-9]+)");
            Console.WriteLine($"Extracted Case ID: {match.Groups[1].Value}");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            throw new Exception($"Unable to extract Case ID from message: {message}");
        }

        /// <summary>
        /// On the Cases tab of Case Tracking, locate and open the newly created Non-Investigative Case
        /// </summary>


        public void LocateAndOpenNewlyCreatedNonInvestigativeCase(string Casename, string CaseID)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(caseTypeFilterDropDown).Click();
            //var user = Driver.WrappedDriver.FindElements(NgBy.Repeater("caseType in caseTypeList"))
            //    .Where(e => e.Text.Equals(Casename, StringComparison.CurrentCultureIgnoreCase))
            //    .FirstOrDefault();
            //WaitForPageLoading();
            //user.Click();

            IList<IWebElement> options = driver.FindElements(By.XPath("//div[@id='caseTypeDiv']/button/following-sibling::ul/li/a"));
            foreach (IWebElement option in options)
            {

                if (option.Text.Equals(Casename))
                {
                    option.Click();
                    Console.WriteLine(option.Text);
                    break;
                }
            }
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(tableSearchOptions).Click();
            CommonHelpers.selectOptionByValue(driver.FindElement(tableSearchOptions), CaseID);
            driver.FindElement(caseGridSearchInput).SendKeys(AppConstants.Non_Inv_CaseId);
            driver.FindElement(caseGridSearchButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }


        ///<summary>
        /// getting non_investigative case id in case tab
        /// </summary>

        public String GetNon_Investigative_caseID()
        {


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageUp).Perform();
            var Non_Investigative_caseID_element = driver.FindElement(By.XPath("//div/h1"));
            var getNon_Investigative_caseIDCaseID = Non_Investigative_caseID_element.Text.Split(':')[1].Trim().Substring(0, 14);
            AppConstants.Non_Inv_CaseId = Non_Investigative_caseID_element.Text.Split(':')[1].Trim().Substring(0, 14);
            return AppConstants.Non_Inv_CaseId;

        }

        public string GetCaseId()
        {
            var waitForCaseIdRow = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(120));
            string caseIdText = string.Empty;
            waitForCaseIdRow.Until(d =>
            {
                try
                {
                    var caseIdRow = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='allCaselist-wrapper']//table/tbody/tr"));
                    caseIdText = caseIdRow.FindElements(By.TagName("small"))[1].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseIdText))
                throw new Exception("Could not retrieve case id");

            return caseIdText;
        }

        public string CapturecaseID()
        {
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, CaseIdField, 30);
                string capturedCaseId = driver.FindElement(CaseIdField).GetAttribute("value")?.Trim();
                Console.WriteLine("Captured Case ID: " + capturedCaseId);
                return capturedCaseId;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Case ID field not found: " + ex.Message);
                return null;
            }
        }



        ///<summary>
        /// Enable Editing on the Case and on the  Summary tab select the newly created Division/Department value. Save Changes.
        /// 
        /// </summary>


        public void enableEditOnCaseTabAndCreateDivOrDepValue(string DivisionOrDepartment)
        {

            //CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            ////SelectElement divisionDropDown = new SelectElement(DivisionsOrDepartmentsTab);
            ////divisionDropDown.SelectByText(DivisionOrDepartment);
            //CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            //try
            //{
            //    driver.FindElement(divisionsOrDepartmentsTab).Click();
            //}

            //catch (Exception ex)
            //{

            //}
            //CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            ////DivisionsOrDepartmentsTabvalue.Click();
            //IList<IWebElement> options1 = driver.FindElements(By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a"));

            //foreach (IWebElement option in options1)

            //{

            //    Console.WriteLine(option.Text);

            //    if (option.Text.Equals(DivisionOrDepartment))

            //    {

            //        option.Click();

            //        break;

            //    }
            //}

            //driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForElementVisiblity(driver, divisionsOrDepartmentsTab, 30);
            driver.FindElement(divisionsOrDepartmentsTab).Click();
            driver.FindElement(By.XPath("//div[@id='caseViewDepartmentsDivisons']/ul/li/a[contains(.,'" + DivisionOrDepartment + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, caseViewSaveButton, 30);
            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }



        public string getValueFromDropDown()
        {
            string divisionText1 = driver.FindElement(divisionsOrDepartmentsTab).Text;
            Console.WriteLine(divisionText1);
            return divisionText1;
        }





        ///<summary>
        /// Enable Editing on the Case and on the  Summary tab select the newly created Division/Department value. Verify
        /// 
        /// </summary>

        public string enableEditOnCaseTabAndCreateDivOrDepValueAlert()
        {
            var message = "";

            try
            {


                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                var getCaseAlertMessage = driver.FindElement(alertMessage).Text.Trim();
                message = getCaseAlertMessage;

            }
            catch (Exception ex)
            {

            }
            return message;

        }

        ///<summary>
        /// Enable Editing on the Case and on the  Summary tab Reselect the newly created Division/Department value. Save Changes.
        /// 
        /// </summary>
        public void enableEditOnCaseTabAndReselectDivOrDepValue()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            //SelectElement divisionDropDown = new SelectElement(DivisionsOrDepartmentsTab);
            //divisionDropDown.SelectByText("SIU Group");

            driver.FindElement(divisionsOrDepartmentsTab).Click();
            driver.FindElement(divisionsOrDepartmentsTabvalueedited).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(caseEndEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(exitCaseButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

        }

        ///<summary>
        ///Verify that the 'Non-Inv Case Auto-Gen' activity was created and complete the activity. 
        /// 
        /// </summary>
        public string nonInvCaseAutoGenActivity()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var tableRows = driver.FindElements(By.XPath("//table/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var firstActivityEditButton = firstRowData.ElementAt(0).Text;
            Console.WriteLine(firstActivityEditButton);


            return firstActivityEditButton;

        }


        ///<summary>
        ///Verify that the 'Non-Inv Case Auto-Gen' activity was created and complete the activity. 
        /// 
        /// </summary>
        /// 
        public void clickActivitiesTabButton()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(activitiesTabButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void editAndCompleteAutoGenActivity(string startdate, string activityTime, string note)
        {


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, autoGenActivityEditButton, 100);
            driver.FindElement(autoGenActivityEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, editActivityNoteButton, 30);
            driver.FindElement(editActivityNoteButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, editActivityAddingNotes, 30);
            driver.FindElement(editActivityAddingNotes).Clear();
            driver.FindElement(editActivityAddingNotes).SendKeys(note);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, editActivitySaveAddedNotes, 30);
            driver.FindElement(editActivitySaveAddedNotes).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, editActivityConfirmSaveAddedNotes, 30);
            driver.FindElement(editActivityConfirmSaveAddedNotes).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, activitesStartDate, 100);
            CommonHelpers.EnterDate(driver.FindElement(activitesStartDate), startdate);
            //driver.FindElement(activitesStartDate).Clear();
            //driver.FindElement(activitesStartDate).SendKeys(starttime);
            //driver.FindElement(activitesStartDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, editActivityTime, 100);
            driver.FindElement(editActivityTime).Clear();
            driver.FindElement(editActivityTime).SendKeys(activityTime);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            CommonHelpers.WaitForElementVisiblity(driver, editActivitySaveButton, 30);
            driver.FindElement(editActivitySaveButton).Click();

            //activitesStartDate.Click();
            // driver.FindElement(activitesStartDatevalue).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);

            CommonHelpers.WaitForElementVisiblity(driver, exitActivity, 30);
            driver.FindElement(exitActivity).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);


        }



        ///<summary>
        ///
        /// Create and Verify finding reason
        /// </summary>
        /// 
        public void clickFindingsTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(findingsTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void addFindingsButtonAndCreateTheForm(string Finding_Reason, string LineofBusiness, string underpayment, string overpayment, string softsavings, string members, string claims, string Lines, string providers, string text)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            ;
            try
            {
                CommonHelpers.ScrollAndCenterElement(driver, driver.FindElement(addFindingButton));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", driver.FindElement(addFindingButton));

            }
            catch (Exception ex)
            {


            }

            WaitForPageLoading();

            SelectElement findingReasonDropDown = new SelectElement(driver.FindElement(findingReasonTab));
            findingReasonDropDown.SelectByText(Finding_Reason);
            WaitForPageLoading();

            SelectElement LineofBusinessDropDown = new SelectElement(driver.FindElement(findingLineofBusinessTab));
            LineofBusinessDropDown.SelectByText(LineofBusiness);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, Total_Underpayment_Amount, 30);
            driver.FindElement(Total_Underpayment_Amount).Clear();
            driver.FindElement(Total_Underpayment_Amount).SendKeys(underpayment);

            driver.FindElement(TotalOverpaymentAmount).Clear();
            driver.FindElement(TotalOverpaymentAmount).SendKeys(overpayment);

            driver.FindElement(TotalSoftSavingAmount).Clear();
            driver.FindElement(TotalSoftSavingAmount).SendKeys(softsavings);

            driver.FindElement(Number_of_Members_in_Population_With_Findings).Clear();
            driver.FindElement(Number_of_Members_in_Population_With_Findings).SendKeys(members);

            driver.FindElement(Number_of_Claims_in_Population_With_Findings).Clear();
            driver.FindElement(Number_of_Claims_in_Population_With_Findings).SendKeys(claims);


            driver.FindElement(Number_of_Lines_inPopulation_With_Findings).Clear();
            driver.FindElement(Number_of_Lines_inPopulation_With_Findings).SendKeys(Lines);

            driver.FindElement(Number_of_Lines_inPopulation_With_Findings).Clear();
            driver.FindElement(Number_of_Lines_inPopulation_With_Findings).SendKeys(Lines);

            driver.FindElement(Number_of_Providers_in_Population_With_Findings).Clear();
            driver.FindElement(Number_of_Providers_in_Population_With_Findings).SendKeys(providers);

            driver.FindElement(Comments).Clear();
            driver.FindElement(Comments).SendKeys(text);
            CommonHelpers.WaitForElementVisiblity(driver, addfindingsSaveButton, 30);
            driver.FindElement(addfindingsSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }


        ///<summary>
        ///
        /// Create and Verify finding reason
        /// </summary>

        public string verifTheNewlyCreatedFindingReasonCode()
        {
            WaitForLoaderToDisappear();
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.PageDown).Perform();

            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table[@id='Findings']/tbody/tr"));

            //ScrollAndCenterElement(Driver.FindElement(By.XPath("//table[@id='Findings']/tbody/tr[@class='ng-star-inserted']")));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var findingsByReasonCode = firstRowData.ElementAt(1).Text.Trim();
            Console.WriteLine(findingsByReasonCode);


            return findingsByReasonCode;



        }


        ///<summary>
        ///
        /// Create new Amount Type
        /// </summary>
        /// 

        public void clickOnAmountTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(amountsTab).Click();

        }

        public void clickOnAddAmountButtonAndCreateNewAmountType(string Amount_Type, string effectivedate, string amount, string LineofBusiness, string dateFrom, string dateTo, string amountDesc)
        {
            try
            {
                WaitForLoaderToDisappear();
                try
                {

                    ScrollAndCenterElement(driver.FindElement(addAmountButton));
                    driver.FindElement(addAmountButton).Click();
                    Console.WriteLine("element is clicked");

                }
                catch (Exception ex)
                {
                    //addAmountButton.Click();
                }

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

                SelectElement amountTypeDropDown = new SelectElement(driver.FindElement(amountType));
                amountTypeDropDown.SelectByText(Amount_Type);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveDateGrid, 30);
                driver.FindElement(amounteffectiveDateGrid).Click();
                driver.FindElement(amounteffectiveTodayDate).Click();
                //activitesStartDatevalue.Click();

                CommonHelpers.WaitForElementVisiblity(driver, Amount, 30);
                driver.FindElement(Amount).Clear();
                driver.FindElement(Amount).SendKeys(amount);
                SelectElement LineofBusinessDropDown = new SelectElement(driver.FindElement(amountLineofBusinessTab));
                LineofBusinessDropDown.SelectByText(LineofBusiness);
                driver.FindElement(amountLineofBusinessTab).Click();
                CommonHelpers.WaitForElementVisiblity(driver, FinalRecoupment, 30);
                driver.FindElement(FinalRecoupment).Click();
                CommonHelpers.WaitForElementVisiblity(driver, AmountDateRangeFrom, 30);
                driver.FindElement(AmountDateRangeFrom).Click();
                //driver.FindElement(AmountDateRangeFrom).SendKeys(dateFrom);
                WaitForPageLoading();
                driver.FindElement(amounteffectiveTodayDate).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, AmountDateRangeTo, 30);
                driver.FindElement(AmountDateRangeTo).Click();
                //driver.FindElement(AmountDateRangeTo).SendKeys(dateTo);
                driver.FindElement(amounteffectiveTodayDate).Click();
                CommonHelpers.WaitForElementVisiblity(driver, AmountCommentArea, 30);
                driver.FindElement(AmountCommentArea).Clear();
                driver.FindElement(AmountCommentArea).SendKeys(amountDesc);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(addCaseAmountSaveButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception e)
            {
                driver.FindElement(By.XPath("//div[@id='detailsTab']/descendant::button[text()='Close']")).Click();
            }

        }

        ///<summary>
        ///
        ///  Verify newlyCreatedAmountType reason
        /// </summary>

        public string verifyNewlyCreatedAmountType()
        {

            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var amountType = firstRowData.ElementAt(3).Text.Trim();

            return amountType;

        }
        public void deleteAmountDetails()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            var tableRows = driver.FindElements(By.XPath("//table[@id='Recoveries']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(11).FindElement(By.XPath("small")).FindElement(By.XPath("//button[contains(text(),'Delete')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);



            driver.FindElement(ConfirmationPopup).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }



        ///<summary>
        ///
        ///  changing the status of newly createdcase as Closed
        /// </summary>

        public void changeStatusOfCase(string Case_Type_Status)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            SelectElement LineofBusinessDropDown = new SelectElement(driver.FindElement(CaseTypeStatusDropdownNon_Investigate));
            LineofBusinessDropDown.SelectByText(Case_Type_Status);


            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);






        }

        ///<summary>
        ///
        ///  changing the status of newly createdcase as Closed
        /// </summary>

        public string getValueFromCaseStatusDropDown()
        {

            SelectElement divisionDropDown = new SelectElement(driver.FindElement(CaseTypeStatusDropdownNon_Investigate));

            IWebElement divisionText = divisionDropDown.SelectedOption;

            string divisionText1 = divisionDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);

            return divisionText1;

        }

        public void enableEditOnCaseTabAndReselectCaseStatusValue(string Case_Type_Status_Open)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            SelectElement LineofBusinessDropDown = new SelectElement(driver.FindElement(CaseTypeStatusDropdownNon_Investigate));
            LineofBusinessDropDown.SelectByText(Case_Type_Status_Open);


            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);




        }

        ///<summary>
        ///
        ///  changing the caseType as standard Investigative Case
        /// </summary>

        public void changingCaseTypeAsStandardInvestigative(string investigative_CaseType, string assignedTo, string Case_Type_Status_Cancel)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            SelectElement investigativeCaseTypeDropDown = new SelectElement(driver.FindElement(investigativeCaseType));
            investigativeCaseTypeDropDown.SelectByText(investigative_CaseType);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, CaseTypeStatusDropdownNon_Investigate, 30);
            SelectElement CaseStatusDropDown = new SelectElement(driver.FindElement(CaseTypeStatusDropdownNon_Investigate));
            CaseStatusDropDown.SelectByText(Case_Type_Status_Cancel);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, AssignedTo, 30);
            driver.FindElement(AssignedTo).Click();
            driver.FindElement(By.XPath("//div[@id='caseViewAssignedToDiv']/ul/li/a[contains(.,'" + assignedTo + "')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        ///<summary>
        ///
        ///  Verifying the caseType as standard Investigative Case
        /// </summary>

        public String verifyingCaseTypeAsStandardInvestigative()
        {
            SelectElement divisionDropDown = new SelectElement(driver.FindElement(investigativeCaseType));

            String divisionText1 = divisionDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);



            return divisionText1;

        }



        public void enableEditOnCaseTabAndReselectCaseTypeAndStatusValue(string Case_Type, string assignedTo, string Case_Type_Status_Open)
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                SelectElement investigativeCaseTypeDropDown = new SelectElement(driver.FindElement(investigativeCaseType));
                investigativeCaseTypeDropDown.SelectByText(Case_Type);

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                CommonHelpers.WaitForElementVisiblity(driver, CaseTypeStatusDropdownNon_Investigate, 30);
                SelectElement CaseStatusDropDown = new SelectElement(driver.FindElement(CaseTypeStatusDropdownNon_Investigate));
                CaseStatusDropDown.SelectByText(Case_Type_Status_Open);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                CommonHelpers.WaitForElementVisiblity(driver, AssignedTo, 30);
                driver.FindElement(AssignedTo).Click();
                driver.FindElement(By.XPath("//div[@id='caseViewAssignedToDiv']/ul/li/a[contains(.,'" + assignedTo + "')]")).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                driver.FindElement(caseViewSaveButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            }
            catch (Exception ex)
            {
                new Exception("Error in enableEditOnCaseTabAndReselectCaseTypeAndStatusValue method: " + ex.Message);

            }



        }




        ///<summary>
        ///
        ///  changing the caseType as standard Investigative Case
        /// </summary>

        public void changeTheCaseType(String investigative_CaseType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(caseBeginEditButton).Click();

            Thread.Sleep(5000);


            SelectElement investigativeCaseTypeDropDown = new SelectElement(driver.FindElement(investigativeCaseType));
            investigativeCaseTypeDropDown.SelectByText(investigative_CaseType);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(caseViewSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        ///<summary>
        ///
        ///  //View and add Related Leads/Cases by Case/Lead ID

        /// </summary>
        /// 

        public void ShowRelatedCasesAndLeads()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(RelatedCasesAndLeadsTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void viewRealatedLeadsOrCases(string Select_Search_Criteria, string RelatedCaseId)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var selectCriteria = new SelectElement(driver.FindElement(SearchAndAddRelatedCasesOrLeadsDropdown));
            selectCriteria.SelectByText(Select_Search_Criteria);

            driver.FindElement(leadIdInput).SendKeys(RelatedCaseId);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            driver.FindElement(searchButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
        }

        public void addRealatedLeadsOrCases()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForPageToLoad(driver, 100);
            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(3).FindElement(By.XPath(".//button")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


        }

        public string verifingRealatedLeadsOrCasesAlertMessage()
        {
            var message = "";

            try
            {
                WaitForPageLoading();
                var alertMessageRelatedCaseORlead = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right ng-star-inserted']/div"));
                WaitForPageLoading();

                var getCaseAlertMessage = alertMessageRelatedCaseORlead.Text.Trim().Substring(27).Trim();

                Thread.Sleep(5000);

                message = getCaseAlertMessage;


            }
            catch (Exception ex)
            {
                WaitForPageLoading();
                var alertMessageRelatedCaseORlead = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='alert alert-info alert-dismissable fade in pull-right ng-star-inserted']//div"));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

                var getCaseAlertMessage = alertMessageRelatedCaseORlead.Text;
                message = getCaseAlertMessage;

            }
            return message;

        }

        public string GetRelated_caseID()
        {

            IWebElement toastMessage = Driver.FindElement(
                By.XPath("//div[contains(@class,'notification-enter')]//label"));

            string text = toastMessage.Text;
            Match match = Regex.Match(text, @"DEM\d+");

            return match.Success ? match.Value : string.Empty;
        }

        public string GetSubjectRelated_CaseID()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='relatedCases']/form/div/div[2]/div/div/div/table/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));


            var CaseID = firstRowData.ElementAt(0).FindElement(By.XPath(".//a")).Text;
            Console.WriteLine("Related Case ID is: " + CaseID);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            return CaseID;
        }

        public void removeRealatedLeadsOrCases()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));


            firstRowData.ElementAt(3).FindElement(By.XPath("//button[contains(text(),'Remove')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


            //firstRowData.ElementAt(2).FindElement(By.XPath(".//button")).Click();
            //WaitForLoaderToDisappear();




            //var removeCaseOrLeadButton = Driver.WrappedDriver.FindElement(By.XPath("//form[@id='relatedCasesAndLeadsForm']/descendant::tbody/tr[1]/td[2]/button[contains(text(),'Remove')]"));
            //removeCaseOrLeadButton.Click();
            //WaitForLoadingOverlayToDisappear();
            driver.FindElement(RelatedCasesAndLeadsTabPopUp).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


        }


        ///<summary>
        ///
        /// View and add Related Leads/Cases by Primary Subject Name

        /// </summary>
        /// 

        public void viewRealatedSubjectName(string SubjectName, string lastname, string firstname)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            var selectCriteria = new SelectElement(driver.FindElement(SearchAndAddRelatedCasesOrLeadsDropdown));
            selectCriteria.SelectByText(SubjectName);

            driver.FindElement(primarySubjectLastName).SendKeys(lastname);
            driver.FindElement(primarySubjectfirstName).SendKeys(firstname);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, searchButton, 60);
            driver.FindElement(searchButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


        }



        ///<summary>
        ///
        ///  //Navigating to sampling tab

        /// </summary>
        /// 

        public void clickClaimsButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsButton).Click();

        }
        //

        public void clickSamplingButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(samplingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }

        public void clickCaseClaimTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(caseClaimTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }


        public void clickBeginEditButton()
        {
            try
            {
                WaitForPageLoading();
                driver.FindElement(caseBeginEditButton).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

                driver.FindElement(caseEndEditButton).Click();
                WaitForPageLoading();
            }
            try
            {
                WaitForPageLoading();
                driver.FindElement(caseBeginEditButton).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

                driver.FindElement(caseEndEditButton).Click();
                WaitForPageLoading();
            }
            try
            {
                WaitForPageLoading();
                driver.FindElement(caseBeginEditButton).Click();

            }
            catch (Exception ex) { }
        }

        public void addSamplingDetailsForDataTab(string SampleDate, string UnitDescription, string seedDateforSample, string obtaineddate, string description)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, addSamplingButton, 60);
            driver.FindElement(addSamplingButton).Click();
            WaitForPageLoading();

            if (driver.FindElement(detailsTab).Displayed)
            {
                driver.FindElement(detailsTab).Click();
            }
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, samplingDate, 60);
            CommonHelpers.EnterDate(driver.FindElement(samplingDate), SampleDate);
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            //driver.FindElement(samplingDate).SendKeys(SampleDate);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, unitDescription, 60);
            driver.FindElement(unitDescription).Clear();
            driver.FindElement(unitDescription).SendKeys(UnitDescription);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(samplingSeedNumber).SendKeys("4");
            CommonHelpers.WaitForElementVisiblity(driver, SeedDateforSample, 60);
            driver.FindElement(SeedDateforSample).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            //driver.FindElement(SeedDateforSample).SendKeys(seedDateforSample);
            CommonHelpers.WaitForElementVisiblity(driver, samplingClaimConfidenceLower, 60);
            driver.FindElement(samplingClaimConfidenceLower).SendKeys("1");
            CommonHelpers.WaitForElementVisiblity(driver, samplingClaimConfidenceUpper, 60);
            driver.FindElement(samplingClaimConfidenceUpper).SendKeys("2");
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            CommonHelpers.WaitForElementVisiblity(driver, ObtainedDate, 60);
            driver.FindElement(ObtainedDate).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            //driver.FindElement(ObtainedDate).SendKeys(obtaineddate);
            CommonHelpers.WaitForElementVisiblity(driver, SamplingMethodologyDescription, 60);
            driver.FindElement(SamplingMethodologyDescription).Clear();
            driver.FindElement(SamplingMethodologyDescription).SendKeys(description);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }


        public void addSamplingDetailsForMetricsTabForSampleTableOne(string PaidFrom, string PaidTo, string DOSFrom, string DOSTo)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            if (driver.FindElement(metricsTab).Displayed)
            {
                driver.FindElement(metricsTab).Click();
                WaitForPageLoading();
            }

            var tableRows = sampleTableOne;

            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.EnterDate(firstRowData.ElementAt(0).FindElement(By.XPath(".//input")), PaidFrom);
            //  firstRowData.ElementAt(0).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            //firstRowData.ElementAt(1).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.EnterDate(firstRowData.ElementAt(1).FindElement(By.XPath(".//input")), PaidTo);
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            CommonHelpers.EnterDate(firstRowData.ElementAt(2).FindElement(By.XPath(".//input")), DOSFrom);
            //  firstRowData.ElementAt(2).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            //  firstRowData.ElementAt(3).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.EnterDate(firstRowData.ElementAt(3).FindElement(By.XPath(".//input")), DOSTo);
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }


        public void addSamplingDetailsForMetricsTabForSampleTableTwo(string UniqueDOCount, string ProviderCount, string PatientCount, string ClaimCount, string ClaimLineCount, string CodesIncluded, string TotalBilled, string TotalAllowed, string TotalPaid)
        {




            var tableRows = sampleTableTwo;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(0).FindElement(By.XPath(".//input")).SendKeys(UniqueDOCount);
            firstRowData.ElementAt(1).FindElement(By.XPath(".//input")).SendKeys(ProviderCount);
            firstRowData.ElementAt(2).FindElement(By.XPath(".//input")).SendKeys(PatientCount);
            firstRowData.ElementAt(3).FindElement(By.XPath(".//input")).SendKeys(ClaimCount);
            firstRowData.ElementAt(4).FindElement(By.XPath(".//input")).SendKeys(ClaimLineCount);
            firstRowData.ElementAt(5).FindElement(By.XPath(".//input")).SendKeys(CodesIncluded);
            firstRowData.ElementAt(6).FindElement(By.XPath(".//input")).SendKeys(TotalBilled);
            firstRowData.ElementAt(7).FindElement(By.XPath(".//input")).SendKeys(TotalAllowed);
            firstRowData.ElementAt(8).FindElement(By.XPath(".//input")).SendKeys(TotalPaid);
            WaitForPageLoading();

        }


        public void addSamplingDetailsForMetricsTabForUniverseTableOne(string PaidFrom, string PaidTo, string DOSFrom, string DOSTo)
        {
            WaitForPageLoading();

            var tableRows = universeTableOne;

            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            CommonHelpers.EnterDate(firstRowData.ElementAt(0).FindElement(By.XPath(".//input")), PaidFrom);
            // firstRowData.ElementAt(0).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            WaitForPageLoading();
            CommonHelpers.EnterDate(firstRowData.ElementAt(1).FindElement(By.XPath(".//input")), PaidTo);
            // firstRowData.ElementAt(1).FindElement(By.XPath(".//input")).Click();
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            WaitForPageLoading();
            CommonHelpers.EnterDate(firstRowData.ElementAt(2).FindElement(By.XPath(".//input")), DOSFrom);
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            WaitForPageLoading();
            CommonHelpers.EnterDate(firstRowData.ElementAt(3).FindElement(By.XPath(".//input")), DOSTo);
            CommonHelpers.WaitForElementVisiblity(driver, amounteffectiveTodayDate, 60);
            driver.FindElement(amounteffectiveTodayDate).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public void addSamplingDetailsForMetricsTabForUniverseTableTwo(string UniqueDOCount, string ProviderCount, string PatientCount, string ClaimCount, string ClaimLineCount, string CodesIncluded, string TotalBilled, string TotalAllowed, string TotalPaid)
        {
            WaitForLoaderToDisappear();
            var tableRows = universeTableTwo;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(0).FindElement(By.XPath(".//input")).SendKeys(UniqueDOCount);
            firstRowData.ElementAt(1).FindElement(By.XPath(".//input")).SendKeys(ProviderCount);
            firstRowData.ElementAt(2).FindElement(By.XPath(".//input")).SendKeys(PatientCount);
            firstRowData.ElementAt(3).FindElement(By.XPath(".//input")).SendKeys(ClaimCount);
            firstRowData.ElementAt(4).FindElement(By.XPath(".//input")).SendKeys(ClaimLineCount);
            firstRowData.ElementAt(5).FindElement(By.XPath(".//input")).SendKeys(CodesIncluded);
            firstRowData.ElementAt(6).FindElement(By.XPath(".//input")).SendKeys(TotalBilled);
            firstRowData.ElementAt(7).FindElement(By.XPath(".//input")).SendKeys(TotalAllowed);
            firstRowData.ElementAt(8).FindElement(By.XPath(".//input")).SendKeys(TotalPaid);
            driver.FindElement(saveSamplingButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

        }

        public void scrollingTodisablingBeginEditButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageUp).Perform();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(caseEndEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }




        //verify the added samplings

        public bool addedSamplingIsDisplayed => driver.FindElement(confirmAddedSampling).Displayed;

        public void disablingBeginEditButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageUp).Perform();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            driver.FindElement(caseEndEditButton).Click();

        }

        //Verifing the data from data and metrics table


        public String verifingTheDataFromMetricSample()
        {

            var tableRows = samplingMetricTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var paidFromMetricDate = firstRowData.ElementAt(3).FindElement(By.XPath("small")).Text;
            Console.WriteLine(paidFromMetricDate);

            return paidFromMetricDate;
        }


        public string verifingTheDataFromDataSample()
        {

            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.Down).Perform();

            var tableRows = samplingBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            //ScrollByElementCoordinates(firstRowData.ElementAt(2).FindElement(By.XPath("small")));
            var paidFromDataSampleDate = firstRowData.ElementAt(4).FindElement(By.XPath("small")).Text;
            Console.WriteLine(paidFromDataSampleDate);

            return paidFromDataSampleDate;
        }

        public String verifingTheSamplingUnit()
        {

            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.Down).Perform();

            var tableRows = samplingBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            //ScrollByElementCoordinates(firstRowData.ElementAt(2).FindElement(By.XPath("small")));
            var samplingUnit = firstRowData.ElementAt(2).FindElement(By.XPath("small")).Text;
            Console.WriteLine(samplingUnit);

            return samplingUnit;
        }


        public string removeAddedSamplings()
        {

            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var tableRows = samplingBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            ScrollByElementCoordinates(firstRowData.ElementAt(8).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Delete')]")));
            var text = firstRowData.ElementAt(8).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Delete')]")).Text;
            //firstRowData.ElementAt(8).FindElement(By.XPath("small")).FindElement(By.XPath("span/button[contains(text(),'Delete')]")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            //ScrollByElementCoordinates(firstRowData.ElementAt(8).FindElement(By.XPath(".//small/span/button[contains(text(),'Delete')]")));
            firstRowData.ElementAt(8).FindElement(By.XPath(".//button[contains(text(),'Delete')]")).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            return text;

        }

        public void confirmSampleDeletion()
        {

            CommonHelpers.WaitForElementVisiblity(driver, confirmDeletionOfSampling, 60);
            driver.FindElement(confirmDeletionOfSampling).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


        }


        //View & Edit the sample, confirm date is saved correctly 

        public void viewAndEditSampleDetails(string editsampledate)
        {
            try
            {

                WaitForPageLoading();
                Actions action = new Actions(Driver);
                action.SendKeys(Keys.PageDown).Perform();

                var tableRows = samplingBody;
                var firstRow = driver.FindElement(tableRows);
                var firstRowData = firstRow.FindElements(By.TagName("td"));
                ScrollByElementCoordinates(firstRowData.ElementAt(8).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Edit')]")));
                firstRowData.ElementAt(8).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Edit')]")).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                Console.WriteLine(editsampledate);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
                CommonHelpers.WaitForElementVisiblity(driver, samplingDate, 30);

                driver.FindElement(samplingDate).Clear();

                //samplingDate.SendKeys(editsampledate);
                driver.FindElement(amounteffectiveTodayDate).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

                driver.FindElement(saveDetailsSampling).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex)
            {
                driver.FindElement(By.XPath("//div[@id='detailsTab']/descendant::button[text()='Close']"));
            }

        }

        //sorting sample and universe matrix grid


        public void sortingSampleAndUniverseMatrix()
        {


            var tableRows = samplingMetricHead;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));

            firstRowData.ElementAt(3).FindElement(By.XPath("small")).Click();



        }


        public String validatingSampleAndUniverseMatrix()
        {

            var tableRows = samplingMetricTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var text = firstRowData.ElementAt(0).FindElement(By.XPath("small")).Text;
            Console.WriteLine(text);
            return text;

        }



        public bool deleteSamplingIsDisplayed => driver.FindElement(deletesamplingHeader).Displayed;

        ///<summary>
        ///
        ///  view ,add and edit findings and verify

        /// </summary>
        /// 

        public void editFindingDetails(string underpayment)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();

            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table[@id='Findings']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(10).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Edit')]")).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, Number_of_Members_in_Population_With_Findings, 30);
            driver.FindElement(Number_of_Members_in_Population_With_Findings).Clear();
            driver.FindElement(Number_of_Members_in_Population_With_Findings).SendKeys(underpayment);
            driver.FindElement(addfindingsSaveButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);


        }

        public string verifingEditedFindings()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            var tableRows = driver.FindElements(By.XPath("//table[@id='Findings']/tbody/tr"));
            var firstRow = tableRows[0];
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var text = firstRowData.ElementAt(2).FindElement(By.XPath("small")).Text;
            Console.WriteLine(text);
            return text;

        }
        //Patient Histories report, download excel export of the report, verify data populates correctly with the column headers

        public void clickPatientHistoriesButton()
        {
            WaitForPageLoading();
            driver.FindElement(patientHistoriesButton).Click();
        }



        //verifing Finding Details Tab and All the Data entered ,are displayed properly in the table columns


        public string verifingFindingInFindingDetailsTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            var tableRows = FindingHead;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));

            var text = firstRowData.ElementAt(1).FindElement(By.XPath("small")).Text.Trim();
            action = new Actions(Driver);
            action.SendKeys(Keys.PageUp).Perform();
            return text;

        }
        //Perform a Claims Review, viewing and editing each individual claim/claim line

        public void reviewingClaimsAndEditingEachIndividualClaimLine(string mod1, string Rev)
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            driver.FindElement(ClaimReviewProfessionalEditingFirstTable).Clear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalEditingFirstTable).SendKeys(mod1);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalEditingFourthTable).Clear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalEditingFourthTable).SendKeys(Rev);
            //WaitForPageLoading();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            //WaitForPageLoading();
            //driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);




        }

        //View, Add & Edit individual claims to add a Finding, Reason, Reason 2, Comments, Units, Modifiers, Diagnosis, CPT, or any other fields that are editable
        public string ViewAddAndEditIndividualClaims(string rev, string Cptvalue, string Mod2, string claimsunit, string pay, string reason, string comments)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            //claimLinesRev.Clear();
            //claimLinesRev.SendKeys(rev);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesCPTORHCPCSORRatesORHIPPS, 100);
            driver.FindElement(claimLinesCPTORHCPCSORRatesORHIPPS).Clear();
            driver.FindElement(claimLinesCPTORHCPCSORRatesORHIPPS).SendKeys(Cptvalue);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesMod2, 100);
            driver.FindElement(claimLinesMod2).Clear();
            driver.FindElement(claimLinesMod2).SendKeys(Mod2);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesUnits, 100);
            driver.FindElement(claimLinesUnits).Clear();
            driver.FindElement(claimLinesUnits).SendKeys(claimsunit);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindingDropDown, 100);
            SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindingDropDown));
            findingDropDown.SelectByText(pay);
            IWebElement divisionText = findingDropDown.SelectedOption;

            string divisionText1 = findingDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesReasonDropDown, 100);
            SelectElement ReasonDropDown = new SelectElement(driver.FindElement(claimLinesReasonDropDown));
            ReasonDropDown.SelectByText(reason);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesComments, 100);
            driver.FindElement(claimLinesComments).Clear();
            driver.FindElement(claimLinesComments).SendKeys(comments);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return divisionText1;
        }
        //View, Add & Edit individual claim to Apply Same Finding to All Lines



        public void ViewAddAndEditIndividualClaimsToApplySameFindingToAllLines(String ClaimReviewFinding, String primaryreason, string comment)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();

            SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindings));
            findingDropDown.SelectByText(ClaimReviewFinding);
            IWebElement divisionText = findingDropDown.SelectedOption;

            driver.FindElement(claimLinesFindingsReason).Click();

            IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect//span[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(primaryreason))

                {

                    option.Click();

                    break;

                }

            }
            //claimLinesFindingsReason.SendKeys(primaryreason);
            //claimLinesFindingsReason.SendKeys(Keys.Enter);

            driver.FindElement(claimLinesFindingsComment).Clear();
            driver.FindElement(claimLinesFindingsComment).SendKeys(comment);

            driver.FindElement(applySameFindingtoAllLines).Click();
            WaitForPageLoading();
            try
            {
                driver.FindElement(applySameFindingtoAllLinesPopUp).Click();
                WaitForPageLoading();
            }
            catch (Exception ex) { }
            try
            {
                driver.FindElement(applySameFindingtoAllLinesConfirmPopUp).Click();
                WaitForPageLoading();
            }
            catch (Exception ex) { }

            WaitForPageLoading();
        }

        //Sorting finding grid
        public void sortingFindingGrid()
        {

            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();

            var tableRows = FindingHead;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            firstRowData.ElementAt(2).FindElement(By.XPath("small")).Click();


            WaitForPageLoading();
        }
        public string verifyEditAmountIsDisplayed(string date)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            string divisionText1 = "";
            try
            {
                SelectElement divisionDropDown = new SelectElement(driver.FindElement(amountLineofBusinessTab));


                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                //var text = effectiveDataError.Text;


                WaitForPageLoading();

                driver.FindElement(addCaseAmountSaveButton).Click();

                WaitForPageLoading();
            }
            catch (Exception ex)
            {
                driver.FindElement(By.XPath("//button[text()='Close']"));
            }

            return divisionText1;


        }
        public void amountValidation()
        {

            WaitForPageLoading();

            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(11).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Edit')]")).Click();

            WaitForPageLoading();
            driver.FindElement(Amount).Clear();

            driver.FindElement(addCaseAmountSaveButton).Click();

            WaitForPageLoading();
        }


        //Amount appears in AmountTable


        public string validatingAmountDetail()
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();

            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            WaitForPageLoading();
            var text = firstRowData.ElementAt(5).FindElement(By.XPath("small")).Text.Substring(1);
            Console.WriteLine(text);

            return text;


        }

        public string validatingAmountDataDetail()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();

            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var text = firstRowData.ElementAt(3).FindElement(By.XPath("small")).Text;

            return text;

        }
        public string verifingSortingAmountsGrid()
        {

            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            WaitForPageLoading();
            var text = firstRowData.ElementAt(5).FindElement(By.XPath("small")).Text;
            Console.WriteLine(text);
            WaitForPageLoading();
            return text;

        }

        public string validatingTotalPayments()
        {

            WaitForPageLoading();
            var text = driver.FindElement(TotalPayments).Text.Substring(1);
            return text;
        }
        public string validatingOutstandingBalance()
        {

            WaitForPageLoading();
            var text = driver.FindElement(OutstandingBalance).Text.Substring(2);
            return text;
        }
        //editing Amounttable fields


        public void editAmountDetails(string LineofBusiness)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(11).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Edit')]")).Click();


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            SelectElement LineofBusinessDropDown = new SelectElement(driver.FindElement(amountLineofBusinessTab));
            LineofBusinessDropDown.SelectByText(LineofBusiness);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }
        public string verifingSortingFindingGrid()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            //Actions action = new Actions(Driver);
            //action.SendKeys(Keys.PageDown).Perform();

            var tableRows = FindingBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var data = firstRowData.ElementAt(1).FindElement(By.XPath(".//small")).Text;
            Console.WriteLine(data);

            return data;

        }
        //Delete one Amount, confirm balances are still correct 

        public double getTotalAmountAndDeleteOneAmount()
        {

            WaitForPageLoading();
            var value1 = driver.FindElement(TotalAmountPayments).Text.Substring(1);
            double v1 = double.Parse(value1);
            Console.WriteLine(v1);

            WaitForPageLoading();
            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            var value2 = firstRowData.ElementAt(5).FindElement(By.XPath("small")).Text.Substring(1);
            double v2 = double.Parse(value2);
            Console.WriteLine(v2);

            double value = v1 - v2;
            Console.WriteLine(value);

            WaitForPageLoading();

            return value;

        }

        //Using the Claim Selector attach claims to a case via Select Claims from a List


        public int selectingTheClaimSelectorAndAttachingTheClaims(string renderingPID, string equal, string renderingPIDvalue)
        {
            WaitForPageLoading();
            driver.FindElement(claimSelector).Click();


            WaitForPageLoading();

            driver.FindElement(queryParameter).Click();
            WaitForPageLoading();

            //queryParameterTextBox.SendKeys(renderingPID);
            //queryParameterTextBox.Click();

            IList<IWebElement> options = driver.FindElements(By.XPath("//div[@id='claimQueryColumnDiv']/child::ul/li/a"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(renderingPID))

                {

                    option.Click();

                    break;

                }

            }
            WaitForPageLoading();

            //WaitForPageLoading();
            //Thread.Sleep(2000);
            //queryparametervalue.Click();
            var selectCriteria = new SelectElement(driver.FindElement(queryparametervalue));
            selectCriteria.SelectByText(equal);

            WaitForPageLoading();
            driver.FindElement(queryparameterIdValue).SendKeys(renderingPIDvalue);

            driver.FindElement(selectClaimsFromTheList).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();

            var tableRows = driver.FindElements(By.XPath("//table[@id='savedQueryBuilderResults']/tbody/tr[@oncontextmenu='return false;']"));
            var input = driver.FindElements(By.XPath("//td/span/input"));
            Console.WriteLine(input.Count);
            var totalRows = input.Count();
            Console.WriteLine(totalRows);
            if (totalRows > 0)
            {
                for (int i = 0; i < 5; i++)
                {

                    input[i].Click();
                }
            }



            WaitForPageLoading();

            action.SendKeys(Keys.PageUp).Perform();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(addSelectedCaseToClaim).Click();
            WaitForPageLoading();
            return totalRows;
        }
        //Sorting on Case claims grid works

        public void sortingCaseClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsHeadTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));
            Thread.Sleep(2000);
            firstRowData.ElementAt(0).FindElement(By.XPath(".//span")).Click();

        }


        //searching for claim id

        public string SearchByCaseId(string claimnumber, string claimvalue)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsSearchDropDowm).Click();
            SelectDropDownOption(driver.FindElement(claimsSearchDropDowm), claimnumber);
            driver.FindElement(SearchInput).Clear();
            driver.FindElement(SearchInput).SendKeys(claimvalue);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(SearchButton).Click();
            WaitForSearchResultsLoading(30);
            driver.FindElement(claimViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var claimid = driver.FindElement(getClaimID).Text;
            Console.WriteLine(claimid);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return claimid;
        }

        //searching for PatientName

        public string SearchByPatientName(string Patientname, string lastname, string firstname)
        {
            WaitForLoaderToDisappear();
            driver.FindElement(claimsSearchDropDowm).Click();
            SelectDropDownOption(driver.FindElement(claimsSearchDropDowm), Patientname);
            driver.FindElement(SearchLastName).Clear();
            driver.FindElement(SearchLastName).SendKeys(lastname);
            driver.FindElement(SearchFirstName).Clear();
            driver.FindElement(SearchFirstName).SendKeys(firstname);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(SearchButton).Click();
            WaitForSearchResultsLoading(30);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var name = driver.FindElement(patientname).Text.Substring(9, 9);
            Console.WriteLine(name);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            return name;
        }

        //searching for claim id

        public string SearchByPatientID(string Patientid, string patientidvalue)
        {
            WaitForLoaderToDisappear();
            driver.FindElement(claimsSearchDropDowm).Click();
            SelectDropDownOption(driver.FindElement(claimsSearchDropDowm), Patientid);
            driver.FindElement(SearchInput).Clear();
            driver.FindElement(SearchInput).SendKeys(patientidvalue);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(SearchButton).Click();
            WaitForSearchResultsLoading(30);
            driver.FindElement(claimViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var patientid = driver.FindElement(getpatientid).Text;
            Console.WriteLine(patientid);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return patientid;
        }

        //searching for CPT/HCPC(s)

        public string SearchByCPTORHCPC(string CPTORHCPC, string CPTORHCPCvalue)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsSearchDropDowm).Click();
            SelectDropDownOption(driver.FindElement(claimsSearchDropDowm), "CPT/HCPC(s)");
            driver.FindElement(SearchInput).Clear();
            driver.FindElement(SearchInput).SendKeys(CPTORHCPCvalue);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var patientid = driver.FindElement(getCPTorHCPCvalue).Text.Trim();
            Console.WriteLine(patientid);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return patientid;
        }

        //searching for DateOfServiceFrom
        public string SearchByDateOfServiceFrom(string DateOfServiceFrom, string startdate, string enddate)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsSearchDropDowm).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var selectCriteria = new SelectElement(driver.FindElement(claimsSearchDropDowm));
            selectCriteria.SelectByText(DateOfServiceFrom);
            driver.FindElement(SearchStartDate).Clear();
            driver.FindElement(SearchStartDate).SendKeys(startdate);
            driver.FindElement(SearchStartDate).SendKeys(Keys.Enter);
            driver.FindElement(SearchEndDate).Clear();
            driver.FindElement(SearchEndDate).SendKeys(enddate);
            driver.FindElement(SearchEndDate).SendKeys(Keys.Enter);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(SearchButton).Click();
            WaitForSearchResultsLoading(30);
            driver.FindElement(claimViewButton).Click();
            WaitForPageLoading();
            var servicestartdate = driver.FindElement(getServiceStartDateTo).Text.Substring(10);
            Console.WriteLine(servicestartdate);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            WaitForPageLoading();
            return servicestartdate;
        }
        //searching for DateOfServiceTo
        public string SearchByDateOfServiceTo(string DateOfServiceTo, string startdate, string enddate)
        {
            WaitForPageLoading();
            driver.FindElement(claimsSearchDropDowm).Click();
            var selectCriteria = new SelectElement(driver.FindElement(claimsSearchDropDowm));
            selectCriteria.SelectByText(DateOfServiceTo);
            driver.FindElement(SearchStartDate).Clear();
            driver.FindElement(SearchStartDate).SendKeys(startdate);
            driver.FindElement(SearchEndDate).Clear();
            driver.FindElement(SearchEndDate).SendKeys(enddate);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            driver.FindElement(SearchButton).Click();
            WaitForSearchResultsLoading(30);
            driver.FindElement(claimViewButton).Click();
            WaitForPageLoading();
            var servicestartdate = driver.FindElement(getStartDate).Text.Substring(8);
            Console.WriteLine(servicestartdate);
            driver.FindElement(clainReviewProfessionalCancelButton).Click();
            WaitForPageLoading();
            return servicestartdate;
        }

        // click on AuditButton

        public void clickOnAuditLogButton()
        {
            WaitForPageLoading();
            driver.FindElement(caseButton).Click();

            WaitForPageLoading();
            driver.FindElement(auditLogButton).Click();

        }
        public void clickAuditLogDateAndTime()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var tableRows = auditLogTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));

            firstRowData.ElementAt(5).FindElement(By.XPath("small")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        //Sorting Amounts grid
        public void sortingAmountsGrid()
        {

            WaitForPageLoading();
            //Actions action = new Actions(Driver);
            //action.SendKeys(Keys.PageDown).Perform();

            var tableRows = recoveriesHead;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("th"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            firstRowData.ElementAt(5).FindElement(By.XPath(".//small")).Click();


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);

        }

        //Verify data in the Case Claims table renders correctly with the column headers

        public string verifingDataRendersCorrectlyInClaimSummaryPatientID()
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForLoadingOverlayToDisappear();
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, getpatientid, 100);
            var patientID = driver.FindElement(getpatientid).Text;
            Console.WriteLine(patientID);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            return patientID;
        }

        public String verifingDataRendersCorrectlyInClaimSummaryPatientname()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalEditButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            CommonHelpers.WaitForElementVisiblity(driver, patientname, 100);
            var patientName = driver.FindElement(patientname).Text;
            Console.WriteLine(patientName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return patientName;
        }

        //View Individual Claim Activity, verify data renders correctly

        public string viewClaimActivity()
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForLoadingOverlayToDisappear();
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            //action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForElementVisiblity(driver, viewClaimActivityButton, 100);
            driver.FindElement(viewClaimActivityButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            CommonHelpers.SwitchtoNewWindow(driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var text = driver.FindElement(getPatientNamefromViewClaimActivityPage).Text;
            Console.WriteLine(text);


            return text;
        }


        public void clickClaimViewSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
        }

        //Case Claims Detail downloadable and data populates


        public string downloadCaseClaimsDetailAndValidateDataPopulates()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, caseClaimDetailButton, 100);
            driver.FindElement(caseClaimDetailButton).Click();
            CommonHelpers.SwitchtoNewWindow(driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            CommonHelpers.WaitForElementVisiblity(driver, caseClaimDetailData, 100);
            var text = driver.FindElement(caseClaimDetailData).Text.Substring(1);
            Console.WriteLine(text);
            return text;
        }

        //download excelsheet

        public String downloadExcelsheetAndVerfyData()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, caseClaimDetailButton, 100);
            driver.FindElement(caseClaimDetailButton).Click();
            CommonHelpers.SwitchtoNewWindow(driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, caseClaimDetailData, 100);
            var text = driver.FindElement(caseClaimDetailData).Text.Substring(1);
            Console.WriteLine(text);

            driver.FindElement(caseClaimDetailsReportViewExcel).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(caseClaimDetailsReportViewExcelData).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);


            return text;
        }

        //count the number of claims

        public string downloadExcelsheetAndVerifyRowCount()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            driver.FindElement(caseClaimDetailButton).Click();
            CommonHelpers.SwitchtoNewWindow(driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var tableRows = driver.FindElements(By.XPath("//div[@id='reportViewer_ctl13']/descendant::table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td/table/tbody/tr"));
            string count = tableRows.Count().ToString();
            Console.WriteLine(tableRows.Count());
            return count;
        }

        //Verify the Claim Status shows all claims as 'Completed'
        public string claimStatusAsCompleted()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            var text = driver.FindElement(caseClaimStatusAsCompleted).Text;
            Console.WriteLine(text);
            return text;
        }

        //Verify all Pay/Deny/Not Reviewed findings are correctly adjusted and calculated


        public void PayFidingsDropdown(string ClaimReviewFinding, string primaryreason, string comment)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsPayViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();

            SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindings));
            findingDropDown.SelectByText(ClaimReviewFinding);
            IWebElement divisionText = findingDropDown.SelectedOption;

            driver.FindElement(claimLinesFindingsReason).Click();


            IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect//span[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(primaryreason))

                {

                    option.Click();

                    break;

                }

            }
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindingsComment, 100);
            driver.FindElement(claimLinesFindingsComment).Clear();
            driver.FindElement(claimLinesFindingsComment).SendKeys(comment);
            CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLines, 100);
            driver.FindElement(applySameFindingtoAllLines).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesPopUp).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex) { }
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesConfirmPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesConfirmPopUp).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex) { }



            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalCancelButton, 100);
            driver.FindElement(ClaimReviewProfessionalCancelButton).Click();


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }

        //verify for Pay Findingdropdown

        public string verifyPayFidingsDropdown()
        {
            string divisionText1 = "";
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            driver.FindElement(claimsPayViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
                action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                WaitForLoadingOverlayToDisappear();
                action.SendKeys(Keys.PageDown).Perform();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);

                CommonHelpers.WaitForElementVisiblity(driver, reasonForPaidClaims, 100);
                SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForPaidClaims));


                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalCancelButton, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }


            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return divisionText1;
        }


        public void DenyFidingsDropdown(string ClaimReviewFinding, string primaryreason, string comment)
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsDenyViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();

            SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindings));
            findingDropDown.SelectByText(ClaimReviewFinding);
            IWebElement divisionText = findingDropDown.SelectedOption;

            driver.FindElement(claimLinesFindingsReason).Click();


            IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect//span[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(primaryreason))

                {

                    option.Click();

                    break;

                }

            }
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindingsComment, 100);
            driver.FindElement(claimLinesFindingsComment).Clear();
            driver.FindElement(claimLinesFindingsComment).SendKeys(comment);
            CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLines, 100);
            driver.FindElement(applySameFindingtoAllLines).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesPopUp).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex) { }
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesConfirmPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesConfirmPopUp).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex) { }
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalCancelButton, 100);
            driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

        }

        //verify for Deny Findingdropdown

        public string verifyDenyFidingsDropdown()
        {
            string divisionText1 = "";
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsDenyViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                driver.FindElement(ClaimReviewProfessionalEditButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, reasonForZeroPaidClaims, 100);
                SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForZeroPaidClaims));

                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalCancelButton, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }
            return divisionText1;
        }

        //Not Revived Finding Dropdown

        public void NotReviewedFidingsDropdown(string reasonforzeropaidclaims, string primaryreason, string comment)
        {

            WaitForPageLoading();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsNRViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForPageLoading();
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindings, 100);
            SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindings));
            findingDropDown.SelectByText(reasonforzeropaidclaims);
            IWebElement divisionText = findingDropDown.SelectedOption;
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindingsReason, 100);
            driver.FindElement(claimLinesFindingsReason).Click();

            IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect//span[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(primaryreason))

                {

                    option.Click();

                    break;

                }

            }
            //claimLinesFindingsReason.SendKeys(primaryreason);
            //claimLinesFindingsReason.SendKeys(Keys.Enter);
            CommonHelpers.WaitForElementVisiblity(driver, claimLinesFindingsComment, 100);
            driver.FindElement(claimLinesFindingsComment).Clear();
            driver.FindElement(claimLinesFindingsComment).SendKeys(comment);
            CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLines, 100);
            driver.FindElement(applySameFindingtoAllLines).Click();
            WaitForPageLoading();
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesPopUp).Click();
                WaitForPageLoading();
            }
            catch (Exception ex) { }
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, applySameFindingtoAllLinesConfirmPopUp, 100);
                driver.FindElement(applySameFindingtoAllLinesConfirmPopUp).Click();
                WaitForPageLoading();
            }
            catch (Exception ex) { }

            WaitForPageLoading();
        }






        public string verifyNotReviewedFidingsDropdown()
        {
            string divisionText1 = "";
            WaitForPageLoading();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsNRViewButton).Click();
            WaitForPageLoading();
            try
            {
                driver.FindElement(ClaimReviewProfessionalEditButton).Click();
                WaitForLoadingOverlayToDisappear();

                CommonHelpers.WaitForElementVisiblity(driver, reasonForPaidClaims, 100);
                SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForPaidClaims));

                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                WaitForPageLoading();

                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

                WaitForLoaderToDisappear();



            }
            catch
            {
                WaitForLoaderToDisappear();
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalCancelButton, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }
            return divisionText1;
        }


        //Findings with no value selected

        public void NoValueFidingsDropdown(string reasonforzeropaidclaims, string primaryreason, string comment)
        {

            WaitForPageLoading();
            driver.FindElement(claimsNVViewButton).Click();
            try
            {
                WaitForLoaderToDisappear();
                driver.FindElement(ClaimReviewProfessionalEditButton).Click();
                WaitForLoadingOverlayToDisappear();


                SelectElement findingDropDown = new SelectElement(driver.FindElement(claimLinesFindings));
                findingDropDown.SelectByText(reasonforzeropaidclaims);
                IWebElement divisionText = findingDropDown.SelectedOption;

                //claimLinesFindingsReason.Clear();
                //claimLinesFindingsReason.SendKeys(primaryreason);
                //claimLinesFindingsReason.SendKeys(Keys.Enter);

                driver.FindElement(claimLinesFindingsReason).Click();

                IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='CaseClaimReviewForm']/descendant::p-multiselect//span[text()='(DO NOT MODIFY) - Automated Testing Finding Reason Testing']"));

                foreach (IWebElement option in options)

                {

                    Console.WriteLine(option.Text);

                    if (option.Text.Contains(primaryreason))

                    {

                        option.Click();

                        break;

                    }

                }

                driver.FindElement(claimLinesFindingsComment).Clear();
                driver.FindElement(claimLinesFindingsComment).SendKeys(comment);
                driver.FindElement(claimLinesFindingsComment).Clear();
                driver.FindElement(claimLinesFindingsComment).SendKeys(comment);

                driver.FindElement(applySameFindingtoAllLines).Click();
                WaitForPageLoading();
                try
                {
                    driver.FindElement(applySameFindingtoAllLinesPopUp).Click();
                    WaitForPageLoading();
                }
                catch (Exception ex) { }
                try
                {
                    driver.FindElement(applySameFindingtoAllLinesConfirmPopUp).Click();
                    WaitForPageLoading();
                }
                catch (Exception ex) { }

                WaitForLoaderToDisappear();
            }
            catch (Exception ex)
            {
                WaitForLoaderToDisappear();
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();

            }
        }






        //Apply Same Line Level Finding to All Claims in Case

        public void ApplySameLineLevelFindingstoAllClaimsInCase(string pay, string Casename)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ApplyFindingstoCaseLevelButton, 100);
            driver.FindElement(ApplyFindingstoCaseLevelButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ApplySameLineLevelFindingtoAllClaimsinCase, 100);
            SelectElement findingDropDown = new SelectElement(driver.FindElement(ApplySameLineLevelFindingtoAllClaimsinCase));
            findingDropDown.SelectByText(pay);
            CommonHelpers.WaitForElementVisiblity(driver, ApplySameLineLevelFindingtoAllClaimsinCaseReason, 100);
            driver.FindElement(ApplySameLineLevelFindingtoAllClaimsinCaseReason).Click();

            IList<IWebElement> options = driver.FindElements(By.XPath("//*[@id='caseClaimFindingsForm']/descendant::ul/li//div[@class='p-checkbox-box']"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(Casename))

                {

                    option.Click();

                    break;

                }

            }
            CommonHelpers.WaitForElementVisiblity(driver, ApplySameLineLevelFindingtoAllClaimsinCaseReasonSave, 100);
            driver.FindElement(ApplySameLineLevelFindingtoAllClaimsinCaseReasonSave).Click();
            CommonHelpers.WaitForElementVisiblity(driver, ApplySameLineLevelFindingtoAllClaimsinCaseReasonConfirm, 100);
            driver.FindElement(ApplySameLineLevelFindingtoAllClaimsinCaseReasonConfirm).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            WaitForPageLoading();
            CommonHelpers.WaitForElementVisiblity(driver, finalizeFindingsButton, 100);
        }

        //Finalize Findings- Once you are completely finished with the Claim Line Review, select Finalize Findings and confirm each claim status reflects 'Finalized'

        public void finalizeFindings()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, finalizeFindingsButton, 100);
            driver.FindElement(finalizeFindingsButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, finalizeFindingsPopup, 100);
            driver.FindElement(finalizeFindingsPopup).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        public string verifyfinalizeFindingsStatus()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var text = driver.FindElement(caseClaimStatusAsCompleted).Text;
            Console.WriteLine(text);
            return text;

        }

        //After Finalize Findings, select Initiate Revisions, verify each claims status shows 'Revision Not Started'

        public void selectInitiateRevisions()
        {

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, initiateRevisionsButton, 100);
            driver.FindElement(initiateRevisionsButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }


        public string verifyselectInitiateRevisions()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var text = driver.FindElement(caseClaimStatusAsCompleted).Text;
            return text;
        }

        //View the claim and verify the original finding still displays


        public string viewClaimAndVerifyTheOriginalFidingStillDisplays()
        {
            string divisionText1 = "";
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsPayViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            try
            {

                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
                action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                WaitForPageLoading();

                SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForPaidClaims));

                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }

            catch (Exception ex)
            {
                WaitForPageLoading();
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return divisionText1;
        }

        //Select the plus sign for Revisions, and enter a new Revision finding (similar to the original claim review process above)

        public string selectPlusSignAndEnterANewRevisionFinding(string pay)
        {
            string divisionText1 = "";
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForElementVisiblity(driver, claimsDenyViewButton, 100);
            driver.FindElement(claimsDenyViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
                action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, findingsRevisionPlusButton, 100);
                driver.FindElement(findingsRevisionPlusButton).Click();

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

                SelectElement findingDropDown = new SelectElement(driver.FindElement(findingRevisionFindingDropdown));
                findingDropDown.SelectByText(pay);
                IWebElement divisionText = findingDropDown.SelectedOption;

                divisionText1 = findingDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }
            return divisionText1;
        }

        //Perform a Revision Claims Review, viewing and editing each individual claim/claim line.  


        public string ViewAddAndEditIndividualRevisionClaims(string rev, string Cptvalue, string Mod2, string claimsunit, string pay, string reason, string comments)
        {
            string divisionText1 = "";
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsDenyViewButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
                action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
                CommonHelpers.WaitForElementVisiblity(driver, findingsRevisionPlusButton, 100);
                driver.FindElement(findingsRevisionPlusButton).Click();

               CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                //CommonHelpers.WaitForElementVisiblity(driver, revisionClaimLinesRev, 100);
                //driver.FindElement(revisionClaimLinesRev).Clear();
                //driver.FindElement(revisionClaimLinesRev).SendKeys(rev);
                CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesCPTORHCPCSORRatesORHIPPS, 100);
                driver.FindElement(revisionclaimLinesCPTORHCPCSORRatesORHIPPS).Clear();
                driver.FindElement(revisionclaimLinesCPTORHCPCSORRatesORHIPPS).SendKeys(Cptvalue);
                CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesMod2, 100);
                driver.FindElement(revisionclaimLinesMod2).Clear();
                driver.FindElement(revisionclaimLinesMod2).SendKeys(Mod2);

                CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesUnits, 100);
                driver.FindElement(revisionclaimLinesUnits).Clear();
                driver.FindElement(revisionclaimLinesUnits).SendKeys(claimsunit);
                CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesFindingDropDown, 100);

                SelectElement findingDropDown = new SelectElement(driver.FindElement(revisionclaimLinesFindingDropDown));
                findingDropDown.SelectByText(pay);
// IWebElement divisionText = findingDropDown.SelectedOption;

                divisionText1 = findingDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                //CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesReasonDropDown, 100);
                //SelectElement ReasonDropDown = new SelectElement(driver.FindElement(revisionclaimLinesReasonDropDown));
                //ReasonDropDown.SelectByText(reason);
                
                //CommonHelpers.WaitForElementVisiblity(driver, revisionclaimLinesComments, 100);
                //driver.FindElement(revisionclaimLinesComments).Clear();
                //driver.FindElement(revisionclaimLinesComments).SendKeys(comments);

                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            }
            catch (Exception ex)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }


            return divisionText1;

        }


        //deleting the added claims

        public void cancelAddedRevision()
        {


            WaitForPageLoading();

            driver.FindElement(revisionRefreshButton).Click();
            WaitForPageLoading();
            driver.FindElement(cancelRevisionhButton).Click();
            WaitForPageLoading();
            driver.FindElement(cancelRevisionhButtonPopupConfirmation).Click();
            WaitForPageLoading();

        }


        public void clickUndoFinlize()
        {


            WaitForPageLoading();
            driver.FindElement(UndoFinalizeButton).Click();
            WaitForPageLoading();
            driver.FindElement(finalizeFindingsPopup).Click();
            WaitForPageLoading();
        }

        public void deleteTheAddedClaims()
        {
            try
            {
                WaitForPageLoading();
                var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table[@id='caseClaimsTable']/tbody/tr"));

                for (int i = tableRows.Count; i > 0; i--)
                {
                    tableRows = Driver.WrappedDriver.FindElements(By.XPath("//table[@id='caseClaimsTable']/tbody/tr"));
                    // var firstRow = tableRows[0];
                    //var firstRowData = firstRow.FindElements(By.TagName("td"));
                    var element = tableRows[0].FindElement(By.XPath(".//small/button[contains(text(),'Delete')]"));
                    int rowcount1 = tableRows.Count();
                    Console.WriteLine(rowcount1);
                    element.Click();
                    CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                    driver.FindElement(finalizeFindingsPopup).Click();
                    CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
                }
            }
            catch (Exception e)
            {
            }


        }





        public void selectingTheClaimSelectorAndAttachingTheClaimshViaGenerateAConvenientSample(string renderingPID, string equal, string renderingPIDvalue)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, claimSelector, 100);
            driver.FindElement(claimSelector).Click();
           CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, queryParameter, 100);
            driver.FindElement(queryParameter).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            IList<IWebElement> options = Driver.WrappedDriver.FindElements(By.XPath("//div[@id='claimQueryColumnDiv']/child::ul/li/a"));

            foreach (IWebElement option in options)

            {

                Console.WriteLine(option.Text);

                if (option.Text.Contains(renderingPID))

                {

                    option.Click();

                    break;

                }

            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, queryparametervalue, 100);
            driver.FindElement(queryparametervalue).Click();
            var selectCriteria = new SelectElement(driver.FindElement(queryparametervalue));
            selectCriteria.SelectByText(equal);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(queryparameterIdValue).SendKeys(renderingPIDvalue);
            CommonHelpers.WaitForElementVisiblity(driver, selectClaimsFromTheConvenientSample, 100);
            driver.FindElement(selectClaimsFromTheConvenientSample).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, getSampleSizeButton, 100);
            driver.FindElement(getSampleSizeButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, runOrGetSampleButton, 100);
            driver.FindElement(runOrGetSampleButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100  );

            Actions action = new Actions(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            action.SendKeys(Keys.PageUp).Perform();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, addSelectedCaseToClaim, 100);
            driver.FindElement(addSelectedCaseToClaim).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
        }

        public void validateAuditLogBasedOnActionsPerformed()
        {

            var tableRows = Driver.WrappedDriver.FindElements(By.XPath("//tr[@ng-repeat='row in tableData.rows | orderBy:sortType1:sortReverse1 | filter:searchTable']"));
            Console.WriteLine(tableRows.Count());
            var totalRows = tableRows.Count();
            for (int i = 0; i < totalRows; i++)
            {

                var firstRow = tableRows[i];
                var firstRowData = firstRow.FindElements(By.TagName("td"));
                var text = firstRowData.ElementAt(1).FindElement(By.XPath("small")).Text;
                if (text == ("Case Manual Finding Added"))
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
        public string ClickCaseClaimDetailsReportViewExcel()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var text = driver.FindElement(caseClaimDetailsReportViewExcelProviderID).Text;

            driver.FindElement(caseClaimDetailsReportViewExcel).Click();

            WaitForPageLoading();
            driver.FindElement(caseClaimDetailsReportViewExcelData).Click();
            Console.WriteLine(text);

            WaitForPageLoading();


            return text;

        }
        public double confirmingBalancesAreStillCorrect()
        {
            WaitForPageLoading();
            var tableRows = recoveriesBody;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));

            firstRowData.ElementAt(11).FindElement(By.XPath("small")).FindElement(By.XPath(".//button[contains(text(),'Delete')]")).Click();


            WaitForPageLoading();

            //Driver.SwitchTo().Alert().Accept();
            driver.FindElement(ConfirmationAmountPopup).Click();
            WaitForPageLoading();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var value1 = driver.FindElement(TotalAmountPayments).Text.Substring(1);
            double v1 = double.Parse(value1);

            Console.WriteLine(v1);
            return v1;
        }
        public string VerifyClaimsAndEditingEachIndividualClaimLine()
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForLoadingOverlayToDisappear();
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, alertMessage, 100);
            var text = driver.FindElement(alertMessage).Text;
            return text;
        }

        public string VerifyNotPaidClaimLineReasonAsNR(string reasonforzeropaidclaims)
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForLoadingOverlayToDisappear();
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForElementVisiblity(driver, reasonForZeroPaidClaims, 100);
            SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForZeroPaidClaims));
            divisionDropDown.SelectByText(reasonforzeropaidclaims);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            string divisionText1 = divisionDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

            //driver.FindElement(ClaimReviewProfessionalCancelButton).Click();

            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return divisionText1;
        }

        //verifing same findings is applied to all the claims or not


        public string verifingSameFindingToAllLines()
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            WaitForLoadingOverlayToDisappear();
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);

            SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForZeroPaidClaims));

            string divisionText1 = divisionDropDown.SelectedOption.Text;
            Console.WriteLine(divisionText1);


            driver.FindElement(ClaimReviewProfessionalCancelButton).Click();

            WaitForPageLoading();


            return divisionText1;

        }

        //Verify all data renders correctly in the individual Claim Summary (within the Claim)

        public string verifingDataRendersCorrectlyInClaimSummary()
        {
            WaitForPageLoading();
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsViewButton).Click();
            WaitForLoaderToDisappear();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalEditButton, 100);
            action.MoveToElement(driver.FindElement(ClaimReviewProfessionalEditButton)).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", driver.FindElement(ClaimReviewProfessionalEditButton));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 200);
            WaitForLoadingOverlayToDisappear();
            action.SendKeys(Keys.PageDown).Perform();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, getClaimID, 100);
            var claimID = driver.FindElement(getClaimID).Text;
            Console.WriteLine(claimID);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            CommonHelpers.WaitForElementVisiblity(driver, ClaimReviewProfessionalSaveButton, 100);
            driver.FindElement(ClaimReviewProfessionalSaveButton).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            return claimID;
        }

        public string verifyNoFidingsDropdown()
        {
            string divisionText1 = "";
            WaitForPageLoading();
            Actions action = new Actions(driver);
            action.SendKeys(Keys.PageDown).Perform();
            WaitForPageLoading();
            driver.FindElement(claimsNVViewButton).Click();
            try
            {
                WaitForLoaderToDisappear();
                driver.FindElement(ClaimReviewProfessionalEditButton).Click();
                WaitForLoadingOverlayToDisappear();
                CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);

                SelectElement divisionDropDown = new SelectElement(driver.FindElement(reasonForZeroPaidClaims));

                divisionText1 = divisionDropDown.SelectedOption.Text;
                Console.WriteLine(divisionText1);
                WaitForPageLoading();

                driver.FindElement(ClaimReviewProfessionalSaveButton).Click();

                WaitForLoaderToDisappear();



            }
            catch
            {
                WaitForLoaderToDisappear();
                driver.FindElement(ClaimReviewProfessionalCancelButton).Click();
            }
            return divisionText1;
        }

        public string verifingClaimsAddedToCase()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);

            var text = driver.FindElement(alertMessage).Text;
            Console.WriteLine(text);
            return text;
        }

        public string verifyClaimsAdded()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            driver.FindElement(claimsRefreshButton).Click();
            WaitForPageLoading();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var count = driver.FindElement(claimsCount).Text;
            Console.WriteLine(count);
            return count;
        }

        public string verifingSortingWorksForClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var data = firstRowData.ElementAt(0).FindElement(By.XPath(".//small")).Text;
            Console.WriteLine(data);
            return data;

        }

        //Verify data in the Case Claims table renders correctly with the column headers

        public string verifingLOBForClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            var data = firstRowData.ElementAt(1).Text;
            Console.WriteLine(data);
            return data;

        }
        public string verifingPatientForClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var data = firstRowData.ElementAt(4).FindElement(By.XPath(".//a")).Text;
            Console.WriteLine(data);
            return data;

        }

        public string verifingProviderForClaimsGrid()
        {
            WaitForPageLoading();
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var data = firstRowData.ElementAt(5).FindElement(By.XPath(".//a")).Text;
            Console.WriteLine(data);
            return data;

        }
        public string verifingDateTimeAddedForClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var data = firstRowData.ElementAt(9).Text;
            Console.WriteLine(data);
            return data;

        }
        public string verifingStatusForClaimsGrid()
        {
            WaitForPageLoading();
            var tableRows = claimsBodyTable;
            var firstRow = driver.FindElement(tableRows);
            var firstRowData = firstRow.FindElements(By.TagName("td"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            var data = firstRowData.ElementAt(10).Text;
            Console.WriteLine(data);
            return data;

        }

    }

}



































