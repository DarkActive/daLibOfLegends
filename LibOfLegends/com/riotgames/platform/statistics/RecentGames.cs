using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// Class with a list of all user's recent games.
    /// </summary>
	public class RecentGames : AbstractDomainObject
	{

        /// <summary>
        /// List of up to 10 previous games.
        /// </summary>
		public List<PlayerGameStats> gameStatistics;

        /// <summary>
        /// Account ID number of specified recent games user.
        /// </summary>
		public long userId;
	}
}
