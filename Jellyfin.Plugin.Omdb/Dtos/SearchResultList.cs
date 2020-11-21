using System;
using System.Collections.Generic;

namespace Jellyfin.Plugin.Omdb.Dtos
{
    /// <summary>
    /// The search result list.
    /// </summary>
    public class SearchResultList
    {
        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>The results.</value>
        public IReadOnlyList<SearchResult> Search { get; set; } = Array.Empty<SearchResult>();
    }
}