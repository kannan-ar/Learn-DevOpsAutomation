using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Learn_DevOpsAutomation.Test.UI.Utility
{
    static class TestUtilities
    {
        public static IWebDriver GetDriver()
        {
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options)
            {
                Url = Configuration.AutomationSettings.Url
            };

            return driver;
        }
    }
}
