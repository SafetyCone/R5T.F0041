using System;

using R5T.F0041;

using R5T.T0142;

using Instances = R5T.F0041.Instances;


namespace System
{
    [DraftTypeMarker]
    public static class GitHubRepositoryLicenseExtensions
    {
        public static string GetLicenseIdentifier(this GitHubRepositoryLicense gitHubRepositoryLicense)
        {
            var licenseIdentifier = Instances.GitHubRepositoryLicenseOperator.GetLicenseIdentifier(gitHubRepositoryLicense);
            return licenseIdentifier;
        }
    }
}
