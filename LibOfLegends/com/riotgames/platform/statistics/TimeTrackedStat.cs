using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// A class that specifies timestamp and type of a lifeTimeStat.
    /// </summary>
	public class TimeTrackedStat : AbstractDomainObject
	{
        /// <summary>
        /// Timestamp of this lifetime stat.
        /// </summary>
		public DateTime timestamp;

        /// <summary>
        /// Type of this lifetime Stat.
        /// </summary>
		public string type;
	}
}