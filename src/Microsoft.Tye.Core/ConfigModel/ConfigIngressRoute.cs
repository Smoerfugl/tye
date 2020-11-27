using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.Tye.ConfigModel
{
    public class ConfigIngressRoute
    {
        [Required]
        public string Name { get; set; } = default!;
        public int? Replicas { get; set; }

        public List<ConfigIngressRouteRoute> Routes { get; set; } = new List<ConfigIngressRouteRoute>();
        public List<ConfigEntryPoint> EntryPoints { get; set; } = new List<ConfigEntryPoint>();
        public List<ConfigMiddleware> MiddleWares { get; set; } = new List<ConfigMiddleware>();
    }

    public class ConfigIngressRouteRoute
    {
        public string? Host { get; set; }
        public string Service { get; set; } = default!;
    }

    public class ConfigMiddleware
    {
        public string Name { get; set; } = default!;
        public string? Namespace { get; set; }
    }

    public class ConfigEntryPoint
    {
        public string Name { get; set; } = default!;
    }
}
