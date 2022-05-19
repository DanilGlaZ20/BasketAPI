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
                HttpResponseMessage responseClub = client.GetAsync("http://localhost:5000/api/club").Result;
                HttpResponseMessage responsePlayer = client.GetAsync("http://localhost:5000/api/player").Result;
                if (responsePlayer.IsSuccessStatusCode && responseClub.IsSuccessStatusCode)
                {
                    return Task.FromResult(
                        HealthCheckResult.Healthy("Сервис живой"));
                }
            }
            catch (Exception e)
            {
            }

            return Task.FromResult(
                HealthCheckResult.Unhealthy("Сервис жив"));
        }
    }
}