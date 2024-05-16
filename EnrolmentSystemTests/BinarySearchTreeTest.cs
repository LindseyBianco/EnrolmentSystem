using EnrolmentSystem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemTests
{
    [TestFixture]
    public class BinarySearchTreeTest
    {
        private BinarySearchTree studentBinarySearchTree;

        [SetUp]
        public void Setup()
        {
            studentBinarySearchTree = new BinarySearchTree();

            studentBinarySearchTree.Add(968);
            studentBinarySearchTree.Add(516);
            studentBinarySearchTree.Add(535);
            studentBinarySearchTree.Add(091);
            studentBinarySearchTree.Add(560);
            studentBinarySearchTree.Add(345);
            studentBinarySearchTree.Add(882);
            
        }

        [Test]
        public void TestTraversePreOrder()
        {
            // Arrange
            EnrolmentSystem.BinarySearchTree tree = new EnrolmentSystem.BinarySearchTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(20);

            List<int> expectedOrder = new List<int> { 10, 5, 3, 7, 15, 12, 20 };
            List<int> actualOrder = new List<int>();

            // Act
            tree.TraversePreOrder(tree.Root, (data) => actualOrder.Add(data));

            // Assert
            CollectionAssert.AreEqual(expectedOrder, actualOrder);
        }

    }
}
