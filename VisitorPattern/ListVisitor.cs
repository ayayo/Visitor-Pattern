using System;

namespace VisitorPattern
{
    public class ListVisitor : IVisitor
    {
        private string currentdir = "";

        public void Visit(IFile file)
        {
            Console.WriteLine(currentdir + "/" + ToString(file));
        }

        public void Visit (IDirectory directory)
        {
			Console.WriteLine(currentdir + "/" + ToString(directory));
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.Name;
			foreach (var entry in directory.ChildEntries)
			{
				entry.Accept(this);
			}

			currentdir = savedir;
        }

		public static string ToString(IEntry entry)
		{
			return entry.Name + " (" + entry.GetSize() + ")";
		}


	}
}
