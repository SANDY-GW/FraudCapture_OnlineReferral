Feature: Lead Edit workflow validation
  As a case tracking user
  I want to manage leads in Lead Edit
  So that lead lifecycle, activities, reasons, subjects, referrals, attachments, reports, and status automation are validated

  Background:
    Given when I open the Fraud Capture application
    When I enter the following credential to login to the fraud capture main page
      | Field     | Value                             |
      | UserEmail | yamuna.c@gainwelltechnologies.com |
    And i click on the Procced to login button on the welcome fraude capture page
    And i click on the I Agree button on the fraud capture Page
    And i click on CaseTracking and select the Leads Tab on the fraud capture home page

  Scenario Outline: 01_Can_Create_New_Lead
    When I click the Create New Lead button
    And I enter the following lead details:
      | Field                      | Value                  |
      | Workflow Type              | <SearchKeyword>        |
      | Detection Method           | <DetectionMethod>      |
      | Source Type                | <SourceType>           |
      | Reason                     | <Reason>               |
      | Suspect Activity From Date | <ActivityFromDate>     |
      | Suspect Activity To Date   | <ActivityToDate>       |
      | Assigned Section/Teams     | <SectionTeams>         |
      | Potential Overpayment      | <OverpaymentAmount>    |
    And I Click the Next button in the first page of CreateNewLead Page
    And I add a subject with the following details:
      | Subject Type       | <SubjectType>   |
      | Search Criteria    | <SearchCriteria> |
      | Subject ID         | <SubjectId>      |
    And I enter lead description "<LeadDescription>"
    And I add anonymous referring party details
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    And the Lead Type should be "<SearchKeyword>"
    And the Assigned To should be "<AssignedTo>"
    And the Suspect Activity From date should be "<ActivityFromDate>"
    And the Suspect Activity To date should be "<ActivityToDate>"
    And the Potential Overpayment Amount should be "<OverpaymentAmount>"
    
    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId  | LeadDescription       | AssignedTo    |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Claims     | Billing Errors | 01/01/2024       | 12/31/2024     | QA_Test      |          10000.00 | Provider    | Search by NPI  | 9999004811 | Test Lead Description | Jha, Narottam |

 Scenario Outline: 02_Can_Navigate_To_Lead_Case_Edit_View
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page

    Examples:
      | UserEmail                         | User | LeadId         |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 |

  
Scenario Outline: 03_Can_Edit_Lead_Activity
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    Then i click Activity Tab and click Begin Editing on the Fraud Capture Page
    And i click Edit button to edit the activity on the Fraud Capture Page

