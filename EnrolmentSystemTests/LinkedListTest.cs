using EnrolmentSystem;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemTests
{
    [TestFixture]
    public class LinkedListTest
    {
        private LinkedList<Student> studentLinkedList;
        private Student student968;
        private Student student516;
        private Student student535;
        private Student student091;
        private Student student560;
        private Student student345;
        private Student student882;
        private Student student599;
        private Student student302;

        [SetUp]
        public void Setup()
        {
            studentLinkedList = new LinkedList<Student>();

            student968 = new Student("968", "nil", "-1", new Enrollment());
            student516 = new Student("516", "nil", "-1", new Enrollment());
            student535 = new Student("535", "nil", "-1", new Enrollment());
            student091 = new Student("091", "nil", "-1", new Enrollment());
            student560 = new Student("560", "nil", "-1", new Enrollment());
            student345 = new Student("345", "nil", "-1", new Enrollment());
            student882 = new Student("882", "nil", "-1", new Enrollment());
            student599 = new Student("599", "nil", "-1", new Enrollment());
            student302 = new Student("302", "nil", "-1", new Enrollment());

        }

        [Test]
        public void TestAddFirst() 
        {
            // arrange
            studentLinkedList.Add(student516);
            
            // act
            studentLinkedList.AddFirst(student968);

            // assert
            Assert.AreEqual(student968, studentLinkedList.Head.Value);
            
        }

        [Test]
        public void TestAddLast()
        {
            // arrange
            studentLinkedList.Add(student535);

            // act
            studentLinkedList.AddLast(student091);

            // assert
            Assert.AreEqual(student091, studentLinkedList.Tail.Value);
        }

        [Test]
        public void TestContains()
        {
            // arrange
            studentLinkedList.Add(student560);

            // act
            bool contains = studentLinkedList.Contains(student560);

            // assert
            Assert.IsTrue(contains);
        }

        [Test]
        public void TestRemoveFirst()
        {
            // arrange
            studentLinkedList.Add(student882);
            studentLinkedList.AddFirst(student345);

            // act
            studentLinkedList.RemoveFirst();
            
            // assert
            Assert.AreEqual(student882, studentLinkedList.Head.Value);
        }

        [Test]
        public void TestRemoveLast()
        {
            // arrange
            studentLinkedList.Add(student599);
            studentLinkedList.AddLast(student302);

            // act
            studentLinkedList.RemoveLast();

            // assert
            Assert.AreEqual(student599, studentLinkedList.Head.Value);
        }
    }
}
