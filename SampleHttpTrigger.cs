using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FaPocPrivate
{
    public class SampleHttpTrigger
    {
        private readonly ILogger<SampleHttpTrigger> _logger;

        public SampleHttpTrigger(ILogger<SampleHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("SampleHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