Examples:	

	| UserEmail                         | LeadId         | selectleadId   |
	| yamuna.c@gainwelltechnologies.com | DEMO0715202637 | DEMO0715202637 |

  Scenario Outline: 04 Reassign lead activity
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I open Activities tab
    And I open the auto-generated lead activity "<ActivityName>"
    And I reassign activity to "<AssignedToUser>"
    Then activity assigned-to value is updated
    Examples:
      | LeadUser | LeadId         | ActivityName              | AssignedToUser |
      | All      | DEMO0715202637 | LeadActivityAutoGen_Title | FC QA TEST     |

  Scenario Outline: 05 Edit lead summary fields
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I update alternate lead id "<AlternateLeadId>" assignment and summary fields
    And I save lead changes
    Then lead summary updates are persisted
    Examples:
      | LeadUser | LeadId         | AlternateLeadId |
      | All      | DEMO0715202637 | ALT-2026-001    |

  Scenario Outline: 06 Edit existing lead reason
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I open Reasons tab
    And I edit the first lead reason description to "<ReasonDescription>"
    Then edited lead reason is saved
    Examples:
      | LeadUser | LeadId         | ReasonDescription        |
      | All      | DEMO0715202637 | Updated reason narrative |

  Scenario Outline: 07 Manually add lead subject
   When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I open Subjects tab
    And I add a subject manually with id "<SubjectId>" first name "<FirstName>" and last name "<LastName>"
    Then the new subject appears in the Subjects grid
    Examples:
      | LeadUser | LeadId         | SubjectId | FirstName | LastName |
      | All      | DEMO0715202637 | SUB9001   | John      | Carter   |

  Scenario Outline: 08 Search and add lead subject
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I open Subjects tab
    And I search for a subject by first name "<FirstName>" and last name "<LastName>" and add it
    Then the selected subject appears in the Subjects grid
    Examples:
      | LeadUser | LeadId         | FirstName | LastName |
      | All      | DEMO0715202637 | Peter     | Hudson   |

  Scenario Outline: 09 View lead in SIU activity widget on subject profile
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I navigate from lead subject to Subject Profile
    Then SIU activity widget displays the lead
    Examples:
      | LeadUser | LeadId         |
      | All      | DEMO0715202637 |

  Scenario Outline: 10 Edit lead referral
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I open Lead Referral tab
    And I update referral organization to "<OrganizationName>"
    And I save referral changes
    Then referral updates are persisted
    Examples:
      | LeadUser | LeadId         | OrganizationName |
      | All      | DEMO0715202637 | Acme Health Inc  |

  Scenario Outline: 11 Edit lead priority
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I open Lead Priority tab
    And I update priority responses using "<PrioritySet>"
    And I save priority updates
    Then lead priority updates are persisted
    Examples:
      | LeadUser | LeadId         | PrioritySet |
      | All      | DEMO0715202637 | Priority_A  |

  Scenario Outline: 12 Add related lead
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I open Related Cases and Leads tab
    And I search related records by lead id "<RelatedLeadId>"
    And I relate the selected lead
    Then related lead is added successfully
    Examples:
      | LeadUser | LeadId         | RelatedLeadId |
      | All      | DEMO0715202637 | DEMO0715202638 |

  Scenario Outline: 13 Audit log populates for lead
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I open Audit Log tab
    Then audit log table is displayed
    Examples:
      | LeadUser | LeadId         |
      | All      | DEMO0715202637 |

  Scenario Outline: 14 Add new lead activity
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I open Activities tab
    And I create a new activity "<ActivityName>" with assigned user "<AssignedToUser>"
    Then the new activity appears in the activities grid
    Examples:
      | LeadUser | LeadId         | ActivityName | AssignedToUser |
      | All      | DEMO0715202637 | Follow Up    | FC QA TEST     |

  Scenario Outline: 15 Sort lead activities grid
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I open Activities tab
    And I sort the activities grid by "<SortColumn>"
    Then activity rows are sorted correctly
    Examples:
      | LeadUser | LeadId         | SortColumn   |
      | All      | DEMO0715202637 | Created Date |

  Scenario Outline: 16 Add note to lead activity
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    When I add a new activity note "<NoteText>"
    Then the note is visible in activity notes
    Examples:
      | LeadUser | LeadId   | NoteText                    |
      | User_2   | LEAD1001 | Automation note validation. |

  Scenario Outline: 17 View all notes export
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    When I export all notes
    Then notes export file "<ExportFileName>" is downloaded
    Examples:
      | LeadUser | LeadId   | ExportFileName |
      | User_2   | LEAD1001 | AllNotes.csv   |

  Scenario Outline: 18 Add attachment to lead activity
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    When I add a new attachment "<AttachmentTitle>"
    Then the attachment appears in activity attachments
    Examples:
      | LeadUser | LeadId   | AttachmentTitle |
      | User_2   | LEAD1001 | TestFile.txt    |

  Scenario Outline: 19 Download from activity-level attachment manager
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    When I download all attachments from activity-level manager
    Then a completed download record appears in attachment manager for "<ActivityName>"
    Examples:
      | LeadUser | LeadId   | ActivityName |
      | User_2   | LEAD1001 | Follow Up    |

  Scenario Outline: 20 Lead activity auto-generates
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I open Activities tab
    Then expected auto-generated lead activity "<ActivityName>" is present
    Examples:
      | LeadUser | LeadId   | ActivityName              |
      | User_1   | LEAD1001 | LeadActivityAutoGen_Title |

  Scenario Outline: 21 Download from lead-level attachment manager
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I open Activities tab
    And I download all attachments from lead-level manager
    Then a completed download record appears in attachment manager for "<ActivityName>"
    Examples:
      | LeadUser | LeadId   | ActivityName |
      | User_2   | LEAD1001 | Follow Up    |

  Scenario Outline: 22 Search attachments and notes
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I open Activities tab
    And I search attachments and notes by keyword "<SearchKeyword>"
    Then matching note results are displayed
    Examples:
      | LeadUser | LeadId   | SearchKeyword |
      | User_2   | LEAD1001 | Test          |

  Scenario Outline: 23 Run lead summary report
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I run Lead Summary Report
    Then report content matches expected lead summary data "<ExpectedReportText>"
    Examples:
      | LeadUser | LeadId   | ExpectedReportText |
      | User_2   | LEAD1001 | Lead Summary Report |

  Scenario Outline: 24 Lead workflow auto-assignment creates case
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I set lead workflow values and create case with workflow "<CaseWorkflowType>"
    Then case is created and routed by workflow auto-assignment
    Examples:
      | LeadUser | LeadId   | CaseWorkflowType |
      | User_2   | LEAD1001 | Investigative    |

  Scenario Outline: 25 Lead activity auto-completes lead status to closed-no-findings
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    When I complete activity according to auto-complete rules
    Then lead status is updated to "<ExpectedStatus>"
    Examples:
      | LeadUser | LeadId   | ExpectedStatus       |
      | User_2   | LEAD1001 | Closed - No Findings |

  Scenario Outline: 26 Lead activity completion overrides lead status to canceled
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    When I complete activity according to cancel override rules
    Then lead status is updated to "<ExpectedStatus>"
    Examples:
      | LeadUser | LeadId   | ExpectedStatus |
      | User_2   | LEAD1001 | Canceled       |

  Scenario Outline: 27 Verify activity name field is locked
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    Then activity name field is read-only
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 28 Verify activity due date field is locked
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    And I open the first activity
    Then due date field is read-only
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 29 Verify alternate lead id behavior
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I update alternate lead id to "<AlternateLeadId>"
    Then alternate lead id update follows expected behavior
    Examples:
      | LeadUser | LeadId   | AlternateLeadId |
      | User_2   | LEAD1001 | ALT-2026-009    |

  Scenario Outline: 30 Verify assign lead to field lock behavior before lead type selection
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    Then Assign Lead To field remains locked until lead type is selected
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 31 Verify duplicate leads are not created
    Given I switch leads user to "<LeadUser>"
    When I attempt to create a lead using duplicate data set "<DuplicateDataSet>"
    Then system prevents duplicate lead creation
    Examples:
      | LeadUser | DuplicateDataSet |
      | User_1   | DUP_SET_01       |

  Scenario Outline: 32 Verify fields are not editable before Begin Editing
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in view mode using "<LeadId>"
    Then summary fields are non-editable until Begin Editing is initiated
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 33 Verify organization name is displayed under Subjects tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I add a provider subject with organization name "<OrganizationName>"
    Then organization name is displayed in Subjects tab
    Examples:
      | LeadUser | LeadId   | OrganizationName |
      | User_2   | LEAD1001 | Apex Provider    |

  Scenario Outline: 34 Verify organization plus FN/MN/LN displayed under Subjects tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I add a provider subject with organization "<OrganizationName>" and names "<FirstName>" "<MiddleName>" "<LastName>"
    Then organization and full name are displayed in Subjects tab
    Examples:
      | LeadUser | LeadId   | OrganizationName | FirstName | MiddleName | LastName |
      | User_2   | LEAD1001 | Apex Provider    | Maria     | K          | Lewis    |

  Scenario Outline: 35 Verify FN/MN/LN displayed under Subjects tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I add a provider subject with names "<FirstName>" "<MiddleName>" "<LastName>"
    Then full name is displayed in Subjects tab
    Examples:
      | LeadUser | LeadId   | FirstName | MiddleName | LastName |
      | User_2   | LEAD1001 | David     | A          | Clark    |

  Scenario Outline: 36 Capture audit log changes for Lead Summary tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I perform changes on Lead Summary tab
    And I open Audit Log details
    Then audit log contains "<AuditKeyword>" change entries
    Examples:
      | LeadUser | LeadId   | AuditKeyword |
      | User_2   | LEAD1001 | Lead Summary |

  Scenario Outline: 37 Capture audit log changes for Activity tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    When I perform activity updates
    And I open Audit Log details
    Then audit log contains "<AuditKeyword>" change entries
    Examples:
      | LeadUser | LeadId   | AuditKeyword |
      | User_2   | LEAD1001 | Activity     |

  Scenario Outline: 38 Only view searched attachments and notes
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    When I search attachments and notes with keyword "<SearchKeyword>"
    Then only matching attachments or notes are shown
    Examples:
      | LeadUser | LeadId   | SearchKeyword |
      | User_2   | LEAD1001 | Test          |

  Scenario Outline: 39 Verify tooltip appears under Has Note/Attachment column
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead using "<LeadId>"
    And I open Activities tab
    When I hover over Has Note/Attachment column
    Then tooltip text is displayed
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 40 Add lead reason from Reasons tab
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    When I open Reasons tab
    And I add a new lead reason using "<DetectionMethod>" "<SourceType>" and "<ReasonType>"
    Then new lead reason is available in lead reasons list
    Examples:
      | LeadUser | LeadId   | DetectionMethod | SourceType     | ReasonType      |
      | User_2   | LEAD1001 | Claims Data     | Internal Audit | Billing Pattern |

  Scenario Outline: 41 Save button enabled when mandatory lead reason fields are filled
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    And I open Reasons tab
    When I enter all mandatory fields for lead reason
    Then Save button for lead reason is enabled
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |

  Scenario Outline: 42 Save button disabled when mandatory lead reason fields are missing
    Given I switch leads user to "<LeadUser>"
    And I open an existing lead in edit mode using "<LeadId>"
    And I open Reasons tab
    When I leave one or more mandatory lead reason fields empty
    Then Save button for lead reason is disabled
    Examples:
      | LeadUser | LeadId   |
      | User_2   | LEAD1001 |