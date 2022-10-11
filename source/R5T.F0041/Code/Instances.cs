using System;

using R5T.F0002;
using R5T.F0032;
using R5T.F0046;
using R5T.F0047;
using R5T.F0057;


namespace R5T.F0041
{
    public static class Instances
    {
        public static IRepositoryDirectoryNameOperator RepositoryDirectoryNameOperator { get; } = F0057.RepositoryDirectoryNameOperator.Instance;
        public static IDirectoryPathOperator DirectoryPathOperator { get; } = F0041.DirectoryPathOperator.Instance;
        public static IDirectoryPaths DirectoryPaths { get; } = F0057.DirectoryPaths.Instance;
        public static IEnumerationHelper EnumerationHelper { get; } = F0002.EnumerationHelper.Instance;
        public static IFilePaths FilePaths { get; } = F0041.FilePaths.Instance;
        public static IGitHubLicenseIdentifiers GitHubLicenseIdentifiers { get; } = F0041.GitHubLicenseIdentifiers.Instance;
        public static IGitHubOperator GitHubOperator { get; } = F0041.GitHubOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = F0047.GitHubOwners.Instance;
        public static IGitHubRepositoryLicenseOperator GitHubRepositoryLicenseOperator { get; } = F0041.GitHubRepositoryLicenseOperator.Instance;
        public static IGitHubRepositorySpecificationOperator GitHubRepositorySpecificationOperator { get; } = F0041.GitHubRepositorySpecificationOperator.Instance;
        public static IGitHubRepositoryVisibilityOperator GitHubRepositoryVisibilityOperator { get; } = F0041.GitHubRepositoryVisibilityOperator.Instance;
        public static IGitOperator GitOperator { get; } = F0041.GitOperator.Instance;
        public static IJsonOperator JsonOperator { get; } = F0032.JsonOperator.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator { get; } = F0046.RepositoryNameOperator.Instance;
        public static IRepositoryOperator RepositoryOperator { get; } = F0041.RepositoryOperator.Instance;
    }
}