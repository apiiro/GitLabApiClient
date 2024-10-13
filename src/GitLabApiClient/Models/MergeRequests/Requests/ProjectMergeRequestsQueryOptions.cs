using System.Collections.Generic;

namespace GitLabApiClient.Models.MergeRequests.Requests
{
    /// <inheritdoc />
    /// <summary>
    /// Options for project merge requests listing.
    /// </summary>
    public sealed class ProjectMergeRequestsQueryOptions : MergeRequestsQueryOptions
    {
        /// <summary>
        /// Initializes a new instance of ProjectMergeRequestsQueryOptions.
        /// </summary>
        internal ProjectMergeRequestsQueryOptions()
        {
        }

        /// <summary>
        /// Return the request having the given ids.
        /// </summary>
        public IList<long> MergeRequestsIds { get; set; } = new List<long>();
    }
}
