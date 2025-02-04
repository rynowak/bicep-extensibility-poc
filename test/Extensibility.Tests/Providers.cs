﻿namespace Extensibility.Tests
{
    using System.Collections.Generic;
    using Extensibility.Core;
    using Extensibility.AzureStorage;
    using Extensibility.Kubernetes;
    
    public static class Providers
    {
        private static readonly IReadOnlyDictionary<string, IExtensibilityProvider> ProvidersLookup = new Dictionary<string, IExtensibilityProvider>
        {
            ["AzureStorage"] = new AzureStorageProvider(),
            ["Kubernetes"] = new KubernetesProvider(),
        };

        public static IExtensibilityProvider? TryGetProvider(string name)
            => ProvidersLookup.TryGetValue(name, out var provider) ? provider : null;
    }
}
