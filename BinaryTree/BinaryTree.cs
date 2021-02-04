using System.Runtime.Serialization.Json;

namespace BinaryTree
{
    public class BinaryTree
    {
        //Root Node
        private TreeNode root;

        //Insert
        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        //Traversals
        public void InOrderTraversal()
        {
            root?.InOrderTraversal();
        }

        public void PreOrderTraversal()
        {
            root?.PreOrderTraversal();
        }

        public void PostOrderTraversal()
        {
            root?.PostOrderTraversal();
        }

        //Find Method
        public TreeNode Find(int data)
        {
            if (root != null)
            {
                return root.Find(data);
            }

            return null;
        }

        public TreeNode FindRecursively(int data)
        {
            if (root != null)
            {
                return root.FindRecursively(data);
            }

            return null;
        }

        public void SoftDelete(int value)
        {
            //if root is not null, invoke SoftDelete
            root?.SoftDelete(value);
        }

    }
}
