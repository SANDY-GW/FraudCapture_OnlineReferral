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

	| UserEmail                         | leadid  | leadID         | selectleadId   | activityName                 | filepath     |
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0103201902 | DEMO0103201902 | Background Review of Subject | TestFile.txt |


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
	| yamuna.c@gainwelltechnologies.com | Lead ID | DEMO0103201902 | DEMO0103201902 | Test     |
	
