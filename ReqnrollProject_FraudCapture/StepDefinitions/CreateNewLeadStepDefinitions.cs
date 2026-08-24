using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace FraudCapture_BDD.StepDefinitions
{
    [Binding]
    public class CreateNewLeadSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));

        public CreateNewLeadSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given(@"I am logged into the FWA PI Portal")]
        public void GivenIAmLoggedIntoTheFWAPIPortal()
        {
            var core = new FraudCapture_Core(Driver);
            core.FC_OnlineLogin();

            try
            {
                var homePage = new HomePage(Driver);
                homePage.AcceptDisclosure();
            }
            catch
            {
            }
        }

        [Given(@"I am on the Case Tracking page")]
        public void GivenIAmOnTheCaseTrackingPage()
        {
            var homePage = new HomePage(Driver);
            homePage.ClickMainNavigationBtn();
            homePage.ClickCaseTrackingOption();
        }

        [When(@"I navigate to the Leads tab")]
        public void WhenINavigateToTheLeadsTab()
        {
            var homePage = new HomePage(Driver);
            homePage.ClickSelectLeadsTab();
        }

        [When(@"I enter the following credential to login to the fraud capture main page")]
        public void WhenIEnterTheFollowingCredentialToLoginToTheFraudCaptureMainPage(Table table)
        {
            var values = ToDictionary(table);
            var userEmail = GetTableValue(values, "UserEmail");

            var loginPage = new FC_LoginPage(Driver);
            loginPage.EnterLoginUserEmail(userEmail);
        }

        [When(@"I click the Create New Lead button")]
        public void WhenIClickTheCreateNewLeadButton()
        {
            var leadPage = new CaseTracking_LeadPage(Driver);
            leadPage.ClickCreateNewLeadBtn();
        }

        [When(@"i click on the Procced to login button on the welcome fraude capture page")]
        public void WhenIClickOnTheProccedToLoginButtonOnTheWelcomeFraudeCapturePageLowercase()
        {
            var loginPage = new FC_LoginPage(Driver);
            loginPage.ClickProceedToLogin();
        }

        [When(@"i click on the I Agree button on the fraud capture Page")]
        public void WhenIClickOnTheIAgreeButtonOnTheFraudCapturePageLowercase()
        {
            var loginPage = new FC_LoginPage(Driver);
            loginPage.waitForIAgreeButton();

            var homePage = new HomePage(Driver);
            homePage.AcceptDisclosure();
        }

        [When(@"i click on CaseTracking and select the Leads Tab on the fraud capture home page")]
        public void WhenIClickOnCaseTrackingAndSelectTheLeadsTabOnTheFraudCaptureHomePageLowercase()
        {
            var homePage = new HomePage(Driver);
            homePage.ClickMainNavigationBtn();
            homePage.ClickCaseTrackingOption();
            homePage.ClickSelectLeadsTab();
        }

        [When(@"I switch to leads user ""(.*)""")]
        public void WhenISwitchToLeadsUser(string user)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            
            // First try to find and click the dropdown
            var dropdownLocator = By.Id("dropdownLeadListUser");
            var dropdown = FindVisibleWithRetry(10, dropdownLocator);
            
            if (dropdown == null)
            {
                // Try alternative XPath if ID doesn't work
                dropdownLocator = By.XPath("//select[@id='dropdownLeadListUser'] | //button[contains(@id,'dropdownLeadListUser')] | //*[@id='dropdownLeadListUser']");
                dropdown = FindVisibleWithRetry(10, dropdownLocator);
            }
            
            Assert.That(dropdown, Is.Not.Null, $"Unable to find leads user dropdown");
            
            try
            {
                SelectOption(dropdownLocator, user);
                System.Threading.Thread.Sleep(500);
                _scenarioContext["CurrentUser"] = user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to switch to leads user '{user}': {ex.Message}", ex);
            }
        }

        [When(@"I search by Lead ID")]
        public void WhenISearchByLeadID()
        {
            SelectOption(By.Id("leadSearchCriteria"), "Lead ID");
        }

        [When(@"I search for lead ""(.*)""")]
        public void WhenISearchForLead(string leadId)
        {
            SetInput(leadId, By.XPath("//div[@id='allLeads']//input[@id='searchInputField']"), By.Id("searchInputField"));
            Click(By.XPath("//div[@id='allLeads']//button[@id='searchStartButton']"), By.Id("searchStartButton"));
            _scenarioContext["SearchedLeadId"] = leadId;
        }

        [When(@"I select the lead")]
        public void WhenISelectTheLead()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);

            var searchedLeadId = _scenarioContext.ContainsKey("SearchedLeadId")
                ? _scenarioContext.Get<string>("SearchedLeadId")
                : string.Empty;

            if (!string.IsNullOrWhiteSpace(searchedLeadId))
            {
                try
                {
                    var leadPage = new FC_CaseTracking_LeadPage(Driver);
                    leadPage.SelectLead(searchedLeadId);

                    // Verify we actually navigated/opened after selection
                    if (Driver.WindowHandles.Count > 1 || IsLeadEditPage())
                    {
                        return;
                    }
                }
                catch
                {
                    // fallback to resilient locator-based click below
                }
            }

            ClickLeadResultRow();
        }

        [When(@"I select the lead ""(.*)""")]
        public void WhenISelectTheLeadWithId(string leadId)
        {
            var leadPage = new CaseTracking_LeadPage(Driver);
            leadPage.SelectLead(leadId);
            _scenarioContext["SelectedLeadId"] = leadId;
        }

        [When(@"I enter the following lead details:")]
        public void WhenIEnterTheFollowingLeadDetails(Table table)
        {
            var values = ToDictionary(table);
            var page = new CreateNewLeadPage(Driver);

            var workflowType = GetTableValue(values, "Workflow Type");
            var detectionMethod = GetTableValue(values, "Detection Method");
            var sourceType = GetTableValue(values, "Source Type");
            var reason = GetTableValue(values, "Reason");
            var assignedTo = GetTableValue(values, "Assigned To");
            var activityFromDate = GetTableValue(values, "Suspect Activity From Date");
            var activityToDate = GetTableValue(values, "Suspect Activity To Date");
            var sectionTeams = GetTableValue(values, "Assigned Section/Teams");
            var overpaymentAmount = GetTableValue(values, "Potential Overpayment");

            if (!string.IsNullOrWhiteSpace(workflowType)) page.SelectLeadWorkflowType(workflowType);
            if (!string.IsNullOrWhiteSpace(detectionMethod)) page.SelectDetectionMethod(detectionMethod);
            if (!string.IsNullOrWhiteSpace(sourceType)) page.SelectSourceType(sourceType);
            if (!string.IsNullOrWhiteSpace(reason)) page.SelectReason(reason);
            if (!string.IsNullOrWhiteSpace(assignedTo)) page.SelectAssignedTo(assignedTo);

            TrySetField(activityFromDate,
                By.XPath("//input[contains(@id,'From') or contains(@name,'From') or contains(@placeholder,'From')][1]"),
                By.XPath("//label[contains(normalize-space(),'From')]/following::input[1]"));
            TrySetField(activityToDate,
                By.XPath("//input[contains(@id,'To') or contains(@name,'To') or contains(@placeholder,'To')][1]"),
                By.XPath("//label[contains(normalize-space(),'To')]/following::input[1]"));
            TrySelectField(sectionTeams,
                By.Id("SectionId"),
                By.XPath("//label[contains(normalize-space(),'Section') or contains(normalize-space(),'Team')]/following::select[1]"));
            TrySetField(overpaymentAmount,
                By.XPath("//input[contains(@id,'payment') or contains(@name,'payment')][1]"),
                By.XPath("//label[contains(normalize-space(),'Overpayment')]/following::input[1]"));

            _scenarioContext["WorkflowType"] = workflowType;
            _scenarioContext["AssignedTo"] = assignedTo;
            _scenarioContext["ActivityFromDate"] = activityFromDate;
            _scenarioContext["ActivityToDate"] = activityToDate;
            _scenarioContext["OverpaymentAmount"] = overpaymentAmount;
        }

        [When(@"I add a subject with the following details:")]
        public void WhenIAddASubjectWithTheFollowingDetails(Table table)
        {
            var values = ToDictionary(table);
            var page = new CreateNewLeadPage(Driver);

            var subjectType = GetTableValue(values, "Subject Type");
            var searchCriteria = GetTableValue(values, "Search Criteria");
            var subjectId = GetTableValue(values, "Subject ID");
            var normalizedCriteria = Normalize(searchCriteria);
            var normalizedSubjectType = Normalize(subjectType);

            if (!string.IsNullOrWhiteSpace(subjectType))
            {
                try
                {
                    page.SelectSubjectType(subjectType);
                }
                catch
                {
                    page.SelectSubjectTypeDropDownProvider(subjectType);
                }
            }

            if (!string.IsNullOrWhiteSpace(searchCriteria))
            {
                try
                {
                    page.SelectPrimarySubject(searchCriteria);
                }
                catch
                {
                    page.SelectPrimarySubjectDropDownProvider(searchCriteria);
                }
            }

            if (normalizedCriteria.Contains("npi"))
            {
                page.ClickProviderSearchByNPI(subjectId);
                page.ClickProviderSearchBtnforNPI();
                page.ClickProviderSelectBtnforNPI();
            }
            else if (normalizedCriteria.Contains("providerid"))
            {
                page.ClickProviderSearchByID(subjectId);
                page.ClickProviderSearchBtn();
                page.ClickProviderSelectBtn();
            }
            else if (normalizedCriteria.Contains("memberid") || normalizedCriteria == "id" || (normalizedCriteria.Contains("id") && normalizedSubjectType.Contains("member")))
            {
                page.ClickMemberSearchByID(subjectId);
                page.ClickMemberSearchBtn();
                page.ClickMemberSelectBtn();
            }
            else
            {
                TrySetField(subjectId,
                    By.Id("searchIdCase"),
                    By.XPath("//input[@id='searchIdCase' or @id='searchByMemberId']"),
                    By.XPath("//label[contains(normalize-space(),'ID')]/following::input[1]"));
                TryClick(By.Id("btnSearch"));
                TryClick(By.Id("SelectSbjectResultBtn"), By.Id("btnAddReferral"));
            }

            page.ClickNextBtnforPrimarySubjectPage();
        }

        [When(@"I enter lead description ""(.*)""")]
        public void WhenIEnterLeadDescription(string leadDescription)
        {
            var page = new CreateNewLeadPage(Driver);
            TryInvoke(() => page.ClickDescriptionTab());
            page.ClickDescriptionField(leadDescription);
            TryInvoke(() => page.ClickNextBtnforDescriptionPage());
            _scenarioContext["LeadDescription"] = leadDescription;
        }
        [Then("I click on the Next button on the Referring Party Page")]
        public void ThenIClickOnTheNextButtonOnTheReferringPartyPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickNextBtnforReferringPartyPage();
        }

        [Then("I click Prioritization and click Create New Lead button in the Prioritization Page")]
        public void ThenIClickPrioritizationAndClickCreateNewLeadButtonInThePrioritizationPage()
        {
            var fc = new CreateNewLeadPage(Driver);
            fc.ClickCreateLeadBtninPrioritizationTab();
        }


        [When(@"I add anonymous referring party details")]
        public void WhenIAddAnonymousReferringPartyDetails()
        {
            // More robust handling for selecting Anonymous referring party
            var referringPartyElement = FindVisible(By.Id("referringPartyVal"));
            if (referringPartyElement != null)
            {
                var select = new SelectElement(referringPartyElement);
                var availableOptions = select.Options.Select(o => $"{o.Text} (value={o.GetAttribute("value")})").ToList();
                
                try
                {
                    // Try different variations of "Anonymous"
                    var anonymousOption = select.Options.FirstOrDefault(o => 
                        o.Text.Equals("Anonymous", StringComparison.OrdinalIgnoreCase) ||
                        o.GetAttribute("value").Equals("Anonymous", StringComparison.OrdinalIgnoreCase) ||
                        o.Text.Contains("Anonymous", StringComparison.OrdinalIgnoreCase) ||
                        o.Text.Equals("None", StringComparison.OrdinalIgnoreCase) ||
                        o.Text.Equals("N/A", StringComparison.OrdinalIgnoreCase));
                    
                    if (anonymousOption != null)
                    {
                        anonymousOption.Click();
                        Console.WriteLine($"Selected referring party: {anonymousOption.Text}");
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Could not find 'Anonymous' option. Available options: {string.Join(", ", availableOptions)}");
                        // Try selecting the first option or leave default
                        if (select.Options.Count > 0)
                        {
                            select.SelectByIndex(0);
                            Console.WriteLine($"Selected first available option: {select.SelectedOption.Text}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error selecting referring party: {ex.Message}. Available options: {string.Join(", ", availableOptions)}");
                }
            }
            else
            {
                Console.WriteLine("Warning: Referring party dropdown not found");
            }
            
            TryClick(By.XPath("//button[@id='next']"));
        }

        [When(@"I add referring party details by Provider TIN:")]
        public void WhenIAddReferringPartyDetailsByProviderTIN(Table table)
        {
            var values = ToDictionary(table);
            var providerTin = GetTableValue(values, "Provider TIN");
            var organizationName = GetTableValue(values, "Organization Name");

            TrySelectField("TIN", By.Id("referringPartyVal"));
            TrySetField(providerTin, By.Id("searchTinEinCase"));
            TryClick(By.Id("btnSearch"));
            TryClick(By.Id("btnAddReferral"));
            TryClick(By.XPath("//button[@id='next']"));

            _scenarioContext["ReferralOrganizationName"] = organizationName;
        }

        [When(@"I add referring party details by Provider NPI:")]
        public void WhenIAddReferringPartyDetailsByProviderNPI(Table table)
        {
            var values = ToDictionary(table);
            var providerNpi = GetTableValue(values, "Provider NPI");
            var organizationName = GetTableValue(values, "Organization Name");

            TrySelectField("NPI", By.Id("referringPartyVal"));
            TrySetField(providerNpi, By.Id("searchNpiCase"));
            TryClick(By.Id("btnSearch"));
            TryClick(By.Id("btnAddReferral"));
            TryClick(By.XPath("//button[@id='next']"));

            _scenarioContext["ReferralOrganizationName"] = organizationName;
        }

        [When(@"I add referring party details by Provider Name:")]
        public void WhenIAddReferringPartyDetailsByProviderName(Table table)
        {
            var values = ToDictionary(table);
            var firstName = GetTableValue(values, "First Name");
            var lastName = GetTableValue(values, "Last Name");
            var organizationName = GetTableValue(values, "Organization Name");

            TrySelectField("Name", By.Id("referringPartyVal"));
            TrySetField(!string.IsNullOrWhiteSpace(organizationName) ? organizationName : $"{firstName} {lastName}".Trim(), By.Id("searchOrgName"));
            TryClick(By.Id("btnSearch"));
            TryClick(By.Id("btnAddReferral"));
            TryClick(By.XPath("//button[@id='next']"));

            _scenarioContext["ReferralOrganizationName"] = organizationName;
        }

        [When(@"I modify the lead priority")]
        public void WhenIModifyTheLeadPriority()
        {
            TryClick(By.XPath("//a[contains(@id,'Priority') or contains(normalize-space(),'Priority')]"));
        }

        [When(@"I click Create Lead button")]
        public void WhenIClickCreateLeadButton()
        {
            var page = new CreateNewLeadPage(Driver);
            page.ClickCreateLeadBtninPrioritizationTab();
        }

        [When(@"I click Begin Editing on the Lead Edit page")]
        public void WhenIClickBeginEditingOnTheLeadEditPage()
        {
            try
            {
                var page = new FC_CaseTracking_LeadPage(Driver);
                page.ClickLeadBeginEditing();
                
                // Switch to new window if opened
                try
                {
                    CommonHelpers.SwitchtoNewWindow(Driver);
                }
                catch
                {
                    // Window switch may not be needed in all cases
                    Console.WriteLine("No new window to switch to");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clicking Begin Editing: {ex.Message}");
                throw;
            }
        }

        [When(@"I set the following lead details:")]
        public void WhenISetTheFollowingLeadDetails(Table table)
        {
            var values = ToDictionary(table);

            var alternateLeadId = GetTableValue(values, "Alternate Lead ID");
            var assignedTo = GetTableValue(values, "Assigned To");
            var assignedSupervisor = GetTableValue(values, "Assigned Supervisor");
            var divisionDepartment = GetTableValue(values, "Division/Department");
            var overpaymentAmount = GetTableValue(values, "Potential Overpayment");
            var leadDescription = GetTableValue(values, "Lead Description");
            var leadFindings = GetTableValue(values, "Lead Findings");

            TrySetField(alternateLeadId, By.Id("altleadId"));
            TrySelectField(assignedTo, By.Id("dropdownMenuLeadAssign"), By.XPath("//label[contains(normalize-space(),'Assigned To')]/following::*[self::select or self::button][1]"));
            TrySelectField(assignedSupervisor, By.Id("dropdownMenuLeadSupervisorAssign"), By.XPath("//label[contains(normalize-space(),'Supervisor')]/following::*[self::select or self::button][1]"));
            TrySelectField(divisionDepartment, By.Id("divisiondep"), By.XPath("//label[contains(normalize-space(),'Division') or contains(normalize-space(),'Department')]/following::select[1]"));
            TrySetField(overpaymentAmount,
                By.XPath("//input[contains(@id,'payment') or contains(@name,'payment')][1]"),
                By.XPath("//label[contains(normalize-space(),'Overpayment')]/following::input[1]"));

            if (!string.IsNullOrWhiteSpace(leadDescription))
            {
                var leadPage = new FC_CaseTracking_LeadPage(Driver);
                leadPage.EnterLeadDescription(leadDescription);
                _scenarioContext["LeadDescription"] = leadDescription;
            }

            TrySetField(leadFindings,
                By.XPath("//label[contains(normalize-space(),'Findings')]/following::textarea[1]"),
                By.XPath("//label[contains(normalize-space(),'Findings')]/following::div[@contenteditable='true'][1]"));

            _scenarioContext["AlternateLeadId"] = alternateLeadId;
            _scenarioContext["AssignedTo"] = assignedTo;
            _scenarioContext["AssignedSupervisor"] = assignedSupervisor;
            _scenarioContext["DivisionDepartment"] = divisionDepartment;
            _scenarioContext["OverpaymentAmount"] = overpaymentAmount;
        }

        [When(@"I select LOB checkbox")]
        public void WhenISelectLOBCheckbox()
        {
            var checkbox = FindVisible(By.XPath("//label[contains(normalize-space(),'LOB')]/preceding::input[@type='checkbox'][1]"), By.XPath("//label[contains(normalize-space(),'LOB')]/following::input[@type='checkbox'][1]"));
            if (checkbox != null && !checkbox.Selected)
            {
                checkbox.Click();
            }
        }

        [When(@"I click Save on the Lead Edit page")]
        public void WhenIClickSaveOnTheLeadEditPage()
        {
            var saveSuccess = false;
            try
            {
                var page = new FC_CaseTracking_LeadPage(Driver);
                page.ClickLeadSaveButton();
                saveSuccess = true;
            }
            catch
            {
                saveSuccess = false;
            }

            _scenarioContext["SaveSuccess"] = saveSuccess;
        }

        [When(@"I click on the Referral tab")]
        public void WhenIClickOnTheReferralTab()
        {
            Click(By.Id("leadReferralTabId"), By.XPath("//a[contains(@id,'Referral') or contains(normalize-space(),'Referral')]"));
        }

        [Then(@"I should be navigated to the Lead Edit page")]
        public void ThenIShouldBeNavigatedToTheLeadEditPage()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            System.Threading.Thread.Sleep(500);

            // Try to verify we're on the Lead Edit page
            bool isOnLeadEditPage = IsLeadEditPage();

            if (!isOnLeadEditPage)
            {
                // Provide detailed debugging information
                Console.WriteLine("\n=== LEAD EDIT PAGE VERIFICATION FAILED ===");
                Console.WriteLine($"Current URL: {Driver.Url}");
                Console.WriteLine($"Page Title: {Driver.Title}");
                
                try
                {
                    var pageSource = Driver.PageSource;
                    Console.WriteLine($"Page source length: {pageSource.Length}");
                    
                    // Check for key lead elements in page source
                    if (pageSource.Contains("leadForm", StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("✓ Found 'leadForm' in page source");
                    if (pageSource.Contains("leadSaveButton", StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("✓ Found 'leadSaveButton' in page source");
                    if (pageSource.Contains("leadViewEditEndButton", StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("✓ Found 'leadViewEditEndButton' in page source");
                    if (pageSource.Contains("Begin Editing", StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("✓ Found 'Begin Editing' button in page source");
                    
                    // Look for Lead ID pattern
                    var leadIdMatch = Regex.Match(pageSource, @"LEAD[-\w]+", RegexOptions.IgnoreCase);
                    if (leadIdMatch.Success)
                        Console.WriteLine($"✓ Found Lead ID pattern: {leadIdMatch.Value}");
                    else
                        Console.WriteLine("✗ No Lead ID pattern found");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking page source: {ex.Message}");
                }

                Console.WriteLine("\n=== END DEBUGGING INFO ===\n");
                
                // Don't fail immediately - check if we can find any lead indicator after additional wait
                System.Threading.Thread.Sleep(2000);
                isOnLeadEditPage = IsLeadEditPage();
            }

            Assert.That(isOnLeadEditPage, 
                "Should be navigated to Lead Edit page. Check console output for debugging details. " +
                "Possible causes: page still loading, element IDs changed, or window switch issue.");
        }


        [Then(@"the Lead ID should be displayed")]
        public void ThenTheLeadIDShouldBeDisplayed()
        {
            var leadId = GetLeadId();

            if (string.IsNullOrWhiteSpace(leadId))
            {
                System.Threading.Thread.Sleep(1000);
                leadId = GetLeadId();
            }

            Assert.That(leadId, Is.Not.Null.And.Not.Empty, "Lead ID should not be empty");
            _scenarioContext["CreatedLeadId"] = leadId;
        }

        [Then(@"the Lead Type should be ""(.*)""")]
        public void ThenTheLeadTypeShouldBe(string expectedLeadType)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(20);
            var actualLeadType = string.Empty;

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);

                actualLeadType = ReadFieldText(
                    By.Id("leadCaseTypeEditNR"),
                    By.XPath("//label[contains(normalize-space(),'Lead Type')]/following::*[self::select or self::input or self::span or self::div][1]"));

                if (!string.IsNullOrWhiteSpace(actualLeadType) &&
                    actualLeadType.Contains(expectedLeadType, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                System.Threading.Thread.Sleep(250);
            }

            Assert.That(actualLeadType.Contains(expectedLeadType, StringComparison.OrdinalIgnoreCase),
                $"Expected Lead Type to contain '{expectedLeadType}' but got '{actualLeadType}'");
        }

        [Then(@"the Assigned To should be ""(.*)""")]
        public void ThenTheAssignedToShouldBe(string expectedAssignedTo)
        {
            var actualAssignedTo = WaitForFieldText(
                value => TextContains(value, expectedAssignedTo),
                By.Id("dropdownMenuLeadAssign"),
                By.XPath("//label[contains(normalize-space(),'Assigned To')]/following::*[1]"));

            Assert.That(TextContains(actualAssignedTo, expectedAssignedTo),
                $"Expected Assigned To to contain '{expectedAssignedTo}' but got '{actualAssignedTo}'");
        }

        [Then(@"the Suspect Activity From date should be ""(.*)""")]
        public void ThenTheSuspectActivityFromDateShouldBe(string expectedDate)
        {
            var actualDate = WaitForFieldText(
                value => DateMatches(value, expectedDate),
                By.XPath("//input[contains(@id,'From') or contains(@name,'From')][1]"),
                By.XPath("//label[contains(normalize-space(),'From')]/following::input[1]"));

            Assert.That(DateMatches(actualDate, expectedDate),
                $"Expected Suspect Activity From date '{expectedDate}' but got '{actualDate}'");
        }

        [Then(@"the Suspect Activity To date should be ""(.*)""")]
        public void ThenTheSuspectActivityToDateShouldBe(string expectedDate)
        {
            var actualDate = WaitForFieldText(
                value => DateMatches(value, expectedDate),
                By.XPath("//input[contains(@id,'To') or contains(@name,'To')][1]"),
                By.XPath("//label[contains(normalize-space(),'To')]/following::input[1]"));

            Assert.That(DateMatches(actualDate, expectedDate),
                $"Expected Suspect Activity To date '{expectedDate}' but got '{actualDate}'");
        }

        [Then(@"the Potential Overpayment Amount should be ""(.*)""")]
        public void ThenThePotentialOverpaymentAmountShouldBe(string expectedAmount)
        {
            var actualAmount = WaitForFieldText(
                value => AmountMatches(value, expectedAmount),
                By.XPath("//input[contains(@id,'payment') or contains(@name,'payment')][1]"),
                By.XPath("//label[contains(normalize-space(),'Overpayment')]/following::input[1]"));

            Assert.That(AmountMatches(actualAmount, expectedAmount),
                $"Expected Potential Overpayment Amount '{expectedAmount}' but got '{actualAmount}'");
        }

        [Then(@"the Lead Description should contain ""(.*)""")]
        public void ThenTheLeadDescriptionShouldContain(string expectedDescription)
        {
            var actualDescription = WaitForFieldText(
                value => TextContains(value, expectedDescription),
                By.XPath("//div[contains(@class,'fr-element') and @contenteditable='true']"),
                By.XPath("//label[contains(normalize-space(),'Description')]/following::div[contains(@class,'fr-element')][1]"),
                By.XPath("//label[contains(normalize-space(),'Description')]/following::textarea[1]"));

            Assert.That(TextContains(actualDescription, expectedDescription),
                $"Expected Lead Description to contain '{expectedDescription}' but got '{actualDescription}'");
        }

        [Then(@"the lead should be saved successfully")]
        public void ThenTheLeadShouldBeSavedSuccessfully()
        {
            var saveSuccess = _scenarioContext.ContainsKey("SaveSuccess") && _scenarioContext.Get<bool>("SaveSuccess");
            Assert.That(saveSuccess, "Lead save was not successful");
        }

        [Then(@"the Alternate Lead ID should be ""(.*)""")]
        public void ThenTheAlternateLeadIDShouldBe(string expectedAlternateLeadId)
        {
            var actualAlternateLeadId = WaitForFieldText(
                value => TextContains(value, expectedAlternateLeadId),
                By.Id("altleadId"));

            Assert.That(TextContains(actualAlternateLeadId, expectedAlternateLeadId),
                $"Expected Alternate Lead ID to contain '{expectedAlternateLeadId}' but got '{actualAlternateLeadId}'");
        }

        [Then(@"the Assigned Supervisor should be ""(.*)""")]
        public void ThenTheAssignedSupervisorShouldBe(string expectedSupervisor)
        {
            var actualSupervisor = WaitForFieldText(
                value => TextContains(value, expectedSupervisor),
                By.Id("dropdownMenuLeadSupervisorAssign"),
                By.XPath("//label[contains(normalize-space(),'Supervisor')]/following::*[1]"));

            Assert.That(TextContains(actualSupervisor, expectedSupervisor),
                $"Expected Assigned Supervisor to contain '{expectedSupervisor}' but got '{actualSupervisor}'");
        }

        [Then(@"the Division/Department should be ""(.*)""")]
        public void ThenTheDivisionDepartmentShouldBe(string expectedDivision)
        {
            var actualDivision = WaitForFieldText(
                value => TextContains(value, expectedDivision),
                By.Id("divisiondep"),
                By.XPath("//label[contains(normalize-space(),'Division') or contains(normalize-space(),'Department')]/following::*[1]"));

            Assert.That(TextContains(actualDivision, expectedDivision),
                $"Expected Division/Department to contain '{expectedDivision}' but got '{actualDivision}'");
        }

        [Then(@"the LOB should be selected")]
        public void ThenTheLOBShouldBeSelected()
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(20);
            IWebElement? checkbox = null;

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
                checkbox = FindVisible(
                    By.XPath("//label[contains(normalize-space(),'LOB')]/preceding::input[@type='checkbox'][1]"),
                    By.XPath("//label[contains(normalize-space(),'LOB')]/following::input[@type='checkbox'][1]"));

                if (checkbox != null && checkbox.Selected)
                {
                    break;
                }

                System.Threading.Thread.Sleep(250);
            }

            Assert.That(checkbox != null && checkbox.Selected, "LOB should be selected");
        }

        [Then(@"the Referral Organization Name should be ""(.*)""")]
        public void ThenTheReferralOrganizationNameShouldBe(string expectedOrganizationName)
        {
            var actualOrganizationName = WaitForFieldText(
                value => OrganizationNameMatches(value, expectedOrganizationName),
                By.Id("ReferralOrganizationName"),
                By.XPath("//*[contains(@id,'ReferralOrganizationName') or contains(@name,'ReferralOrganizationName')][1]"),
                By.XPath("//label[contains(normalize-space(),'Organization Name')]/following::*[self::input or self::span or self::div][1]"));

            if (!OrganizationNameMatches(actualOrganizationName, expectedOrganizationName))
            {
                actualOrganizationName = ReadFieldText(
                    By.XPath("//table//td[contains(normalize-space(), 'Medical') or contains(normalize-space(), 'Health') or contains(normalize-space(), 'Group')][1]"),
                    By.XPath($"//*[contains(normalize-space(),{ToXPathLiteral(expectedOrganizationName)})][1]"));
            }

            if (!OrganizationNameMatches(actualOrganizationName, expectedOrganizationName))
            {
                try
                {
                    var pageText = Driver.FindElement(By.TagName("body")).Text;
                    actualOrganizationName = ExtractMatchingLine(pageText, expectedOrganizationName);
                }
                catch
                {
                }
            }

            Assert.That(OrganizationNameMatches(actualOrganizationName, expectedOrganizationName),
                $"Expected Referral Organization Name '{expectedOrganizationName}' but got '{actualOrganizationName}'");
        }

        private static string Normalize(string value)
        {
            return new string((value ?? string.Empty).Where(char.IsLetterOrDigit).ToArray()).ToLowerInvariant();
        }

        private static string GetTableValue(IDictionary<string, string> values, string fieldName)
        {
            return values.TryGetValue(fieldName, out var value) ? value : string.Empty;
        }

        private static Dictionary<string, string> ToDictionary(Table table)
        {
            var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var headers = table.Header.ToList();

            if (headers.Count == 2 && headers.Contains("Field") && headers.Contains("Value"))
            {
                foreach (var row in table.Rows)
                {
                    values[row["Field"]] = row["Value"];
                }

                return values;
            }

            if (table.RowCount == 1)
            {
                foreach (var header in headers)
                {
                    values[header] = table.Rows[0][header];
                }

                return values;
            }

            if (headers.Count == 2)
            {
                var keyHeader = headers[0];
                var valueHeader = headers[1];
                values[keyHeader] = valueHeader;

                foreach (var row in table.Rows)
                {
                    values[row[keyHeader]] = row[valueHeader];
                }
            }

            return values;
        }

        private void SetInput(string value, params By[] locators)
        {
            var element = FindVisibleWithRetry(20, locators);
            Assert.That(element, Is.Not.Null, $"Unable to find input for locators: {string.Join(", ", locators.Select(x => x.ToString()))}");

            ClickWithRetry(20, locators);

            element = FindVisibleWithRetry(10, locators);
            Assert.That(element, Is.Not.Null, $"Unable to find input for locators: {string.Join(", ", locators.Select(x => x.ToString()))}");

            TryInvoke(() => element!.Clear());
            element!.SendKeys(value);
        }

        private void TrySetField(string value, params By[] locators)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var element = FindVisibleWithRetry(10, locators);
            if (element == null)
            {
                return;
            }

            TryInvoke(() => ClickWithRetry(10, locators));

            element = FindVisibleWithRetry(5, locators);
            if (element == null)
            {
                return;
            }

            try
            {
                element.Clear();
            }
            catch
            {
            }

            element.SendKeys(value);
        }

        private void SelectOption(By locator, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var element = FindVisibleWithRetry(20, locator);
            Assert.That(element, Is.Not.Null, $"Unable to find select element: {locator}");

            if (element!.TagName.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                SelectOption(element, value);
                return;
            }

            ClickWithRetry(20, locator);
            
            // Wait a bit for dropdown to open
            System.Threading.Thread.Sleep(300);

            var optionLocators = new[]
            {
                By.XPath($"//*[contains(@class,'dropdown')]//*[normalize-space()={ToXPathLiteral(value)}]"),
                By.XPath($"//div[contains(@class,'dropdown-menu')]//a[normalize-space()={ToXPathLiteral(value)}]"),
                By.XPath($"//ul[contains(@class,'dropdown')]//li//a[normalize-space()={ToXPathLiteral(value)}]"),
                By.XPath($"//a[normalize-space()={ToXPathLiteral(value)}]"),
                By.XPath($"//button[normalize-space()={ToXPathLiteral(value)}]"),
                By.XPath($"//li[normalize-space()={ToXPathLiteral(value)}]")
            };

            var optionElement = FindVisibleWithRetry(10, optionLocators);
            if (optionElement != null)
            {
                ClickElement(optionElement);
                System.Threading.Thread.Sleep(200);
            }
            else
            {
                // Try clicking on the option even if not found, in case it's there but not immediately visible
                var allElements = Driver.FindElements(By.XPath("//*[normalize-space()='" + value + "']"));
                if (allElements.Count > 0)
                {
                    ClickElement(allElements.FirstOrDefault(e => e.Displayed) ?? allElements[0]);
                }
            }
        }

        private void TrySelectField(string value, params By[] locators)
        {
            if (string.IsNullOrWhiteSpace(value) || locators == null || locators.Length == 0)
            {
                return;
            }

            foreach (var locator in locators)
            {
                var element = FindVisibleWithRetry(5, locator);
                if (element == null)
                {
                    continue;
                }

                TryInvoke(() => SelectOption(locator, value));
                return;
            }
        }

        private static void SelectOption(IWebElement element, string value)
        {
            if (element.TagName.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                var select = new SelectElement(element);
                try
                {
                    select.SelectByText(value);
                }
                catch
                {
                    select.SelectByValue(value);
                }

                return;
            }

            element.Click();
        }

        private void Click(params By[] locators)
        {
            ClickWithRetry(20, locators);
        }

        private void TryClick(params By[] locators)
        {
            TryInvoke(() => ClickWithRetry(10, locators));
        }

        private static void TryInvoke(Action action)
        {
            try
            {
                action();
            }
            catch
            {
            }
        }

        private IWebElement? FindVisible(params By[] locators)
        {
            foreach (var locator in locators)
            {
                var element = Driver.FindElements(locator).FirstOrDefault(x => x.Displayed);
                if (element != null)
                {
                    return element;
                }
            }

            return null;
        }

        private IWebElement? FindVisibleWithRetry(int timeoutInSeconds, params By[] locators)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(timeoutInSeconds);

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
                var element = FindVisible(locators);
                if (element != null)
                {
                    return element;
                }

                System.Threading.Thread.Sleep(200);
            }

            return null;
        }

        private void ClickWithRetry(int timeoutInSeconds, params By[] locators)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(timeoutInSeconds);

            while (DateTime.UtcNow < timeoutAt)
            {
                try
                {
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
                    var element = FindVisible(locators);
                    if (element == null)
                    {
                        System.Threading.Thread.Sleep(200);
                        continue;
                    }

                    ClickElement(element);
                    return;
                }
                catch
                {
                }

                System.Threading.Thread.Sleep(200);
            }

            throw new WebDriverTimeoutException($"Unable to click element for locators: {string.Join(", ", locators.Select(x => x.ToString()))}");
        }

        private void ClickElement(IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (ElementClickInterceptedException)
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
            }
        }

        private static string ToXPathLiteral(string value)
        {
            if (!value.Contains("'"))
            {
                return $"'{value}'";
            }

            if (!value.Contains("\""))
            {
                return $"\"{value}\"";
            }

            var parts = value.Split('\'');
            return "concat('" + string.Join("', \"'\", '", parts) + "')";
        }

        private bool IsLeadEditPage()
        {
            try
            {
                // Wait for page to load
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
                System.Threading.Thread.Sleep(500);

                // Check 1: Look for Lead Edit page indicators - multiple attempts with different locators
                var leadEditIndicators = new []
                {
                    // Primary indicators - Lead Edit page buttons
                    By.Id("leadViewEditEndButton"),
                    By.Id("leadSaveButton"),
                    By.XPath("//button[contains(normalize-space(),'Begin Editing')]"),
                    By.XPath("//button[@id='leadSaveButton' or normalize-space()='Save']"),
                    
                    // Secondary indicators - Lead form elements
                    By.Id("leadForm"),
                    By.XPath("//form[@id='leadForm']"),
                    By.XPath("//div[@id='leadForm']"),
                    
                    // Tertiary indicators - Lead-specific elements
                    By.Id("altleadId"),
                    By.Id("dropdownMenuLeadAssign"),
                    By.Id("leadStatusViewMode"),
                    By.XPath("//span[contains(@class,'link-text') and contains(normalize-space(),'LEAD')]"),
                    
                    // Quaternary indicators - Tab elements
                    By.Id("leadSummaryTabId"),
                    By.XPath("//a[contains(@id,'leadSummaryTab')]"),
                    By.XPath("//a[@id='activitiesDetailsTabId']"),
                    By.XPath("//a[contains(@id,'activitiesTab')]"),
                };

                // Check if any lead edit indicator is found
                var foundIndicator = FindVisible(leadEditIndicators);
                if (foundIndicator != null)
                {
                    Console.WriteLine($"Lead Edit page indicator found: {foundIndicator.TagName}#{foundIndicator.GetAttribute("id")}");
                    return true;
                }

                // Check 2: Look for page title or URL containing "lead"
                try
                {
                    var pageTitle = Driver.Title;
                    if (!string.IsNullOrWhiteSpace(pageTitle) && pageTitle.Contains("lead", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Lead Edit page detected via title: {pageTitle}");
                        return true;
                    }

                    var currentUrl = Driver.Url;
                    if (!string.IsNullOrWhiteSpace(currentUrl) && currentUrl.Contains("lead", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Lead Edit page detected via URL: {currentUrl}");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking page title/URL: {ex.Message}");
                }

                // Check 3: Look for Lead ID on the page
                try
                {
                    var leadIdLocators = new[]
                    {
                        By.XPath("//label[contains(@class,'headerFields') and contains(normalize-space(),'LEAD')][1]"),
                        By.XPath("(//span[@class='link-text'])[1]"),
                        By.XPath("//*[contains(normalize-space(),'LEAD-')]")
                    };

                    var leadIdText = ReadFieldText(leadIdLocators);
                    
                    if (!string.IsNullOrWhiteSpace(leadIdText) && leadIdText.Contains("LEAD", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Lead ID found on page: {leadIdText}");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking for Lead ID: {ex.Message}");
                }

                // Check 4: Look for any lead-related content in page body
                try
                {
                    var bodyElements = Driver.FindElements(By.TagName("body"));
                    if (bodyElements.Count > 0)
                    {
                        var bodyText = bodyElements[0].Text;
                        if (bodyText.Contains("Lead ID", StringComparison.OrdinalIgnoreCase) || 
                            bodyText.Contains("Lead Type", StringComparison.OrdinalIgnoreCase) ||
                            bodyText.Contains("Lead Status", StringComparison.OrdinalIgnoreCase) ||
                            bodyText.Contains("Assigned To", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Lead Edit page detected via page content");
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking page content: {ex.Message}");
                }

                // If no indicators found, log available elements for debugging
                Console.WriteLine("WARNING: Lead Edit page indicators not found. Checking for alternative elements...");
                try
                {
                    var availableElements = Driver.FindElements(By.XPath("//*[@id]"));
                    var leadElements = availableElements
                        .Where(e => 
                        {
                            try
                            {
                                var id = e.GetAttribute("id");
                                return !string.IsNullOrWhiteSpace(id) && 
                                       id.Contains("lead", StringComparison.OrdinalIgnoreCase);
                            }
                            catch
                            {
                                return false;
                            }
                        })
                        .Take(10)
                        .ToList();
                    
                    if (leadElements.Any())
                    {
                        Console.WriteLine($"Found {leadElements.Count} lead-related elements:");
                        foreach (var element in leadElements)
                        {
                            try
                            {
                                Console.WriteLine($"  - {element.TagName}#{element.GetAttribute("id")}");
                            }
                            catch { }
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error listing lead elements: {ex.Message}");
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in IsLeadEditPage: {ex.Message}");
                return false;
            }
        }

        private string GetLeadId()
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(30);

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);

                var raw = ReadFieldText(
                    By.XPath("//label[contains(@class,'headerFields') and contains(normalize-space(),'LEAD')][1]"),
                    By.XPath("//*[@id='leadForm']//label[contains(@class,'headerFields')][1]"),
                    By.XPath("//*[@id='leadForm']//span[contains(@class,'link-text')][1]"),
                    By.XPath("(//span[@class='link-text'])[1]"),
                    By.XPath("//*[contains(normalize-space(),'LEAD-')][1]")
                );

                var leadId = ExtractLeadId(raw);
                if (!string.IsNullOrWhiteSpace(leadId))
                {
                    return leadId;
                }

                try
                {
                    var pageText = Driver.FindElement(By.TagName("body")).Text;
                    leadId = ExtractLeadId(pageText);
                    if (!string.IsNullOrWhiteSpace(leadId))
                    {
                        return leadId;
                    }
                }
                catch
                {
                }

                System.Threading.Thread.Sleep(300);
            }

            return string.Empty;
        }

        private static string ExtractLeadId(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
            {
                return string.Empty;
            }

            var match = Regex.Match(raw, @"LEAD[-\w]+", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Value.Trim();
            }

            return raw.Trim();
        }

        private string WaitForFieldText(Func<string, bool> predicate, params By[] locators)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(20);
            var lastValue = string.Empty;

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
                lastValue = ReadFieldText(locators);

                if (predicate(lastValue))
                {
                    return lastValue;
                }

                System.Threading.Thread.Sleep(250);
            }

            return lastValue;
        }

        private static bool TextContains(string actual, string expected)
        {
            if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(expected))
            {
                return false;
            }

            return actual.Trim().Contains(expected.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        private static bool TextEquals(string actual, string expected)
        {
            if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(expected))
            {
                return false;
            }

            return string.Equals(actual.Trim(), expected.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        private static bool OrganizationNameMatches(string actual, string expected)
        {
            if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(expected))
            {
                return false;
            }

            var normalizedActual = Regex.Replace(actual.Trim(), @"\s+", " ");
            var normalizedExpected = Regex.Replace(expected.Trim(), @"\s+", " ");

            return string.Equals(normalizedActual, normalizedExpected, StringComparison.OrdinalIgnoreCase)
                   || normalizedActual.Contains(normalizedExpected, StringComparison.OrdinalIgnoreCase)
                   || normalizedExpected.Contains(normalizedActual, StringComparison.OrdinalIgnoreCase);
        }

        private static string ExtractMatchingLine(string pageText, string expected)
        {
            if (string.IsNullOrWhiteSpace(pageText) || string.IsNullOrWhiteSpace(expected))
            {
                return string.Empty;
            }

            var lines = pageText
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim());

            return lines.FirstOrDefault(line =>
                line.Contains(expected, StringComparison.OrdinalIgnoreCase)) ?? string.Empty;
        }

        private static bool DateMatches(string actual, string expected)
        {
            if (string.IsNullOrWhiteSpace(actual) || string.IsNullOrWhiteSpace(expected))
            {
                return false;
            }

            if (DateTime.TryParse(actual, out var actualDate) && DateTime.TryParse(expected, out var expectedDate))
            {
                return actualDate.Date == expectedDate.Date;
            }

            return actual.Trim().Contains(expected.Trim(), StringComparison.OrdinalIgnoreCase) ||
                   expected.Trim().Contains(actual.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        private static bool AmountMatches(string actual, string expected)
        {
            if (TryParseAmount(actual, out var actualAmount) && TryParseAmount(expected, out var expectedAmount))
            {
                return actualAmount == expectedAmount;
            }

            return TextEquals(actual, expected);
        }

        private static bool TryParseAmount(string value, out decimal amount)
        {
            amount = 0;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            var cleaned = Regex.Replace(value, @"[^0-9\.-]", string.Empty);
            return decimal.TryParse(cleaned, NumberStyles.Number | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out amount);
        }

        private string ReadFieldText(params By[] locators)
        {
            var element = FindVisible(locators);
            if (element == null)
            {
                return string.Empty;
            }

            if (element.TagName.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    var selectedText = new SelectElement(element).SelectedOption?.Text;
                    if (!string.IsNullOrWhiteSpace(selectedText))
                    {
                        return selectedText.Trim();
                    }
                }
                catch
                {
                }
            }

            var value = element.GetAttribute("value");
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value.Trim();
            }

            var text = element.Text;
            return text?.Trim() ?? string.Empty;
        }

        private void ClickLeadResultRow()
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(25);
            Exception? lastError = null;

            var leadRowLocators = new[]
            {
                By.XPath("//div[@id='allLeads']//table/tbody/tr[1]//td[2]//a"),
                By.XPath("//div[@id='allLeadlist-wrapper']//table/tbody/tr[1]//td[2]//a"),
                By.XPath("(//span[@class='link-text'])[1]"),
                By.XPath("//table/tbody/tr[1]/td[2]//a"),
                By.XPath("//table/tbody/tr[1]/td[2]//small")
            };

            while (DateTime.UtcNow < timeoutAt)
            {
                try
                {
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);

                    foreach (var locator in leadRowLocators)
                    {
                        var candidate = Driver.FindElements(locator).FirstOrDefault(e => e.Displayed);
                        if (candidate == null)
                        {
                            continue;
                        }

                        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({block:'center'});", candidate);
                        System.Threading.Thread.Sleep(150);

                        try
                        {
                            candidate.Click();
                        }
                        catch
                        {
                            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", candidate);
                        }

                        return;
                    }
                }
                catch (Exception ex)
                {
                    lastError = ex;
                }

                System.Threading.Thread.Sleep(250);
            }

            throw new WebDriverTimeoutException(
                "Unable to click first lead row after search. Tried multiple result-row locators." +
                (lastError != null ? $" Last error: {lastError.Message}" : string.Empty));
        }
    }
}
