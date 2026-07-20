using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadReferral : BaseSettings
    {
        public LeadReferral(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By leadReasonBtn = By.XPath("//*[@id='leadReasonTabId']");
        private readonly By referralTab = By.XPath("//*[self::a or self::button][normalize-space()='Referral']");
        private readonly By referralReceivedDate = By.XPath("//label[contains(normalize-space(.),'Referral Received Date')]/following::input[1]");

        #endregion
        public void ClickLeadReason()
        {
            Driver.FindElement(leadReasonBtn).Click();
        }

        public void ClickReferralTab()
        {
            CommonHelpers.WaitForElementVisiblity(Driver, referralTab, 30);
            Driver.FindElement(referralTab).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);
        }

        public string GetReferralReceivedDate()
        {
            return GetElementValue(Driver.FindElement(referralReceivedDate));
        }

        public string GetFieldValue(string fieldLabel)
        {
            By field = By.XPath("//label[normalize-space(.)=" + ToXPathLiteral(fieldLabel) + "]/following::*[self::input or self::textarea or self::select][1]");
            By field1 = By.XPath("//label[contains(.," + ToXPathLiteral(fieldLabel) + ")]//following::*[self::input or self::textarea or self::select][1]");
            CommonHelpers.WaitForElementVisiblity(Driver, field1, 30);
            return GetElementValue(Driver.FindElement(field1));
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
