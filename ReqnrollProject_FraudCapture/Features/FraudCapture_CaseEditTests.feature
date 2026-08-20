Feature: FraudCapture_CreateNewCase

A short summary of the feature

Scenario: _01 Verify user is able to close lead by entering existing leadID and convert case by selecting case details
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the required option on the fraud capture home page
		| LeadsTab   |
		| <LeadsTab> |
	And I filter Assigned To Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And I search for leadID under Select Criteria dropdown
		| LeadTableSearchOptions   |
		| <LeadTableSearchOptions> |
	And I search for Lead ID
		| LeadID   |
		| <LeadID> |
	And I click on Lead search button
	And I click on the Lead ID Link
	And I verify the given Lead ID link is opened
		| LeadID   |
		| <LeadID> |
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And I store all lead summary dropdown values
	And I change the Lead Status dropdown
		| LeadStatus   |
		| <LeadStatus> |
	And I validate Status Change and Case Creation popup is displayed
	And I click on Close the Lead & Create a Case button
		| CloseLeadCreateCaseButton   |
		| <CloseLeadCreateCaseButton> |
	And I select a case Workflow Type on the create case popup
		| CaseWorkflowType   |
		| <CaseWorkflowType> |
	And I select the primary Case Reason on the create case popup
		| CaseReason   |
		| <CaseReason> |
	And I select Assign workflow To on the create case popup
		| AssignWorkflowTo   |
		| <AssignWorkflowTo> |
	And I select assign a Supervisor on the create case popup
		| AssignSupervisor    |
		| < AssignSupervisor> |
	And I select a Department or Division on the create case popup
		| Depart_OR_Div  |
		| <Depart_OR_Div |
	And I select a Section or Team on the create case popup
		| Section_OR_Team   |
		| <Section_OR_Team> |
	And I click create case button on the create case popup
	Then I validate the created case is linked to the same lead id entered
		| LeadID   |
		| <LeadID> |

Examples:
	| UserEmail                             | LeadsTab | AssignedToFilter | LeadTableSearchOptions | CaseWorkflowType                        | CaseReason     | AssignWorkflowTo | AssignSupervisor | Depart_OR_Div | Section_OR_Team | LeadID         | CaseID         | LeadStatus                 | CloseLeadCreateCaseButton      |
	| jayapradha.d@gainwelltechnologies.com | Leads    | All              | Lead ID                | (DO NOT MODIFY) Automated Lead Workflow | Billing Errors | D, Jayapradha    | D, Jayapradha    | SIU Group     | QA_Test         | DEMO0804202614 | DEMO0804202614 | Closed Lead - Case Created | Close the Lead & Create a Case |


Scenario: _02 Verify user is able to close lead by creating a new lead and convert case and validate created case details
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the required option on the fraud capture home page
		| LeadsTab   |
		| <LeadsTab> |
	And I click CreateNewLead button to go to Lead Creation Page
	And I enter initial user details in Lead Creation Tab:
		| WorkflowType   | DetectionMethod   | SourceType   | Reason   | AssignedTo   |
		| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
	And I Click the Next button in the first page of CreateNewLead Page
	And I enter Subject details in Primary Subject Tab for Search By Address:
		| SubjectType   | SubjectTypeSelect   | addressField   | city   |
		| <SubjectType> | <SubjectTypeSelect> | <addressField> | <city> |
	And I click Search button from the Search By Address screen
	And I giving the address to see the Case Details
	And I click on the Next button on the Primary Subject Page
	And I click Description tab in the Description Page
	And I enter Description details in Description tab:
		| Description   |
		| <Description> |
	And I click on the Next button on the Description Page
	And I enter Referring Party details in Referring Party tab:
		| ReferringParty   |
		| <ReferringParty> |
	And I click on the Next button on the Referring Party Page
	And I click Prioritization and click Create New Lead button in the Prioritization Page
	And Get the lead ID for the newly created lead
	Then the lead with captured ID should be displayed in the search results

	When I click on CaseTracking and select the required option on the fraud capture home page
		| LeadsTab   |
		| <LeadsTab> |
	And I filter Assigned To Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And I search for leadID under Select Criteria dropdown
		| LeadTableSearchOptions   |
		| <LeadTableSearchOptions> |
	And I search for Lead ID Created
	And I click on Lead search button
	And I click on the Lead ID Link
	And I verify the Lead ID link is opened
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And I store all lead summary dropdown values
	And I change the Lead Status dropdown
		| LeadStatus   |
		| <LeadStatus> |
	And I validate Status Change and Case Creation popup is displayed
	And I click on Close the Lead & Create a Case button
		| CloseLeadCreateCaseButton   |
		| <CloseLeadCreateCaseButton> |
	And I select a case Workflow Type on the create case popup
		| CaseWorkflowType   |
		| <CaseWorkflowType> |
	And I select the primary Case Reason on the create case popup
		| CaseReason   |
		| <CaseReason> |
	And I select Assign workflow To on the create case popup
		| AssignWorkflowTo   |
		| <AssignWorkflowTo> |
	And I select assign a Supervisor on the create case popup
		| AssignSupervisor    |
		| < AssignSupervisor> |
	And I select a Department or Division on the create case popup
		| Depart_OR_Div   |
		| <Depart_OR_Div> |
	And I select a Section or Team on the create case popup
		| Section_OR_Team   |
		| <Section_OR_Team> |
	Then I validate the created case is linked to the same lead id


