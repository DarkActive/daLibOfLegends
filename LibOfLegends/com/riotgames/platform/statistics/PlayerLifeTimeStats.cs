using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    /// <summary>
    /// Player/summoner lifetime stats of the season that was requested.
    /// Includes all queue type stats and regular player stats.
    /// </summary>
	public class PlayerLifeTimeStats : AbstractDomainObject
	{
        /// <summary>
        /// A class with a list of each individual queue type and the stat summaries of that queue.
        /// </summary>
		public PlayerStatSummaries playerStatSummaries;

        /// <summary>
        /// A class with information about leaver penalty stats.
        /// </summary>
		public LeaverPenaltyStats leaverPenaltyStats;

        /// <summary>
        /// The date/time of the last time First Win Of the Day was used.
        /// </summary>
		public DateTime previousFirstWinOfDay;

        /// <summary>
        /// The account ID number corresponding to this PlayerStats.
        /// </summary>
		public long userId;

        /// <summary>
        /// The streak number of dodges this player is currently at.
        /// </summary>
		public int dodgeStreak;

        /// <summary>
        /// The last dodgePenalty date which is by default set to "object" type because it can be null, but if set is a DateTime object.
        /// </summary>
		public object dodgePenaltyDate;

        /// <summary>
        /// JSON of the playerStats.
        /// </summary>
		public string playerStatsJson;

        /// <summary>
        /// The general player stats.
        /// </summary>
		public PlayerStats playerStats;

        public PlayerStatSummary getRankedSolo5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "rankedsolo5x5")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public PlayerStatSummary getNormal5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "unranked")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public PlayerStatSummary getRankedTeam5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "rankedteam5x5")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public PlayerStatSummary getRankedTeam3x3()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "rankedpremade3x3")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public int getRankedKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getKills();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getKills();

            return value;
        }

        public int getRankedAssists()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getAssists();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getAssists();

            return value;
        }

        public int getRankedTurretKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getTurretKills();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getTurretKills();

            return value;
        }

        public int getRankedMinionKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += (rTeam5x5.aggregatedStats.getMinionKills() + rTeam5x5.aggregatedStats.getNeutralMinionKills());

            if (rSolo5x5 != null)
                value += (rSolo5x5.aggregatedStats.getMinionKills() + rSolo5x5.aggregatedStats.getNeutralMinionKills());

            return value;
        }
	}
}