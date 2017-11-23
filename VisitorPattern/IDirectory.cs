using System.Collections;

namespace VisitorPattern
{
	public interface IDirectory : IEntry
	{
		void Add(IEntry entry);

		IEnumerator GetEnumerator();
	}
}
