using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// Class with list of Aggregated Stats of specific queue type or stat type.
    /// </summary>
	public class SummaryAggStats : AbstractDomainObject
	{
        /// <summary>
        /// List of aggregated stats.
        /// </summary>
		public List<SummaryAggStat> stats;

        /// <summary>
        /// JSON of aggregated stats.
        /// </summary>
		public string statsJson;

        public int getKills()
        {
            for (int i = 0; i < stats.Count; i++)
                if (stats[i].statType.ToUpper() == "TOTAL_CHAMPION_KILLS")
                    return stats[i].value;
            return 0;
        }

        public int getAssists()
        {
            for (int i = 0; i < stats.Count; i++)
                if (stats[i].statType.ToUpper() == "TOTAL_ASSISTS")
                    return stats[i].value;
            return 0;
        }

        public int getTurretKills()
        {
            for (int i = 0; i < stats.Count; i++)
                if (stats[i].statType.ToUpper() == "TOTAL_TURRETS_KILLED")
                    return stats[i].value;
            return 0;
        }

        public int getMinionKills()
        {
            for (int i = 0; i < stats.Count; i++)
                if (stats[i].statType.ToUpper() == "TOTAL_MINION_KILLS")
                    return stats[i].value;
            return 0;
        }

        public int getNeutralMinionKills()
        {
            for (int i = 0; i < stats.Count; i++)
                if (stats[i].statType.ToUpper() == "TOTAL__NEUTRAL_MINIONS_KILLED")
                    return stats[i].value;
            return 0;
        }
	}
}
