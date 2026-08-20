using FC_OnlineReferral;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FC_OnlineReferral.FraudCapture_Pages.HeaderComponent
{
    public class HeaderComponent : BaseSettings
{
    public HeaderComponent(IWebDriver driver) : base(driver) { }
    #region Elements
    private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");


        #endregion

        private readonly By AlertsAndExportsButton = By.XPath("//*[@id='header-navbar-controls-collapse']//fc-app-header/span/span/i/img");
        private readonly By QuickSearchButton = By.XPath("//*[@id='header-navbar-controls-collapse']//fc-app-header/button");
        private readonly By SearchInput = By.XPath("//*[@id='searchId']");
        private readonly By LastNameSearchInput = By.XPath("//*[@id='searchLname']");
        private readonly By FirstNameSearchInput = By.XPath("//*[@id='searchFname']");
        private readonly By AddressSearchInput = By.XPath("//*[@id='searchAddress']");
        private readonly By CitySearchInput = By.XPath("//*[@id='searchCity']");
        private readonly By StateSearchInput = By.XPath("//*[@id='searchState']");
        private readonly By ZipSearchInput = By.XPath("//*[@id='searchZip']");
        private readonly By SearchButton = By.XPath("//button[@id='btnSearch']");

        private readonly string FileDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private readonly By SwitchPayorDropdown = By.Id("payorSelector");
        private readonly By UserMenu = By.Id("optionSelector");
        private readonly By UserDropdown = By.XPath("//a[@id='optionLogout']");

        private readonly By ApplyButton = By.XPath("//button[contains(text(),'Apply')]");

        public string GetSelectedPayor => driver.FindElement(By.XPath("//*[@id='payorSelector']/li[@class='dropdown user-dropdown']/a/b[@class='ng-binding']")).Text;
        private readonly By FileDownloadButton = By.XPath("//*[@id='resultTable']/thead/tr/th[2]/button");
        private readonly By CloseQuickSearchButton = By.XPath("//button[contains(text(),'Close')]");

        private readonly By SwitchActivitiesAssignedToDropdown = By.Id("dropdownActivityListUser");
        private readonly By SwitchActivitiesAssignedSupervisorDropdown = By.Id("dropdownActivityLisSupervisor");
        private readonly By SwitchActivitiesDivisionsDepartmentsDropdown = By.Id("dropDownActivityDepartment");
        private readonly By SwitchActivitiesLeadCaseTypeDropdown = By.Id("dropDownLeadOrCaseType");
        private readonly By SwitchActivitiesStatusDropdown = By.Id("acitivityStatus");

        private readonly By SwitchCasesAssignedToDropdown = By.Id("dropdownCaseListUser");
        private readonly By SwitchCasesAssignedSupervisorDropdown = By.Id("dropdownCaseListSupervisor");
        private readonly By SwitchCasesDivisionsDepartmentsDropdown = By.Id("dropDownCaseDepartment");
        private readonly By SwitchCasesCaseTypeDropdown = By.Id("dropDownCaseType");
        private readonly By SwitchCasesStatusDropdown = By.Id("caseStatus");

        private readonly By SwitchLeadsAssignedToDropdown = By.Id("dropdownLeadListUser");
        private readonly By SwitchLeadsAssignedSupervisorDropdown = By.Id("dropdownLeadListSupervisor");
        private readonly By SwitchLeadsDivisionsDepartmentsDropdown = By.Id("dropDownleadDepartment");
        private readonly By SwitchLeadsLeadTypeDropdown = By.Id("dropDownLeadType");
        private readonly By SwitchLeadsStatusDropdown = By.Id("leadStatus");


        /// <summary>
        /// Switches the currently selected payor to the given.
        /// </summary>
        public void SwitchPayor(string name)
        {            try
            {
                driver.FindElement(CloseQuickSearchButton).Click();
            }
            catch (NoSuchElementException)
            {

            }

            driver.FindElement(SwitchPayorDropdown).Click();
            var payor = driver.FindElements(By.XPath("//*[contains(@ng-repeat,'payor in payors')]"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();

            payor.Click();


           CommonHelpers.WaitForPageLoading(driver);
        }

        public void CloseQuickSearch()
        {
            try
            {
                driver.FindElement(CloseQuickSearchButton).Click();
            }
            catch (NoSuchElementException)
            {
            }
        }

        /*
        public void DismissPayorAlert()
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("//*[@id='content-wrapper']/div/div[1]/div[1]/div/label"), "Payor"));
                Driver.WrappedDriver.FindElement(By.ClassName("close")).Click();
            }
            catch (NoSuchElementException ex)
            {
                throw new NoSuchElementException("", ex);
            }
            catch (StaleElementReferenceException ex)
            {
                throw new StaleElementReferenceException("", ex);
            }
        }
        */

        public void DismissPayorAlert()
        {
            try
            {
                WebDriverWait waitForPayorAlert = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                waitForPayorAlert.Until(d =>
                {
                    try
                    {
                        var payorAlert = d.FindElement(By.XPath("//*[@id='content-wrapper']/div/div[1]/div[1]/div/label"));
                        return payorAlert.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                });

                driver.FindElement(By.ClassName("close")).Click();
            }
            catch (WebDriverTimeoutException)
            {
                // no Payor Alert found, move along
            }
        }

        public void SearchHelpArticle(string title)
        {
            driver.FindElement(By.XPath("//div[@id='header-navbar-controls-collapse']//ul//li//a//i")).Click();
            //WaitForPageLoading(120);
            CommonHelpers.WaitForPageLoading(driver);
            var articleSearchInput = driver.FindElement(By.Id("searchTitle"));
            articleSearchInput.Clear();
            articleSearchInput.SendKeys(title);
            driver.FindElement(By.Id("btnSearch")).Click();
            //WaitForPageLoading(120);
            CommonHelpers.WaitForPageLoading(driver);
            driver.FindElement(By.XPath("//a[contains(text(),'Help Article With Attachments')]")).Click();
            //WaitForPageLoading(120);
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void ShowAlertsAndExports()
        {
            driver.FindElement(AlertsAndExportsButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public bool NewClaimExportAppearsInAlertsAndExports(string title)
        {
            var waitForExport = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            string exportStatus = string.Empty;
            waitForExport.Until(d =>
            {
                try
                {
                    var exports = driver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
                    var selectedExport = exports.Where(row =>
                    {
                        var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
                        return title == selectedTitle;
                    }).First();

                    exportStatus = selectedExport.FindElements(By.TagName("td"))[0].Text.Trim();
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    return false;
                }
            });

            while (!exportStatus.Equals("Complete"))
            {
                var refreshButton = driver.FindElement(By.XPath("//button[contains(text(),'Refresh')]"));
                refreshButton.Click();
                CommonHelpers.WaitForPageLoading(driver);
                var exports = driver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
                var selectedExport = exports.Where(row =>
                {
                    var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
                    return title == selectedTitle;
                }).First();

                exportStatus = selectedExport.FindElements(By.TagName("td"))[0].Text.Trim();
            }

            if (exportStatus.Equals("Complete"))
            {
                DeleteExport(title);
                    CommonHelpers.CloseWindowHandles(driver);
                return true;
            }
            else
            {
                CommonHelpers.CloseWindowHandles(driver);
                return false;
            }
        }

        public void DeleteExport(string title)
        {
            var exports = driver.FindElements(By.XPath("/html/body/modal-container/div[2]/div/div[2]/table/tbody/tr"));
            var selectedExport = exports.Where(row =>
            {
                var selectedTitle = row.FindElements(By.TagName("td"))[2].Text.Trim();
                return title == selectedTitle;
            }).First();

            var deleteSelectedExportButton = selectedExport.FindElement(By.XPath("//tbody/tr[1]/td[4]/button[2]"));
            deleteSelectedExportButton.Click();
            var confirmDeleteExportButton = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            confirmDeleteExportButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public void OpenQuickSearch()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(QuickSearchButton).Click();
        }

        public void SearchByProviderID(string queryProviderID)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Provider ID");
            driver.FindElement(SearchInput).SendKeys(queryProviderID);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver, 30);
        }

        public void SearchByTaxID(string queryTaxID)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Provider TIN");
            driver.FindElement(SearchInput).SendKeys(queryTaxID);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByNPI(string queryNPI)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Provider NPI");
            driver.FindElement(SearchInput).SendKeys(queryNPI);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByPatientID(string queryPatientID)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Member ID");
            driver.FindElement(SearchInput).SendKeys(queryPatientID);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByProviderName(string queryLastName, string queryFirstName)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Provider Name");
            driver.FindElement(LastNameSearchInput).SendKeys(queryLastName);
            driver.FindElement(FirstNameSearchInput).SendKeys(queryFirstName);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByPatientName(string queryLastName, string queryFirstName)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Member Name");
            driver.FindElement(LastNameSearchInput).SendKeys(queryLastName);
            driver.FindElement(FirstNameSearchInput).SendKeys(queryFirstName);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByProviderAddress(string queryAddress, string queryCity, string queryState, string queryZip)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Provider Address");
            driver.FindElement(AddressSearchInput).SendKeys(queryAddress);
            driver.FindElement(CitySearchInput).SendKeys(queryCity);
            driver.FindElement(StateSearchInput).SendKeys(queryState);
            driver.FindElement(ZipSearchInput).SendKeys(queryZip);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByPatientAddress(string queryAddress, string queryCity, string queryState, string queryZip)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Member Address");
            driver.FindElement(AddressSearchInput).SendKeys(queryAddress);
            driver.FindElement(CitySearchInput).SendKeys(queryCity);
            driver.FindElement(StateSearchInput).SendKeys(queryState);
            driver.FindElement(ZipSearchInput).SendKeys(queryZip);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByClaimId(string queryClaimID)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Claim ID");
            driver.FindElement(SearchInput).SendKeys(queryClaimID);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByCaseId(string queryCaseId)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Case ID");
            driver.FindElement(SearchInput).SendKeys(queryCaseId);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchByLeadId(string queryLeadId)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Lead ID");
            driver.FindElement(SearchInput).SendKeys(queryLeadId);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void SearchCaseTrackingNotesAndAttachments(string querySearchKeyword)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Case Tracking Notes & Attachments");
            driver.FindElement(SearchInput).SendKeys(querySearchKeyword);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public void ViewFirstNote()
        {
            var firstViewButton = driver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div[2]/div/div[1]/div[2]/table/tbody/tr[1]/td[5]/button"));
            CommonHelpers.ScrollByElementCoordinates(driver, firstViewButton);
            firstViewButton.Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        public bool NoteIsPresentInSearchResults(string searchKeyword)
        {
            var noteText = driver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div[2]/div/div[2]/div/div/div")).Text;

            if (noteText.Contains(searchKeyword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SearchByActivityReferenceId(string queryActivityReferenceId)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Activity Reference ID");
            driver.FindElement(SearchInput).SendKeys(queryActivityReferenceId);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public string GetActivityReferenceId()
        {
            var activityReferenceIdText = driver.FindElement(By.XPath("//div/activity-note-attachment/div/div[2]/div[3]/lable")).Text;

            if (string.IsNullOrWhiteSpace(activityReferenceIdText))
            {
                CommonHelpers.CloseWindowHandles(driver);
                throw new Exception("Could not retrieve activity reference Id");
            }
            else
            {
                CommonHelpers.CloseWindowHandles(driver);
                return activityReferenceIdText;
            }
        }

        public void SearchByDeconflictionReferenceId(string queryDeconflictionReferenceId)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Deconfliction Reference ID");
            driver.FindElement(SearchInput).SendKeys(queryDeconflictionReferenceId);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public string GetDeconflictionReferenceId()
        {
            var deconflictionReferenceIdText = driver.FindElement(By.Id("referenceID")).GetAttribute("value");

            if (string.IsNullOrWhiteSpace(deconflictionReferenceIdText))
            {
                CommonHelpers.CloseWindowHandles(driver);
                throw new Exception("Could not retrieve deconfliction reference Id");
            }
            else
            {
                CommonHelpers.CloseWindowHandles(driver);
                return deconflictionReferenceIdText;
            }
        }

        public void SearchByLeadAndCaseSubjects(string queryLastName, string queryFirstName)
        {
            var selectCriteria = new SelectElement(driver.FindElement(By.Id("criteria")));
            selectCriteria.SelectByValue("Lead & Case Subjects");
            var lastNameSearchInput = driver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[1]/div[5]/input[2]"));
            lastNameSearchInput.SendKeys(queryLastName);
            var firstNameSearchInput = driver.FindElement(By.XPath("/html/body/modal-container/div[2]/div/div/div/div[1]/div[2]/div/div[1]/div[5]/input[3]"));
            firstNameSearchInput.SendKeys(queryFirstName);
            driver.FindElement(SearchButton).Click();
            CommonHelpers.WaitForSearchResultsLoading(driver,30);
        }

        public bool FileIsPresent(string fileName)
        {
            var fileDownloadButtonElement = driver.FindElement(FileDownloadButton);
            CommonHelpers.CommonScrollAndCenterElement(driver, fileDownloadButtonElement);
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)driver;
            jsExec.ExecuteScript("arguments[0].click();", fileDownloadButtonElement);
            Task.Delay(15000).Wait();

            bool filePresent;

            if (Directory.Exists(FileDirectoryPath))
            {
                bool result = CheckFile(fileName);
                if (result == true)
                {
                    filePresent = true;
                    DeleteFile(fileName);
                }
                else
                {
                    filePresent = false;
                }
                return filePresent;
            }
            else
            {
                return filePresent = false;
            }
        }

        public bool CheckFile(string fileName)
        {
            var filePath = FileDirectoryPath + "\\\\" + fileName + "";

            if (File.Exists(filePath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteFile(string fileName)
        {
            var filePath = FileDirectoryPath + "\\\\" + fileName + "";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        //public void ViewMemberProfile(string memberId, PatientProfilePage patientProfilePage, bool useRightClick = false)
        //{
        //    var profileButton = GetMemberProfileButtons().Where(button => button.Key.Equals(memberId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(profileButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        profileButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewLead(string leadId, LeadEditPage leadEditPage, bool useRightClick = false)
        //{
        //    var leadButton = GetLeadViewButtons().Where(button => button.Key.Equals(leadId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(driver);
        //        rightClickAction.ContextClick(leadButton).Perform();
        //        CommonHelpers.WaitForWindowHandles(driver);
        //    }
        //    else
        //    {
        //        leadButton.Click();
        //        CommonHelpers.WaitForWindowHandles(driver);
        //    }

        //    CommonHelpers.WaitForLoadingOverlayToDisappear(driver,30);
        //}

        //public void ViewProviderProfile(string providerId, ProviderProfilePage providerProfilePage, bool useRightClick = false)
        //{
        //    var profileButton = GetProviderProfileButtons().Where(button => button.Key.Equals(providerId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(profileButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        profileButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewClaim(string claimId, ClaimViewPage claimViewPage, bool useRightClick = false)
        //{
        //    var claimButton = GetClaimViewButtons().Where(button => button.Key.Equals(claimId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(claimButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        claimButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewCase(string caseId, CaseEditPage caseEditPage, bool useRightClick = false)
        //{
        //    var caseButton = GetCaseViewButtons().Where(button => button.Key.Equals(caseId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(caseButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        caseButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();Click)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(leadButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        leadButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewActivity(string activityReferenceId, bool useRightClick = false)
        //{
        //    var activityButton = GetActivityViewButtons().Where(button => button.Key.Equals(activityReferenceId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(activityButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        activityButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewDeconflictionRecord(string deconflictionReferenceId, bool useRightClick = false)
        //{
        //    var deconflictionButton = GetDeconflictionViewButtons().Where(button => button.Key.Equals(deconflictionReferenceId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(deconflictionButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        deconflictionButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //public void ViewCaseSubject(string caseId, CaseEditPage caseEditPage, bool useRightClick = false)
        //{
        //    var caseButton = GetCaseSubjectViewButtons().Where(button => button.Key.Equals(caseId)).First().Value;

        //    if (useRightClick)
        //    {
        //        var rightClickAction = new Actions(Driver.WrappedDriver);
        //        rightClickAction.ContextClick(caseButton).Perform();
        //        WaitForWindowHandles();
        //    }
        //    else
        //    {
        //        caseButton.Click();
        //        WaitForWindowHandles();
        //    }

        //    WaitForLoadingOverlayToDisappear();
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetMemberProfileButtons()
        //{
        //    //var memberRows = Driver.WrappedDriver.FindElements(NgBy.Repeater("data in myData"));
        //    var memberRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = memberRows.Select(memberRow =>
        //    {
        //        //var memberIdText = memberRow.FindElement(By.XPath(".//td[2]/small[1]")).Text;
        //        var memberIdText = memberRow.FindElement(By.XPath(".//small[1]")).Text;
        //        //var memberId = memberIdText.Replace("Member Id: ", "").Substring(0, 6);
        //        var memberId = memberIdText.Replace("Member Id:", "");
        //        //var memberProfileButton = memberRow.FindElement(By.XPath(".//td[6]/span[2]/img"));
        //        var memberProfileButton = memberRow.FindElement(By.XPath("//table[2]/tbody/tr/td[5]/span[2]/img"));
        //        return new KeyValuePair<string, IWebElement>(memberId, memberProfileButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetProviderProfileButtons()
        //{
        //    var providerRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = providerRows.Select(providerRow =>
        //    {
        //        var providerIdText = providerRow.FindElement(By.XPath(".//small[1]")).Text;
        //        var providerId = providerIdText.Replace("Provider Id:", "");
        //        var providerProfileButton = providerRow.FindElement(By.XPath("//table[2]/tbody/tr/td[5]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(providerId, providerProfileButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetClaimViewButtons()
        //{
        //    var claimRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = claimRows.Select(claimRow =>
        //    {
        //        var claimId = claimRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //        var claimButton = claimRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(claimId, claimButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetCaseViewButtons()
        //{
        //    var caseRows = Driver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = caseRows.Select(caseRow =>
        //    {
        //        var caseId = caseRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //        var caseButton = caseRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(caseId, caseButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetLeadViewButtons()
        //{
        //    var leadRows = Driver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = leadRows.Select(leadRow =>
        //    {
        //        var leadId = leadRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //        var leadButton = leadRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(leadId, leadButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetActivityViewButtons()
        //{
        //    var activityRows = Driver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = activityRows.Select(activityRow =>
        //    {
        //        var activityId = activityRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //        var activityButton = activityRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(activityId, activityButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetDeconflictionViewButtons()
        //{
        //    var deconflictionRows = Driver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = deconflictionRows.Select(activityRow =>
        //    {
        //        var deconflictionReferenceId = activityRow.FindElement(By.XPath("//span[@class='ui-select-highlight']")).Text;
        //        var deconflictionButton = activityRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(deconflictionReferenceId, deconflictionButton);
        //    }).ToList();

        //    return xPaths;
        //}

        //private IEnumerable<KeyValuePair<string, IWebElement>> GetCaseSubjectViewButtons()
        //{
        //    var caseRows = Driver.WrappedDriver.FindElements(By.XPath("//table[2]/tbody/tr"));

        //    var xPaths = new List<KeyValuePair<string, IWebElement>>();
        //    xPaths = caseRows.Select(caseRow =>
        //    {
        //        var caseId = caseRow.FindElement(By.XPath("//table[2]/tbody/tr[2]/td[1]/span[2]/small")).Text;
        //        var caseButton = caseRow.FindElement(By.XPath("//table[2]/tbody/tr/td[2]/span[1]/img"));
        //        return new KeyValuePair<string, IWebElement>(caseId, caseButton);
        //    }).ToList();

        //    return xPaths;
        //}

        /*
        private void WaitForSearchResultsLoading(int seconds)
        {
            By alertDismissBtn = By.ClassName("close");
            WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(alertDismissBtn));
        }
        */

        /// <summary>
        /// Takes the user to the settings page
        /// </summary>
        //public void GoToSettings()
        //{
        //    Driver.FindElement(UserMenu).Click();
        //    var settingsButton = Driver.FindElement(By.Id("optionsettings"));
        //    settingsButton.Click();
        //    CommonHelpers.WaitForPageLoading(Driver);
        //}

        public void ApplySettings()
        {
            driver.FindElement(ApplyButton).Click();
            CommonHelpers.WaitForPageLoading(driver);
        }

        //public bool CanViewAppliedSettings(string moduleName)
        //{
        //    var getPageTitle = Driver.FindElement(By.XPath("//div[@class='HmsContainer']/h1")).Text.Trim();

        //    if (getPageTitle.Contains("Data Query & Extraction"))
        //    {
        //        CommonHelpers.GoToSettings(Driver);
        //        SetDefaultLandingPage(moduleName);
        //        ApplySettings();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public void SetDefaultLandingPage(string moduleName)
        {
            switch (moduleName)
            {
                case "Administrator":
                    var administratorRadioButton = driver.FindElement(By.XPath("//*[@id='default']/div[1]/div/input"));
                    administratorRadioButton.Click();
                    break;
                case "Custom Analysis & Reports":
                    var customAnalysisAndReportsRadioButton = driver.FindElement(By.XPath("//*[@id='default']/div[2]/div/input"));
                    customAnalysisAndReportsRadioButton.Click();
                    break;
                case "Case Tracking":
                    var caseTrackingRadioButton = driver.FindElement(By.XPath("//*[@id='default']/div[3]/div/input"));
                    caseTrackingRadioButton.Click();
                    break;
                case "Data Query & Extraction":
                    var dataQueryAndExtractionRadioButton = driver.FindElement(By.XPath("//*[@id='default']/div[5]/div/input"));
                    dataQueryAndExtractionRadioButton.Click();
                    break;
                case "Guided Analytics":
                    var guidedAnalyticsRadioButton = driver.FindElement(By.XPath("//*[@id='default']/div[6]/div/input"));
                    guidedAnalyticsRadioButton.Click();
                    break;
            }
        }

        public void SetCaseTrackingListDefaultFilters(string name)
        {
            var caseTrackingListDefaultsTab = driver.FindElement(By.XPath("//*[@id='content-wrapper']/div/div[2]/div/div/user-settings/div/div/div/div[2]/ul/li[2]/a"));
            caseTrackingListDefaultsTab.Click();
            CommonHelpers.WaitForPageLoading(driver);

            IWebElement user;

            driver.FindElement(SwitchActivitiesAssignedToDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='activitiesAssignedTo']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchActivitiesAssignedSupervisorDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='activitiesAssignedToSupervisor']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchActivitiesDivisionsDepartmentsDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='activityDdepartment']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchActivitiesLeadCaseTypeDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadOrCaseTypeListDiv']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchActivitiesStatusDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='acitivityStatus']/option"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchCasesAssignedToDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='caseListAssignedTo']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchCasesAssignedSupervisorDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='caseListAssignedToSupervisor']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchCasesDivisionsDepartmentsDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='caseDepartment']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchCasesCaseTypeDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='caseTypeListDiv']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchCasesStatusDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='caseStatus']/option"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchLeadsAssignedToDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadListAssignedTo']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchLeadsAssignedSupervisorDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadListAssignedToSupervisor']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchLeadsDivisionsDepartmentsDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadDepartment']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchLeadsLeadTypeDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadTypeListDiv']/li/a"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();

            driver.FindElement(SwitchLeadsStatusDropdown).Click();
            user = driver.FindElements(By.XPath("//*[@id='leadStatus']/option"))
                .Where(e => e.Text.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
            CommonHelpers.WaitForPageLoading(driver);
            user.Click();
        }
        public void ClickUserDropdown()
        {
            driver.FindElement(UserDropdown).Click();
        }

        // <summary>
        // Logs the user out from the user panel in the page header
        // </summary>
        public void Logout()
        {
            driver.FindElement(UserDropdown).Click();
            var logoutButton = driver.FindElement(By.XPath("//a[@id='optionLogout']"));
            logoutButton.Click();
        }
    }
}
