using System;

using R5T.T0142;


namespace R5T.F0041
{
    [DataTypeMarker]
    public class GitHubRepositorySpecification
    {
        public string Organization { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool InitializeWithReadMe { get; set; }
        public GitHubRepositoryVisibility Visibility { get; set; }
        public GitHubRepositoryLicense License { get; set; }
    }
}
