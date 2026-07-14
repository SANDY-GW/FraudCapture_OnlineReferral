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

        private readonly By BeginEditing = By.XPath("//*[@id='leadViewEditEndButton']");
        private readonly By ExitLead = By.XPath("//*[@id='closeBtn']");


        private readonly By ActivitiesDetailsTab = By.XPath("//a[@id='activitiesDetailsTabId']");
        private readonly By ActivitiesBeginEditing = By.XPath("//button[@id='leadViewEditEndButton']");

        private readonly By ActivitiesEditButton = By.XPath("(//button[@id='editActivityId'])[3]");
        private readonly By ActivitiesViewButton = By.XPath("//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')]");
        private readonly By AddBtnNotes = By.XPath("//button[(text()=' Add ')])");
        private readonly By AddNotesTextArea = By.XPath("//trix-editor[@id='notes']");
        private readonly By AddNotesSaveBtn = By.XPath("( //button[(text()=' Save ' )])[2]");
        private readonly By AddSaveConfirmYesbtn = By.XPath("//button[(text()='Yes' )]");
        private readonly By ActivitiesAttachmentTab = By.XPath("//a[@id='attachmentTabId']");
        private readonly By ActivitiesAddAttachmentBtn = By.XPath("//button[contains(text(),'Add Attachment')]");
        private readonly By uploadFileArrow = By.XPath("//label[contains(text(),'Choose a File or Drag Files To Upload')]");
        private readonly By ActivityAttachmentCloseBtn= By.XPath("//img[@class='ActivityIndicator float-end ng-star-inserted']");

        private readonly By AttachmentTab = By.XPath("//div[@id='noteAttachmentList']/descendant::ul//li/a[contains(text(),'Attachments')]");
        private readonly By ExitActivityButton = By.XPath("//div[@id='attachment']/descendant::button[text()='Exit Activity']");
        private readonly By leadCreationDate = By.XPath("//input[@name='leadDate']");
        private readonly By activityDuedate = By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr/td[4]");
        // Page verification locators
        private By editActivityHeader =By.XPath("//b[text()='Edit Activity']");

        private By activityNameField = By.XPath("//label[contains(text(),'Activity Name')]/following::select[1]");


        private By assignedToDropdown = By.XPath("//div[@id='activitiesContentId']/descendant::label[contains(text(),'Assigned To')]/following::div[1]");



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
            Driver.FindElement(ActivitiesEditButton).Click();
        }
        public void ClickActivitiesBeginEditing()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            Driver.FindElement(ActivitiesBeginEditing).Click();
        }
        public void ClickLeadActivitiesDetailsTab()
        {
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);
            Driver.FindElement(ActivitiesDetailsTab).Click();
        }
        public void ClickLeadActivitiesView()
        {
            Driver.FindElement(ActivitiesViewButton).Click();
        }
        public void ClickAddBtnNotes()
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
            Driver.FindElement(AddBtnNotes).Click();
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
            Driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {
            
            Driver.FindElement(ActivitiesAttachmentTab).Click();
        }
        public void ClickActivitiesAddAttachmentBtn()
        {
            Driver.FindElement(ActivitiesAddAttachmentBtn).Click();
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

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

        }
        public void waitForLeadLink()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadIDLink, 120);

            // CommonHelpers.WaitForElementVisiblity(Driver, goToPreviousSectionButton, 15000);

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
          //  var common = new CommonHelpers(Driver);
          //common.WaitForLoadingOverlayToDisappear();
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
                //already in Edit mode, move along
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
                //already in Edit mode, move along
            }
        }
        public void ClickLeadActivityTab()
        {
            //  WaitForPageLoading();
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(ActivitiesDetailsTab).Click();
           
        }


        //serach for the activity created through online referral

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
            searchleadid=searchleadid.Trim('"');
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
            var fc = new FC_CaseTracking_LeadPage(Driver);           
            CommonHelpers.WaitForPageLoading(Driver);
            var countRows = Driver.FindElements(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr")).Count;
            
            for (int i = 0; i < countRows; i++)
            {
               // var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr[" + (i + 1) + "]/td[1]")).Text;
                var activityName = Driver.FindElement(ActivityNameByRow(i+1)).Text;               
                if (activityName.Equals(activityNme))
                {
                    Driver.FindElement(LeadEditBtnByRow(i+1)).Click();           
                    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver,50);
                    return true;                    
                }
            }
            return false;
           // var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr[1]/td[1]")).Text;
            
        }
        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            CommonHelpers.WaitForPageLoading(Driver);            
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']//table[@rules='groups']/tbody/tr[1]/td[1]")).Text;
            return activityName;

        }

        public string getActivityDueDate()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
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

    }
}

