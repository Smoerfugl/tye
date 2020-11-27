using System.Collections;
using System.Collections.Generic;

namespace Microsoft.Tye
{
    public class IngressRouteBuilder
    {
        public IngressRouteBuilder(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Replicas { get; set; } = 1;
        public List<EntryPointBuilder> EntryPoints { get; set; }

        public List<IngressRouteRuleBuilder> Routes { get; set; } = new List<IngressRouteRuleBuilder>();

        public List<IngressRouteOutput> Outputs { get; } = new List<IngressRouteOutput>();
        public List<MiddlewareBuilder> MiddleWares { get; set; } = new List<MiddlewareBuilder>();
    }

    public class MiddlewareBuilder
    {
        public string Name { get; set; }
        public string? Namespace { get; set; }
    }
}
