namespace Microsoft.Tye
{
    public class IngressRouteRuleBuilder
    {
        public string? Host { get; set; }

        public string Service { get; set; } = default!;
    }
}
