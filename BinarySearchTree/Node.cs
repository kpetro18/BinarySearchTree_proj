﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        int item;
        public int data;
        public Node leftNode;
        public Node rightNode;

        public Node(int item)
        {
            this.item = item;

            leftNode = null;
            rightNode = null;
        }
    }
}
