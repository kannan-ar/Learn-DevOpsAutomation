using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Learn_DevOpsAutomation.Test.UI.Src.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
