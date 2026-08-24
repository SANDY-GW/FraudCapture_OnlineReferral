using OpenQA.Selenium;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab
{
    public class CreateNewLeadPageObjects
    {
        #region Lead Details Elements
        public static readonly By LeadWorkflowTypeDropDown = By.XPath("//select[@id='leadCaseType']");
        public static readonly By DetectionMethodDropDown = By.XPath("//select[@id='leadDetection']");
        public static readonly By SourceTypeDropDown = By.XPath("//select[@id='leadSource']");
        public static readonly By ReasonDropDown = By.XPath("//select[@id='leadReason']");
        public static readonly By AssignedToDropDown = By.XPath("//select[@id='leadAssignedTo']");
        public static readonly By NextBtn = By.XPath("//button[@id='next']");
        #endregion

        #region Subject Type Elements
        public static readonly By SubjectTypeDropDown = By.XPath("//select[@id='subjectTypeVal']");
        public static readonly By PrimarySubjectDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        public static readonly By NextBtnforPrimarySubjectPage = By.XPath("//button[@id='next']");
        #endregion

        #region Description Elements
        public static readonly By DescriptionTab = By.XPath("//a[@id='descriptionTabId']");
        public static readonly By DescriptionField = By.XPath("//div[@class='fr-element fr-view fr-element-scroll-visible']/p");
        public static readonly By NextBtnforDescriptionPage = By.XPath("//button[@id='next']");
        #endregion

        #region Referring Party Elements
        public static readonly By ReferringPartyDropDown = By.XPath("//select[@id='referringPartyVal']");
        public static readonly By NextBtnforReferringPartyPage = By.XPath("//button[@id='next']");
        public static readonly By CreateLeadBtninPrioritizationTab = By.XPath("//button[@id='createLeadBtninPrioritizationTab']");
        #endregion

        #region Manual Subject Entry Elements
        public static readonly By ManuallyAddBySubjectPrefix = By.XPath("//input[@id='ViewSubjectNamePrefix']");
        public static readonly By ManuallyAddBySubjectFirstName = By.XPath("//input[@id='ViewSubjectFirstName']");
        public static readonly By ManuallyAddBySubjectLastName = By.XPath("//input[@id='ViewSubjectLastName']");
        public static readonly By ManuallyAddBySubjectMiddleName = By.XPath("//input[@id='ViewSubjectMiddleName']");
        public static readonly By ManuallyAddBySubjectSuffix = By.XPath("//input[@id='ViewSubjectSuffix']");
        public static readonly By ManuallyAddBySubjectDateofBirth = By.XPath("//input[@name='ViewSubjectDateofBirth']");
        public static readonly By ManuallyAddBySubjectGender = By.XPath("//input[@id='ViewSubjectGender']");
        public static readonly By ManuallyAddBySubjectOther = By.XPath("//input[@id='ViewSubjectOther']");
        public static readonly By ManuallyAddBySubjectId = By.XPath("//input[@id='ViewSubjectId']");
        public static readonly By ManuallyAddBySubjectSSN = By.XPath("//input[@id='ViewSubjectSSN']");
        public static readonly By ManuallyAddBySubjectMedicaidNo = By.XPath("//input[@id='SubjectMedicaidNo']");
        public static readonly By ManuallyAddBySubjectMedicareNo = By.XPath("//input[@id='SubjectMedicareNo']");
        public static readonly By ManuallyAddBySubjectOtherId = By.XPath("//input[@id='ViewSubjectOtherId']");
        public static readonly By ManuallyAddBySubjectplan = By.XPath("//input[@id='ViewSubjectplan']");
        public static readonly By ManuallyAddBySubjectprogram = By.XPath("//input[@id='ViewSubjectprogram']");
        public static readonly By ManuallyAddBySubjectLob = By.XPath("//input[@id='ViewSubjectLob']");
        public static readonly By ManuallyAddBySubjectGroup = By.XPath("//input[@id='ViewSubjectGroup']");
        public static readonly By ManuallyAddBySubjectAddress1 = By.XPath("//input[@id='ViewSubjectAddress1']");
        public static readonly By ManuallyAddBySubjectAddress2 = By.XPath("//input[@id='ViewSubjectAddress2']");
        public static readonly By ManuallyAddBySubjectCity = By.XPath("//input[@id='ViewSubjectCity']");
        public static readonly By ManuallyAddBySubjectState = By.XPath("//select[@id='ViewSubjectState']");
        public static readonly By ManuallyAddBySubjectCounty = By.XPath("//select[@id='ViewSubjectCounty']");
        public static readonly By ManuallyAddBySubjectZipCode = By.XPath("//input[@id='ViewSubjectZipCode']");
        public static readonly By ManuallyAddByViewSubjectPhone = By.XPath("//input[@id='ViewSubjectPhone']");
        public static readonly By ManuallyAddBySecondaryPhone = By.XPath("//input[@id='SecondaryPhone']");
        public static readonly By ManuallyAddBySubjectEmail = By.XPath("//input[@id='ProviderViewSubjectEmail']");
        #endregion

        #region Member Search Elements
        public static readonly By SearchByIDSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        public static readonly By MemberSearchByID = By.XPath("//input[@id='searchIdCase']");
        public static readonly By MemberSearchBtn = By.XPath("//button[@id='btnSearch']");
        public static readonly By MemberClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        public static readonly By MemberSelectBtn = By.XPath("//button[@id='SelectSbjectResultBtn']");

        public static readonly By SearchByNameSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        public static readonly By MemberSearchByFirstName = By.XPath("//input[@id='searchFname']");
        public static readonly By MemberSearchByLastName = By.XPath("//input[@id='searchLname']");
        public static readonly By MemberSearchByNameSearchBtn = By.XPath("//button[@id='btnSearch']");
        public static readonly By MemberSearchByNameSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        public static readonly By MemberSearchByNameSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");

        public static readonly By SearchByAddressSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        public static readonly By MemberSearchByAddressfield = By.XPath("//input[@id='searchAddress']");
        public static readonly By MemberSearchByCity = By.XPath("//input[@id='searchCity']");
        public static readonly By MemberSearchByAddressSearchBtn = By.XPath("//button[@id='btnSearch']");
        public static readonly By MemberSearchByAddressSearchClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        public static readonly By MemberSearchByAddressSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");
        #endregion

        #region Provider Search Elements
        public static readonly By SubjectTypeDropDownProvider = By.XPath("//select[@id='subjectTypeVal']");
        public static readonly By PrimarySubjectDropDownProvider = By.XPath("//select[@id='subjectTypeSelection']");
        public static readonly By ProviderOrganizationName = By.XPath("//input[@id='ReferralOrganizationName']");

        public static readonly By ProviderSearchByID = By.XPath("//input[@id='searchIdCase']");
        public static readonly By ProviderSearchBtn = By.XPath("//button[@id='btnSearch']");
        public static readonly By ProviderClearBtn = By.XPath("//form[@id='LeadNewForm']//button[text()='Clear']");
        public static readonly By ProviderSelectBtn = By.XPath("//button[@id='SelectSbjectResultBtn']");

        public static readonly By ProviderSearchByTIN = By.XPath("//input[@id='searchIdCase']");
        public static readonly By ProviderSearchBtnforTIN = By.XPath("//button[@id='btnSearch']");
        public static readonly By ProviderClearBtnforTIN = By.XPath("(//button[text()='Clear'])[5]");
        public static readonly By ProviderSelectBtnforTIN = By.XPath("//button[@id='SelectSbjectResultBtn']");

        public static readonly By ProviderSearchByNPI = By.XPath("//input[@id='searchIdCase']");
        public static readonly By ProviderSearchBtnforNPI = By.XPath("//button[@id='btnSearch']");
        public static readonly By ProviderClearBtnforNPI = By.XPath("(//button[text()='Clear'])[5]");
        public static readonly By ProviderSelectBtnforNPI = By.XPath("//button[@id='SelectSbjectResultBtn']");

        public static readonly By ProviderSearchByOrganization = By.XPath("//input[@id='searchOrgName']");
        public static readonly By ProviderSelectBtnforName = By.XPath("//button[@id='SelectSbjectResultBtn']");

        public static readonly By ProviderSearchByAddress = By.XPath("//input[@id='searchAddress']");
        public static readonly By ProviderSearchByCity = By.XPath("//input[@id='searchCity']");
        public static readonly By ProviderSearchByAddressSelectBtn = By.XPath("//div//button[@id='SelectSbjectResultBtn']");
        #endregion

        #region Referring Party Search Elements
        public static readonly By ReferringPartySearchByID = By.XPath("//input[@name='searchIdCase']");
        public static readonly By ReferringPartySearchBtn = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtn = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtn = By.XPath("//button[@id='btnAddReferral']");

        public static readonly By ReferringPartySearchByFirstname = By.XPath("//input[@id='searchFname']");
        public static readonly By ReferringPartySearchBtnFirstname = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtnFirstname = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtnFirstname = By.XPath("//button[@id='btnAddReferral']");

        public static readonly By ReferringPartySearchByProviderID = By.XPath("//input[@id='searchByMemberId']");
        public static readonly By ReferringPartySearchBtnProviderID = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtnProviderID = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtnProviderID = By.XPath("//button[@id='btnAddReferral']");

        public static readonly By ReferringPartySearchByProviderTIN = By.XPath("//input[@id='searchTinEinCase']");
        public static readonly By ReferringPartySearchBtnProviderTIN = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtnProviderTIN = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtnProviderTIN = By.XPath("//button[@id='btnAddReferral']");

        public static readonly By ReferringPartySearchByProviderNPI = By.XPath("//input[@id='searchNpiCase']");
        public static readonly By ReferringPartySearchBtnProviderNPI = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtnProviderNPI = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtnProviderNPI = By.XPath("//button[@id='btnAddReferral']");

        public static readonly By ReferringPartySearchByProviderName = By.XPath("//input[@id='searchOrgName']");
        public static readonly By ReferringPartySearchBtnProviderName = By.XPath("//button[@id='btnSearch']");
        public static readonly By ReferringPartyClearBtnProviderName = By.XPath("//button[text()='Clear Search Fields']");
        public static readonly By ReferringPartySelectBtnProviderName = By.XPath("//button[@id='btnAddReferral']");
        #endregion
    }
}
