using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadSubjects : BaseSettings
    {
        public LeadSubjects(IWebDriver driver) : base(driver) { }

        private readonly By subjectsTab = By.XPath("//*[self::a or self::button][normalize-space()='Subjects']");
        private readonly By primarySubjectEditButton = By.XPath("//button[@id='SubjectsNew0C110C20']");
        private readonly By editSubjectHeader = By.XPath("//*[normalize-space()='Edit Subject']");
        private readonly By cancelButton = By.XPath("//*[normalize-space()='Edit Subject']/following::button[normalize-space()='Cancel'][1]");

        public void ClickSubjectsTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, subjectsTab, 30);
            Driver.FindElement(subjectsTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public void ClickPrimarySubjectEdit()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, primarySubjectEditButton, 30);
            Driver.FindElement(primarySubjectEditButton).Click();
            CommonHelpers.WaitForElementVisiblity(Driver, editSubjectHeader, 30);
        }

        public bool IsEditSubjectFormDisplayed()
        {
            return Driver.FindElements(editSubjectHeader).Any(element => element.Displayed);
        }

        public string GetEditFieldValue(string fieldLabel)
        {
            bool exactMatch = new[] { "Other" }.Contains(fieldLabel);

            string condition = exactMatch
                ? $"normalize-space()={ToXPathLiteral(fieldLabel)}"
                : $"normalize-space()={ToXPathLiteral(fieldLabel)} or contains(.,{ToXPathLiteral(fieldLabel)})";

            var locator = By.XPath(
                $"(//form[@id='LeadSubjectForm']//label[{condition}][1]/following::*[self::input or self::textarea or self::select])[1]");

                //By field2 = By.XPath("(//form[@id='LeadSubjectForm']//label[normalize-space()=" + ToXPathLiteral(fieldLabel) + " or contains(.," + ToXPathLiteral(fieldLabel) + ")][1]//following::*[self::input or self::textarea or self::select])[1]");
                CommonHelpers.WaitForElementVisiblity(Driver, locator, 30);
                return GetElementValue(Driver.FindElement(locator));
                            
        }
        

        public void CloseEditSubjectForm()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, cancelButton, 30);
            Driver.FindElement(cancelButton).Click();
        }

        private static string GetElementValue(IWebElement element)
        {
            if (element.TagName.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                var selected = new SelectElement(element).SelectedOption;
                return string.IsNullOrWhiteSpace(selected.Text)
                    ? (selected.GetAttribute("value") ?? string.Empty).Trim()
                    : selected.Text.Trim();
            }

            return (element.GetAttribute("value") ?? element.Text).Trim();
        }

        private static string ToXPathLiteral(string value)
        {
            if (!value.Contains('\'')) return $"'{value}'";
            if (!value.Contains('"')) return $"\"{value}\"";
            return "concat('" + value.Replace("'", "',\"'\",'") + "')";
        }
    }
}
