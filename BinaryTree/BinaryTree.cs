namespace BinaryTree
{
    public class BinaryTree
    {
        private TreeNode root;

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



        public TreeNode Find(int data)
        {
            if (root != null)
            {
                return root.Find(data);
            }

            return null;
        }
    }
}
