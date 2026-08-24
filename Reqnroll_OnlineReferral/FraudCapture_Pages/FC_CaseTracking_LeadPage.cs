using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class FC_CaseTracking_LeadPage : BaseSettings
    {
        public FC_CaseTracking_LeadPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        private void ClickWithFallback(params By[] locators)
        {
            var timeoutAt = DateTime.UtcNow.AddSeconds(40);
            Exception? lastError = null;

            while (DateTime.UtcNow < timeoutAt)
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);

                foreach (var locator in locators)
                {
                    var elements = Driver.FindElements(locator);
                    foreach (var element in elements)
                    {
                        try
                        {
                            if (!element.Displayed)
                            {
                                continue;
                            }

                            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                            System.Threading.Thread.Sleep(150);

                            if (element.Enabled)
                            {
                                try
                                {
                                    element.Click();
                                    return;
                                }
                                catch (WebDriverException ex)
                                {
                                    lastError = ex;
                                }
                            }

                            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                            return;
                        }
                        catch (StaleElementReferenceException ex)
                        {
                            lastError = ex;
                        }
                        catch (ElementNotInteractableException ex)
                        {
                            lastError = ex;
                            try
                            {
                                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                                return;
                            }
                            catch (WebDriverException jsEx)
                            {
                                lastError = jsEx;
                            }
                        }
                        catch (WebDriverException ex)
                        {
                            lastError = ex;
                        }
                    }
                }

                System.Threading.Thread.Sleep(250);
            }

            var locatorDetails = string.Join(" | ", locators.Select(l => l.ToString()));
            var errorDetails = lastError != null ? $" Last error: {lastError.Message}" : string.Empty;
            throw new ElementNotInteractableException($"Unable to click element using the provided locators. Tried: {locatorDetails}.{errorDetails}");
        }

        #region Elements
        //Add xpath here
        private readonly By LeadTab = By.XPath("//a[@id='allLeadsTabId']");
        private readonly By LeadSearchCriteria = By.XPath("//select[@id='leadSearchCriteria']");
        //private readonly By LeadSearchCriteria = By.XPath("//select[@id='leadSearchCriteria']");
        ////select[normalize-space(text())='leadSearchCriteria']
        private readonly By LeadSearchTextBox = By.XPath("//input[@id='searchInputField']");
        private readonly By LeadSearchButton = By.XPath("(//button[@id='searchStartButton'])[3]");
        private readonly By LeadSearchClearButton = By.XPath("//button[@id='searchClearButton']");
        private readonly By LeadIDLink = By.XPath("//*[@id='allLeadlist-wrapper']//div[1]/table/tbody/tr[1]/td[2]/small");
        private readonly By LeadIDFirstLink = By.XPath("(//span[@class='link-text'])[1]");
        private readonly By LeadIDsecondLink = By.XPath("//table/tbody/tr[2]/td[2]/small/a");

        private By LeadIDLinkByRow(int row) => By.XPath("//*[@id='allLeadlist-wrapper']//div[1]/table//tr[" + row + "]/td[2]//a");
        private By ActivityNameByRow(int row) => By.XPath("//*[@id='activityForm']//table[@rules='groups']//tr[" + row + "]/td[1]");
        private By LeadEditBtnByRow(int row) => By.XPath("//*[@id='activityForm']//table[@rules='groups']//tr[" + row + "]//button[@id='editActivityId']");
        private By LeadActivityByName(string name) => By.XPath("//*[@id='activityForm']//table[@rules='groups']//tr[1]//td[contains(text(),'"+ name + "')]");
        private By LeadViewBtnByRow(int row) => By.XPath("//*[@id='activityForm']//table[@rules='groups']//tr[" + row + "]//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')]");


        private readonly By LeadGridSearchInput = By.XPath("//div[@id='allLeads']/descendant::input[@id='searchInputField']");
        private readonly By LeadGridSearchButton = By.XPath("//div[@id='allLeads']/descendant::button[@id='searchStartButton']");
        private readonly By LeadOrgName = By.XPath("//tbody/tr[1]/td[8]/div/small");
        private readonly By LeadOrgNameSecondRow = By.XPath("//tbody/tr[2]/td[8]/div/small[1]");
        private readonly By LeadSubFirstNameLastNameFirstRow = By.XPath("//*[@id='allLeadlist-wrapper']//tr[1]/td[8]/div/small[1]");
        private readonly By LeadSubFirstNameLastNameSecondRow = By.XPath("//*[@id='allLeadlist-wrapper']//tr[2]/td[8]/div/small[1]");

        //tbody/tr[1]/td[8]/div/small
        private readonly By LeadCreateDateFilter = By.XPath("//*[@id='headerTableLeads']//*[@title='Created Date']");

        private readonly By BeginEditing = By.XPath("//button[contains(text(),'Begin Editing')]");
        private readonly By ExitLead = By.XPath("//*[@id='closeBtn']");
        private readonly By LeadBeginEditingBtn = By.XPath("//button[contains(text(),'Begin Editing')]");

        private readonly By ActivitiesDetailsTab = By.XPath("//a[@id='activitiesDetailsTabId']");
        private readonly By ActivitiesBeginEditing = By.XPath("//*[@id='caseViewEditEndButton']");
        private readonly By LeadDetailsTab = By.XPath("//a[@id='leadDetailsId']");
        private readonly By LeadDescriptionEditor = By.XPath("//div[contains(@class,'fr-element') and @contenteditable='true']");
        private readonly By LeadSaveButton = By.XPath("//button[@id='leadSaveButton']");
        private readonly By LeadTypeDropdown = By.XPath("//select[@id='leadCaseTypeEditNR']");
        private readonly By LeadStatusDropdown = By.XPath("//select[@id='leadStatusNR']");
        private readonly By LeadDepartmentDivisionDropdown = By.XPath("//form[@id='leadForm']//select[@name='departmentKey']");
        private readonly By LeadSectionTeamDropdown = By.XPath("//form[@id='leadForm']//select[@id='SectionId' or @name='sectionKey']");
        private readonly By LeadSubjectTab = By.XPath("//a[@id='newSubjectTabId' or @id='leadSubjectTabId' or contains(normalize-space(),'Subject')]");
        private readonly By LeadAssignedToDropdownButton = By.XPath("//button[@id='dropdownMenuLeadAssign']");
        private readonly By LeadReasonTab = By.XPath("//a[@id='leadReasonTabId']");
        private readonly By LeadReasonAddButton = By.XPath("//button[@id='leadReasonAddButton']");
        private readonly By LeadReasonDetectionMethodDropdown = By.XPath("//select[@id='leadSource' or @id='detectionId']");
        private readonly By LeadReasonSourceTypeDropdownButton = By.XPath("//button[@id='dropdownMenuLeadSourceType']");
        private readonly By LeadReasonReasonDropdownButton = By.XPath("//button[@id='dropdownMenuLeadReason']");
        private readonly By LeadReasonDescriptionEditor = By.XPath("//div[@id='AddLeadReasonModal']//div[contains(@class,'fr-element') and @contenteditable='true']");
        private readonly By LeadReasonSaveButton = By.XPath("//div[@id='AddLeadReasonModal']//button[normalize-space()='Save' or contains(@class,'orangeBtn')]");
        private readonly By ActivitiesEditButton = By.XPath("(//button[@id='editActivityId'])[1]");
        private readonly By ActivitiesViewButton = By.XPath("//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')]");
        private readonly By AddBtnNotes = By.XPath("(//button[contains(text(),' Add ')])[1]");
        private readonly By AddNotesTextArea = By.XPath("//trix-editor[@id='notes']");
        private readonly By AddNotesSaveBtn = By.XPath("( //button[(text()=' Save ' )])[2]");
        private readonly By AddSaveConfirmYesbtn = By.XPath("//button[(text()='Yes' )]");
        private readonly By ActivitiesAttachmentTab = By.XPath("//a[@id='attachmentTabId']");
        private readonly By ActivitiesAddAttachmentBtn = By.XPath("//button[contains(text(),'Add Attachment')]");
        private readonly By AddActivityButton = By.XPath("//a[@id='addActivityId']");
        private readonly By AddActivityNameDropdown = By.XPath("//select[@id='name']");
        private readonly By AddActivityContinueButton = By.XPath("//div[@id='activitydetail']//button[normalize-space()='Continue' or .//span[normalize-space()='Continue']]");
        private readonly By AddActivityAddButton = By.XPath("//div[@id='activitydetail']//button[normalize-space()='Add' or .//span[normalize-space()='Add']]");
        private readonly By uploadFileArrow = By.XPath("//label[contains(text(),'Choose a File or Drag Files To Upload')]");
        private readonly By ActivityAttachmentCloseBtn = By.XPath("//img[@alt='Activity Image' and contains(@class,'ActivityIndicator') and (contains(@class,'pointer') or contains(@src,'x-circle-fill.svg'))]");

        private readonly By AttachmentTab = By.XPath("//div[@id='noteAttachmentList']/descendant::ul//li/a[contains(text(),'Attachments')]");
        private readonly By ExitActivityButton = By.XPath("//div[@id='attachment']/descendant::button[text()='Exit Activity']");
        private readonly By leadCreationDate = By.XPath("//input[@name='leadDate']");
        private readonly By activityDuedate = By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr/td[4]");
        // Page verification locators
        private By editActivityHeader =By.XPath("//b[text()='Edit Activity']");

        private By activityNameField = By.XPath("//label[contains(text(),'Activity Name')]/following::select[1]");


        private By assignedToDropdown = By.XPath("//div[@id='activitiesContentId']/descendant::label[contains(text(),'Assigned To')]/following::div[1]");

        private readonly By DownloadAttachmentManagerButton = By.XPath("//button[@title='Download Attachment Manager']");
        private readonly By DownloadAttachmentManagerPopup = By.XPath("//div[contains(@class, 'modal') or contains(@class, 'dialog') or contains(@class, 'popup')]");
        private readonly By DownloadAllAttachmentsButton = By.XPath("//div[contains(@class,'modal') or contains(@class,'dialog') or contains(@class,'popup')]//button[normalize-space()='Download All Attachments']");
        private readonly By DownloadButtonInAttachmentManagerPopup = By.XPath("//div[contains(@class,'modal') or contains(@class,'dialog') or contains(@class,'popup')]//button[contains(@id,'allAttachmentManagerTbl') and contains(normalize-space(),'Download')]");
        private readonly By DownloadConfirmYesButton = By.XPath("//div[contains(@class,'modal') or contains(@class,'dialog') or contains(@class,'popup')]//button[normalize-space()='Yes']");
        private readonly By DownloadAttachmentManagerCloseButton = By.XPath("//div[contains(@class,'modal') or contains(@class,'dialog') or contains(@class,'popup')]//button[contains(normalize-space(),'Close') or contains(@class,'close') or contains(@aria-label,'close')]");
        private readonly By ViewAttachmentButton = By.XPath("//button[@title='View Attachment']");
        private readonly By BackAttachmentButton = By.XPath("//button[@id='noteAttachmentBackButton']");
        private readonly By BackAttachmentButtonFallback = By.XPath("//button[@id='noteAttachmentBackButton' or normalize-space()='Back' or contains(@title,'Back')]");

        #endregion

        public Boolean isEditActivityPageDisplayed()
        {
            return Driver.FindElement(editActivityHeader).Displayed
                    && Driver.FindElement(activityNameField).Displayed
                    && Driver.FindElement(assignedToDropdown).Displayed;

        }
        public void ClickAttachmentTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, AttachmentTab, 10);
            Driver.FindElement(AttachmentTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        private By attachmentRow(String keyword)
        {
            return By.XPath("//tr[td[contains(normalize-space(),'" + keyword + "')]]");
        }

        //Getting lead create date

        public string getLeadCreationDate()
        {
            var value = "";
            if (leadCreationDate != null)
            {
                CommonHelpers.WaitForElementVisiblity(Driver, leadCreationDate, 30);

                value = Driver.FindElement(leadCreationDate).GetAttribute("value")?.Trim();
                Console.WriteLine($"Original Detection Date field value: {value}");

            }


            return value;
        }
        private bool isAttachmentDisplayed(String attachmentName)
        {
            try
            {

                attachmentRow(attachmentName);
               
                return true;
            }
            catch (TimeoutException )
            {
                return false;
            }
        }
        public string getLeadiD()
        {
            try
            {
                var attachment = Driver.FindElement(By.XPath("//fc-activity-note-attachment/descendant::label[@class='form-control darkNavy-fc title3 editSourceId headerFields']"));
                string leadid = attachment.Text;
                Console.WriteLine("Lead ID: " + leadid);
                return leadid;
            }
            catch (NoSuchElementException )
            {
                return null;
            }
        }
        public bool areAllRequiredAttachmentsDisplayed()
        {

            bool summaryDisplayed = isAttachmentDisplayed("ReferralSummary-'"+ getLeadiD() + "'");
            bool confirmationDisplayed = isAttachmentDisplayed("Confirmation");
            bool testFileDisplayed = isAttachmentDisplayed("TestFile");

            if (summaryDisplayed && confirmationDisplayed && testFileDisplayed)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void ClickExitActivity()
        {
            Driver.FindElement(ExitActivityButton).Click();
            CommonHelpers.WaitForPageLoading(Driver);
        }
        public void ClickLeadGridSearchInput()
        {
            Driver.FindElement(LeadGridSearchInput).Click();
        }

        public void ClickLeadTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTab, 120);            
            Driver.FindElement(LeadTab).Click();
        }
        public void SelectLeadSearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            //Driver.FindElement(LeadSearchCriteria).Click();
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadSearchCriteria), searchCriteria);

        }
        public void EnterLeadSearchCriteriaText(string searchCriteriaText)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadSearchTextBox, 100);
            Driver.FindElement(LeadSearchTextBox).SendKeys(searchCriteriaText);
        }
        public void ClickLeadActivitiesEdit()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);

            ClickWithFallback(
                By.XPath("(//button[@id='editActivityId' and not(@disabled)])[1]"),
                By.XPath("//*[@id='activityForm']//table[@rules='groups']//tr[1]//button[@id='editActivityId']"),
                ActivitiesEditButton
            );

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }
        public void ClickActivitiesBeginEditing()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForPageLoading(Driver);
            ClickWithFallback(ActivitiesBeginEditing, BeginEditing, LeadBeginEditingBtn);
        }
        public void ClickLeadActivitiesDetailsTab()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.SwitchtoNewWindow(Driver);
            Driver.FindElement(ActivitiesDetailsTab).Click();
        }
        public void ClickLeadActivitiesView()
        {
            Driver.FindElement(ActivitiesViewButton).Click();
        }
        public void ClickAddBtnNotes()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForPageLoading(Driver);

            ClickWithFallback(
                By.XPath("//trix-editor[@id='notes']/ancestor::fc-activity-note-attachment//button[@title='Add' or normalize-space()='Add' or .//span[normalize-space()='Add'] ]"),
                By.XPath("//trix-editor[@id='notes']/ancestor::div[contains(@id,'activity') or contains(@id,'note')][1]//button[@title='Add' or normalize-space()='Add' or .//span[normalize-space()='Add'] ]"),
                By.XPath("//div[@id='activitydetail']//button[@title='Add']"),
                By.XPath("//button[@title='Add' and contains(@class,'orangeBtn') and not(contains(@class,'disabled'))]"),
                AddBtnNotes,
                By.XPath("(//button[normalize-space()='Add' and not(@disabled)])[last()]")
            );

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }
        public void ClickAddNotesTextArea(string AddNotes)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);
            CommonHelpers.WaitForElementVisiblity(Driver, AddNotesTextArea, 100);
            Driver.FindElement(AddNotesTextArea).SendKeys(AddNotes);
        }
        public void ClickAddNotesSaveBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(AddNotesSaveBtn).Click();
        }
        public void ClickAddSaveConfirmYesbtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(AddSaveConfirmYesbtn).Click();
        }
        public void ClickLeadSearch()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            Driver.FindElement(LeadSearchButton).Click();
        }
        public void ClickLeadSearchClear()
        {
            Driver.FindElement(LeadSearchClearButton).Click();
        }
        public void ClickLeadIDLink()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDLink).Click();
        }
        public void ClickLeadIDLinkbyRow(int row)
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDLinkByRow(row)).Click();
            CommonHelpers.SwitchtoNewWindow(Driver);
        }
        public void ClickLeadIDFirstLink()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadIDFirstLink, 120);
            Driver.FindElement(LeadIDFirstLink).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }
        public void ClickLeadIDSecondLink()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            Driver.FindElement(LeadIDsecondLink).Click();
        }
        public void ClickBeginEditing()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            Driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {


            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, ActivitiesAttachmentTab, 50);
            Driver.FindElement(ActivitiesAttachmentTab).Click();
            CommonHelpers.WaitForPageLoading(Driver);
        }
        public void ClickActivitiesAddAttachmentBtn()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            CommonHelpers.WaitForElementVisiblity(Driver, ActivitiesAddAttachmentBtn, 20);
            ClickWithFallback(
                ActivitiesAddAttachmentBtn,
                By.XPath("//button[contains(normalize-space(),'Add Attachment') or .//span[contains(normalize-space(),'Add Attachment')]]")
            );
        }
        public void ClickLeadBeginEditingBtn()
        {
            CommonHelpers.WaitForPageLoading(Driver);
                        Driver.FindElement(LeadBeginEditingBtn).Click();
        }

        public void ClickAddActivityButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);

            var locators = new List<By>
            {
                By.XPath("//a[@id='addActivityId']"),
                By.XPath("//button[@id='addActivityId']"),
                By.XPath("//*[contains(@id,'addActivity') and (self::a or self::button)]"),
                By.XPath("//button[contains(normalize-space(),'Add Activity') or .//span[contains(normalize-space(),'Add Activity')]]"),
                By.XPath("//a[contains(normalize-space(),'Add Activity')]")
            };

            foreach (var locator in locators)
            {
                var elements = Driver.FindElements(locator);
                var element = elements.FirstOrDefault(e => e.Displayed && e.Enabled);
                if (element != null)
                {
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                    try
                    {
                        element.Click();
                    }
                    catch
                    {
                        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                    }
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                    return;
                }
            }

            throw new NoSuchElementException("Unable to locate Add Activity button using known locators.");
        }

        public void SelectAddActivityName(string activityName)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, AddActivityNameDropdown, 30);

            var requested = (activityName ?? string.Empty).Trim();
            var dropdownElement = Driver.FindElement(AddActivityNameDropdown);
            var dropdown = new SelectElement(dropdownElement);

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(_ => dropdown.Options.Count > 1);

            static string Normalize(string text)
            {
                return string.Join(" ", (text ?? string.Empty)
                    .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    .Trim()
                    .ToLowerInvariant();
            }

            if (!string.IsNullOrWhiteSpace(requested))
            {
                var byValue = dropdown.Options.FirstOrDefault(o =>
                    string.Equals((o.GetAttribute("value") ?? string.Empty).Trim(), requested, StringComparison.OrdinalIgnoreCase));

                if (byValue != null)
                {
                    byValue.Click();
                    return;
                }

                var normalizedRequested = Normalize(requested);

                var byExactText = dropdown.Options.FirstOrDefault(o =>
                    Normalize(o.Text) == normalizedRequested);

                if (byExactText != null)
                {
                    byExactText.Click();
                    return;
                }

                var byContainsText = dropdown.Options.FirstOrDefault(o =>
                    Normalize(o.Text).Contains(normalizedRequested));

                if (byContainsText != null)
                {
                    byContainsText.Click();
                    return;
                }
            }

            var availableOptions = string.Join(" | ", dropdown.Options.Select(o => o.Text.Trim()));
            throw new NoSuchElementException($"Activity name/value '{requested}' not found in dropdown. Available options: {availableOptions}");
        }

        public void ClickAddActivityContinueButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, AddActivityContinueButton, 30);
            ClickWithFallback(
                AddActivityContinueButton,
                By.XPath("//div[@id='activitydetail']//button[.//span[normalize-space()='Continue']]"),
                By.XPath("//div[@id='activitydetail']//button[contains(normalize-space(),'Continue')]"),
                By.XPath("//button[contains(@id,'continue') and not(@disabled)]")
            );
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickAddActivityAddButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, AddActivityAddButton, 30);
            ClickWithFallback(
                AddActivityAddButton,
                By.XPath("//div[@id='activitydetail']//button[.//span[normalize-space()='Add']]"),
                By.XPath("//div[@id='activitydetail']//button[contains(normalize-space(),'Add')]"),
                By.XPath("//button[contains(@id,'add') and not(@disabled)]")
            );
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickLeadDetailsTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);

            try
            {
                ClickWithFallback(
                    LeadDetailsTab,
                    By.XPath("//a[@id='leadDetailsId' or normalize-space()='Lead' or @role='link']"),
                    By.XPath("//*[@id='leadDetailsId' or @id='LeadTabId' or @id='leadTabId']")
                );
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                return;
            }
            catch (ElementNotInteractableException)
            {
                // Fall through to already-on-tab check
            }

            // If Lead tab is already active, lead fields are available and no tab click is required.
            var onLeadTab = Driver.FindElements(LeadTypeDropdown).Any(e => e.Displayed)
                            || Driver.FindElements(LeadStatusDropdown).Any(e => e.Displayed)
                            || Driver.FindElements(LeadSaveButton).Any(e => e.Displayed);

            if (!onLeadTab)
            {
                throw new ElementNotInteractableException("Unable to navigate to Lead tab. Lead tab element is not interactable and lead fields are not visible.");
            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickLeadBeginEditing()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                CommonHelpers.WaitForPageLoading(Driver);
                
                // Additional wait to ensure page is fully loaded after window switch
                System.Threading.Thread.Sleep(1500);
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);

                // First, check if we're already in edit mode (save button visible)
                var saveButton = Driver.FindElements(LeadSaveButton);
                if (saveButton.Any(e => e.Displayed && e.Enabled))
                {
                    Console.WriteLine("Already in edit mode - Save button is visible");
                    return;
                }

                // Attempt to find and click Begin Editing button with multiple strategies
                var beginEditingLocators = new []
                {
                    By.Id("leadViewEditEndButton"),
                    By.XPath("//button[@id='leadViewEditEndButton']"),
                    By.XPath("//button[@title='Begin Editing']"),
                    By.XPath("//button[normalize-space()='Begin Editing' and not(@disabled)]"),
                    By.XPath("//button[contains(normalize-space(),'Begin Editing')]"),
                    By.XPath("//div[@id='CaseDetailContentId']//button[contains(@class,'orangeBtn')]"),
                    By.XPath("//button[.//i[contains(@class,'fa-lock')]]"),
                    By.XPath("//a[@id='leadViewEditEndButton']"),
                    By.XPath("//a[contains(normalize-space(),'Begin Editing')]")
                };

                IWebElement beginEditButton = null;
                
                // Try to find the button with visual checks
                foreach (var locator in beginEditingLocators)
                {
                    var elements = Driver.FindElements(locator);
                    beginEditButton = elements.FirstOrDefault(e => 
                    {
                        try
                        {
                            return e.Displayed && e.Enabled;
                        }
                        catch
                        {
                            return false;
                        }
                    });

                    if (beginEditButton != null)
                    {
                        Console.WriteLine($"Found Begin Editing button using locator: {locator}");
                        break;
                    }
                }

                if (beginEditButton != null)
                {
                    // Scroll to the button
                    ((IJavaScriptExecutor)Driver).ExecuteScript(
                        "arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", 
                        beginEditButton);
                    
                    System.Threading.Thread.Sleep(500);

                    // Try normal click first
                    try
                    {
                        // Remove any overlaying elements that might intercept clicks
                        ((IJavaScriptExecutor)Driver).ExecuteScript(@"
                            var overlays = document.querySelectorAll('[role=""dialog""], [role=""presentation""], .modal-backdrop');
                            overlays.forEach(function(overlay) {
                                if (overlay.style.display !== 'none') {
                                    overlay.style.pointerEvents = 'none';
                                }
                            });
                        ");

                        System.Threading.Thread.Sleep(200);
                        beginEditButton.Click();
                        Console.WriteLine("Successfully clicked Begin Editing button");
                    }
                    catch (ElementClickInterceptedException ex)
                    {
                        Console.WriteLine($"Normal click intercepted, using JavaScript click: {ex.Message}");
                        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", beginEditButton);
                    }
                    catch (StaleElementReferenceException ex)
                    {
                        Console.WriteLine($"Stale element encountered, retrying: {ex.Message}");
                        // Element became stale, re-find and click
                        var retryElement = Driver.FindElements(By.XPath("//button[normalize-space()='Begin Editing']")).FirstOrDefault();
                        if (retryElement != null && retryElement.Displayed)
                        {
                            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", retryElement);
                        }
                    }

                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
                    System.Threading.Thread.Sleep(1000);
                    
                    return;
                }

                // If Begin Editing button not found, check if already in edit mode
                System.Threading.Thread.Sleep(1000);
                var editModeIndicators = Driver.FindElements(LeadSaveButton);
                if (editModeIndicators.Any(e => e.Displayed))
                {
                    Console.WriteLine("Already in edit mode - Save button is visible");
                    return;
                }

                // Last resort: check for any indicators of lead edit page
                var leadForm = Driver.FindElements(By.Id("leadForm"));
                if (leadForm.Any(e => e.Displayed))
                {
                    Console.WriteLine("Lead form found and displayed - may already be editable");
                    return;
                }

                throw new InvalidOperationException(
                    "Begin Editing button not found or not clickable. Expected to find a button with 'Begin Editing' text or id 'leadViewEditEndButton'. " +
                    "Page may already be in edit mode or the element is obscured.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in ClickLeadBeginEditing: {ex.Message}");
                throw;
            }
        }

        public void EnterLeadDescription(string leadDescription)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            System.Threading.Thread.Sleep(500);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadDescriptionEditor, 30);

            var editor = Driver.FindElement(LeadDescriptionEditor);
            
            // Scroll into view with extra space to ensure element is not at edge
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", editor);
            System.Threading.Thread.Sleep(300);

            // Try to click using normal click first
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0, -100);"); // Scroll up a bit to avoid overlays
                System.Threading.Thread.Sleep(200);
                editor.Click();
            }
            catch (ElementClickInterceptedException)
            {
                // If normal click fails, use JavaScript click
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", editor);
            }

            System.Threading.Thread.Sleep(200);

            // Clear existing content using JavaScript for better reliability
            ((IJavaScriptExecutor)Driver).ExecuteScript(@"
                var editor = arguments[0];
                editor.innerText = '';
                editor.textContent = '';
                var event = new Event('input', { bubbles: true });
                editor.dispatchEvent(event);
            ", editor);

            System.Threading.Thread.Sleep(100);

            // Send the new description
            editor.SendKeys(leadDescription);
            
            System.Threading.Thread.Sleep(300);
        }

        public void ClickLeadSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            ClickWithFallback(LeadSaveButton, By.XPath("//button[@id='leadSaveButton' or @title='Save' or normalize-space()='Save']"));
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickActivityAttachmentCloseBtn()
        {
            Driver.FindElement(ActivityAttachmentCloseBtn).Click();
            CommonHelpers.WaitForPageLoading(Driver);
        }

        public void ClickLeadcreateDateFilter()
        {
            CommonHelpers.WaitForPageToLoad(Driver, 100);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            CommonHelpers.ScrollDown(Driver);
            Driver.FindElement(LeadCreateDateFilter).Click();
        }

        public string getLeadFirstRowOrganizatioName()
        {
            var subjectname = Driver.FindElement(LeadOrgName).Text.Split(':')[1];
            var firsRowOrgName = subjectname.Split('-')[0];
            return firsRowOrgName;
        }

        public string getLeadSecondRowOrganizatioName()
        {
            var subjectname = Driver.FindElement(LeadOrgNameSecondRow).Text.Split(':')[1];
            var secondRowOrgName = subjectname.Split('-')[0];
            return secondRowOrgName;
        }

        public string getLeadFirstRowFirstAndLastNameName()
        {
            return Driver.FindElement(LeadSubFirstNameLastNameFirstRow).Text;
        }

        public string getLeadSecondRowFirstAndLastNameName()
        {
            return Driver.FindElement(LeadSubFirstNameLastNameSecondRow).Text;
        }

        public void waitForLeadTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTab, 120);
        }

        public void waitForLeadLink()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadIDLink, 120);
        }

        public void SelectLead(string selectleadId)
        {
            var tableRows = Driver.FindElements(By.XPath("//table/tbody/tr"));

            try
            {
                var selectedRow = tableRows.Where(row =>
                {
                    var selectedLeadId = row.FindElements(By.TagName("small"))[1].Text;
                    return selectleadId == selectedLeadId;
                }).First();

                var viewLeadButton = selectedRow.FindElements(By.TagName("small"))[1];
                CommonHelpers.ScrollByElementCoordinates(Driver, viewLeadButton);
                viewLeadButton.Click();
            }
            catch (NoSuchElementException) { }

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        public void BeginEditingLead()
        {
            try
            {
                if (Driver.FindElement(BeginEditing).Displayed)
                {
                    Driver.FindElement(BeginEditing).Click();
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
                }
            }
            catch (NoSuchElementException)
            {
                // already in Edit mode
            }
        }

        public void ExitLeadActivity()
        {
            try
            {
                if (Driver.FindElement(ExitLead).Displayed)
                {
                    Driver.FindElement(ExitLead).Click();
                    CommonHelpers.WaitForPageLoading(Driver);
                }
            }
            catch (NoSuchElementException)
            {
                // already closed
            }
        }

        public void ClickLeadActivityTab()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(ActivitiesDetailsTab).Click();
        }

        public void SearchActivityName(string activityName)
        {
            var selectCriteria = Driver.FindElement(By.XPath("//form[@id='activityForm']/descendant::input[@name='searchtext']"));
            selectCriteria.Clear();
            selectCriteria.SendKeys(activityName);
            Driver.FindElement(By.XPath("//form[@id='activityForm']/descendant::button[@id='searchStartButton']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        public void SearchByLeadID(string searchleadid)
        {
            var selectCriteria = new SelectElement(Driver.FindElement(By.Id("leadSearchCriteria")));
            searchleadid = searchleadid.Trim('"');
            selectCriteria.SelectByValue(searchleadid);
        }

        public void EnterLeadID(string leadID)
        {
            Driver.FindElement(LeadGridSearchInput).SendKeys(leadID);
            CommonHelpers.WaitForPageLoading(Driver);
        }

        public void ClickSearchButton()
        {
            Driver.FindElement(LeadGridSearchButton).Click();
            CommonHelpers.WaitForPageLoading(Driver);
        }

        public bool ClickOnEditActivity(string activityNme)
        {
            CommonHelpers.WaitForPageLoading(Driver);
            var countRows = Driver.FindElements(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr")).Count;

            for (int i = 0; i < countRows; i++)
            {
                var activityName = Driver.FindElement(ActivityNameByRow(i + 1)).Text;
                if (activityName.Equals(activityNme))
                {
                    ClickWithFallback(
                        LeadEditBtnByRow(i + 1),
                        By.XPath($"//*[@id='activityForm']//table[@rules='groups']//tr[{i + 1}]//button[@id='editActivityId' and not(@disabled)]")
                    );

                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
                    return true;
                }
            }

            return false;
        }

        public string GetActivityName()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr[1]/td[1]")).Text;
            return activityName;
        }

        public string getActivityDueDate()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            var activityduedate = Driver.FindElement(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr/td[4]")).Text;
            return activityduedate;
        }

        public void ClickUploadFileArrow(string filepath)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 700);");
            CommonHelpers.WaitForElementVisiblity(Driver, uploadFileArrow, 500);
            var fileUploadArea = Driver.FindElement(By.Id("fileLabel"));
            DropFile(fileUploadArea, filepath);
            js.ExecuteScript("window.scrollBy(0, 700);");
            CommonHelpers.WaitForPageLoading(Driver);
        }

        const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;";

        public void DropFile(IWebElement target, string filePath, double offsetX = 0, double offsetY = 0)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;
            IWebElement input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
            input.SendKeys(filePath);
        }

        public void ClickDownloadAttachmentManagerButton()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(DownloadAttachmentManagerButton));
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                System.Threading.Thread.Sleep(500);
                element.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("Download Attachment Manager button was not clickable.", ex);
            }
        }

        public bool IsDownloadAttachmentManagerPopupDisplayed()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(DownloadAttachmentManagerPopup));
                return Driver.FindElements(DownloadAttachmentManagerPopup).Count > 0;
            }
            catch (TimeoutException)
            {
                return false;
            }
        }

        public void ClickDownloadAllAttachments()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(DownloadAllAttachmentsButton));
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                System.Threading.Thread.Sleep(300);
                element.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("Download All Attachments button not clickable/available.", ex);
            }
        }

        public void ConfirmDownloadYes()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                var yes = wait.Until(ExpectedConditions.ElementToBeClickable(DownloadConfirmYesButton));
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", yes);
                System.Threading.Thread.Sleep(200);
                yes.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("Confirmation 'Yes' button not clickable/available.", ex);
            }
        }

        public void CloseDownloadAttachmentManagerPopup()
        {
            try
            {
                var closeButtons = Driver.FindElements(DownloadAttachmentManagerCloseButton);
                if (closeButtons.Any())
                {
                    closeButtons.First().Click();
                }
                else
                {
                    var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
                    actions.SendKeys(OpenQA.Selenium.Keys.Escape).Perform();
                }

                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(DownloadAttachmentManagerPopup));
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            }
            catch (WebDriverTimeoutException)
            {
                // ignore if popup still present
            }
        }

        public void ClickViewAttachmentButton()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(ViewAttachmentButton));
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                System.Threading.Thread.Sleep(300);
                element.Click();
                CommonHelpers.WaitForPageLoading(Driver);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("View Attachment button was not clickable/available.", ex);
            }
        }

        public bool IsAttachmentDetailsPageDisplayed()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(BackAttachmentButton));
                return Driver.FindElements(BackAttachmentButton).Count > 0;
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Attachment Details Page not displayed within 20 seconds");
                return false;
            }
        }

        public void ClickBackButton()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 40);

                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
                var element = wait.Until(d =>
                {
                    var candidates = d.FindElements(BackAttachmentButton);
                    if (!candidates.Any())
                    {
                        candidates = d.FindElements(BackAttachmentButtonFallback);
                    }

                    var btn = candidates.FirstOrDefault();
                    return (btn != null && btn.Displayed && btn.Enabled) ? btn : null;
                });

                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                System.Threading.Thread.Sleep(300);

                try
                {
                    element.Click();
                }
                catch (ElementClickInterceptedException)
                {
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                }
                catch (WebDriverException)
                {
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
                }

                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(BackAttachmentButton));
                CommonHelpers.WaitForPageLoading(Driver);
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("Back button was not clickable/available after 40 seconds.", ex);
            }
        }

        public bool IsAttachmentListViewDisplayed()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

                wait.Until(d =>
                {
                    var hasViewButton = d.FindElements(ViewAttachmentButton).Any();
                    var hasBackButton = d.FindElements(BackAttachmentButton).Any();
                    return hasViewButton && !hasBackButton;
                });

                return Driver.FindElements(ViewAttachmentButton).Any()
                    && !Driver.FindElements(BackAttachmentButton).Any();
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Attachment List View not displayed within 20 seconds");
                return false;
            }
        }

        public void ClickDownloadButtonInAttachmentManagerPopup()
        {
            try
            {
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(DownloadButtonInAttachmentManagerPopup));
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", element);
                System.Threading.Thread.Sleep(300);
                element.Click();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
            }
            catch (TimeoutException ex)
            {
                throw new InvalidOperationException("Download button in Download Attachment Manager popup was not clickable/available.", ex);
            }
        }

        public void SelectLeadType(string leadType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadTypeDropdown, 30);

            var dropdown = new SelectElement(Driver.FindElement(LeadTypeDropdown));
            var requested = (leadType ?? string.Empty).Trim();

            var byText = dropdown.Options.FirstOrDefault(o =>
                string.Equals(o.Text.Trim(), requested, StringComparison.OrdinalIgnoreCase)
                || o.Text.Contains(requested, StringComparison.OrdinalIgnoreCase));

            if (byText != null)
            {
                byText.Click();
                return;
            }

            throw new NoSuchElementException($"Lead Type '{requested}' not found.");
        }

        public void SelectLeadStatus(string leadStatus)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadStatusDropdown, 30);

            var dropdown = new SelectElement(Driver.FindElement(LeadStatusDropdown));
            var requested = (leadStatus ?? string.Empty).Trim();

            static string NormalizeLeadValue(string text)
            {
                return string.Join(" ", (text ?? string.Empty)
                    .Replace(" - ", "-")
                    .Replace("- ", "-")
                    .Replace(" -", "-")
                    .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    .Trim()
                    .ToLowerInvariant();
            }

            var normalizedRequested = NormalizeLeadValue(requested);

            var byExact = dropdown.Options.FirstOrDefault(o =>
                NormalizeLeadValue(o.Text) == normalizedRequested);

            if (byExact != null)
            {
                byExact.Click();
                return;
            }

            var byContains = dropdown.Options.FirstOrDefault(o =>
                NormalizeLeadValue(o.Text).Contains(normalizedRequested)
                || normalizedRequested.Contains(NormalizeLeadValue(o.Text)));

    if (byContains != null)
    {
        byContains.Click();
        return;
    }

    // Environment-safe fallback: status labels vary between "Test ... Default on Open" and "Open Lead - New"
    if (normalizedRequested.Contains("default on open") || normalizedRequested.Contains("open"))
    {
        var openFallback = dropdown.Options.FirstOrDefault(o =>
            NormalizeLeadValue(o.Text).Contains("open") || NormalizeLeadValue(o.Text).Contains("new"));

        if (openFallback != null)
        {
            openFallback.Click();
            return;
        }
    }

    var availableOptions = string.Join(" | ", dropdown.Options.Select(o => o.Text.Trim()));
    throw new NoSuchElementException($"Lead Status '{requested}' not found. Available options: {availableOptions}");
}

        private void SelectValueFromDropdownMenu(By menuButton, string value)
        {
            var requested = (value ?? string.Empty).Trim();
            ClickWithFallback(menuButton);

            var optionLocators = new[]
            {
                By.XPath($"//ul[contains(@class,'dropdown-menu') and contains(@class,'show')]//a[normalize-space()='{requested}']"),
                By.XPath($"//ul[contains(@class,'dropdown-menu') and contains(@class,'show')]//*[normalize-space()='{requested}']"),
                By.XPath($"//ul[contains(@class,'dropdown-menu')]//a[contains(normalize-space(),'{requested}')]"),
                By.XPath($"//ul[contains(@class,'dropdown-menu')]//*[contains(normalize-space(),'{requested}')]")
            };

            ClickWithFallback(optionLocators);
        }

        public void SelectLeadAssignedTo(string assignedTo)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            SelectValueFromDropdownMenu(LeadAssignedToDropdownButton, assignedTo);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void SelectLeadDepartmentDivision(string departmentDivision)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadDepartmentDivisionDropdown, 30);

            var dropdown = new SelectElement(Driver.FindElement(LeadDepartmentDivisionDropdown));
            var requested = (departmentDivision ?? string.Empty).Trim();

            var byText = dropdown.Options.FirstOrDefault(o =>
                string.Equals(o.Text.Trim(), requested, StringComparison.OrdinalIgnoreCase)
                || o.Text.Contains(requested, StringComparison.OrdinalIgnoreCase));

            if (byText != null)
            {
                byText.Click();
                return;
            }

            var availableOptions = string.Join(" | ", dropdown.Options.Select(o => o.Text.Trim()));
            throw new NoSuchElementException($"Department/Division '{requested}' not found. Available options: {availableOptions}");
        }

        public void SelectLeadSectionTeam(string sectionTeam)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadSectionTeamDropdown, 30);

            var dropdown = new SelectElement(Driver.FindElement(LeadSectionTeamDropdown));
            var requested = (sectionTeam ?? string.Empty).Trim();

            var byText = dropdown.Options.FirstOrDefault(o =>
                string.Equals(o.Text.Trim(), requested, StringComparison.OrdinalIgnoreCase)
                || o.Text.Contains(requested, StringComparison.OrdinalIgnoreCase));

            if (byText != null)
            {
                byText.Click();
                return;
            }

            var availableOptions = string.Join(" | ", dropdown.Options.Select(o => o.Text.Trim()));
            throw new NoSuchElementException($"Section/Team '{requested}' not found. Available options: {availableOptions}");
        }

        public void ClickLeadSubjectTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            ClickWithFallback(
                LeadSubjectTab,
                By.XPath("//a[@id='newSubjectTabId']"),
                By.XPath("//a[@id='leadSubjectTabId']"),
                By.XPath("//a[contains(normalize-space(),'Subject') and contains(@class,'blackText')]")
            );
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickLeadReasonTab()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            ClickWithFallback(LeadReasonTab);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickLeadReasonAddButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            ClickWithFallback(LeadReasonAddButton);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void SelectLeadReasonDetectionMethod(string detectionMethod)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadReasonDetectionMethodDropdown, 30);

            var dropdown = new SelectElement(Driver.FindElement(LeadReasonDetectionMethodDropdown));
            var requested = (detectionMethod ?? string.Empty).Trim();

            var byText = dropdown.Options.FirstOrDefault(o =>
                string.Equals(o.Text.Trim(), requested, StringComparison.OrdinalIgnoreCase)
                || o.Text.Contains(requested, StringComparison.OrdinalIgnoreCase));

            if (byText != null)
            {
                byText.Click();
                return;
            }

            var availableOptions = string.Join(" | ", dropdown.Options.Select(o => o.Text.Trim()));
            throw new NoSuchElementException($"Detection Method '{requested}' not found. Available options: {availableOptions}");
        }

        public void SelectLeadReasonSourceType(string sourceType)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            SelectValueFromDropdownMenu(LeadReasonSourceTypeDropdownButton, sourceType);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void SelectLeadReasonReason(string reason)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            SelectValueFromDropdownMenu(LeadReasonReasonDropdownButton, reason);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void EnterLeadReasonDescription(string description)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            CommonHelpers.WaitForElementVisiblity(Driver, LeadReasonDescriptionEditor, 30);

            var editor = Driver.FindElement(LeadReasonDescriptionEditor);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView({behavior: 'auto', block: 'center'});", editor);
            editor.Click();
            editor.SendKeys(Keys.Control + "a");
            editor.SendKeys(Keys.Delete);
            editor.SendKeys(description);
        }

        public void ClickLeadReasonSaveButton()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            ClickWithFallback(LeadReasonSaveButton);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
        }

        public void ClickSaveAndNavigateToSubjectTab()
        {
            ClickLeadSaveButton();
            ClickLeadSubjectTab();
        }
    }
}









































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































