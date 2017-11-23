namespace VisitorPattern
{
	public interface IEntry
    {
        string Name { get; }
		int GetSize();
		void Accept(IVisitor v);
    }
}
