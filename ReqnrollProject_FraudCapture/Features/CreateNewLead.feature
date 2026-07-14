Feature: FraudCapture_CreateNewLead

A short summary of the feature
Scenario Outline: 01_Creating_NewLead_With_SubjectType_As_Member_And_Adding_Manually
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType   | DetectionMethod   | SourceType   | Reason   | AssignedTo   |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab: 
| SubjectType   | SubjectTypeSelect   | NamePrefix   | FirstName   | LastName   | MiddleName   | suffix   | dateOfBirth   | gender   | other   | subjectId   | ssn   | medicaidNo   | medicareNo   | OtherId   | plan   | program   | Lob   | Group   | Address1   | Address2   | City   | State   | County   | ZipCode   | Phone   | SecondaryPhone   | Email   |
| <SubjectType> | <SubjectTypeSelect> | <NamePrefix> | <FirstName> | <LastName> | <MiddleName> | <suffix> | <dateOfBirth> | <gender> | <other> | <subjectId> | <ssn> | <medicaidNo> | <medicareNo> | <OtherId> | <plan> | <program> | <Lob> | <Group> | <Address1> | <Address2> | <City> | <State> | <County> | <ZipCode> | <Phone> | <SecondaryPhone> | <Email> |
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect        | NamePrefix | FirstName | LastName | MiddleName | suffix | dateOfBirth | gender | other | subjectId | ssn       | medicaidNo | medicareNo | OtherId | plan   | program | Lob   | Group  | Address1 | Address2 | City   | State | County                 | ZipCode | Phone      | SecondaryPhone | Email            | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Manually add the Subject | Mrs        | Smitha    | Vedha    | Singh      | Mrs.   | 02/03/1990  | Female |   123 |      3456 | 345678910 |      12345 |     567890 |    4567 | PLAN14 | Test    | Test1 | Group1 | Texas    | Cali     | Mandal | AK    | Aleutians East Borough |   34567 | 8906785432 |     7896542341 | smitha@gmail.com | Test        | Manually add the Referring Party Details |


Scenario Outline: 02_Creating_NewLead_With_SubjectType_As_Member_And_Adding_Through_SearchByID
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId   | 
| <SubjectType> | <SubjectTypeSelect> | <memberId> | 
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page

Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Manually add the Referring Party Details |



Scenario Outline: 03_Creating_NewLead_With_SubjectType_As_Member_And_Adding_Through_SearchByName
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Search By Name: 
| SubjectType   | SubjectTypeSelect   | firstName |lastName |
| <SubjectType> | <SubjectTypeSelect> | <firstName> | <lastName> |
And I click Search button from the Search By Name screen
And I giving the name to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page

Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | firstName | lastName | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by Name    | FN33480   | LN42933  | Test        | Manually add the Referring Party Details |


Scenario Outline: 04_Creating_NewLead_With_SubjectType_As_Member_And_Adding_Through_SearchByAddress
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Search By Address: 
| SubjectType   | SubjectTypeSelect   | addressField   | city |
| <SubjectType> | <SubjectTypeSelect> | <addressField> | <city> |
And I click Search button from the Search By Address screen
And I giving the address to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page

Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | addressField       | city   | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by Address | 5615 High Point Dr | Irving | Test        | Manually add the Referring Party Details |

#Member with Referring Party-SearchBy_MemberID
Scenario Outline: 05_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_MemberID 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By Member ID
| ReferringParty   | memberIdRefParty   |
| <ReferringParty> | <memberIdRefParty> |
And I click Search button in the Search By ID Window
And I Selecting the respective Member ID for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty      | memberIdRefParty |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Member ID |           123427 |

#Member with Referring Party-SearchBy_MemberName
Scenario Outline: 06_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_Member_Name
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By Member Name
| ReferringParty   | Firstname |
| <ReferringParty> | <Firstname> |
And I click Search button in the Search By Name Window
And I Selecting the respective Member Name for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty        | Firstname |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Member Name | FN33480   |

#Member with Referring Party-SearchBy_ProviderID
Scenario Outline: 07_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderID
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search by Provider ID:
| ReferringParty   | providerId |
| <ReferringParty> | <providerId> |
And I click Search button in the Search By Provider ID Window
And I Selecting the respective Provider ID for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty        | providerId |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Provider ID |      10006 |

#Member with Referring Party-SearchBy_ProviderName
Scenario Outline: 08_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderName
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search by Provider Name:
| ReferringParty   | providerName |
| <ReferringParty> | <providerName> |
And I click Search button in the Search By Provider Name Window
And I Selecting the respective Provider Name for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty          | providerName |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Provider Name | PR13163      |

#Member with Referring Party-SearchBy_ProviderNPI
Scenario Outline: 09_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderNPI
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By NPI:
| ReferringParty   | providerNPI |
| <ReferringParty> | <providerNPI> |
And I click Search button in the Search By Provider NPI Window
And I Selecting the respective Provider NPI for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty         | providerNPI |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Provider NPI |  9999004811 |

#Member with Referring Party-SearchBy_ProviderTIN_OR_EIN
Scenario Outline: 10_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderTIN_OR_EIN
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Member ID: 
| SubjectType   | SubjectTypeSelect   | memberId |
| <SubjectType> | <SubjectTypeSelect> | <memberId> |
And I click Search button from the Search By ID screen
And I Selecting the respective Member ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By TIN:
| ReferringParty   | providerTIN |
| <ReferringParty> | <providerTIN> |
And I click Search button in the Search By Provider TIN Window
And I Selecting the respective Provider TIN for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | SubjectType | SubjectTypeSelect | memberId | Description | ReferringParty             | providerTIN |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Member      | Search by ID      |   123427 | Test        | Search by Provider TIN/EIN |    66602459 |

