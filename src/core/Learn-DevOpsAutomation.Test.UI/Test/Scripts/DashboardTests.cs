using Learn_DevOpsAutomation.Test.UI.Src.Pages;
using Learn_DevOpsAutomation.Test.UI.Test.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Learn_DevOpsAutomation.Test.UI.Test.Scripts
{
    public class DashboardTests : IClassFixture<AutomationTestsFixture>
    {
        private readonly AutomationTestsFixture _fixture;

        public DashboardTests(AutomationTestsFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Test_Dashboard_Loaded()
        {
            var dashboard = new DashboardPage(_fixture.Driver);
            Assert.True(dashboard.VerifyMessageLoaded(), "Dashboard message is not loaded");
        }
    }
}
