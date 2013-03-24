using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// Class for individual aggregated stats, specified by type member.
    /// </summary>
	public class SummaryAggStat : AbstractDomainObject
	{
        /// <summary>
        /// Type or name of aggregated stat.
        /// </summary>
		public string statType;

		/// <summary>
		/// Value of aggregated stat.
		/// </summary>
		public int value;
	}
}
