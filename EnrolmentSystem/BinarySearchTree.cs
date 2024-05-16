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

        public bool Add(string value)
        {
            BinarySearchTreeNode before = null;
            BinarySearchTreeNode after = this.Root;

            while (after != null)
            {
                before = after;
                int comparisonResult = value.CompareTo(after.Data);
                if (comparisonResult < 0)
                    after = after.LeftNode;
                else if (comparisonResult > 0)
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
                int comparisonResult = value.CompareTo(before.Data);
                if (comparisonResult < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public BinarySearchTreeNode Find(string value)
        {
            return this.Find(value, this.Root);
        }

        private BinarySearchTreeNode Find(string value, BinarySearchTreeNode parent)
        {
            if (parent != null)
            {
                int comparisonResult = value.CompareTo(parent.Data);
                if (comparisonResult == 0)
                    return parent;
                if (comparisonResult < 0)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(string value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BinarySearchTreeNode Remove(BinarySearchTreeNode parent, string key)
        {
            if (parent == null)
                return parent;
            int comparisonResult = key.CompareTo(parent.Data);
            if (comparisonResult < 0)
                parent.LeftNode = Remove(parent.LeftNode, key);
            else if (comparisonResult > 0)
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

        private string MinValue(BinarySearchTreeNode node)
        {
            string minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        public string TraversePreOrder(BinarySearchTreeNode parent)
        {
            if (parent == null)
                return string.Empty;

            string result = parent.Data + " ";
            result += TraversePreOrder(parent.LeftNode);
            result += TraversePreOrder(parent.RightNode);

            return result;
        }

        public string TraverseInOrder(BinarySearchTreeNode parent)
        {
            if (parent == null)
                return string.Empty;

            string result = TraverseInOrder(parent.LeftNode);
            result += parent.Data + " ";
            result += TraverseInOrder(parent.RightNode);

            return result;
        }

        public string TraversePostOrder(BinarySearchTreeNode parent)
        {
            if (parent == null)
                return string.Empty;

            string result = TraversePostOrder(parent.LeftNode);
            result += TraversePostOrder(parent.RightNode);
            result += parent.Data + " ";

            return result;
        }
    }
}
