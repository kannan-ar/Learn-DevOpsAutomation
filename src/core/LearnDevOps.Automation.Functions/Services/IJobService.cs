using LearnDevOps.Automation.Functions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDevOps.Automation.Functions.Services
{
    public interface IJobService
    {
        IEnumerable<JobModel> GetJobs();
    }
}
