using System;


namespace R5T.F0041
{
	public class RepositoryOperator : IRepositoryOperator
	{
		#region Infrastructure

	    public static IRepositoryOperator Instance { get; } = new RepositoryOperator();

	    private RepositoryOperator()
	    {
        }

	    #endregion
	}
}