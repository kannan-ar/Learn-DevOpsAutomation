using LearnDevOps.Automation.Functions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDevOps.Automation.Functions.Services
{
    public class JobService : IJobService
    {
        public IEnumerable<JobModel> GetJobs()
        {
            return Enumerable.Range(1, 5).Select(x => new JobModel
            {
                JobId = x,
                JobName = $"Job {x}"
            });
        }
    }
}
