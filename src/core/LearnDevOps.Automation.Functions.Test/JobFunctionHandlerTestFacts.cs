using FluentAssertions;
using LearnDevOps.Automation.Functions.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearnDevOps.Automation.Functions.Test
{
    public class JobFunctionHandlerTestFacts : IClassFixture<JobFunctionHandlerTestFixture>
    {
        private readonly JobFunctionHandlerTestFixture _fixture;
        public JobFunctionHandlerTestFacts(JobFunctionHandlerTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Given_Service_Should_Returns_Correct_Jobs()
        {
            var handler = _fixture.GetJobFunctionHandler();
            var response = handler.GetJobs();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var jobs = JsonConvert.DeserializeObject<IEnumerable<JobModel>>(await response.Content.ReadAsStringAsync());
            jobs.Should().BeEquivalentTo(_fixture.Jobs);
        }
    }
}
