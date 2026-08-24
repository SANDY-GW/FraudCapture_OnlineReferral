Feature: Create New Lead
  As a fraud investigator
  I want to create and manage leads in the FWA PI Portal
  So that I can track potential fraud cases

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

  Scenario Outline: 02_Can_Create_New_Lead
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
      | UserEmail                         | SearchKeyword                 | DetectionMethod  | SourceType | Reason          | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription          | AssignedTo |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Member     | Billing Errors | 02/01/2024       | 11/30/2024     | QA_Test      | 5000.00           | Member      | Search by ID   | 123427    | Hotline Lead Description | Jha, Narottam   |

  Scenario Outline: 03_Can_Navigate_To_Lead_Case_Edit_View
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page

    Examples:
      | UserEmail                         | User | LeadId         |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 |

  Scenario Outline: 04_Can_Navigate_To_Lead_Case_Edit_View_TC04
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page

    Examples:
      | UserEmail                         | User | LeadId         |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 |

  Scenario Outline: 05_Can_Navigate_To_Lead_Case_Edit_View
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page

    Examples:
      | UserEmail                         | User | LeadId         |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 |

  Scenario Outline: 06_Can_Edit_Lead_Summary
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    Then I should be navigated to the Lead Edit page
    When I click Begin Editing on the Lead Edit page
    And I set the following lead details:
      | Field                       | Value                |
      | Alternate Lead ID           | <AlternateLeadId>    |
      | Assigned To                 | <AssignedToUser>     |
      | Assigned Supervisor         | <AssignedSupervisor> |
      | Division/Department         | <DivisionDepartment> |
      | Potential Overpayment       | <OverpaymentAmount>  |
      | Lead Description            | <LeadDescription>    |
      | Lead Findings               | <LeadFindings>       |
    And I select LOB checkbox
    And I click Save on the Lead Edit page
    Then the lead should be saved successfully
    And the Alternate Lead ID should be "<AlternateLeadId>"
    And the Assigned To should be "<AssignedToUser>"
    And the Assigned Supervisor should be "<AssignedSupervisor>"
    And the Division/Department should be "<DivisionDepartment>"
    And the LOB should be selected
    And the Potential Overpayment Amount should be "<OverpaymentAmount>"

    Examples:
      | UserEmail                         | User | LeadId         | AlternateLeadId | AssignedToUser | AssignedSupervisor | DivisionDepartment             | OverpaymentAmount | LeadDescription          | LeadFindings                     |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 | DEMO0715202637  | Jha, Narottam  | Test 527080        | Bureau of Financial Operations |          15000.00 | Updated Lead Description | Potential billing irregularities |

  Scenario Outline: 07_Can_Edit_Lead_Summary
    When I switch to leads user "<User>"
    And I search by Lead ID
    And I search for lead "<LeadId>"
    And I select the lead
    When I click Begin Editing on the Lead Edit page
    And I set the following lead details:
      | Field                       | Value                |
      | Alternate Lead ID           | <AlternateLeadId>    |
      | Assigned To                 | <AssignedToUser>     |
      | Assigned Supervisor         | <AssignedSupervisor> |
      | Division/Department         | <DivisionDepartment> |
      | Potential Overpayment       | <OverpaymentAmount>  |
      | Lead Description            | <LeadDescription>    |
      | Lead Findings               | <LeadFindings>       |
    And I select LOB checkbox
    And I click Save on the Lead Edit page
    Then the lead should be saved successfully
    And the Alternate Lead ID should be "<AlternateLeadId>"
    And the Assigned To should be "<AssignedToUser>"
    And the Assigned Supervisor should be "<AssignedSupervisor>"
    And the Division/Department should be "<DivisionDepartment>"
    And the LOB should be selected
    And the Potential Overpayment Amount should be "<OverpaymentAmount>"

    Examples:
      | UserEmail                         | User | LeadId         | AlternateLeadId | AssignedToUser | AssignedSupervisor | DivisionDepartment                            | OverpaymentAmount | LeadDescription    | LeadFindings              |
      | yamuna.c@gainwelltechnologies.com | All  | DEMO0715202637 | DEMO0715202637  | Jha, Narottam  | Test 527080        | Medicaid Fraud Control and Patient Abuse Unit |          25000.00 | High Priority Lead | Suspicious claim patterns |

  Scenario Outline: 08_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_TIN
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
  And I add referring party details by Provider TIN:
    | Provider TIN            | <ProviderTIN>          |
    | Referral Received Date  | <ReferralReceivedDate> |
    | Organization Name       | <OrganizationName>     |
  And I modify the lead priority
  And I click Create Lead button
  Then I should be navigated to the Lead Edit page
  And the Lead ID should be displayed
  When I click on the Referral tab
  And I click Begin Editing on the Lead Edit page
  

  Examples:
    | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId  | LeadDescription   | ProviderTIN | ReferralReceivedDate | OrganizationName  |
    | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Claims     | Billing Errors | 01/01/2024       | 12/31/2024     | QA_Test      | 10000.00          | Provider    | Search by NPI  | 9999004811 | TIN Referral Lead | 66602459    | 01/15/2024           | ABC Medical Group |

  Scenario Outline: 09_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_TIN
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
    And I add referring party details by Provider TIN:
      | Provider TIN            | <ProviderTIN>          |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
    

    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription            | ProviderTIN | ReferralReceivedDate | OrganizationName        |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Provider   | Billing Errors | 02/01/2024       | 11/30/2024     | QA_Test      |           8000.00 | Provider    |  Search by ID    | 10006   | Provider TIN Investigation |    66602459 | 02/10/2024           | XYZ Healthcare Services |

  Scenario Outline: 10_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_NPI
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
    And I add referring party details by Provider NPI:
      | Provider NPI            | <ProviderNPI>          |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
   

    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId  | LeadDescription   | ProviderNPI | ReferralReceivedDate | OrganizationName    |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral  | Claims     | Billing Errors | 01/01/2024       | 12/31/2024     | QA_Test      |          12000.00 | Provider    | Search by NPI  | 9999004811 | NPI Referral Lead |  9999004811 | 01/20/2024           | City Medical Center |

  Scenario Outline: 11_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_NPI
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
    And I add referring party details by Provider NPI:
      | Provider NPI            | <ProviderNPI>          |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
    

    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason          | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription              | ProviderNPI | ReferralReceivedDate | OrganizationName         |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Provider   | Billing Errors | 03/01/2024       | 10/31/2024     | QA_Test      | 20000.00          | Provider    | Search by NPI  | 9999004811 | High Value NPI Investigation | 0987654321  | 03/05/2024           | County Health Associates |

  Scenario Outline: 12_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_Name
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
    And I add referring party details by Provider Name:
      | First Name              | <FirstName>            |
      | Last Name               | <LastName>             |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
   

    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId  | LeadDescription             | FirstName | LastName | ReferralReceivedDate | OrganizationName         |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Claims     | Billing Errors | 01/01/2024       | 12/31/2024     | QA_Test      |           9000.00 | Provider    | Search by NPI  | 9999004811 | Provider Name Referral Lead | John      | Smith    | 01/25/2024           | Premier Healthcare Group |

  Scenario Outline: 13_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_Name
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
    And I add referring party details by Provider Name:
      | First Name              | <FirstName>            |
      | Last Name               | <LastName>             |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
   

    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription           | FirstName | LastName | ReferralReceivedDate | OrganizationName           |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Provider   | Billing Errors | 04/01/2024       | 09/30/2024     | QA_Test      |          15000.00 | Provider    | Search by ID   |     10006 | Name Search Investigation | Sarah     | Johnson  | 04/10/2024           | Advanced Medical Solutions |

  Scenario Outline: 14_Creating_NewLead_With_Referring_Party_Details_Through_Search_By_Provider_Name
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
    And I add referring party details by Provider Name:
      | First Name              | <FirstName>            |
      | Last Name               | <LastName>             |
      | Referral Received Date  | <ReferralReceivedDate> |
      | Organization Name       | <OrganizationName>     |
    And I modify the lead priority
    And I click Create Lead button
    Then I should be navigated to the Lead Edit page
    And the Lead ID should be displayed
    When I click on the Referral tab
    And I click Begin Editing on the Lead Edit page
   
    Examples:
      | UserEmail                         | SearchKeyword                  | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription                  | FirstName | LastName | ReferralReceivedDate | OrganizationName             |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Member     | Billing Errors | 05/01/2024       | 08/31/2024     | QA_Test      |          18000.00 | Member      | Search by ID   |    123427 | High Priority Name Investigation | Michael   | Williams | 05/15/2024           | Metropolitan Health Services |

  Scenario Outline: 15_Create_New_Lead_With_Different_Workflow_Types
    When I click the Create New Lead button
    And I enter the following lead details:
      | Field                      | Value                  |
      | Workflow Type              | <WorkflowType>         |
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
    And the Lead Type should be "<WorkflowType>"

    Examples:
      | UserEmail                         | WorkflowType                   | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId  | LeadDescription       |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Claims     | Billing Errors | 01/01/2024       | 12/31/2024     | QA_Test      |             10000 | Provider    | Search by NPI  | 9999004811 | Test Lead Description |

  Scenario Outline: 16_Create_New_Lead_With_Different_Workflow_Types
    When I click the Create New Lead button
    And I enter the following lead details:
      | Field                      | Value                  |
      | Workflow Type              | <WorkflowType>         |
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
    And the Lead Type should be "<WorkflowType>"

    Examples:
      | UserEmail                         | WorkflowType                   | DetectionMethod  | SourceType | Reason         | ActivityFromDate | ActivityToDate | SectionTeams | OverpaymentAmount | SubjectType | SearchCriteria | SubjectId | LeadDescription       |
      | yamuna.c@gainwelltechnologies.com | 03062026-Lead Workflow Testing | Hotline Referral | Member     | Billing Errors | 02/01/2024       | 11/30/2024     | QA_Test      |              5000 | Member      | Search by ID   |    123427 | Test Lead Description |
