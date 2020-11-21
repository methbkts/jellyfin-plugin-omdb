using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.Omdb.Configuration
{
    /// <summary>
    /// The plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether to retrieve cast and crew information.
        /// </summary>
        public bool CastAndCrew { get; set; }
    }
}
