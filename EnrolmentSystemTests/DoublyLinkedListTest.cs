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
    public class DoublyLinkedListTest
    {
        private DoublyLinkedList<Student> studentDoublyLinkedList;
        private Student student968;
        private Student student516;
        private Student student535;
        private Student student091;
        private Student student560;
        private Student student345;
        private Student student882;
        private Student student599;
        private Student student302;
        private Student student683;

        [SetUp]
        public void Setup()
        {
            studentDoublyLinkedList = new DoublyLinkedList<Student>();

            student968 = new Student("968", "nil", "-1", new Enrollment());
            student516 = new Student("516", "nil", "-1", new Enrollment());
            student535 = new Student("535", "nil", "-1", new Enrollment());
            student091 = new Student("091", "nil", "-1", new Enrollment());
            student560 = new Student("560", "nil", "-1", new Enrollment());
            student345 = new Student("345", "nil", "-1", new Enrollment());
            student882 = new Student("882", "nil", "-1", new Enrollment());
            student599 = new Student("599", "nil", "-1", new Enrollment());
            student302 = new Student("302", "nil", "-1", new Enrollment());
            student683 = new Student("683", "nil", "-1", new Enrollment());
        }

        [Test]
        public void TestAddFirst()
        {
            // arrange
            studentDoublyLinkedList.Add(student516);

            // act
            studentDoublyLinkedList.AddFirst(student968);

            // assert
            Assert.AreEqual(student968, studentDoublyLinkedList.Head.Value);

        }

        [Test]
        public void TestAddLast()
        {
            // arrange
            studentDoublyLinkedList.Add(student535);

            // act
            studentDoublyLinkedList.AddLast(student091);

            // assert
            Assert.AreEqual(student091, studentDoublyLinkedList.Tail.Value);
        }

        [Test]
        public void TestContains()
        {
            // arrange
            studentDoublyLinkedList.Add(student560);

            // act
            bool contains = studentDoublyLinkedList.Contains(student560);

            // assert
            Assert.IsTrue(contains);
        }

        [Test]
        public void TestRemoveFirst()
        {
            // arrange
            studentDoublyLinkedList.Add(student882);
            studentDoublyLinkedList.AddFirst(student345);

            // act
            studentDoublyLinkedList.RemoveFirst();

            // assert
            Assert.AreEqual(student882, studentDoublyLinkedList.Head.Value);
        }

        [Test]
        public void TestRemoveLast()
        {
            // arrange
            studentDoublyLinkedList.Add(student599);
            studentDoublyLinkedList.AddLast(student302);

            // act
            studentDoublyLinkedList.RemoveLast();

            // assert
            Assert.AreEqual(student599, studentDoublyLinkedList.Tail.Value);
        }
    }
}
