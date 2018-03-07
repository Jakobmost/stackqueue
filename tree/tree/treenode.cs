using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class TreeNode<T>
    {
        public T value;
        public bool hasParent;
        public List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value != null)
            {
                this.value = value;
                this.children = new List<TreeNode<T>>();
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return children[index];
        }
    }
}
