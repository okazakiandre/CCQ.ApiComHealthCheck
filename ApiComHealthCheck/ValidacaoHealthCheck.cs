using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ApiComHealthCheck
{
    public class ValidacaoHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                throw new Exception("Erro na validacao");
                return Task.FromResult(
                    new HealthCheckResult(HealthStatus.Healthy, "Tá tudo beleza")
                );
            }
            catch (Exception ex)
            {
                return Task.FromResult(
                    new HealthCheckResult(HealthStatus.Unhealthy, "Deu ruim", ex)
                );
            }
        }
    }
}
