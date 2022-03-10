using Learn_DevOpsAutomation.Test.UI.Utility;
using OpenQA.Selenium;
using System;

namespace Learn_DevOpsAutomation.Test.UI.Test.Fixtures
{
    public class AutomationTestsFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public AutomationTestsFixture()
        {
            Driver = TestUtilities.GetDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
