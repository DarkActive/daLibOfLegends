using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// The class with all statistical summary of a certain queue type. Like ranked5v5, normal5v5, etc.
    /// </summary>
	public class PlayerStatSummary : AbstractDomainObject
	{
        /// <summary>
        /// Account ID number corresponding to these stats.
        /// </summary>
		public long userId;

        /// <summary>
        /// Max rating corresponding to this queue/stat type. HIDDEN IN S3.
        /// </summary>
		public int maxRating;

        /// <summary>
        /// Number of leaves corresponding to this queue/stat type.
        /// </summary>
		public int leaves;

        /// <summary>
        /// The date/time this queue/stat type was last modified.
        /// </summary>
		public DateTime modifyDate;

        /// <summary>
        /// Number of losses corresponding to this queue/stat type. HIDDEN IN S3 IF NOT SELF.
        /// </summary>
		public int losses;

        /// <summary>
        /// The current rating corresponding to this queue/stat type. HIDDEN IN S3.
        /// </summary>
		public int rating;

        /// <summary>
        /// Number of wins corresponding to this queue/stat type.
        /// </summary>
		public int wins;

        /// <summary>
        /// The queue type or stat type corresponding to these stats.
        /// </summary>
		public string playerStatSummaryType;

        /// <summary>
        /// String of the queue type or stat type corresponding to these stats. Usually same as playerStatSummaryType.
        /// </summary>
		public string playerStatSummaryTypeString;

        /// <summary>
        /// Individual aggregated stats corresponding to this queue/stat type.
        /// </summary>
		public SummaryAggStats aggregatedStats;

        /// <summary>
        /// JSON of individual aggregated stats corresponding to this queue/stat type.
        /// </summary>
		public object aggregatedStatsJson;
	}
}
