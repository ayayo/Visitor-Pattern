namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(IFile file);
        void Visit(IDirectory directory);
    }
}
