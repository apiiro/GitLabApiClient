namespace GitLabApiClient.Models
{
    // per this documentation https://docs.gitlab.com/api/access_requests/#:~:text=The%20access%20levels%20are%20defined,Guest%20(%2010%20)
    public enum AccessLevel
    {
        NoAccess = 0,
        MinimalAccess = 5,
        Guest = 10,
        Planner = 15,
        Reporter = 20,
        Developer = 30,
        Maintainer = 40,
        Owner = 50 // Only valid for groups
    }
}
