using System;

namespace BinaryTree
{
    public class TreeNode
    {
        //Constructor
        public TreeNode(int value)
        {
            Data = value;
        }

        public int Data { get; }

        public TreeNode RightNode { get; private set; } //Right Child

        public TreeNode LeftNode { get; private set; } //Left Child

        public bool IsDeleted { get; private set; } //IsDeleted

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Insert(int value)
        {
            //if the value passed is greater than or equal to the data then insert right node
            if (value >= Data)
            {
                //if rightNode is null, instantiate a new rightNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode(value);
                }
                //if not null, recursively call insert on the rightNode
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                //if the value passed is less than the data, insert left node
                //if leftNode is null, instantiate one
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(value);
                }
                //if not null, recursively call Insert on the leftNode
                else
                {
                    LeftNode.Insert(value);
                }
            }
        }
        public void InOrderTraversal()
        {

            //if leftNode is null, call InOrderTraversal recursively
            LeftNode?.InOrderTraversal();

            Console.Write(Data + " ");
            //if rightNode is null, call InOrderTraversal recursively
            RightNode?.InOrderTraversal();

        }

        public void PreOrderTraversal()
        {
            Console.Write(Data + " ");

            LeftNode?.PreOrderTraversal();

            RightNode?.PreOrderTraversal();

        }

        public void PostOrderTraversal()
        {
            LeftNode?.PostOrderTraversal();

            RightNode?.PostOrderTraversal();

            Console.Write(Data + " ");
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.Data && !IsDeleted)
                {
                    return currentNode;
                }
                //if the value passed is greater than the currentNode.Data go to right child
                else if (value >= currentNode.Data)
                {
                    currentNode = currentNode.RightNode;
                }
                //else if the value passed is less than the currentNode.Data go to left child
                else if (value < currentNode.Data)
                {
                    currentNode = currentNode.LeftNode;
                }
            }

            //Node not found
            return null;
        }

    }
}
