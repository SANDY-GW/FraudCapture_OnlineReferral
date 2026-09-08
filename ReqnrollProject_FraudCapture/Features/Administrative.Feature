Feature: Non-Investigative (Administrative) Case Management
  As a user of the FWA PI Portal
  I want to create, edit and manage Non-Investigative (Administrative) cases
  So that I can track findings, amounts, claims and related case information

Scenario: 1 Opening Administrative Case Form
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And the user clicks the Non-Investigative Case button
	Then the Create Administrative Case form should be displayed
	And the user cancels the Non-Investigative Case form

Scenario: 2 Creating Non-Investigative Case Audit
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And the user clicks the Non-Investigative Case button
	Then the Create Administrative Case form should be displayed
	When the user creates a Non-Investigative Case Audit with project name "SampleProject", case type "(DO NOT MODIFY) Automated Administrative Workflow" and assigned to "User1"
	And Get the Case ID for the newly created Case
	Then the case management alert message should be displayed
	When I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	Then the Case with captured ID should be displayed in the search results
	When I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	Then the user should be able to see the newly created Non-Investigative Case Audit in the Case List with the correct details
	

Scenario: 3 Locate and Open Newly Created Non-Investigative Case
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	Then the displayed Non-Investigative Case ID should match the retrieved Case ID
	
Scenario: 4 Begin Editing and Change Division/Department Value
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user enables edit on the Case tab and selects division or department value "SIU Group "
	Then the division or department dropdown value should be "SIU Group "
	When the user enables edit on the Case tab and selects division or department value "(DO NOT MODIFY) Automated Testing Department"

Scenario: 5 Verify Non-Inv Case Auto-Gen Activity
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Activities tab
	And the user edits and completes the auto generated activity with start date "01/01/2025", activity time "10:00 AM" and note "Test Note"
	Then the non-inv case auto gen activity should equal the expected value
	When the user selects the first activity
	And Delete the note added



Scenario: 6 Create and Verify Newly Created Finding Reason
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Findings tab
	And the user clicks the Add Finding button and creates the finding form with reason "Reason1", line of business "LOB1", underpayment "100", overpayment "50", soft saving "25", members "2", claims "3", lines "4", providers "1" and comments "Test Comment"
	Then verify new created finding
	Then Delete finding

Scenario: 7 Create and Verify Newly Created Amount Type
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Amounts tab
	And the user clicks the Add Amount button and creates a new amount type "AmountType1" with effective date "01/01/2025", amount "500", line of business "LOB1", date from "01/01/2025", date to "01/31/2025" and comment area "Comments"
	Then the newly created amount type should equal the expected value
	And Delete Amount details

Scenario: 8 Change Status of Newly Created Case to Closed
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user changes the case status to "Closed"
	Then the case status dropdown value should be "Closed"
	Then the user re-selects the case status to "Open"

Scenario: 9 Change Case Type to Investigative and Status to Cancelled/Closed
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user changes the case type to standard investigative type "Investigative" with assigned to "User1" and cancel status "Cancelled"
	Then the case type should equal "Investigative"
	Then the user re-selects the case type "Administrative" with assigned to "User1" and open status "Open"

Scenario: 10 View and Add Related Leads/Cases by Case/Lead ID
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user shows the Related Cases and Leads tab
	And the user searches related leads or cases by criteria "Case ID" and related case id "67890"
	And the user adds the related lead or case
	Then the related case id should be contained in the related leads or cases
	And the user removes the related lead or case

Scenario: 11 View and Add Related Leads/Cases by Primary Subject Name
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user shows the Related Cases and Leads tab
	And the user searches related subjects by name "Subject" with last name "Doe" and first name "John"
	And the user adds the related lead or case
	Then the related case id should be contained in the related leads or cases
	Then the user removes the related lead or case

Scenario: 12 Add Sampling Manually and Complete All Fields in Details and Metrics Tabs
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Claims button
	And the user clicks the Sampling button
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user adds sampling details for the Data tab with sampling date "01/01/2025", unit description "Unit", seed date "01/01/2025", obtained date "01/02/2025" and methodology description "Methodology"
	And the user adds sampling details for the Metrics tab Sample table one with paid from "01/01/2025", paid to "01/31/2025", DOS from "01/01/2025" and DOS to "01/31/2025"
	And the user adds sampling details for the Metrics tab Sample table two with unique DO count "1", provider count "2", patient count "3", claim count "4", claim line count "5", codes included "CPT1", total billed "100", total allowed "90" and total paid "80"
	And the user adds sampling details for the Metrics tab Universe table one with paid from "01/01/2025", paid to "01/31/2025", DOS from "01/01/2025" and DOS to "01/31/2025"
	And the user adds sampling details for the Metrics tab Universe table two with unique DO count "1", provider count "2", patient count "3", claim count "4", claim line count "5", codes included "CPT1", total billed "100", total allowed "90" and total paid "80"
	Then the sampling data from the data tab should match the metric tab data

Scenario: 13 View and Edit the Sample and Confirm Date is Saved Correctly
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Claims button
	And the user clicks the Sampling button
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user views and edits sample details with sample date "02/01/2025"
	Then the sampling data from the data tab should match the metric tab data