#Provider-Adding Manually
Scenario Outline: 11_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Manually
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Manually add the Subject: 
| subjectTypeprovider   | subjectTypeselectprovider   | organization   | providerId   | providerfirstName   | providerlastName   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <organization> | <providerId> | <providerfirstName> | <providerlastName> |
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page

Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | organization | providerid | providerfirstName | providerlastName | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider             | Manually add the Subject  | asv          |     123427 | FN29303           | LN10061          | Test        | Manually add the Referring Party Details |


Scenario Outline: 12_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Through_SearchByID
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Manually add the Referring Party Details |


Scenario Outline: 13_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Through_TIN_OR_EIN 

Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By TIN: 
| subjectTypeprovider   | subjectTypeselectprovider   | tin   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <tin> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | tin      | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            |  Search by TIN/EIN              | 66602459 | Test        | Manually add the Referring Party Details |


Scenario Outline: 14_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Through_NPI 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By NPI: 
| subjectTypeprovider   | subjectTypeselectprovider   | npi   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <npi> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | npi      | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            |  Search by NPI              | 9999004811 | Test        | Manually add the Referring Party Details |


Scenario Outline: 15_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Through_Name 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By Name: 
		| subjectTypeprovider   | subjectTypeselectprovider   | providerorganization |
		| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerorganization> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerorganization | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by Name            | PR13163              | Test        | Manually add the Referring Party Details |


Scenario Outline: 16_Creating_NewLead_With_SubjectType_As_Provider_And_Adding_Through_Address 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By Address: 
		| subjectTypeprovider   | subjectTypeselectprovider   | provideraddressField   | providercity |
		| <subjectTypeprovider> | <subjectTypeselectprovider> | <provideraddressField> | <providercity> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab:
| ReferringParty |
| <ReferringParty> |
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | provideraddressField | providercity | Description | ReferringParty                           |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by Address            | 5615 High Point Dr   | Irving       | Test        | Manually add the Referring Party Details |

#Provider with Referring Party-SearchBy_MemberID
Scenario Outline: 17_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_MemberID 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By Member ID
| ReferringParty   | memberIdRefParty   |
| <ReferringParty> | <memberIdRefParty> |
And I click Search button in the Search By ID Window
And I Selecting the respective Member ID for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty      | memberIdRefParty |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Member ID |           123427 |

#Provider with Referring Party-SearchBy_MemberName
Scenario Outline: 18_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_Member_Name

Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By Member Name
| ReferringParty   | Firstname |
| <ReferringParty> | <Firstname> |
And I click Search button in the Search By Name Window
And I Selecting the respective Member Name for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty        | Firstname |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Member Name | FN33480   |

#Provider with Referring Party-SearchBy_ProviderID
Scenario Outline: 19_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderID
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search by Provider ID:
| ReferringParty   | providerId |
| <ReferringParty> | <providerId> |
And I click Search button in the Search By Provider ID Window
And I Selecting the respective Provider ID for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty        | providerId |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Provider ID |      10006 |

#Provider with Referring Party-SearchBy_ProviderName
Scenario Outline: 20_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderName
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search by Provider Name:
| ReferringParty   | providerName |
| <ReferringParty> | <providerName> |
And I click Search button in the Search By Provider Name Window
And I Selecting the respective Provider Name for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty          | providerName |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Provider Name | PR13163      |

#Provider with Referring Party-SearchBy_ProviderNPI
Scenario Outline: 21_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderNPI
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By NPI:
| ReferringParty   | providerNPI |
| <ReferringParty> | <providerNPI> |
And I click Search button in the Search By Provider NPI Window
And I Selecting the respective Provider NPI for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty         | providerNPI |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Provider NPI |    9999004811 |

#Provider with Referring Party-SearchBy_ProviderTIN_OR_EIN
Scenario Outline: 22_Creating_NewLead_With_adding_the_Referring_Party_Details_Through_SearchBy_ProviderTIN_OR_EIN
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
And I click CreateNewLead button to go to Lead Creation Page
When I enter initial user details in Lead Creation Tab: 
| WorkflowType | DetectionMethod | SourceType | Reason | AssignedTo |
| <WorkflowType> | <DetectionMethod> | <SourceType> | <Reason> | <AssignedTo> |
And I Click the Next button in the first page of CreateNewLead Page
And I enter Subject details in Primary Subject Tab for Provider-Search By ID: 
| subjectTypeprovider   | subjectTypeselectprovider   | providerId1   |
| <subjectTypeprovider> | <subjectTypeselectprovider> | <providerId1> |
And I click Search button from the Search By ID screen for Provider
And I Selecting the respective provider ID to see the Case Details
And I click on the Next button on the Primary Subject Page
And I click Description tab in the Description Page
And I enter Description details in Description tab:
| Description |
| <Description> |
And I click on the Next button on the Description Page
And I enter Referring Party details in Referring Party tab for Search By TIN:
| ReferringParty   | providerTIN |
| <ReferringParty> | <providerTIN> |
And I click Search button in the Search By Provider TIN Window
And I Selecting the respective Provider TIN for the Referring Party Screen
And I click on the Next button on the Referring Party Page
And I click Prioritization and click Create New Lead button in the Prioritization Page


Examples:	
	| UserEmail                         | WorkflowType  | DetectionMethod  | SourceType | Reason         | AssignedTo           | subjectTypeprovider | subjectTypeselectprovider | providerId1 | Description | ReferringParty             | providerTIN |
	| yamuna.c@gainwelltechnologies.com | 02192026 Test | Hotline Referral | Claims     | Billing Errors | Chandrasekar, Yamuna | Provider            | Search by ID              |       10006 | Test        | Search by Provider TIN/EIN |    66602459 |
