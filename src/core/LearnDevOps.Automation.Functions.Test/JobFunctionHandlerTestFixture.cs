using LearnDevOps.Automation.Functions.Models;
using LearnDevOps.Automation.Functions.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDevOps.Automation.Functions.Test
{
    public class JobFunctionHandlerTestFixture
    {
        public IEnumerable<JobModel> Jobs => new List<JobModel>
         {
            new JobModel
            {
                JobId = 1,
                JobName = "Job 1"
            }
         };

        public IJobFunctionHandler GetJobFunctionHandler()
        {
            var mockService = new Mock<IJobService>();

            mockService.Setup(x => x.GetJobs()).Returns(Jobs);

            return new JobFunctionHandler(mockService.Object);
        }
    }
}
