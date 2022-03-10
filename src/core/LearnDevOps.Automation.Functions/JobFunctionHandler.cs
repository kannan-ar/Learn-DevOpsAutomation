using LearnDevOps.Automation.Functions.Models;
using LearnDevOps.Automation.Functions.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LearnDevOps.Automation.Functions
{
    public class JobFunctionHandler : IJobFunctionHandler
    {
        private readonly IJobService _service;

        public JobFunctionHandler(IJobService service)
        {
            _service = service;
        }

        public HttpResponseMessage GetJobs()
        {
            var httpResponse = new HttpResponseMessage(HttpStatusCode.OK);
            var serilizedJobs = JsonConvert.SerializeObject(_service.GetJobs().ToList());
            httpResponse.Content = new StringContent(serilizedJobs, Encoding.UTF8, "application/json");
            return httpResponse;
        }
    }
}
