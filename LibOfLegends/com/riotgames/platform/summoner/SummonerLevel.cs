using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// The summoner's current level and information about leveling up and experience/influence tier modifications.
    /// </summary>
	public class SummonerLevel : AbstractDomainObject
	{
        /// <summary>
        /// Experience points tier modification (unknown significance).
        /// </summary>
		public int expTierMod;

        /// <summary>
        /// The number of RP granted (unknown significance).
        /// </summary>
		public int grantRp;

        /// <summary>
        /// Amount of experience to earn for a loss.
        /// </summary>
		public int expForLoss;

        /// <summary>
        /// The tier of summoner (unknown significance).
        /// </summary>
		public int summonerTier;

        /// <summary>
        /// Influence points tier modification (unknown significance).
        /// </summary>
		public int infTierMod;

        /// <summary>
        /// Experience needed for next level.
        /// </summary>
		public int expToNextLevel;

        /// <summary>
        /// Amount of experience to earn for a win.
        /// </summary>
		public int expForWin;

        /// <summary>
        /// The current summoner level.
        /// </summary>
		public int summonerLevel;
	}
}