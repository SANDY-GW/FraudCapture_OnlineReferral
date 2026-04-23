using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Amounts.AddAmounts
{
    public class AddAmounts : BaseSettings
    {
        public AddAmounts(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By amountTypeDDL = By.XPath("//*[@id=\"detailsTab\"]/div[2]/div[1]/p/select");
        private readonly By subjectDDL = By.XPath("//*[@id=\"detailsTab\"]/div[2]/div[2]/p/select");
        private readonly By amountEffectiveDate = By.XPath("//*[@id=\"paymentDate\"]/span/input");
        private readonly By paymentAmount = By.XPath("//*[@id=\"paymentAmount\"]");
        private readonly By lineOfBusinessDDL = By.XPath("//*[@id=\"detailsTab\"]/div[2]/div[5]/p/select");
        private readonly By finalRecoupChk = By.XPath("//*[@id=\"IsActiveFinalRecoup\"]");
        private readonly By cancleBtn = By.XPath("//*[@id=\"detailsTab\"]/div[1]/button[1]");
        private readonly By saveBtn = By.XPath("//*[@id=\"btnOk\"]");

        #endregion
        public void SelectAmountType(string type)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(amountTypeDDL), type);
        }
        public void ClickFinalRecoup()
        {
            Driver.FindElement(finalRecoupChk).Click();
        }
        public void ClickCancel()
        {
            Driver.FindElement(cancleBtn).Click();
        }
        public void ClickSave()
        {
            Driver.FindElement(saveBtn).Click();
        }
        public void SelectSubject(string subject)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(subjectDDL), subject);
        }
        public void SelectLineOfBusiness(string LOB)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(lineOfBusinessDDL), LOB);
        }
        public void EnterAmountEffectiveDate(string date)
        {
            Driver.FindElement(amountEffectiveDate).SendKeys(date);
        }
        public void EnterPaymentAmount(string amount)
        {
            Driver.FindElement(paymentAmount).SendKeys(amount);
        }
    }
}
