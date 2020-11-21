using System;
using System.Collections.Generic;

namespace Jellyfin.Plugin.Omdb.Dtos
{
    /// <summary>
    /// The season root object.
    /// </summary>
    public class SeasonRootObject
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the series id.
        /// </summary>
        public string? SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        public int Season { get; set; }

        /// <summary>
        /// Gets or sets the total seasons.
        /// </summary>
        public int? TotalSeasons { get; set; }

        /// <summary>
        /// Gets or sets the list of episodes.
        /// </summary>
        public IReadOnlyList<RootObject> Episodes { get; set; } = Array.Empty<RootObject>();

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public string? Response { get; set; }
    }
}