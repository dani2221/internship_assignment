using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_assignment
{
    public class Tree
    {
        internal class Branch
        {
            public List<Branch> Children { get; set; } = new List<Branch>();
        }

        private Branch Root;

        public int GetDepth()
        {
            return GetDepthRecursive(Root);
        }

        private int GetDepthRecursive(Branch curr)
        {
            // base case - current branch node is a leaf
            if(curr.Children.Count == 0) { return 1; }

            return 1 + curr.Children.Select(x => GetDepthRecursive(x)).Max();
        }

        public void GenerateTree()
        {
            // Generates tree as in picture
            Root = new Branch();
            Root.Children.Add(new Branch());
            Root.Children[0].Children.Add(new Branch());
            Root.Children.Add(new Branch());
            Root.Children[1].Children.Add(new Branch());
            Root.Children[1].Children.Add(new Branch());
            Root.Children[1].Children.Add(new Branch());
            Root.Children[1].Children[0].Children.Add(new Branch());
            Root.Children[1].Children[1].Children.Add(new Branch());
            Root.Children[1].Children[1].Children[0].Children.Add(new Branch());
            Root.Children[1].Children[1].Children.Add(new Branch());
        }
    }
}
