using System;
using System.Collections.Generic;
using Jellyfin.Plugin.Omdb.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.Omdb
{
    /// <summary>
    /// Omdb plugin.
    /// </summary>
    public class OmdbPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmdbPlugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
        /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
        public OmdbPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <summary>
        /// Gets current plugin instance.
        /// </summary>
        public static OmdbPlugin? Instance { get; private set; }

        /// <inheritdoc />
        public override Guid Id => new Guid("a628c0da-fac5-4c7e-9d1a-7134223f14c8");

        /// <inheritdoc />
        public override string Name => "OMDb";

        /// <inheritdoc />
        public override string Description => "Get metadata for movies and other video content from OMDb.";

        /// <inheritdoc />
        public IEnumerable<PluginPageInfo> GetPages()
        {
            yield return new PluginPageInfo
            {
                Name = Name,
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.config.html"
            };
        }
    }
}
