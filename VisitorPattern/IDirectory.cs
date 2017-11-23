using System.Collections;

namespace VisitorPattern
{
	public interface IDirectory : IEntry
	{
		IEntry Add(IEntry entry);

		IEnumerator GetEnumerator();
	}
}
