using System;
using System.IO.Enumeration;

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
            Console.WriteLine(node.Data);

            //Find SoftDeleted element
            binaryTree.SoftDelete(75);
            TreeNode softDeleted = binaryTree.Find(75);

            try
            {
                Console.WriteLine(softDeleted.Data);
            }
            catch (Exception)
            {
                Console.WriteLine("Element not found");
            }


            //Find element recursively
            TreeNode findRecursively = binaryTree.FindRecursively(32);
            Console.WriteLine(findRecursively.Data);

            //Traversals
            binaryTree.PreOrderTraversal();
            Console.Write(Environment.NewLine);
            binaryTree.InOrderTraversal();
            Console.Write(Environment.NewLine);
            binaryTree.PostOrderTraversal();






        }
    }
}
