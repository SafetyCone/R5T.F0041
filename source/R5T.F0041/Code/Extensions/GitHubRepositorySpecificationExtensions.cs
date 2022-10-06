using System;


namespace R5T.F0041
{
    public static class GitHubRepositorySpecificationExtensions
    {
        public static void IsPrivate(this GitHubRepositorySpecification repositorySpecification,
            bool isPrivate)
        {
            Instances.GitHubRepositorySpecificationOperator.IsPrivate(
                repositorySpecification,
                isPrivate);
        }
    }
}