Examples:
	| UserEmail                             | WorkflowType                            | DetectionMethod                                    | SourceType                                    | Reason                                        | AssignedTo           | SubjectType | SubjectTypeSelect | addressField       | city   | Description | ReferringParty                           |
	| jayapradha.d@gainwelltechnologies.com | (DO NOT MODIFY) Automated Lead Workflow | (DO NOT MODIFY) Automated Testing Detection Method | (DO NOT MODIFY) Automated Testing Lead Source | (DO NOT MODIFY) Automated Testing Lead Reason | Chandrasekar, Yamuna | Member      | Search by Address | 5615 High Point Dr | Irving | Test        | Manually add the Referring Party Details |


Scenario: _03 Edit case summary fields and save successfully and Validate the changes are reflected in the Case Summary Page
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab   |
		| <CasesTab> |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions   |
		| <CaseTableSearchOptions> |
	And I search for Case ID
		| CaseID   |
		| <CaseID> |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And I update case summary with alternate case id,case type, case status, assigned to, assigned supervisor, department_Or_division, section_Or_team, and lob
		| ALT_Case_ID   | CaseType   | CaseStatus   | AssignedCaseTo   | AssignedCaseSupervisor   | CaseDep_OR_Dev   | CaseSection_Or_Team   | lob   |
		| <ALT_Case_ID> | <CaseType> | <CaseStatus> | <AssignedCaseTo> | <AssignedCaseSupervisor> | <CaseDep_OR_Dev> | <CaseSection_OR_Team> | <lob> |
	Then I validate case summary changes are saved
	When I remove all the added values alternate case id,case type, case status, section_Or_team, and lob
		| ReassignALT_CaseID   | Reassign_CaseType   | ReassigncaseStatus   | Reassign_Section_OR_Team   | Uncheck_LOB   |
		| <ReassignALT_CaseID> | <Reassign_CaseType> | <ReassigncaseStatus> | <Reassign_Section_OR_Team> | <Uncheck_LOB> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | ALT_Case_ID        | CaseType | CaseStatus                       | AssignedCaseTo | AssignedCaseSupervisor | CaseDep_OR_Dev | CaseSection_OR_Team | lob  | ReassignALT_CaseID | ReassigncaseStatus                              | Reassign_CaseType                                | Reassign_Section_OR_Team     | Uncheck_LOB |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | ALT-DEMO0804202614 | Pharmacy | Open - Investigation in Progress | D, Jayapradha  | D, Jayapradha          | SIU Group      | QA_Test             | LOB1 | DEMO               | (DO NOT MODIFY) Automated Testing Inv Case Open | (DO NOT MODIFY) Automated Investigative Workflow | (Do Not Modify) Product Team | LOB1        |


Scenario: _04 Manually add a new subject to the case and validate the subject is added successfully
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab   |
		| <CasesTab> |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions   |
		| <CaseTableSearchOptions> |
	And I search for Case ID
		| CaseID   |
		| <CaseID> |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And navigate to Subjects Tab
	And Manually add Subject Type as "Provider", select option as "Manually add the Subject" and enter the subject details in the manually add subject page: org name as "TestOrg", subject id as "12345", first name as "John", last name as "Doe"
		
		Examples:
		
		| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | SubjectType   | SubjectTypeSelect   | FirstName   | LastName   | NPI   | AddressField   | City   |
		| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | <SubjectType> | <SubjectTypeSelect> | <FirstName> | <LastName> | <NPI> | <AddressField> | <City> |

Scenario Outline: _05 Validate the subject first and last name and delete it if the passed subject name is already present
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab   |
		| <CasesTab> |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions   |
		| <CaseTableSearchOptions> |
	And I search for Case ID
		| CaseID   |
		| <CaseID> |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And navigate to Subjects Tab
	Then I validate the subject "<FirstName>" "<LastName>" is present and delete it if already present
	When Manually add Subject Type as "Provider", select option as "Manually add the Subject" and enter the subject details in the manually add subject page: org name as "TestOrg", subject id as "12345", first name as "John", last name as "Doe"
	Then validate newly added subject "<FirstName>" "<LastName>" is present in the subject table
		

	Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | FirstName | LastName |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | John      | Doe      |
