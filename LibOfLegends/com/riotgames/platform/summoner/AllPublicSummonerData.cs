using com.riotgames.platform.gameclient.domain;
using com.riotgames.platform.summoner.spellbook;

namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// All the public summoner data that is available.
    /// </summary>
	public class AllPublicSummonerData : AbstractDomainObject
	{
        /// <summary>
        /// The list of rune pages class.
        /// </summary>
		public SpellBook spellBook;

        /// <summary>
        /// The default summoner spells class of the summoner.
        /// </summary>
		public SummonerDefaultSpells summonerDefaultSpells;

        /// <summary>
        /// The talents and points class of the summoner.
        /// </summary>
		public SummonerTalentsAndPoints summonerTalentsAndPoints;

        /// <summary>
        /// The base public summoner data class of the summoner.
        /// </summary>
		public BasePublicSummoner summoner;

        /// <summary>
        /// The level and points class of the summoner.
        /// </summary>
		public SummonerLevelAndPoints summonerLevelAndPoints;

        /// <summary>
        /// The summoner level class of the summoner.
        /// </summary>
		public SummonerLevel summonerLevel;
	}
}
