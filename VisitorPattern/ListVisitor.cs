using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ListVisitor :Visitor
    {
        private string currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine(currentdir + "/" + file);
        }

        public override void Visit (Directory directory)
        {
            Console.WriteLine(currentdir + "/" + directory);
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.GetName();
            IEnumerator it = directory.GetEnumerator();

            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }
    }
}
