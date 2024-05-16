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
        private Student student968;
        private Student student516;
        private Student student535;
        private Student student091;
        private Student student560;
        private Student student345;
        private Student student882;

        [SetUp]
        public void Setup()
        {
            studentBinarySearchTree = new BinarySearchTree();

            student968 = new Student("968", "nil", "-1", new Enrollment());
            student516 = new Student("516", "nil", "-1", new Enrollment());
            student535 = new Student("535", "nil", "-1", new Enrollment());
            student091 = new Student("091", "nil", "-1", new Enrollment());
            student560 = new Student("560", "nil", "-1", new Enrollment());
            student345 = new Student("345", "nil", "-1", new Enrollment());
            student882 = new Student("882", "nil", "-1", new Enrollment());


            studentBinarySearchTree.Add(student968.StudentID);
            studentBinarySearchTree.Add(student516.StudentID);
            studentBinarySearchTree.Add(student535.StudentID);
            studentBinarySearchTree.Add(student091.StudentID);
            studentBinarySearchTree.Add(student560.StudentID);
            studentBinarySearchTree.Add(student345.StudentID);
            studentBinarySearchTree.Add(student882.StudentID);
        }

        [Test]
        public void TestTraversePreOrder()
        {
            // act
            string result = studentBinarySearchTree.TraversePreOrder(studentBinarySearchTree.Root);

            // assert
            Assert.AreEqual("968 516 091 345 535 560 882 ", result);
        }

        [Test]
        public void TestTraversePostOrder()
        {
            // act
            string result = studentBinarySearchTree.TraversePostOrder(studentBinarySearchTree.Root);

            // assert
            Assert.AreEqual("345 091 882 560 535 516 968 ", result);
        }

        [Test]
        public void TestTraverseInOrder()
        {
            // act
            string result = studentBinarySearchTree.TraverseInOrder(studentBinarySearchTree.Root);

            // assert
            Assert.AreEqual("091 345 516 535 560 882 968 ", result);
        }
    }
}
