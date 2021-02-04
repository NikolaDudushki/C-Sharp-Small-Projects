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

        public TreeNode RightNode { get; set; } //Right Child

        public TreeNode LeftNode { get; set; } //Left Child

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
            //Print the root first
            Console.Write(Data + " ");

            LeftNode?.PreOrderTraversal();

            RightNode?.PreOrderTraversal();

        }

        public void PostOrderTraversal()
        {
            //If leftNode is not null, call PostOrderTraversal recursively
            LeftNode?.PostOrderTraversal();
            
            //If rightNode is not null, call PostOrderTraversal recursively
            RightNode?.PostOrderTraversal();

            //Print the tree
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

        public TreeNode FindRecursively(int value)
        {
            //return the node if the data is equal to value and soft delete is false
            if (value == Data && IsDeleted == false)
            {
                return this;
            }
            //if the value is less than the data and the left node is not null, invoke FindRecursively on the left child node
            if (value < Data && LeftNode != null)
            {
                return LeftNode.FindRecursively(value);
            }
            //else, check if the value is greater than the data and the right node is not null, invoke FindRecursively
            //on the right child node
            if (RightNode != null)
            {
                return RightNode.FindRecursively(value);
            }

            //return null if none of the above return value
            return null;

        }



        public void SoftDelete(int value)
        {
            TreeNode nodeToSoftDelete = Find(value);

            if (nodeToSoftDelete != null)
                nodeToSoftDelete.IsDeleted = true;

        }
    }
}
