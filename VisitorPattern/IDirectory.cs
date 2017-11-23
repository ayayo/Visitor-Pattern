using System.Collections.Generic;

namespace VisitorPattern
{
	public interface IDirectory : IEntry
	{
		IReadOnlyList<IEntry> ChildEntries { get; }
		void Add(IEntry entry);
	}
}
