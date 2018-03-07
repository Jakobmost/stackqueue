using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Tree<T>
    {
        public TreeNode<T> root;

        public Tree(T value)
        {
            if (value != null)
            {
                this.root = new TreeNode<T>(value);
            }
        }


        public void BreadthFirstSearch()
        {
            //Create new queue
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            //Put root in queue
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode<T> v = queue.Dequeue();
                Console.WriteLine(v.value);
                foreach (TreeNode<T> c in v.children)
                {
                    queue.Enqueue(c);
                }
            }
        }

        public void DepthFirstSearch()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                TreeNode<T> v = stack.Pop();
                Console.WriteLine(v.value);
                foreach (TreeNode<T> c in v.children)
                {
                    stack.Push(c);
                }

            }
        }
    }
}
