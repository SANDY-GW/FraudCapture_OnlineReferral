Feature: LeadEditTests

A short summary of the feature

Scenario Outline: 03_Can_Add_Attachment_To_Lead_Activity
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
And I click Attachment to add the attachment on the fraud capture lead page
| filePath   |
| <filePath> |

Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   | filePath     |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 | TestFile.txt |


Scenario Outline: 04_Can_Add_Lead_Activity
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the "Leads" option on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page

Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 |
	

Scenario Outline: 06_Can_Add_Note_To_Lead_Activity 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
Then I Add the note on the fraud capture lead page and click on the Save button with Confirmation
| AddNotes |
| <AddNotes> |
	


Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   | AddNotes |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 | Test     |
	

Scenario Outline: 07_Can_Download_Attachment_Manager
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
And I click Attachment to view attachments on the fraud capture lead page
Then I click the Download Attachment Manager button
And the Download Attachment Manager popup should be displayed on the fraud capture lead page
When I click the "Download" button in the Download Attachment Manager popup
Then I should be able to close the Download Attachment Manager popup
And I close the Activity window on the fraud capture lead page

Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 |

Scenario Outline: 08_Can_Download_Attachment_Manager
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
And I click Attachment to view attachments on the fraud capture lead page
Then I click the Download Attachment Manager button
And the Download Attachment Manager popup should be displayed on the fraud capture lead page
When I click the "Download" button in the Download Attachment Manager popup
Then I should be able to close the Download Attachment Manager popup
And I close the Activity window on the fraud capture lead page

Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 |

Scenario Outline: 09_Can_View_Attachment_And_Click_Back
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
And I click Attachment to view attachments on the fraud capture lead page
When I click the "View" button to view the attachment document
Then I should be able to navigate to the attachment details page
When I click the "Back" button to return from the attachment details page
Then I should be navigated back to the attachment list view

Examples:	

	| UserEmail                         | leadid  | leadID         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 |




Scenario Outline: 10_Verify_Add_Activity_And_Attachment_Flow
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
When I click the Add Activity button on the fraud capture lead activity page
And I select Activity Name from the dropdown as "<activityName>"
And I click Continue button on the Add Activity popup
And I click Add button on the Add Activity popup
And I enter notes as "<notes>" and click Save button with confirmation Yes
And I click Attachment to view attachments on the fraud capture lead page
And I click Add Attachment button on the fraud capture lead page
And I upload attachment file on the fraud capture lead page
| filePath   |
| <filePath> |
When I click the "Back" button to return from the attachment details page
And I click the "View" button to view the attachment document
Then I should be able to navigate to the attachment details page

Examples:

	| UserEmail                         | leadid  | leadID         | selectleadId   | activityName                                                | notes | filePath     |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 | Test Lead Manual Activity- Lead Canceled Status Change Test | test  | TestFile.txt |

Scenario Outline: 11_Verify_Lead_Tab_Begin_Editing_And_Save_Description
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then I click Lead tab and click Begin Editing button on the fraud capture lead page
And I enter "<LeadDescription>" in Lead Description area on the fraud capture lead page
And I click Save button on the fraud capture lead page

Examples:

	| UserEmail                         | leadid  | leadID         | selectleadId   | LeadDescription |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 | Test Summary    |

Scenario Outline: 13_Verify_Begin_Editing_Update_Lead_Type_Assigned_To_And_Status
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Begin Editing button to Edit the Lead Details
And I select Lead Type as "<LeadType>" on the fraud capture lead page
And I select Assigned To as "<AssignedTo>" on the fraud capture lead page
And I select Lead Status as "<LeadStatus>" on the fraud capture lead page
And I select Department/Division as "<DepartmentDivision>" on the fraud capture lead page
And I select Section/Team as "<SectionTeam>" on the fraud capture lead page
And I click Save button on the fraud capture lead page and click Subjects tab

Examples:

	| UserEmail                         | leadid  | leadID         | selectleadId   | LeadType               | AssignedTo            | LeadStatus                                 | DepartmentDivision                            | SectionTeam |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 | 02242026-Lead Workflow | Chandrasekar, Yamuna | Test Lead Testing Status - Default on Open | (DO NOT MODIFY) Automated Testing Department | QA_Test     |




Scenario Outline: 15_Verify_Download_Attachment_Manager_Download_File_And_Close_Activity
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the Leads Tab on the fraud capture home page
When I select  the select criteria  as "Lead ID" on the fraud capture Lead table Page
Then I search the LeadID from Search Criteria on the fraud capture lead page
| leadID   |
| <leadID> |
And I click Search button to search the LeadID and navigate to the Lead Details page on the fraud capture
| selectleadId   |
| <selectleadId> |
Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
And i click Edit button to edit the activity on the Fraud Capture Page
And I click Attachment to view attachments on the fraud capture lead page
Then I click the Download Attachment Manager button
And the Download Attachment Manager popup should be displayed on the fraud capture lead page
When I click the "Download" button in the Download Attachment Manager popup
Then I should be able to close the Download Attachment Manager popup
And I close the Activity window on the fraud capture lead page

Examples:

	| UserEmail                         | leadid  | leadID         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0715202637 | DEMO0715202637 |