Scenario: 14 Sample Data Appears Correctly in Summary Sample and Universe Metrics Tool Table
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Claims button
	And the user clicks the Sampling button
	And I click on the Begin Editing on the fraud capture Case detials Page
	Then the sampling data from the data tab should match the metric tab data
	
Scenario: 15 Sorting on Summary Sample and Universe Metric Totals Grid Works
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Claims button
	And the user clicks the Sampling button
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user sorts the sample and universe matrix grid
	Then the sorted sample and universe matrix value should be contained in the expected sample

Scenario: 16 Delete One Sample
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And the user clicks the Claims button
	And the user clicks the Sampling button
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user removes an added sampling
	Then the delete sampling confirmation should be displayed
	And the user confirms the sample deletion

Scenario: 17 View, Add and Edit Manual Findings in the Findings Tab
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Findings tab
	And the user clicks the Add Finding button and creates the finding form with reason "Reason1", line of business "LOB1", underpayment "100", overpayment "50", soft saving "25", members "2", claims "3", lines "4", providers "1" and comments "Test Comment"
	And the user edits the finding details with members in population "5"
	Then the edited findings should contain the finding date "01/01/2025"

Scenario: 18 Findings Appear in Findings Details Table with Correct Rendering
		Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Findings tab
	Then the edited findings should contain the finding date "01/01/2025"

Scenario: 19 Sorting on Findings Grid Works
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Findings tab
	And the user sorts the findings grid
	Then the sorted findings grid should contain the finding date "01/01/2025"
	Then Delete finding

Scenario: 20 View, Add and Edit Amounts Using Different Amount Types
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Amounts tab
	And the user clicks the Add Amount button and creates a new amount type "AmountType1" with effective date "01/01/2025", amount "500", line of business "LOB1", date from "01/01/2025", date to "01/31/2025" and comment area "Comments"
	And the user edits the amount details with line of business "LOB2"
	Then the edited amount line of business should equal "LOB2"
	And the user validates the amount

Scenario: 21 Amounts Appear in Amounts Table and Total Payments/Outstanding Balance Grid
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Amounts tab
	And the user clicks the Add Amount button and creates a new amount type "AmountType1" with effective date "01/01/2025", amount "500", line of business "LOB1", date from "01/01/2025", date to "01/31/2025" and comment area "Comments"
	Then the amount data details should contain the expected amount type "AmountType1"
	And the total payments should equal the expected value
	And the outstanding balance should equal the expected value

Scenario: 22 Sorting on Amounts Grid Works
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Amounts tab
	And the user sorts the Amounts grid
	Then the sorted amounts grid should contain the expected amount "500"
	

Scenario: 23 View the Audit Log and Confirm Actions are Reflected
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Findings tab
	And the user clicks the Add Finding button and creates the finding form with reason "Reason1", line of business "LOB1", underpayment "100", overpayment "50", soft saving "25", members "2", claims "3", lines "4", providers "1" and comments "Test Comment"
	And the user clicks the Audit Log button
	And the user clicks the Audit Log date and time
	Then the audit log should be validated based on actions performed
	When the user clicks the Findings tab
	Then Delete finding

Scenario: 24 Delete One Amount and Confirm Balances are Still Correct
Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Amounts tab
	And the user gets the total amount and deletes one amount
	Then the confirmed balance should equal the total amount before deletion

Scenario: 25 Attach Claims to a Case via Select Claims from a List Using the Claim Selector
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| jayapradha.d@gainwelltechnologies.com |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| Cases    |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| All              |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| Case ID                |
	And I search for Non-Investigative Case ID
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user selects the Claim Selector and attaches claims using rendering PID "PID1", query value "Query1" and rendering id value "RID1"
	Then the claims added message should contain the expected message "Claims Added to Case"

Scenario: 26 Verify All Claims Successfully Upload to the Claims Tab
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the claims added count should contain the expected count "5"

Scenario: 27 Sorting on Case Claims Grid Works
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user sorts the Case Claims grid
	Then the sorted Case Claims grid should contain the expected claim id "123456"

Scenario: 28 Verify Data in the Case Claims Table Renders Correctly with the Column Headers
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the Line of Business column should contain the expected value "LOB1"
	And the Patient column should contain the expected value "Patient1"
	And the Provider column should contain the expected value "Provider1"
	And the Date Time Added column should contain the expected value "01/01/2025 12:00 PM"
	And the Status column should contain the expected value "Active"

Scenario: 29 Verify All Search Functionality Works for Each of the Options
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user searches by claim number "12345" and value "1"
	And the user searches by patient name "Patient Name", last name "Doe" and first name "John"
	And the user searches by patient id "Patient ID" and value "P12345"
	And the user searches by CPT or HCPC "CPT" and value "99213"
	And the user searches by date of service from "DOS From", start date "01/01/2025" and end date "01/31/2025"
	And the user searches by date of service to "DOS To", from "01/01/2025" and to "01/31/2025"

Scenario: 30 Download Patient Histories Report and Verify Data Populates Correctly
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user clicks the Patient Histories button
	And the user switches to the new window
	Then the downloaded report excel data should equal the expected value "123 "
	And the user closes the window handles

