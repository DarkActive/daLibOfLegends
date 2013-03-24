using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.leagues
{
    /// <summary>
    /// Class for a specific league/division of the summoner.
    /// </summary>
    public class LeagueList
    {
        /// <summary>
        /// Queue name/type this league is for.
        /// </summary>
        public string queue;

        /// <summary>
        /// Name of this league.
        /// </summary>
        public string name;

        /// <summary>
        /// This league's tier (Bronze, Silver, Gold, etc)
        /// </summary>
        public string tier;

        /// <summary>
        /// The rank or division number of summoner whose league info was requested.
        /// </summary>
        public string requestorsRank;

        /// <summary>
        /// Individual item (player or team) entries in this league.
        /// </summary>
        public List<LeagueItem> entries;

        /// <summary>
        /// The name of summoner whose league info was requested.
        /// </summary>
        public string requestorsName;
    }
}
