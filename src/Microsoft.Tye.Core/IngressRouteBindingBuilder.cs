namespace Microsoft.Tye
{
    public sealed class IngressRouteBindingBuilder
    {
        public int? Port { get; set; }
        public string? Protocol { get; set; } // HTTP or HTTPS
    }
}
