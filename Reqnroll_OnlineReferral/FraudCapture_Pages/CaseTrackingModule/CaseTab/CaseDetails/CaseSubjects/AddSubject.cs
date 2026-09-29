using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.CaseSubjects
{
    public class AddSubject : BaseSettings
    {
        public AddSubject(IWebDriver driver) : base(driver)
        {
            Wait = new WebDriverWait(driver, DefaultTimeout);
        }

        public readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By SubjectsTab = By.XPath("//ul/li[@id='subjectNewListId']/a");
        private readonly By AddSubjectButton = By.XPath("//button[contains(.,'Add Subject')]");
        private readonly By SubjectTypeDropdown = By.XPath("//select[@id='subjectType']");
        private readonly By AddSubjectOptionsDropdown = By.XPath("//select[@id='subjectTypeSelection']");
        private readonly By AddSubjectOptionsButton = By.XPath("//div[@class='modal-footer']//button[contains(.,'Add Subject')]");
        private readonly By SubjectIDInput = By.XPath("//input[@id='ViewSubjectId']");
        private readonly By FirstNameInput = By.XPath("//input[@id='ViewSubjectFirstName']");
        private readonly By LastNameInput = By.XPath("//input[@id='ViewSubjectLastName']");
        private readonly By SaveSubjectButton = By.XPath("//button[@id='btnEditSave']");
        private readonly By OrgaNameInput = By.XPath("//input[@id='ViewSubjectOrganization']");
        private readonly By alertMessageClose = By.XPath("//div[@class='notification-enter alert alert-info alert-dismissible fade show']/child::button");
        private readonly By SubjectsTableRows = By.XPath("//form[@name='subjectFormNew']/descendant::table[@id='SubjectsNew']/tbody/tr");
        #endregion

        public void ClickOnSubjectsTab()
        {
            CommonHelpers.WaitForElementVisiblity(driver, SubjectsTab, 10);
            driver.FindElement(SubjectsTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
        }
        public void ManuallyAddSubjectDetails(string subjectType, string subjectOption, string subjectID, string firstName, string lastName, string organizationName)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 30);
            Wait.Until(ExpectedConditions.ElementToBeClickable(AddSubjectButton)).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            Wait.Until(ExpectedConditions.ElementIsVisible(SubjectTypeDropdown));
            var subjectTypeSelect = new SelectElement(driver.FindElement(SubjectTypeDropdown));
            subjectTypeSelect.SelectByText(subjectType);
            var subjectOptionSelect = new SelectElement(driver.FindElement(AddSubjectOptionsDropdown));
            subjectOptionSelect.SelectByText(subjectOption);
            Wait.Until(ExpectedConditions.ElementToBeClickable(AddSubjectOptionsButton)).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 50);
            Wait.Until(ExpectedConditions.ElementIsVisible(OrgaNameInput)).SendKeys(organizationName);
            Wait.Until(ExpectedConditions.ElementIsVisible(SubjectIDInput)).SendKeys(subjectID);
            Wait.Until(ExpectedConditions.ElementIsVisible(FirstNameInput)).SendKeys(firstName);
            Wait.Until(ExpectedConditions.ElementIsVisible(LastNameInput)).SendKeys(lastName);
            Wait.Until(ExpectedConditions.ElementToBeClickable(SaveSubjectButton)).Click();
            Wait.Until(ExpectedConditions.ElementToBeClickable(alertMessageClose)).Click();
        }


        public bool NewSubjectAppearsInTheSubjectList(string firstName, string lastName)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var waitForSubject = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var subjectName = firstName + ' ' + lastName;
            string caseSubjectName = string.Empty;
            waitForSubject.Until(d =>
            {
                try
                {
                    var subjectsRow = driver.FindElements(By.XPath("//form[@name='subjectFormNew']/descendant::table[@id='SubjectsNew']/tbody/tr"));
                    var selectedSubject = subjectsRow.Where(row =>
                    {
                        var smallElements = row.FindElements(By.TagName("small"));
                        if (smallElements.Count < 2)
                            return false;

                        var selectedSubjectName = smallElements[1].Text.Trim();
                        Console.WriteLine(selectedSubjectName);
                        Console.WriteLine(subjectName);
                        return subjectName == selectedSubjectName;
                    }).FirstOrDefault();

                    if (selectedSubject != null)
                    {
                        var smallElements = selectedSubject.FindElements(By.TagName("small"));
                        if (smallElements.Count > 1)
                        {
                            caseSubjectName = smallElements[1].Text.Trim();
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            });

            if (string.IsNullOrWhiteSpace(caseSubjectName))
            {
                return false;
            }
            else
            {
                DeleteSubject(firstName, lastName);
                return true;
            }
        }

        public void DeleteSubject(string firstName, string lastName)
        {
            var subjectsRow = driver.FindElements(SubjectsTableRows);
            var selectedSubject = subjectsRow.Where(row =>
            {
                var smallElements = row.FindElements(By.TagName("small"));
                if (smallElements.Count < 2)
                    return false;

                var selectedSubjectName = smallElements[1].Text.Trim();
                return IsSubjectNameMatch(selectedSubjectName, firstName, lastName);
            }).First();

            var deleteSubjectButton = selectedSubject.FindElement(By.XPath(".//button[contains(text(),'Delete')]"));
            deleteSubjectButton.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var confirmDeleteSubjectButton = driver.FindElement(By.XPath("//button[contains(text(),'Yes')]"));
            confirmDeleteSubjectButton.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
        }

        /// <summary>
        /// Checks whether a subject row's display text (e.g. " jbhhgg - FN Mali LN") represents the
        /// given first/last name, tolerating any surrounding text such as org name or labels.
        /// </summary>
        private static bool IsSubjectNameMatch(string rowText, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(rowText))
                return false;

            return rowText.IndexOf(firstName, StringComparison.OrdinalIgnoreCase) >= 0
                && rowText.IndexOf(lastName, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// Gets the row data from the subjects table and validates whether a subject with the
        /// given first and last name is present.
        /// </summary>
        public bool IsSubjectPresentInList(string firstName, string lastName)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 100);
            var waitForSubject = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            var subjectName = firstName + ' ' + lastName;
            Console.WriteLine($"Checking for subject: {subjectName}");
            string caseSubjectName = string.Empty;
            try
            {
                waitForSubject.Until(d =>
                {
                    var subjectsRow = d.FindElements(SubjectsTableRows);
                    var selectedSubject = subjectsRow.Where(row =>
                    {
                        var selectedSubjectName = row.FindElements(By.TagName("small"))[1].Text.Trim();

                        return subjectName .Contains( selectedSubjectName);
                    }).FirstOrDefault();

                    if (selectedSubject == null)
                    {
                        return false;
                    }

                    caseSubjectName = selectedSubject.FindElements(By.TagName("small"))[1].Text.Trim();
                    return true;
                });
            }
            catch (WebDriverTimeoutException)
            {
                // Subject not found within the timeout window.
            }

            if (string.IsNullOrWhiteSpace(caseSubjectName))
            {
                return false;
            }
            else
            {
                DeleteSubject(firstName, lastName);
                return true;
            }
        }
        /// <summary>
        /// Validates the subject first/last name is present in the subjects list and deletes it
        /// if it is already present. Returns true when the subject was found (and deleted).
        /// </summary>
        public bool DeleteSubjectIfAlreadyPresent(string firstName, string lastName)
        {
            bool isPresent = IsSubjectPresentInList(firstName, lastName);

            if (isPresent)
            {
                Console.WriteLine($"Subject '{firstName} {lastName}' was present and has been deleted.");
            }
            else
            {
                Console.WriteLine($"Subject '{firstName} {lastName}' is not present in the subjects list.");
            }

            return isPresent;
        }
    }
}