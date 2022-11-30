using System;


namespace R5T.F0088
{
	public class VisualStudioOperator : IVisualStudioOperator
	{
		#region Infrastructure

	    public static IVisualStudioOperator Instance { get; } = new VisualStudioOperator();

	    private VisualStudioOperator()
	    {
        }

	    #endregion
	}
}