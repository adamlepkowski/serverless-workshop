using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FlightDataFunctionApp
{
    public static class HelloWorld
    {
        [FunctionName("HelloWorld")]
        public static void Run([TimerTrigger("*/2 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogWarning($"Hello World! {DateTime.Now}");
        }
    }
}
