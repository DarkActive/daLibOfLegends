using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// The class including a list of queue type stats and user id.
    /// </summary>
	public class PlayerStatSummaries : AbstractDomainObject
	{
        /// <summary>
        /// Summaries of player's stats based on queue type.
        /// </summary>
		public List<PlayerStatSummary> playerStatSummarySet;

        /// <summary>
        /// The account ID number that corresponds to the summary stat list.
        /// </summary>
		public long userId;
	}
}
