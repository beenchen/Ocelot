﻿namespace Ocelot.Library.Configuration.Yaml
{
    using System.Collections.Generic;

    public class YamlReRoute
    {
        public YamlReRoute()
        {
            AddHeadersToRequest = new Dictionary<string, string>();
        }

        public string DownstreamTemplate { get; set; }
        public string UpstreamTemplate { get; set; }
        public string UpstreamHttpMethod { get; set; }
        public YamlAuthenticationOptions AuthenticationOptions { get; set; }
        public Dictionary<string, string> AddHeadersToRequest { get; set; }
    }
}