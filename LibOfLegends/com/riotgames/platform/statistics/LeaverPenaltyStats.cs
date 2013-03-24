using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// Leaver penalty stats class.
    /// </summary>
	public class LeaverPenaltyStats : AbstractDomainObject
	{
		/// <summary>
		/// Date/time of last leaver level increase.
		/// </summary>
		public DateTime lastLevelIncrease;

        /// <summary>
        /// Current leaver level.
        /// </summary>
		public int level;

        /// <summary>
        /// Last decay of leaver level.
        /// </summary>
		public DateTime lastDecay;

        /// <summary>
        /// If user was informed of leaver.
        /// </summary>
		public bool userInformed;

        /// <summary>
        /// Points loss from leaving.
        /// </summary>
		public int points;
	}
}