using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.HeaderComponent
{
    public class HeaderComponent : BaseSettings
    {
        public HeaderComponent(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        //private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");


        #endregion

        //private IWebElement AlertsAndExportsButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='header-navbar-controls-collapse']//fc-app-header/span/span/i/img"));
        //    private IWebElement QuickSearchButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='header-navbar-controls-collapse']//fc-app-header/button"));
        //    private IWebElement SearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchId']"));
        //    private IWebElement LastNameSearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchLname']"));
        //    private IWebElement FirstNameSearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchFname']"));
        //    private IWebElement AddressSearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchAddress']"));
        //    private IWebElement CitySearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchCity']"));
        //    private IWebElement StateSearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchState']"));
        //    private IWebElement ZipSearchInput => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='searchZip']"));
        //    private IWebElement SearchButton => Driver.WrappedDriver.FindElement(By.XPath("//button[@id='btnSearch']"));
        //    private IWebElement SwitchPayorDropdown => Driver.WrappedDriver.FindElement(By.Id("payorSelector"));
        //private IWebElement UserMenu => Driver.WrappedDriver.FindElement(By.Id("optionSelector"));
        private readonly By UserDropdown = By.XPath("//a[@id='optionLogout']");
        //private readonly By UserMenu = By.XPath("//a[@id='optionLogout']");
        //    private IWebElement ApplyButton => Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Apply')]"));
        //    public string GetSelectedPayor => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='payorSelector']/li[@class='dropdown user-dropdown']/a/b[@class='ng-binding']")).Text;
        //    private IWebElement FileDownloadButton => Driver.WrappedDriver.FindElement(By.XPath("//*[@id='resultTable']/thead/tr/th[2]/button"));
        //    private IWebElement CloseQuickSearchButton => Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Close')]"));
        //    private IWebElement SwitchActivitiesAssignedToDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownActivityListUser"));
        //    private IWebElement SwitchActivitiesAssignedSupervisorDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownActivityLisSupervisor"));
        //    private IWebElement SwitchActivitiesDivisionsDepartmentsDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownActivityDepartment"));
        //    private IWebElement SwitchActivitiesLeadCaseTypeDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownLeadOrCaseType"));
        //    private IWebElement SwitchActivitiesStatusDropdown => Driver.WrappedDriver.FindElement(By.Id("acitivityStatus"));
        //    private IWebElement SwitchCasesAssignedToDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownCaseListUser"));
        //    private IWebElement SwitchCasesAssignedSupervisorDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownCaseListSupervisor"));
        //    private IWebElement SwitchCasesDivisionsDepartmentsDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownCaseDepartment"));
        //    private IWebElement SwitchCasesCaseTypeDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownCaseType"));
        //    private IWebElement SwitchCasesStatusDropdown => Driver.WrappedDriver.FindElement(By.Id("caseStatus"));
        //    private IWebElement SwitchLeadsAssignedToDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownLeadListUser"));
        //    private IWebElement SwitchLeadsAssignedSupervisorDropdown => Driver.WrappedDriver.FindElement(By.Id("dropdownLeadListSupervisor"));
        //    private IWebElement SwitchLeadsDivisionsDepartmentsDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownleadDepartment"));
        //    private IWebElement SwitchLeadsLeadTypeDropdown => Driver.WrappedDriver.FindElement(By.Id("dropDownLeadType"));
        //    private IWebElement SwitchLeadsStatusDropdown => Driver.WrappedDriver.FindElement(By.Id("leadStatus"));

        //    private readonly string FileDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        //    /// <summary>
        //    /// Switches the currently selected payor to the given.
        //    /// </summary>
        //    public void SwitchPayor(string name)
        //    {
        //        try
        //        {
        //            CloseQuickSearchButton.Click();
        //        }
        //        catch (NoSuchElementException)
        //        {

        //        }

        //        SwitchPayorDropdown.Click();
        //        var payor = Driver.WrappedDriver.FindElements(NgBy.Repeater("payor in payors"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();

        //        payor.Click();


        //        WaitForPageLoading();
        //    }

        //    /*
        //    public void DismissPayorAlert()
        //    {

        //        try
        //        {
        //            WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(30));
        //            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("//*[@id='content-wrapper']/div/div[1]/div[1]/div/label"), "Payor"));
        //            Driver.WrappedDriver.FindElement(By.ClassName("close")).Click();
        //        }
        //        catch (NoSuchElementException ex)
        //        {
        //            throw new NoSuchElementException("", ex);
        //        }
        //        catch (StaleElementReferenceException ex)
        //        {
        //            throw new StaleElementReferenceException("", ex);
        //        }
        //    }
        //    */

        //    public void DismissPayorAlert()
        //    {
        //        try
        //        {
        //            WebDriverWait waitForPayorAlert = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(5));
        //            waitForPayorAlert.Until(d =>
        //            {
        //                try
        //                {
        //                    var payorAlert = d.FindElement(By.XPath("//*[@id='content-wrapper']/div/div[1]/div[1]/div/label"));
        //                    return payorAlert.Displayed;
        //                }
        //                catch (NoSuchElementException)
        //                {
        //                    return false;
        //                }
        //                catch (StaleElementReferenceException)
        //                {
        //                    return false;
        //                }
        //            });

        //            Driver.WrappedDriver.FindElement(By.ClassName("close")).Click();
        //        }
        //        catch (WebDriverTimeoutException)
        //        {
        //            // no Payor Alert found, move along
        //        }
        //    }

        //    public void SearchHelpArticle(string title)
        //    {
        //        Driver.WrappedDriver.FindElement(By.XPath("//div[@id='header-navbar-controls-collapse']//ul//li//a//i")).Click();
        //        //WaitForPageLoading(120);
        //        WaitForPageLoading();
        //        var articleSearchInput = Driver.WrappedDriver.FindElement(By.Id("searchTitle"));
        //        articleSearchInput.Clear();
        //        articleSearchInput.SendKeys(title);
        //        Driver.WrappedDriver.FindElement(By.Id("btnSearch")).Click();
        //        //WaitForPageLoading(120);
        //        WaitForPageLoading();
        //        Driver.WrappedDriver.FindElement(By.XPath("//a[contains(text(),'Help Article With Attachments')]")).Click();
        //        //WaitForPageLoading(120);
        //        WaitForPageLoading();
        //    }

        //    public void ShowAlertsAndExports()
        //    {
        //        AlertsAndExportsButton.Click();
        //        WaitForPageLoading();
        //    }

        //    public bool NewClaimExportAppearsInAlertsAndExports(string title)
        //    {
        //        var waitForExport = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(120));
        //        string exportStatus = string.Empty;
        //        waitForExport.Until(d =>
        //        {
        //            try
        //            {
        //                var exports = Driver.WrappedDriver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
        //                var selectedExport = exports.Where(row =>
        //                {
        //                    var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
        //                    return title == selectedTitle;
        //                }).First();

        //                exportStatus = selectedExport.FindElements(By.TagName("td"))[0].Text.Trim();
        //                return true;
        //            }
        //            catch (WebDriverTimeoutException)
        //            {
        //                return false;
        //            }
        //        });

        //        while (!exportStatus.Equals("Complete"))
        //        {
        //            var refreshButton = Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Refresh')]"));
        //            refreshButton.Click();
        //            WaitForPageLoading();
        //            var exports = Driver.WrappedDriver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
        //            var selectedExport = exports.Where(row =>
        //            {
        //                var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
        //                return title == selectedTitle;
        //            }).First();

        //            exportStatus = selectedExport.FindElements(By.TagName("td"))[0].Text.Trim();
        //        }

        //        if (exportStatus.Equals("Complete"))
        //        {
        //            DeleteExport(title);
        //            CloseWindowHandles();
        //            return true;
        //        }
        //        else
        //        {
        //            CloseWindowHandles();
        //            return false;
        //        }
        //    }

        //    public void DeleteExport(string title)
        //    {
        //        var exports = Driver.WrappedDriver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
        //        var selectedExport = exports.Where(row =>
        //        {
        //            var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
        //            return title == selectedTitle;
        //        }).First();

        //        var deleteSelectedExportButton = selectedExport.FindElement(By.XPath("//tbody/tr[1]/td[4]/button[2]"));
        //        deleteSelectedExportButton.Click();
        //        var confirmDeleteExportButton = Driver.WrappedDriver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
        //        confirmDeleteExportButton.Click();
        //        WaitForPageLoading();
        //    }

        //    public void OpenQuickSearch()
        //    {
        //        Driver.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //        QuickSearchButton.Click();
        //    }

        //    public void SearchByProviderID(string queryProviderID)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Provider ID");
        //        SearchInput.SendKeys(queryProviderID);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByTaxID(string queryTaxID)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Provider TIN");
        //        SearchInput.SendKeys(queryTaxID);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByNPI(string queryNPI)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Provider NPI");
        //        SearchInput.SendKeys(queryNPI);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByPatientID(string queryPatientID)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Member ID");
        //        SearchInput.SendKeys(queryPatientID);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByProviderName(string queryLastName, string queryFirstName)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Provider Name");
        //        LastNameSearchInput.SendKeys(queryLastName);
        //        FirstNameSearchInput.SendKeys(queryFirstName);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByPatientName(string queryLastName, string queryFirstName)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Member Name");
        //        LastNameSearchInput.SendKeys(queryLastName);
        //        FirstNameSearchInput.SendKeys(queryFirstName);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByProviderAddress(string queryAddress, string queryCity, string queryState, string queryZip)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Provider Address");
        //        AddressSearchInput.SendKeys(queryAddress);
        //        CitySearchInput.SendKeys(queryCity);
        //        StateSearchInput.SendKeys(queryState);
        //        ZipSearchInput.SendKeys(queryZip);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByPatientAddress(string queryAddress, string queryCity, string queryState, string queryZip)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Member Address");
        //        AddressSearchInput.SendKeys(queryAddress);
        //        CitySearchInput.SendKeys(queryCity);
        //        StateSearchInput.SendKeys(queryState);
        //        ZipSearchInput.SendKeys(queryZip);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByClaimId(string queryClaimID)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Claim ID");
        //        SearchInput.SendKeys(queryClaimID);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByCaseId(string queryCaseId)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Case ID");
        //        SearchInput.SendKeys(queryCaseId);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchByLeadId(string queryLeadId)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Lead ID");
        //        SearchInput.SendKeys(queryLeadId);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void SearchCaseTrackingNotesAndAttachments(string querySearchKeyword)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Case Tracking Notes & Attachments");
        //        SearchInput.SendKeys(querySearchKeyword);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public void ViewFirstNote()
        //    {
        //        var firstViewButton = Driver.WrappedDriver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div[2]/div/div[1]/div[2]/table/tbody/tr[1]/td[5]/button"));
        //        ScrollByElementCoordinates(firstViewButton);
        //        firstViewButton.Click();
        //        WaitForPageLoading();
        //    }

        //    public bool NoteIsPresentInSearchResults(string searchKeyword)
        //    {
        //        var noteText = Driver.WrappedDriver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div[2]/div/div[2]/div/div/div")).Text;

        //        if (noteText.Contains(searchKeyword))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    public void SearchByActivityReferenceId(string queryActivityReferenceId)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Activity Reference ID");
        //        SearchInput.SendKeys(queryActivityReferenceId);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public string GetActivityReferenceId()
        //    {
        //        var activityReferenceIdText = Driver.WrappedDriver.FindElement(By.XPath("//div/activity-note-attachment/div/div[2]/div[3]/lable")).Text;

        //        if (string.IsNullOrWhiteSpace(activityReferenceIdText))
        //        {
        //            CloseWindowHandles();
        //            throw new Exception("Could not retrieve activity reference Id");
        //        }
        //        else
        //        {
        //            CloseWindowHandles();
        //            return activityReferenceIdText;
        //        }
        //    }

        //    public void SearchByDeconflictionReferenceId(string queryDeconflictionReferenceId)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Deconfliction Reference ID");
        //        SearchInput.SendKeys(queryDeconflictionReferenceId);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public string GetDeconflictionReferenceId()
        //    {
        //        var deconflictionReferenceIdText = Driver.WrappedDriver.FindElement(By.Id("referenceID")).GetAttribute("value");

        //        if (string.IsNullOrWhiteSpace(deconflictionReferenceIdText))
        //        {
        //            CloseWindowHandles();
        //            throw new Exception("Could not retrieve deconfliction reference Id");
        //        }
        //        else
        //        {
        //            CloseWindowHandles();
        //            return deconflictionReferenceIdText;
        //        }
        //    }

        //    public void SearchByLeadAndCaseSubjects(string queryLastName, string queryFirstName)
        //    {
        //        var selectCriteria = new SelectElement(Driver.WrappedDriver.FindElement(By.Id("criteria")));
        //        selectCriteria.SelectByValue("Lead & Case Subjects");
        //        var lastNameSearchInput = Driver.WrappedDriver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[1]/div[5]/input[2]"));
        //        lastNameSearchInput.SendKeys(queryLastName);
        //        var firstNameSearchInput = Driver.WrappedDriver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[1]/div[5]/input[3]"));
        //        firstNameSearchInput.SendKeys(queryFirstName);
        //        SearchButton.Click();
        //        WaitForSearchResultsLoading(30);
        //    }

        //    public bool FileIsPresent(string fileName)
        //    {
        //        ScrollAndCenterElement(FileDownloadButton);
        //        IJavaScriptExecutor jsExec = (IJavaScriptExecutor)Driver.WrappedDriver;
        //        jsExec.ExecuteScript("arguments[0].click();", FileDownloadButton);
        //        Task.Delay(15000).Wait();

        //        bool filePresent;

        //        if (Directory.Exists(FileDirectoryPath))
        //        {
        //            bool result = CheckFile(fileName);
        //            if (result == true)
        //            {
        //                filePresent = true;
        //                DeleteFile(fileName);
        //            }
        //            else
        //            {
        //                filePresent = false;
        //            }
        //            return filePresent;
        //        }
        //        else
        //        {
        //            return filePresent = false;
        //        }
        //    }

        //    public bool CheckFile(string fileName)
        //    {
        //        var filePath = FileDirectoryPath + "\\\\" + fileName + "";

        //        if (File.Exists(filePath))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    public void DeleteFile(string fileName)
        //    {
        //        var filePath = FileDirectoryPath + "\\\\" + fileName + "";

        //        if (File.Exists(filePath))
        //        {
        //            File.Delete(filePath);
        //        }
        //    }

        //    public void ViewMemberProfile(string memberId, PatientProfilePage patientProfilePage, bool useRightClick = false)
        //    {
        //        var profileButton = GetMemberProfileButtons().Where(button => button.Key.Equals(memberId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(profileButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            profileButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewProviderProfile(string providerId, ProviderProfilePage providerProfilePage, bool useRightClick = false)
        //    {
        //        var profileButton = GetProviderProfileButtons().Where(button => button.Key.Equals(providerId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(profileButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            profileButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewClaim(string claimId, ClaimViewPage claimViewPage, bool useRightClick = false)
        //    {
        //        var claimButton = GetClaimViewButtons().Where(button => button.Key.Equals(claimId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(claimButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            claimButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewCase(string caseId, CaseEditPage caseEditPage, bool useRightClick = false)
        //    {
        //        var caseButton = GetCaseViewButtons().Where(button => button.Key.Equals(caseId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(caseButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            caseButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewLead(string leadId, LeadEditPage leadEditPage, bool useRightClick = false)
        //    {
        //        var leadButton = GetLeadViewButtons().Where(button => button.Key.Equals(leadId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(leadButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            leadButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewActivity(string activityReferenceId, bool useRightClick = false)
        //    {
        //        var activityButton = GetActivityViewButtons().Where(button => button.Key.Equals(activityReferenceId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(activityButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            activityButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewDeconflictionRecord(string deconflictionReferenceId, bool useRightClick = false)
        //    {
        //        var deconflictionButton = GetDeconflictionViewButtons().Where(button => button.Key.Equals(deconflictionReferenceId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(deconflictionButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            deconflictionButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    public void ViewCaseSubject(string caseId, CaseEditPage caseEditPage, bool useRightClick = false)
        //    {
        //        var caseButton = GetCaseSubjectViewButtons().Where(button => button.Key.Equals(caseId)).First().Value;

        //        if (useRightClick)
        //        {
        //            var rightClickAction = new Actions(Driver.WrappedDriver);
        //            rightClickAction.ContextClick(caseButton).Perform();
        //            WaitForWindowHandles();
        //        }
        //        else
        //        {
        //            caseButton.Click();
        //            WaitForWindowHandles();
        //        }

        //        WaitForLoadingOverlayToDisappear();
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetMemberProfileButtons()
        //    {
        //        //var memberRows = Driver.WrappedDriver.FindElements(NgBy.Repeater("data in myData"));
        //        var memberRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = memberRows.Select(memberRow =>
        //        {
        //            //var memberIdText = memberRow.FindElement(By.XPath(".//td[2]/small[1]")).Text;
        //            var memberIdText = memberRow.FindElement(By.XPath(".//small[1]")).Text;
        //            //var memberId = memberIdText.Replace("Member Id: ", "").Substring(0, 6);
        //            var memberId = memberIdText.Replace("Member Id:", "");
        //            //var memberProfileButton = memberRow.FindElement(By.XPath(".//td[6]/span[2]/img"));
        //            var memberProfileButton = memberRow.FindElement(By.XPath("//table[2]/tbody/tr/td[5]/span[2]/img"));
        //            return new KeyValuePair<string, IWebElement>(memberId, memberProfileButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetProviderProfileButtons()
        //    {
        //        var providerRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = providerRows.Select(providerRow =>
        //        {
        //            var providerIdText = providerRow.FindElement(By.XPath(".//small[1]")).Text;
        //            var providerId = providerIdText.Replace("Provider Id:", "");
        //            var providerProfileButton = providerRow.FindElement(By.XPath("//table[2]/tbody/tr/td[5]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(providerId, providerProfileButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetClaimViewButtons()
        //    {
        //        var claimRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = claimRows.Select(claimRow =>
        //        {
        //            var claimId = claimRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //            var claimButton = claimRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(claimId, claimButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetCaseViewButtons()
        //    {
        //        var caseRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = caseRows.Select(caseRow =>
        //        {
        //            var caseId = caseRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //            var caseButton = caseRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(caseId, caseButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetLeadViewButtons()
        //    {
        //        var leadRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = leadRows.Select(leadRow =>
        //        {
        //            var leadId = leadRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //            var leadButton = leadRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(leadId, leadButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetActivityViewButtons()
        //    {
        //        var activityRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = activityRows.Select(activityRow =>
        //        {
        //            var activityId = activityRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //            var activityButton = activityRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(activityId, activityButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetDeconflictionViewButtons()
        //    {
        //        var deconflictionRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = deconflictionRows.Select(activityRow =>
        //        {
        //            var deconflictionReferenceId = activityRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //            var deconflictionButton = activityRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(deconflictionReferenceId, deconflictionButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    private IEnumerable<KeyValuePair<string, IWebElement>> GetCaseSubjectViewButtons()
        //    {
        //        var caseRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //        var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //        xPaths = caseRows.Select(caseRow =>
        //        {
        //            var caseId = caseRow.FindElement(By.XPath("//table[2]/tbody/tr[2]/td[1]/span[2]/small")).Text;
        //            var caseButton = caseRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //            return new KeyValuePair<string, IWebElement>(caseId, caseButton);
        //        }).ToList();

        //        return xPaths;
        //    }

        //    /*
        //    private void WaitForSearchResultsLoading(int seconds)
        //    {
        //        By alertDismissBtn = By.ClassName("close");
        //        WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(seconds));
        //        wait.Until(ExpectedConditions.ElementToBeClickable(alertDismissBtn));
        //    }
        //    */

        //    /// <summary>
        //    /// Takes the user to the settings page
        //    /// </summary>
        //    public void GoToSettings()
        //    {
        //        UserMenu.Click();
        //        var settingsButton = Driver.WrappedDriver.FindElement(By.Id("optionsettings"));
        //        settingsButton.Click();
        //        WaitForPageLoading();
        //    }

        //    public void ApplySettings()
        //    {
        //        ApplyButton.Click();
        //        WaitForPageLoading();
        //    }

        //    public bool CanViewAppliedSettings(string moduleName)
        //    {
        //        var getPageTitle = Driver.WrappedDriver.FindElement(By.XPath("//div[@class='HmsContainer']/h1")).Text.Trim();

        //        if (getPageTitle.Contains("Data Query & Extraction"))
        //        {
        //            GoToSettings();
        //            SetDefaultLandingPage(moduleName);
        //            ApplySettings();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    public void SetDefaultLandingPage(string moduleName)
        //    {
        //        switch (moduleName)
        //        {
        //            case "Administrator":
        //                var administratorRadioButton = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='default']/div[1]/div/input"));
        //                administratorRadioButton.Click();
        //                break;
        //            case "Custom Analysis & Reports":
        //                var customAnalysisAndReportsRadioButton = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='default']/div[2]/div/input"));
        //                customAnalysisAndReportsRadioButton.Click();
        //                break;
        //            case "Case Tracking":
        //                var caseTrackingRadioButton = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='default']/div[3]/div/input"));
        //                caseTrackingRadioButton.Click();
        //                break;
        //            case "Data Query & Extraction":
        //                var dataQueryAndExtractionRadioButton = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='default']/div[5]/div/input"));
        //                dataQueryAndExtractionRadioButton.Click();
        //                break;
        //            case "Guided Analytics":
        //                var guidedAnalyticsRadioButton = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='default']/div[6]/div/input"));
        //                guidedAnalyticsRadioButton.Click();
        //                break;
        //        }
        //    }

        //    public void SetCaseTrackingListDefaultFilters(string name)
        //    {
        //        var caseTrackingListDefaultsTab = Driver.WrappedDriver.FindElement(By.XPath("//*[@id='content-wrapper']/div/div[2]/div/div/user-settings/div/div/div/div[2]/ul/li[2]/a"));
        //        caseTrackingListDefaultsTab.Click();
        //        WaitForPageLoading();

        //        IWebElement user;

        //        SwitchActivitiesAssignedToDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activitiesAssignedTo']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchActivitiesAssignedSupervisorDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activitiesAssignedToSupervisor']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchActivitiesDivisionsDepartmentsDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='activityDdepartment']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchActivitiesLeadCaseTypeDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadOrCaseTypeListDiv']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchActivitiesStatusDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='acitivityStatus']/option"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchCasesAssignedToDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='caseListAssignedTo']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchCasesAssignedSupervisorDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='caseListAssignedToSupervisor']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchCasesDivisionsDepartmentsDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='caseDepartment']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchCasesCaseTypeDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='caseTypeListDiv']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchCasesStatusDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='caseStatus']/option"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchLeadsAssignedToDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadListAssignedTo']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchLeadsAssignedSupervisorDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadListAssignedToSupervisor']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchLeadsDivisionsDepartmentsDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadDepartment']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchLeadsLeadTypeDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadTypeListDiv']/li/a"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();

        //        SwitchLeadsStatusDropdown.Click();
        //        user = Driver.WrappedDriver.FindElements(By.XPath("//*[@id='leadStatus']/option"))
        //            .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
        //            .FirstOrDefault();
        //        WaitForPageLoading();
        //        user.Click();
        //    }
        //public void ClickUserDropdown()
        //{
        //    Driver.FindElement(UserDropdown).Click();
        //}

        /// <summary>
        /// Logs the user out from the user panel in the page header
        /// </summary>
        public void Logout()
        {
            Driver.FindElement(UserDropdown).Click();
            var logoutButton = Driver.FindElement(By.XPath("//a[@id='optionLogout']"));
            logoutButton.Click();
        }
    }
}
