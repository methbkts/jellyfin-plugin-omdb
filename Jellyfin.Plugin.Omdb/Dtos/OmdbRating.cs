namespace Jellyfin.Plugin.Omdb.Dtos
{
    /// <summary>
    /// Omdb rating.
    /// </summary>
    public class OmdbRating
    {
        /// <summary>
        /// Gets or sets the rating source.
        /// </summary>
        public string? Source { get; set; }

        /// <summary>
        /// Gets or sets the rating value.
        /// </summary>
        public string? Value { get; set; }
    }
}