using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {

        public Node Add(Node RootNode, int data)
        {
            if (RootNode == null)
            {
                RootNode = new Node(data);
                RootNode.data = data;
            }
            else if (data < RootNode.data)
            {
                RootNode.leftNode = Add(RootNode.leftNode, data);
            }
            else
            {
                RootNode.rightNode = Add(RootNode.rightNode, data);
            }
            return RootNode;

        }

        public Node Search(Node currentNode, int searchValue)
        {
            if (currentNode != null)
            {
                if (searchValue == currentNode.data)
                {
                    return currentNode;
                }
                if (searchValue < currentNode.data)
                {
                    return Search(currentNode.leftNode, searchValue);
                }
                else
                {
                    return Search(currentNode.rightNode, searchValue);
                }
            }
            return null;
        }
    }
}
