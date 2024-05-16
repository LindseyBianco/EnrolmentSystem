using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnrolmentSystem
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; set; }

        public bool Add(int value)
        {
            BinarySearchTreeNode before = null;
            BinarySearchTreeNode after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) 
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            BinarySearchTreeNode newNode = new BinarySearchTreeNode();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public BinarySearchTreeNode Find(int value)
        {
            return this.Find(value, this.Root);
        }

        private BinarySearchTreeNode Find(int value, BinarySearchTreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                    return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BinarySearchTreeNode Remove(BinarySearchTreeNode parent, int key)
        {
            if (parent == null)
                return parent;
            if (key < parent.Data)
                parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(BinarySearchTreeNode node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        public void TraversePreOrder(BinarySearchTreeNode parent, Action<int> action)
        {
            if (parent != null)
            {
                action(parent.Data);
                TraversePreOrder(parent.LeftNode, action);
                TraversePreOrder(parent.RightNode, action);
            }
        }

        public void TraverseInOrder(BinarySearchTreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.WriteLine(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(BinarySearchTreeNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.WriteLine(parent.Data + " ");
            }
        }
    }
}
