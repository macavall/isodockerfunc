using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace isodockerfunc
{
    public class timer1
    {
        private readonly ILogger _logger;

        public timer1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<timer1>();
        }

        [Function("timer1")]
        public void Run([TimerTrigger("0 * * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
