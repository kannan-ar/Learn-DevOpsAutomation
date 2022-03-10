using LearnDevOps.Automation.Functions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnDevOps.Automation.Functions
{
    public interface IJobFunctionHandler
    {
        HttpResponseMessage GetJobs();
    }
}
