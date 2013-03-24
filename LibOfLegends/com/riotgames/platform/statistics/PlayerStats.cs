using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// General player stats like time tracked stats.
    /// </summary>
	public class PlayerStats : AbstractDomainObject
	{
        /// <summary>
        /// List of time tracked stats for this summoner in specified season.
        /// </summary>
		public List<TimeTrackedStat> timeTrackedStats;

        /// <summary>
        /// Number of promotional games played for this summoner in specified season.
        /// </summary>
		public int promoGamesPlayed;

		/// <summary>
		/// Number of promotional games played since last updated. (Unknown significance).
		/// </summary>
		public object promoGamesPlayedLastUpdated;
	}
}