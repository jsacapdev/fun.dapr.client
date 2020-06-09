using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace fundaprapi
{
    public static class DaprHttpTrigger
    {
        [FunctionName(Constants.DaprHttpTrigger)]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            await Task.Run(() => { });

            return new OkObjectResult(DateTime.UtcNow.ToString());
        }
    }
}
