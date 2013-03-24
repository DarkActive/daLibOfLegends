namespace com.riotgames.platform.summoner
{
    /// <summary>
    /// The Base data of the summoner for AllPublicSummoner
    /// </summary>
	public class BasePublicSummoner
	{
        /// <summary>
        /// Name of the summoner.
        /// </summary>
		public string internalName;

        /// <summary>
        /// Highest ranked tier in season one.
        /// </summary>
		public string seasonOneTier;

        /// <summary>
        /// Highest ranked tier in season two.
        /// </summary>
        public string seasonTwoTier;

        /// <summary>
        /// Account ID number of summoner.
        /// </summary>
		public long acctId;

        /// <summary>
        ///  Name of the summoner.
        /// </summary>
		public string name;

        /// <summary>
        /// Summoner ID number of summoner.
        /// </summary>
		public long sumId;

        /// <summary>
        /// Profile Icon ID number of summoner.
        /// </summary>
		public int profileIconId;
	}
}

