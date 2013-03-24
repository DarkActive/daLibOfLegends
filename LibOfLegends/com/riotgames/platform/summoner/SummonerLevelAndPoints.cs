using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// Conatins information about summoner's influence and experience points as well as summoner level.
    /// </summary>
	public class SummonerLevelAndPoints : AbstractDomainObject
	{
        /// <summary>
        /// Number of influence points (total)   .
        /// </summary>
		public int infPoints;

        /// <summary>
        /// Number of experience points.
        /// </summary>
		public int expPoints;

        /// <summary>
        /// The current level of summoner.
        /// </summary>
		public int summonerLevel;

        /// <summary>
        /// The summoner ID number.
        /// </summary>
		public long summonerId;
	}
}
