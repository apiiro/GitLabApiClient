using System.Collections.Generic;
using GitLabApiClient.Models.Milestones.Responses;

namespace GitLabApiClient.Models.Milestones.Requests
{
    /// <summary>
    /// Options for project milestone listing
    /// </summary>
    public sealed class MilestonesQueryOptions
    {
        internal MilestonesQueryOptions() { }

        /// <summary>
        /// Return only the milestones having the given iid.
        /// </summary>
        public IList<long> MilestoneIds { get; set; } = new List<long>();

        /// <summary>
        /// Return only active or closed milestones.
        /// </summary>
        public MilestoneState State { get; set; }

        /// <summary>
        /// Return only milestones with a title or description matching the provided string.
        /// </summary>
        public string Search { get; set; }
    }
}
