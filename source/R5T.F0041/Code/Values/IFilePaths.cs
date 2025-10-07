using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.F0041
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker,
		Z0069.IFilePaths
	{
#pragma warning disable IDE1006 // Naming Styles

		[Ignore]
        Z0069.IFilePaths _Z0069 => Z0069.FilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles
	}
}