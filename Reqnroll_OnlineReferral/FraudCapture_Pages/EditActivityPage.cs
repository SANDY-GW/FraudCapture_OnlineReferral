using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FC.Tests.Pages
{
    /// <summary>
    /// Page Object Model for the Edit Activity page.
    /// Supports Add Note workflow validations after the note is saved.
    ///
    /// Screen coverage:
    /// - Edit Activity modal/page
    /// - Activity tab
    /// - Add button under Notes section
    /// - Notes grid/list at the bottom of Edit Activity page
    /// - Latest note verification after saving a note
    /// </summary>
    public class EditActivityPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public EditActivityPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        #region Page Locators

        private By EditActivityTitle =>
            By.XPath("//*[normalize-space()='Edit Activity']");

        private By ActivityTab =>
            By.XPath("//*[self::button or self::a or @role='tab'][normalize-space()='Activity' or .//*[normalize-space()='Activity']]");

        private By ActivitySection =>
            By.XPath("//*[normalize-space()='Activity Name' or contains(normalize-space(),'Activity Name')]");

        private By LeadIdField =>
            By.XPath("//*[normalize-space()='Lead ID']/following::*[self::input or self::div or self::span][1]");

        private By ActivityNameField =>
            By.XPath("//*[contains(normalize-space(),'Activity Name')]/following::*[self::input or self::select or @role='combobox'][1]");

        private By AssignedToField =>
            By.XPath("//*[contains(normalize-space(),'Assigned To')]/following::*[self::input or self::select or @role='combobox'][1]");

        private By StatusField =>
            By.XPath("//*[normalize-space()='Status']/following::*[self::input or self::select or @role='combobox'][1]");

        private By AddButton =>
            By.XPath("//*[self::button or self::a][normalize-space()='Add' or .//*[normalize-space()='Add']]");

        private By ViewAllNotesButton =>
            By.XPath("//*[self::button or self::a][normalize-space()='View All Notes' or .//*[normalize-space()='View All Notes']]");

        private By NotesSectionHeader =>
            By.XPath("//*[normalize-space()='Notes' or starts-with(normalize-space(),'Notes for ID:')]");

        private By NotesGridHeader =>
            By.XPath("//*[normalize-space()='Note Added Date']/ancestor::*[self::table or self::div][1]");

        private By NotesGridRows =>
            By.XPath("//*[normalize-space()='Note Added Date']/ancestor::*[self::table or self::div][1]/following::*[self::tr or contains(@class,'row')][.//*[normalize-space()!='']]");

        private By LatestNoteTextArea =>
            By.XPath("//*[starts-with(normalize-space(),'Notes for ID:')]/following::*[self::div or self::td or self::span or self::p][normalize-space()][1]");

        private By AnyNoteTextContainer =>
            By.XPath("//*[starts-with(normalize-space(),'Notes for ID:')]/following::*[normalize-space()][position() <= 5]");

        #endregion

        #region Page Verification Methods

        public bool IsDisplayed()
        {
            return IsElementDisplayed(EditActivityTitle);
        }

        public bool IsActivityTabSelected()
        {
            IWebElement tab = WaitForVisible(ActivityTab);

            string classValue = tab.GetAttribute("class") ?? string.Empty;
            string ariaSelected = tab.GetAttribute("aria-selected") ?? string.Empty;

            return classValue.Contains("active", StringComparison.OrdinalIgnoreCase)
                || classValue.Contains("selected", StringComparison.OrdinalIgnoreCase)
                || ariaSelected.Equals("true", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsActivitySectionDisplayed()
        {
            return IsElementDisplayed(ActivitySection);
        }

        public bool IsAddButtonDisplayed()
        {
            return IsElementDisplayed(AddButton);
        }

        public bool IsAddButtonEnabled()
        {
            IWebElement addButton = WaitForVisible(AddButton);
            return addButton.Displayed && addButton.Enabled;
        }

        public bool IsViewAllNotesButtonDisplayed()
        {
            return IsElementDisplayed(ViewAllNotesButton);
        }

        public bool IsNotesSectionDisplayed()
        {
            return IsElementDisplayed(NotesSectionHeader);
        }

        public bool IsNotesGridDisplayed()
        {
            return IsElementDisplayed(NotesGridHeader) || IsElementDisplayed(NotesSectionHeader);
        }

        #endregion

        #region Actions

        public void ClickAddButton()
        {
            Click(AddButton);
        }

        public void ClickViewAllNotes()
        {
            Click(ViewAllNotesButton);
        }

        #endregion

        #region Notes Validation Methods

        public bool IsNoteDisplayed(string expectedNoteText)
        {
            if (string.IsNullOrWhiteSpace(expectedNoteText))
                throw new ArgumentException("Expected note text cannot be blank.", nameof(expectedNoteText));

            WaitForEditActivityPageToRefreshAfterSave();

            By noteLocator = By.XPath($"//*[contains(normalize-space(), {XPathText(expectedNoteText)})]");

            return _driver.FindElements(noteLocator).Any(e => e.Displayed);
        }

        public string GetLatestNoteText()
        {
            WaitForEditActivityPageToRefreshAfterSave();

            IList<IWebElement> noteContainers = _driver.FindElements(AnyNoteTextContainer)
                .Where(e => e.Displayed && !string.IsNullOrWhiteSpace(e.Text))
                .ToList();

            if (noteContainers.Any())
                return noteContainers.Last().Text.Trim();

            if (IsElementDisplayed(LatestNoteTextArea))
                return WaitForVisible(LatestNoteTextArea).Text.Trim();

            return string.Empty;
        }

        public string GetLatestNoteDate()
        {
            WaitForEditActivityPageToRefreshAfterSave();

            // Looks for date in the Note Added Date column, e.g. Jul 8 2026 11:42 AM GMT+5:30
            var dateCells = _driver.FindElements(
                By.XPath("//*[contains(normalize-space(),'GMT') or contains(normalize-space(),'AM') or contains(normalize-space(),'PM')]")
            ).Where(e => e.Displayed && !string.IsNullOrWhiteSpace(e.Text)).ToList();

            return dateCells.Any() ? dateCells.Last().Text.Trim() : string.Empty;
        }

        public string GetLatestNoteUser()
        {
            WaitForEditActivityPageToRefreshAfterSave();

            // Generic locator for the Note Added By User column values.
            // Preferred improvement: replace with a stable grid column map if the DOM has table headers.
            var possibleUsers = _driver.FindElements(
                By.XPath("//*[normalize-space()='Note Added By User']/following::*[contains(normalize-space(), ',')][1]")
            ).Where(e => e.Displayed && !string.IsNullOrWhiteSpace(e.Text)).ToList();

            return possibleUsers.Any() ? possibleUsers.Last().Text.Trim() : string.Empty;
        }

        public int GetNoteCount()
        {
            if (!IsNotesGridDisplayed())
                return 0;

            return _driver.FindElements(NotesGridRows).Count(e => e.Displayed);
        }

        public bool IsLatestNoteDisplayedAtBottom(string expectedNoteText)
        {
            string latestNote = GetLatestNoteText();
            return latestNote.Contains(expectedNoteText, StringComparison.OrdinalIgnoreCase);
        }

        #endregion

        #region Common Field Getters

        public string GetLeadId()
        {
            return GetElementTextOrValue(LeadIdField);
        }

        public string GetActivityName()
        {
            return GetElementTextOrValue(ActivityNameField);
        }

        public string GetAssignedTo()
        {
            return GetElementTextOrValue(AssignedToField);
        }

        public string GetStatus()
        {
            return GetElementTextOrValue(StatusField);
        }

        #endregion

        #region Wait Helpers

        public void WaitForEditActivityPageToRefreshAfterSave()
        {
            _wait.Until(driver => driver.FindElements(EditActivityTitle).Any(e => e.Displayed));
            _wait.Until(driver => driver.FindElements(NotesSectionHeader).Any(e => e.Displayed));
        }

        private IWebElement WaitForVisible(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        private IWebElement WaitForClickable(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        private bool IsElementDisplayed(By locator)
        {
            try
            {
                return _driver.FindElements(locator).Any(e => e.Displayed);
            }
            catch (StaleElementReferenceException)
            {
                return _driver.FindElements(locator).Any(e => e.Displayed);
            }
        }

        private void Click(By locator)
        {
            IWebElement element = WaitForClickable(locator);
            ScrollToElement(element);
            element.Click();
        }

        private string GetElementTextOrValue(By locator)
        {
            IWebElement element = WaitForVisible(locator);

            string value = element.GetAttribute("value");
            if (!string.IsNullOrWhiteSpace(value))
                return value.Trim();

            return element.Text.Trim();
        }

        private void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)_driver)
                .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", element);
        }

        private static string XPathText(string value)
        {
            if (!value.Contains("'"))
                return $"'{value}'";

            if (!value.Contains("\""))
                return $"\"{value}\"";

            return "concat('" + value.Replace("'", "',\"'\",'") + "')";
        }

        #endregion
    }
}
