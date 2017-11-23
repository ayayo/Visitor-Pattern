using System;

namespace VisitorPattern
{
    public class ListVisitor : IVisitor
    {
        private string currentDir = "";

        public void Visit(IFile file)
        {
            Console.WriteLine(currentDir + "/" + ToString(file));
        }

        public void Visit (IDirectory directory)
        {
			Console.WriteLine(currentDir + "/" + ToString(directory));
            string savedir = currentDir;
            currentDir = currentDir + "/" + directory.Name;
			foreach (var entry in directory.ChildEntries)
			{
				entry.Accept(this);
			}

			currentDir = savedir;
        }

		public static string ToString(IEntry entry)
		{
			return entry.Name + " (" + entry.GetSize() + ")";
		}


	}
}
