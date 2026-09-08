Feature: Case Edit Functionality
  As a user of the FWA PI Portal
  I want to be able to edit cases and manage case activities
  So that I can track and update case information effectively

 # Background:
 # Given when I open the Fraud Capture application
	#When I enter the UserEmail on the welcome fraude capture page:
	#	| UserEmail   |
	#	| <UserEmail> |
	#And I click on the Procced to login button on the welcome fraude capture page
	#And I click on the I Agree button on the fraud capture Page
 #   Given the user navigates to the Case Tracking page
 #   And the user shows cases
 #   And the user switches to user "<User>"

Scenario Outline: 1. Add Case Activity
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
	And the user shows activities
	And the user adds activity with title and assigned to
		| InvestigativeCaseActivityManual_Title   | AssignedTo   |
		| <InvestigativeCaseActivityManual_Title> | <AssignedTo> |
	And the user sorts activities by created date column
	Then the new activity should appear in the activities list
		| InvestigativeCaseActivityManual_Title   |
		| <InvestigativeCaseActivityManual_Title> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | InvestigativeCaseActivityManual_Title                      | AssignedTo    |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | (DO NOT MODIFY) Automated Testing Inv Case Activity Manual | Jha, Narottam |


Scenario Outline: 2. Add Attachment To Lead Activity
	Given when I open the Fraud Capture application
	#When I enter the UserEmail on the welcome fraude capture page:
	#	| UserEmail   |
	#	| <UserEmail> |
	#And I click on the Procced to login button on the welcome fraude capture page
	#And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user shows activities
	And the user selects the first activity
	And the user adds a new attachment
	Then the new attachment should appear in the list
		| AttachmentTitle   |
		| <AttachmentTitle> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | AttachmentTitle |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | TestFile.txt    |


Scenario Outline: 3. Add Note To Case Activity
	Given when I open the Fraud Capture application
	#When I enter the UserEmail on the welcome fraude capture page:
	#	| UserEmail   |
	#	| <UserEmail> |
	#And I click on the Procced to login button on the welcome fraude capture page
	#And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user shows activities
	And the user selects the first activity
	And the user adds a new note with text
		| CaseActivityManual_Title    |
		| <CaseActivityManual_Title > |
	Then the activity note should match
		| CaseActivityManual_Title    |
		| <CaseActivityManual_Title > |
Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | CaseActivityManual_Title    |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | Note added to Case Activity |

Scenario Outline: 4. Download From Activity Level Download Attachment Manager
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
	And the user shows activities
	And the user selects the first activity
	And the user adds a new attachment
	And the user downloads from activity level download attachment manager
	Then the new download should appear in download attachment manager
		| InvestigativeCaseActivityManual_Title    |
		| <InvestigativeCaseActivityManual_Title > |
	And the user closes the activity

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | InvestigativeCaseActivityManual_Title                      |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0108202513 | (DO NOT MODIFY) Automated Testing Inv Case Activity Manual |

Scenario Outline: 5. Download From Case Level Download Attachment Manager
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
	And the user shows activities
	And the user selects the first activity
	And the user adds a new attachment
	And the user closes the activity
	And the user downloads from case level download attachment manager
	Then the new case download should appear in download attachment manager
		| ActivityName_2   |
		| <ActivityName_2> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | ActivityName_2 |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0108202513 | All            |

Scenario Outline: 6. Verify Case Claims Clear Button Works
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user clicks claims button
	And the user clicks case claim tab
	And the user searches by case claim number with value
		| ClaimDropdownValue   | claimvalue1   |
		| <ClaimDropdownValue> | <claimvalue1> |
	Then the case claim search button should be enabled

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | ClaimDropdownValue | claimvalue1  |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0720202611 | Claim Number(s)    | 201400238639 |

Scenario Outline: 7. Verify Tooltip Appears Under Has Note Or Attachment Column
	#Given when I open the Fraud Capture application
	#When I enter the UserEmail on the welcome fraude capture page:
	#	| UserEmail   |
	#	| <UserEmail> |
	#And I click on the Procced to login button on the welcome fraude capture page
	#And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user shows activities
	And the user selects the first activity
	And the user adds a new attachment
	And the user adds a new note with text
		| CaseActivityManual_Title   |
		| <CaseActivityManual_Title> |
	And the user closes the activity
	And the user hovers over attachment and notes column
	Then the attachment and notes column text should match
	When the user selects the first activity
	And the user deletes the note
	And the user closes the activity

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | CaseActivityManual_Title    |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0108202513 | Note added to Case Activity |
 
