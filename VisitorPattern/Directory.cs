using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class Directory: IDirectory
    {
        private List<IEntry> childEntries = new List<IEntry>();

		public string Name { get; }

		public IReadOnlyList<IEntry> ChildEntries => childEntries;

		public Directory(string name)
        {
			Name = name;
        }

		public int GetSize() => childEntries.Sum(entry => entry.GetSize());

        public void Add(IEntry entry) => childEntries.Add(entry);

		public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
