Feature: FraudCapture_CreateNewCase

A short summary of the feature
Scenario Outline: Creating_NewCase_By_Closing the lead
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the "Cases" option on the fraud capture home page
#And I click CreateNewLead button to go to Lead Creation Page
#When I enter initial user details in Lead Creation Tab: 
#| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
#| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
#And I Click the Next button in the first page of CreateNewLead Page
#And I enter Subject details in Primary Subject Tab: 
#| SubjectType | SubjectTypeSelect | NamePrefix | FirstName | LastName |
#| <SubjectType> | <SubjectTypeSelect> | <NamePrefix> | <FirstName> | <LastName> |
#And I click on the Next button on the Primary Subject Page
#And I click Description tab in the Description Page
#And I enter Description details in Description tab:
#| Description |
#| <Description> |
#And I click on the Next button on the Description Page
#And I enter Referring Party details in Referring Party tab:
#| ReferringParty |
#| <ReferringParty> |
#And I click on the Next button on the Referring Party Page
#And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                             | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect        | NamePrefix | FirstName | LastName | Description | ReferringParty                           |
	| jayapradha.d@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Manually add the Subject | Mrs        | Yamuna    | C        | Test        | Manually add the Referring Party Details |

Scenario: Verify user is able to close lead and convert case by searching Lead ID
Given when I open the Fraud Capture application
When I enter the "jayapradha.d@gainwelltechnologies.com" on the welcome fraude capture page:
| UserEmail |
| jayapradha.d@gainwelltechnologies.com |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the "Leads" option on the fraud capture home page
And I filter Assigned To Dropdown with "All"
And I search for "Lead ID" under Select Criteria dropdown
And I search for Lead ID as "DEMO0728202605"
And I click on search button for lead search
And I click on the Lead ID Link "DEMO0728202605"
And I verify the Lead ID link "DEMO0728202605" is opened
And I click on the Begin Editing on the fraud capture Lead detials Page
And I store all lead summary dropdown values
And I change the Lead Status dropdown to "Closed Lead - Case Created"
And I validate Status Change and Case Creation popup is displayed
And I click on "Close the Lead & Create a Case" button




