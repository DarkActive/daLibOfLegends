using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.leagues
{
    /// <summary>
    /// Class for a specific item (player or team) in a league.
    /// </summary>
    public class LeagueItem
    {
        public int previousDayLeaguePosition;
        public bool hotStreak;
        public object miniSeries;
        public bool freshBlood;
        public string tier;
        public DateTime lastPlayed;
        public long playerOrTeamId;
        public int leaguePoints;
        public bool inactive;
        public string rank;
        public bool veteran;
        public string queueType;
        public int losses;
        public string playerOrTeamName;
        public int wins;
    }
}
