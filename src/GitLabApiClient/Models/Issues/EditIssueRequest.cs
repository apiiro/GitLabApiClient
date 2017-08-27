﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Issues
{
    public class EditIssueRequest
    {
        [JsonProperty("id")]
        public long ProjectId { get; set; }

        [JsonProperty("issue_iid")]
        public long IssueId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("confidential")]
        public bool Confidential { get; set; }

        [JsonProperty("assignee_ids")]
        public List<int> Assignees { get; set; } = new List<int>();

        [JsonProperty("milestone_id")]
        public int? MilestoneId { get; set; }

        [JsonProperty("labels")]
        public string Labels { get; set; }

        [JsonProperty("state_event")]
        public string State { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }
    }
}