using System;
using System.Collections.Generic;
using Microsoft.Tye.ConfigModel;
using YamlDotNet.RepresentationModel;

namespace Tye.Serialization
{
    public class ConfigIngressRouteParser
    {
        public static void HandleIngressRoute(YamlSequenceNode yamlSequenceNode, List<ConfigIngressRoute> ingressRoute)
        {
            foreach (var child in yamlSequenceNode.Children)
            {
                YamlParser.ThrowIfNotYamlMapping(child);
                var configIngressRoute = new ConfigIngressRoute();
                HandleIngressRouteMapping((YamlMappingNode) child, configIngressRoute);
                ingressRoute.Add(configIngressRoute);
            }
        }

        private static void HandleIngressRouteMapping(YamlMappingNode yamlMappingNode, ConfigIngressRoute configIngressRoute)
        {
            foreach (var child in yamlMappingNode)
            {
                var key = YamlParser.GetScalarValue(child.Key);

                switch (key)
                {
                    case "name":
                        configIngressRoute.Name = YamlParser.GetScalarValue(key, child.Value).ToLowerInvariant();
                        break;
                    case "tls":
                        if (!Boolean.TryParse(YamlParser.GetScalarValue(key, child.Value), out var tls))
                        {
                            throw new TyeYamlException(child.Value.Start, CoreStrings.FormatMustBeABoolean(key));
                        }

                        configIngressRoute.Tls = tls;
                        break;
                    case "entrypoints":
                        HandleEntrypointsMapping((child.Value as YamlSequenceNode)!, configIngressRoute.EntryPoints);
                        break;

                    default:
                        break;
                    
                }

            }
        }

        private static void HandleEntrypointsMapping(YamlSequenceNode yamlMappingNode,
            List<ConfigEntryPoint> configEntryPoints)
        {
            foreach (var child in yamlMappingNode.Children)
            {
                YamlParser.ThrowIfNotYamlMapping(child);
                
            }
        }
    }
}
