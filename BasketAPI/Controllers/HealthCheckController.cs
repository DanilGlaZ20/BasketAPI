using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BasketAPI.Controllers
{

    [Controller]
    [Route("/health")]
    public class HealthCheckController : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage responseAnimals = client.GetAsync("http://localhost:5000/api/animals").Result;
                HttpResponseMessage responseAreals = client.GetAsync("http://localhost:5000/api/areals").Result;
                if (responseAnimals.IsSuccessStatusCode && responseAreals.IsSuccessStatusCode)
                {
                    return Task.FromResult(
                        HealthCheckResult.Healthy("Сервис живой"));
                }
            }
            catch (Exception e)
            {
            }

            return Task.FromResult(
                HealthCheckResult.Unhealthy("Сервис умер"));
        }
    }
}