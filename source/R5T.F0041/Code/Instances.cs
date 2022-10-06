using System;

using R5T.F0002;
using R5T.F0032;
using R5T.S0043.Library;


namespace R5T.F0041
{
    public static class Instances
    {
        public static S0043.Library.IDirectoryNameOperator DirectoryNameOperator { get; } = S0043.Library.DirectoryNameOperator.Instance;
        public static IDirectoryPaths DirectoryPaths { get; } = S0043.Library.DirectoryPaths.Instance;
        public static IEnumerationHelper EnumerationHelper { get; } = F0002.EnumerationHelper.Instance;
        public static IFilePaths FilePaths { get; } = F0041.FilePaths.Instance;
        public static IGitHubLicenseIdentifiers GitHubLicenseIdentifiers { get; } = F0041.GitHubLicenseIdentifiers.Instance;
        public static IGitHubOperator GitHubOperator { get; } = F0041.GitHubOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = S0043.Library.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = S0043.Library.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = S0043.Library.GitHubOwners.Instance;
        public static IGitHubRepositoryLicenseOperator GitHubRepositoryLicenseOperator { get; } = F0041.GitHubRepositoryLicenseOperator.Instance;
        public static IGitHubRepositorySpecificationOperator GitHubRepositorySpecificationOperator { get; } = F0041.GitHubRepositorySpecificationOperator.Instance;
        public static IGitHubRepositoryVisibilityOperator GitHubRepositoryVisibilityOperator { get; } = F0041.GitHubRepositoryVisibilityOperator.Instance;
        public static IGitOperator GitOperator { get; } = F0041.GitOperator.Instance;
        public static IJsonOperator JsonOperator { get; } = F0032.JsonOperator.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = S0043.Library.RepositoryNameOperator.Instance;
    }
}