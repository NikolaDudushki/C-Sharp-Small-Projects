using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation of the tree
            BinaryTree binaryTree = new BinaryTree();

            //Inserts
            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(60);
            binaryTree.Insert(32);

            //Find element
            TreeNode node = binaryTree.Find(57);

            //Traversals
            binaryTree.PreOrderTraversal();
            binaryTree.InOrderTraversal();
            binaryTree.PostOrderTraversal();
        }
    }
}
