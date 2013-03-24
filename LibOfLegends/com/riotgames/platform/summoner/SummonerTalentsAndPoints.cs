using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// The number of talent points, which corresponds to summoner level.
    /// </summary>
	public class SummonerTalentsAndPoints : AbstractDomainObject
	{
        /// <summary>
        /// Talent points number.
        /// </summary>
		public int talentPoints;

        /// <summary>
        /// Date/time of modification.
        /// </summary>
		public DateTime modifyDate;

        /// <summary>
        /// Date/time of creation
        /// </summary>
		public DateTime createDate;

        /// <summary>
        /// ID number of summoner.
        /// </summary>
		public long summonerId;
	}
}