Scenario Outline: 8. Verify Findings Total Over Payments And Total Underpayments Displays Percentages Correctly
	#Given when I open the Fraud Capture application
	#When I enter the UserEmail on the welcome fraude capture page:
	#	| UserEmail   |
	#	| <UserEmail> |
	#And I click on the Procced to login button on the welcome fraude capture page
	#And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user begins editing case
	And the user clicks findings tab
	And the user adds findings with the following details:
		| Field              | Value                |
		| FindingSubject     | <FindingSubject>     |
		| FindingReason      | <FindingReason>      |
		| LineOfBusiness     | <LineOfBusiness>     |
		| UnderpaymentAmount | <UnderpaymentAmount> |
		| OverpaymentAmount  | <OverpaymentAmount>  |
		| SoftSavingAmount   | <SoftSavingAmount>   |
		| MembersCount       | <MembersCount>       |
		| ClaimsCount        | <ClaimsCount>        |
		| LinesCount         | <LinesCount>         |
		| ProvidersCount     | <ProvidersCount>     |
		| Comments           | <Comments>           |
	Then the total underpayment value should be displayed correctly
	And the total overpayment value should be displayed correctly
	And the user deletes the findings

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | FindingSubject        | FindingReason                                              | LineOfBusiness | UnderpaymentAmount | OverpaymentAmount | SoftSavingAmount | MembersCount | ClaimsCount | LinesCount | ProvidersCount | Comments      |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0804202614 | Gainwell - FN Mali LN | (DO NOT MODIFY) - Automated Testing Finding Reason Testing | LOB1           |                900 |               700 |              600 |            2 |           4 |          7 |              4 | Test Comments |

Scenario Outline: 9. Verify Claim Line Preview Functionality Works
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
	And I search for Case ID
		| CaseID         |
		| DEMO0804202614 |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user begins editing case
	And the user clicks claims button
	And the user clicks case claim tab
	And the user clicks on claim selector button
	And the user selects claims
	And the user clicks case claim link
	Then the claim line preview popup should be displayed

Examples:
	| User   | CaseID |
	| User_1 | Case_2 |

Scenario Outline: 10. Verify Claim Line Preview Popup Column Names Are Not Repeated
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
	And I search for Case ID
		| CaseID         |
		| DEMO0804202614 |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user begins editing case
	And the user clicks claims button
	And the user clicks case claim tab
	And the user clicks on claim selector button
	And the user selects claims
	And the user clicks case claim link
	Then the case claim review popup column names should not be repeated

Examples:
	| User   | CaseID |
	| User_1 | Case_2 |

Scenario Outline: 11. Download Claims Detail And Validate Data
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail   |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
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
	And the user clicks claims button
	And the user clicks case claim tab
	And the user downloads case claims detail
	Then the downloaded claim summary should match
		| ClaimSummaryClaimIDforInvestigativecase   |
		| <ClaimSummaryClaimIDforInvestigativecase> |
	And the user closes window handles

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | ClaimSummaryClaimIDforInvestigativecase |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0720202611 |                            201400238639 |

Scenario Outline: 12. Can Run Patient Histories Report
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
	And the user clicks claims button
	And the user clicks case claim tab
	And the user runs patient histories report with expected data
	Then the patient histories report should run successfully
		| PatientHistoriesReport_ExpectedData   |
		| <PatientHistoriesReport_ExpectedData> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | PatientHistoriesReport_ExpectedData |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0720202611 |                               49279 |

Scenario Outline: 13. Download Excel Report And Verify Data Renders Properly
	Given when I open the Fraud Capture application
	When I enter the UserEmail on the welcome fraude capture page:
		| UserEmail                             |
		| <UserEmail> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	When I click on CaseTracking and select the Case option on the fraud capture home page
		| CasesTab |
		| <CasesTab> |
	And I filter Assigned To Case Dropdown
		| AssignedToFilter |
		| <AssignedToFilter> |
	And I search for caseID under Select Criteria dropdown
		| CaseTableSearchOptions |
		| <CaseTableSearchOptions> |
	And I search for Case ID
		| CaseID   |
		| <CaseID> |
	And I click on Case search button
	And I click on the Case ID Link
	And I click on the Begin Editing on the fraud capture Case detials Page
	And the user clicks claims button
	And the user clicks case claim tab
	And the user downloads patient histories excel report with expected data
	Then the excel report should be downloaded and data should render properly
		| PatientHistoriesReport_ExpectedData   |
		| <PatientHistoriesReport_ExpectedData> |

Examples:
	| UserEmail                             | CasesTab | AssignedToFilter | CaseTableSearchOptions | CaseID         | PatientHistoriesReport_ExpectedData |
	| jayapradha.d@gainwelltechnologies.com | Cases    | All              | Case ID                | DEMO0720202611 |                               49279 |
