using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            Node root = null;
            Node result;
            Node dataFound;
            result = binarySearchTree.Add(root, 100);
            binarySearchTree.Add(result, 400);
            binarySearchTree.Add(result, 80);
            binarySearchTree.Add(result, 192);
            binarySearchTree.Add(result, 54);

            dataFound = binarySearchTree.Search(result, 54);
            Console.WriteLine(dataFound.data);

            Console.ReadLine();
        }
    }
}
