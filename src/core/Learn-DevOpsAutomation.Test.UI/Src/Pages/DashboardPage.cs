using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DevOpsAutomation.Test.UI.Src.Pages
{
    public class DashboardPage : BasePage
    {
        private const string message = "Success";

        [FindsBy(How = How.TagName, Using = "h3")]
        [CacheLookup]
        private readonly IWebElement statusMessage;

        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        public bool VerifyMessageLoaded()
        {
            return statusMessage.Text == message;
        }
    }
}
