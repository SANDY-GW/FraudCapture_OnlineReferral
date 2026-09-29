
    /// <summary>
    /// Simple data holder for test data used by CaseEdit BDD step definitions.
    /// </summary>
    /// 
    namespace FC_CaseTrackingData.Data
    {
        public class CaseTrackingData
        {
            public string User_1 { get; set; } = System.Environment.GetEnvironmentVariable("TEST_USERNAME") ?? "Test_Username";
            public string CaseId_2 { get; set; } = System.Environment.GetEnvironmentVariable("CASE_TRACKING_CASE_ID_2") ?? "DEMO0804202614";
            public string CaseId_3 { get; set; } = System.Environment.GetEnvironmentVariable("CASE_TRACKING_CASE_ID_3") ?? "DEMO0720202611";
            public string InvestigativeCaseActivityManual_Title { get; set; } = string.Empty;
            public string ActivityAssignedTo { get; set; } = string.Empty;
            public string CaseActivityManual_Title { get; set; } = string.Empty;
            public string ClaimDropdownValue { get; set; } = "Claim Number(s)";
            public string claimvalue1 { get; set; } = string.Empty;
            public string FindingSubject { get; set; } = string.Empty;
            public string FindingReason { get; set; } = string.Empty;
            public string LineOfBusiness { get; set; } = string.Empty;
            public string LineofBusiness { get; set; } = "LOB1";
            public string UnderpaymentAmount { get; set; } = string.Empty;
            public string OverpaymentAmount { get; set; } = string.Empty;
            public string SoftSavingAmount { get; set; } = string.Empty;
            public string MembersCount { get; set; } = string.Empty;
            public string ClaimsCount { get; set; } = string.Empty;
            public string LinesCount { get; set; } = string.Empty;
            public string ProvidersCount { get; set; } = string.Empty;
            public string Comments { get; set; } = "Testing";
            public string PatientHistoriesReport_ExpectedData { get; set; } = "49279";
            public string AttachmentTitle { get; set; } = "TestFile.txt";
            public string ActivityName_2 { get; set; } = "All";
            public string ClaimSummaryClaimIDforInvestigativecase { get; set; } = "201400238639";

            public string ActivitesStartDate { get; set; } = "04/19/1990";
            public string activityTime { get; set; } = string.Empty;
            public string Amount { get; set; } = "800";
            public string Amount_Type { get; set; } = "(DO NOT MODIFY) Automated Testing Amount Type";
            public string AmountCommentArea { get; set; } = "Testing";
            public string AmountDateRangeFrom { get; set; } = string.Empty;
            public string AmountDateRangeTo { get; set; } = string.Empty;
            public string Amounteffectivedate { get; set; } = string.Empty;
            public string AssignedToUser { get; set; } = "D, Jayapradha";
            public string Auto_Gen_Activity { get; set; } = "(DO NOT MODIFY) Automated Testing Non-Inv Case Activity Auto-Gen";
            public string Case_Type { get; set; } = "(DO NOT MODIFY) Automated Testing Non-Inv";
            public string Case_Type_Status { get; set; } = "(DO NOT MODIFY) Automated Testing Non-Inv Closed";
            public string Case_Type_Status_Cancel { get; set; } = "Test Non-Inv Case Testing Status - Canceled";
            public string Case_Type_Status_Open { get; set; } = "(DO NOT MODIFY) Automated Testing Non-Inv Open";
            public string CaseID { get; set; } = string.Empty;
            public string ClaimCount { get; set; } = "1";
            public string Claimid { get; set; } = "201400";
            public string ClaimLineCount { get; set; } = "1";
            public string ClaimNumber { get; set; } = "Claim Number(s)";
            public string ClaimReviewFinding { get; set; } = "Deny";
            public string ClaimReviewFindingReason { get; set; } = "(DO NOT MODIFY)";
            public string ClaimsAddedToCase { get; set; } = "The selected claims will be added to case";
            public string ClaimsComments { get; set; } = "Claim lines has been updated";
            public string ClaimsCPT { get; set; } = "99234";
            public string ClaimsFinding { get; set; } = "Pay";
            public string ClaimsMod2 { get; set; } = "78";
            public string ClaimsReason { get; set; } = "(DO NOT MODIFY) - Automated Testing Finding Reason Testing";
            public string ClaimsRev { get; set; } = "47";
            public string Claimsummarrayclaimid { get; set; } = "201400126152";
            public string Claimsummarraypatientid { get; set; } = "221581";
            public string Claimsummarraypatientname { get; set; } = "FN22814 LN38417";
            public string ClaimsUnits { get; set; } = "0.07";
            public string claimvalue { get; set; } = "201400126096";
            public string CodesIncluded { get; set; } = "1";
            public string CPTorHCPC { get; set; } = "CPT/HCPC(s)";
            public string CPTorHCPCvalue { get; set; } = "99212";
            public string Dateofservicefrom { get; set; } = "Date of Service From";
            public string DateOfServiceTo { get; set; } = "Date of Service To";
            public string DateTimeAdded { get; set; } = "GMT+5:30";
            public string DivisionOrDepartment { get; set; } = "SIU Group";
            public string DOSFrom { get; set; } = string.Empty;
            public string DOSTo { get; set; } = string.Empty;
            public string EditClaimsuccess { get; set; } = "Claim Review has been saved successfully.";
            public string editSampleDate { get; set; } = string.Empty;
            public string EndDate { get; set; } = "09/08/2022";
            public string ExpectedClaimCount { get; set; } = "5";
            public string exportClaimcount { get; set; } = "10";
            public string Finding_Reason { get; set; } = "(DO NOT MODIFY) - Automated Testing Finding Reason Testing";
            public string FindingDate { get; set; } = "GMT+5:30";
            public string Finding { get; set; } = "(DO NOT MODIFY)";
            public string Findingswithzerovalue { get; set; } = string.Empty;
            public string FirstName { get; set; } = "FN5349";
            public string FN { get; set; } = "FN12850";
            public string investigativeCaseType { get; set; } = "Test Environment - Administrative Case Testing";
            public string InvestigativeRefrenceidvalue { get; set; } = "53916";
            public string LastName { get; set; } = "LN5310";
            public string LineofBusiness2 { get; set; } = "LOB2";
            public string LN { get; set; } = "LN28142";
            public string LOB { get; set; } = "LOB1";
            public string membersInpoulation { get; set; } = "5";
            public string MOD1 { get; set; } = "35";
            public string note { get; set; } = "Testing";
            public string Number_of_Members_in_Population_With_Findings { get; set; } = "2";
            public string Number_ofClaims_in_Population_With_Findings { get; set; } = "3";
            public string Number_ofLines_inPopulation_With_Findings { get; set; } = "4";
            public string Number_ofProviders_in_Population_With_Findings { get; set; } = "1";
            public string ObtainedDate { get; set; } = string.Empty;
            public string OutstandingBalance { get; set; } = string.Empty;
            public string PaidFrom { get; set; } = string.Empty;
            public string PaidTo { get; set; } = string.Empty;
            public string Patient { get; set; } = "FN";
            public string PatientCount { get; set; } = "1";
            public string PatientID { get; set; } = "Patient ID(s)";
            public string PatientIDValue { get; set; } = "158638";
            public string Patientname { get; set; } = "Patient Name";
            public string Project_Name { get; set; } = string.Empty;
            public string Provider { get; set; } = "LN11650, FN2796";
            public string ProviderCount { get; set; } = "1";
            public string PatientProviderID { get; set; } = "52029";
            public string queryValue { get; set; } = "equal";
            public string reasonforzeropaidclaims { get; set; } = "Not Reviewed";
            public string Related_Case_or_Lead { get; set; } = string.Empty;
            public string RelatedCaseId { get; set; } = "DEMO0407202602";
            public string renderingIdValue { get; set; } = "21066";
            public string RenderingPID { get; set; } = "RenderingProviderId";
            public string REV { get; set; } = string.Empty;
            public string Sample { get; set; } = "Sample";
            public string SamplingDate { get; set; } = string.Empty;
            public string SamplingMethodologyDescription { get; set; } = "Gainwell is creating sampling details for the claims";
            public string SeedDateforSample { get; set; } = string.Empty;
            public string Select_Search_Criteria { get; set; } = "Case/Lead ID";
            public string ServiceDateTo { get; set; } = string.Empty;
            public string ServiceDateToFrom { get; set; } = string.Empty;
            public string StartDate { get; set; } = "09/08/2022";
            public string Status { get; set; } = "Completed";
            public string StatusAsCompleted { get; set; } = "Completed";
            public string StatusAsFinalized { get; set; } = "Finalized";
            public string StatusAsRevisionNotStarted { get; set; } = "Revision Not Started";
            public string SubjectName { get; set; } = "Primary Subject Name";
            public string Total_Underpayment_Amount { get; set; } ="100";
            public string TotalAllowed { get; set; } = "1";
            public string TotalBilled { get; set; } = "1";
            public string TotalOverpaymentAmount { get; set; } = "100";
            public string TotalPaid { get; set; } = "1";
            public string TotalPayments { get; set; } = "Total Payments";
            public string TotalSoftSavingAmount { get; set; } = "100";
            public string UniqueDOCount { get; set; } = "1";
            public string UnitDescription { get; set; } = "samplingdetails";
        }
    }


