using System;

using R5T.T0132;
using R5T.T0209;


namespace R5T.F0041
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryUrlOperator : IFunctionalityMarker
    {
        public GitHubRepositoryIdentifier Get_Identifier(string gitHubRepositoryUrl)
        {
            var tokens = gitHubRepositoryUrl.Split('/');

            var unadjustedName = tokens[^1];
            var owner = tokens[^2];

            var name = Instances.StringOperator.Trim_End(
                unadjustedName,
                ".git");            

            var output = new GitHubRepositoryIdentifier
            {
                OwnerName = owner,
                RepositoryName = name,
            };

            return output;
        }
    }
}
