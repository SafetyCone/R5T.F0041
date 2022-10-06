using System;

using R5T.F0041;


namespace System
{
    public static class GitHubRepositoryVisibilityExtensions
    {
        public static bool IsPrivate(this GitHubRepositoryVisibility gitHubRepositoryVisibility)
        {
            var output = gitHubRepositoryVisibility == GitHubRepositoryVisibility.Private;
            return output;
        }
    }
}