Scenario: 31 Perform a Claims Review Viewing and Editing Each Individual Claim/Claim Line
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the claim review should equal the expected value "123"
	When the user reviews claims and edits each individual claim line with modifier "M1" and revenue code "REV1"

Scenario: 32 Verify Zero Paid Lines Automatically Have Not Reviewed Finding and NR Reason
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the reason for zero paid claim lines should contain the expected value "NR"

Scenario: 33 View, Add and Edit Individual Claims with All Editable Fields
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user views, adds and edits individual claims with revenue "REV1", CPT "99213", modifier 2 "M2", units "1", finding "Pay", reason "Reason1" and comments "Comment1"
	Then the same finding applied to all lines should contain the expected value "Pay"

Scenario: 34 View, Add and Edit Individual Claim to Apply Same Finding to All Lines
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user views, adds and edits individual claims to apply same finding "Pay", reason "Reason1" and comments "Comment1" to all lines
	Then the same finding applied to all lines should contain the expected value "Pay"

Scenario: 35 Verify All Data Renders Correctly in the Individual Claim Summary
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the claim summary claim id should contain the expected value "12345"
	And the claim summary patient id should contain the expected value "67890"
	And the claim summary patient name should contain the expected value "John Doe"

Scenario: 36 View Individual Claim Activity and Verify Data Renders Correctly
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user begins editing the case
	And the user views the individual claim activity
	Then the user closes the window handles
	And the user clicks the Claim View Save button

Scenario: 37 Case Claims Detail is Downloadable and Data Populates
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the downloaded case claims detail should equal the expected value "123"
	And the user closes the window handles

Scenario: 38 Download Excel Export and Verify Data Renders Correctly with Column Headers
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the downloaded excel sheet data should equal the expected value "123"
	And the user closes the window handles

Scenario: 39 Verify the Number of Records in the Claims Tab Matches the Export
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the downloaded excel sheet row count should equal the expected value "123"
	And the user closes the window handles

Scenario: 40 Verify All Pay/Deny/Not Reviewed Findings are Correctly Adjusted and Calculated
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user sets the Pay findings dropdown with Finding "Pay", reason "Reason1" and comments "Comment1"
	Then the pay findings dropdown should contain "Pay"
	When the user sets the Pay findings dropdown with Finding "Deny", reason "Reason1" and comments "Comment1"
	Then the deny findings dropdown should contain "Deny"

Scenario: 41 Verify All Not Reviewed Findings are Correctly Adjusted and Calculated
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user sets the Not Reviewed findings dropdown with reason for zero paid claims "NR", reason "Reason1" and comments "Comment1"
	Then the not reviewed findings dropdown should contain "NR"
	When the user sets the No Value findings dropdown with finding "NoValue", reason "Reason1" and comments "Comment1"
	Then the no value findings dropdown should contain "NoValue"

Scenario: 42 Verify the Claim Status Shows All Claims as Completed
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the claim status should contain "Completed"

Scenario: 43 Finalize Findings and Confirm Each Claim Status Reflects Finalized
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user finalizes the findings
	Then the finalize findings status should equal "Finalized"

Scenario: 44 After Finalize Findings Select Initiate Revisions and Verify Status Revision Not Started
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user selects Initiate Revisions
	Then the initiate revisions status should equal "Revision Not Started"

Scenario: 45 View the Claim and Verify the Original Finding Still Displays
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the original finding for the claim should equal the expected value

Scenario: 46 Select the Plus Sign for Revisions and Enter a New Revision Finding
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user selects the plus sign for revisions and enters a new revision finding "Pay"
	Then the finding should equal "Pay"

Scenario: 47 Perform a Revision Claims Review, Viewing and Editing Each Individual Claim Line
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user selects the plus sign for revisions and enters a new revision finding "Pay"
	Then the finding should equal "Pay"

Scenario: 48 Revision Findings Should Include Finding, Reason, Reason 2, Comments, Units, Modifiers, Diagnosis, CPT and Other Fields
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user views, adds and edits individual revision claims with revenue "REV1", CPT "99213"", modifier 2 "M2", units "1", finding "Pay", reason "Reason1" and comments "Comment1"
	Then the finding should equal "Pay"

Scenario: 49 Deleting the Added Claims
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user cancels the added revision
	And the user undoes finalize
	Then the added claims should be deleted

Scenario: 50 Attach Claims to a Case via Generate a Convenient Sample Using the Claim Selector
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
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	And the user selects the Claim Selector and attaches claims via Generate a Convenient Sample using rendering PID "PID1", query value "Query1" and investigative reference id value "IREF1"
	Then the claims added message should contain the expected message "Claims Added to Case"
	When I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab   |
		| <CasesTab> |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter   |
		| <AssignedToFilter> |
	And the user locates and opens the newly created Non-Investigative Case with case type "Administrative" and case id "12345"
	And the user clicks on the latest Case ID
	And the user begins editing the case
	And the user clicks the Claims button
	And the user clicks the Case Claim tab
	Then the added claims should be deleted
