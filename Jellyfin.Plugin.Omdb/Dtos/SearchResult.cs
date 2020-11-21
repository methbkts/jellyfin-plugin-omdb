namespace Jellyfin.Plugin.Omdb.Dtos
{
    /// <summary>
    /// Omdb search result.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        public string? Year { get; set; }

        /// <summary>
        /// Gets or sets rated.
        /// </summary>
        public string? Rated { get; set; }

        /// <summary>
        /// Gets or sets released.
        /// </summary>
        public string? Released { get; set; }

        /// <summary>
        /// Gets or sets season.
        /// </summary>
        public string? Season { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        public string? Episode { get; set; }

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        public string? Runtime { get; set; }

        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Gets or sets the director.
        /// </summary>
        public string? Director { get; set; }

        /// <summary>
        /// Gets or sets the writer.
        /// </summary>
        public string? Writer { get; set; }

        /// <summary>
        /// Gets or sets the actors.
        /// </summary>
        public string? Actors { get; set; }

        /// <summary>
        /// Gets or sets the plot.
        /// </summary>
        public string? Plot { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the awards.
        /// </summary>
        public string? Awards { get; set; }

        /// <summary>
        /// Gets or sets the poster.
        /// </summary>
        public string? Poster { get; set; }

        /// <summary>
        /// Gets or sets the metascore.
        /// </summary>
        public string? Metascore { get; set; }

        /// <summary>
        /// Gets or sets the imdb rating.
        /// </summary>
        public string? ImdbRating { get; set; }

        /// <summary>
        /// Gets or sets the imdb votes.
        /// </summary>
        public string? ImdbVotes { get; set; }

        /// <summary>
        /// Gets or sets the imdb id.
        /// </summary>
        public string? ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the series id.
        /// </summary>
        public string? SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public string? Response { get; set; }
    }
}