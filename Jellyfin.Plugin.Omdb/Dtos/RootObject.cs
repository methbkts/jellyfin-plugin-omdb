using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Jellyfin.Plugin.Omdb.Dtos
{
    /// <summary>
    /// Root response object.
    /// </summary>
    public class RootObject
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
        /// Gets or sets runtime.
        /// </summary>
        public string? Runtime { get; set; }

        /// <summary>
        /// Gets or sets genre.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Gets or sets director.
        /// </summary>
        public string? Director { get; set; }

        /// <summary>
        /// Gets or sets writer.
        /// </summary>
        public string? Writer { get; set; }

        /// <summary>
        /// Gets or sets actors.
        /// </summary>
        public string? Actors { get; set; }

        /// <summary>
        /// Gets or sets plot.
        /// </summary>
        public string? Plot { get; set; }

        /// <summary>
        /// Gets or sets language.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets awards.
        /// </summary>
        public string? Awards { get; set; }

        /// <summary>
        /// Gets or sets the poster.
        /// </summary>
        public string? Poster { get; set; }

        /// <summary>
        /// Gets or sets the list of ratings.
        /// </summary>
        public IReadOnlyList<OmdbRating> Ratings { get; set; } = Array.Empty<OmdbRating>();

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
        /// Gets or sets the type.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the dvd.
        /// </summary>
        public string? DVD { get; set; }

        /// <summary>
        /// Gets or sets the box office.
        /// </summary>
        public string? BoxOffice { get; set; }

        /// <summary>
        /// Gets or sets production.
        /// </summary>
        public string? Production { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string? Website { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public string? Response { get; set; }

        /// <summary>
        /// Gets or sets the episode.
        /// </summary>
        public int? Episode { get; set; }

        /// <summary>
        /// Gets the rotten tomato score.
        /// </summary>
        /// <returns>The rotton tomato score.</returns>
        public float? GetRottenTomatoScore()
        {
            var rating = Ratings.FirstOrDefault(i => string.Equals(i.Source, "Rotten Tomatoes", StringComparison.OrdinalIgnoreCase));
            if (rating != null && rating.Value != null)
            {
                var value = rating.Value.TrimEnd('%');
                if (float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var score))
                {
                    return score;
                }
            }

            return null;
        }
    }
}