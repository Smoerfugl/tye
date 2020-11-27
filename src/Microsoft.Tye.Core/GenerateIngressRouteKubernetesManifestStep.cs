using System.Threading.Tasks;

namespace Microsoft.Tye
{
    public sealed class GenerateIngressRouteKubernetesManifestStep : ApplicationExecutor.IngressRouteStep
    {
        public override string DisplayText => "Generating Manifests...";

        public string Environment { get; set; } = "production";

        public override Task ExecuteAsync(OutputContext output, ApplicationBuilder application, IngressRouteBuilder ingress)
        {
            ingress.Outputs.Add(KubernetesManifestGenerator.CreateIngressRoute(output, application, ingress));
            return Task.CompletedTask;
        }
    }
}
