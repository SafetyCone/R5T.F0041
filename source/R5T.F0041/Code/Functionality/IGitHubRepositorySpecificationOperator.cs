using System;

using R5T.T0132;


namespace R5T.F0041
{
	[FunctionalityMarker]
	public partial interface IGitHubRepositorySpecificationOperator : IFunctionalityMarker
	{
        public void IsPrivate(GitHubRepositorySpecification repositorySpecification,
            bool isPrivate)
        {
            if (isPrivate)
            {
                repositorySpecification.Visibility = GitHubRepositoryVisibility.Private;
            }
            else
            {
                repositorySpecification.Visibility = GitHubRepositoryVisibility.Public;
            }
        }
    }
}