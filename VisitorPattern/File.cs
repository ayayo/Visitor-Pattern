namespace VisitorPattern
{
    public class File : IFile
    {
        private int Size { get; }

		public string Name { get; }

		public File(string name,int size)
        {
			Name = name;
            Size = size;
        }

		public int GetSize() => Size;

		public void Accept(IVisitor visitor) => visitor.Visit(this);
	}
}
