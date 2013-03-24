using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// PublicSummoner has the most important information
    /// about a summoner that is displayed publicly.
    /// </summary>
	public class PublicSummoner : AbstractDomainObject
	{
        /// <summary>
        /// The name of the summoner.
        /// </summary>
		public string internalName;

        /// <summary>
        /// The name of the summoner.
        /// </summary>
		public string name;

        /// <summary>
        /// The account ID number.
        /// </summary>
		public long acctId;

        /// <summary>
        /// The ID number of summoner's profile icon.
        /// </summary>
		public int profileIconId;

        /// <summary>
        /// Date/time this information was revised.
        /// </summary>
		public DateTime revisionDate;

        /// <summary>
        /// NOT IMPLEMENTED.
        /// </summary>
		public int revisionId;

        /// <summary>
        /// The current level of the summoner.
        /// </summary>
		public int summonerLevel;

        /// <summary>
        /// The summoner ID number.
        /// </summary>
		public long summonerId;
	}
}
