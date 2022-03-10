using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace LearnDevOps.Automation.Functions
{
    public class JobFunctionTriggers
    {
        private readonly IJobFunctionHandler _handler;

        public JobFunctionTriggers(IJobFunctionHandler handler)
        {
            _handler = handler;
        }

        [FunctionName(nameof(GetJobs))]
        public HttpResponseMessage GetJobs(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "jobs")] HttpRequest req,
            ILogger log)
        {
            return _handler.GetJobs();
        }
    }
}
