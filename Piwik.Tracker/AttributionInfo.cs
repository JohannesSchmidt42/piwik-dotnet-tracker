﻿#region license

// http://www.gnu.org/licenses/gpl-3.0.html GPL v3 or later

#endregion license

using System;

/// <summary>
/// Piwik - Open source web analytics
/// For more information, see http://piwik.org
/// </summary>
namespace Piwik.Tracker
{
    /// <summary>
    /// Represents visit attribution information: referrer URL, referrer timestamp, campaign name & keyword.
    /// Used in the context of goal converions to attribute the right information.
    /// </summary>
    public class AttributionInfo
    {
        public string CampaignName { get; set; }
        public string CampaignKeyword { get; set; }

        /// <summary>
        /// Timestamp at which the referrer was set
        /// </summary>
        public DateTimeOffset ReferrerTimestamp { get; set; }

        public string ReferrerUrl { get; set; }

        public string[] ToArray()
        {
            var infos = new string[4];
            infos[0] = CampaignName;
            infos[1] = CampaignKeyword;
            infos[2] = (ReferrerTimestamp - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            infos[3] = ReferrerUrl;
            return infos;
        }
    }
}