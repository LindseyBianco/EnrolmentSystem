using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrolmentSystem;
using NUnit.Framework;

namespace EnrolmentSystemTests
{
    [TestFixture]
    public class UtilityTests
    {
        private Student[] students;

        [SetUp]
        public void Setup()
        {
            Student student968 = new Student("968", "nil", "-1", new Enrollment());
            Student student516 = new Student("516", "nil", "-1", new Enrollment());
            Student student535 = new Student("535", "nil", "-1", new Enrollment());
            Student student091 = new Student("091", "nil", "-1", new Enrollment());
            Student student560 = new Student("560", "nil", "-1", new Enrollment());
            Student student345 = new Student("345", "nil", "-1", new Enrollment());
            Student student882 = new Student("882", "nil", "-1", new Enrollment());
            Student student599 = new Student("599", "nil", "-1", new Enrollment());
            Student student302 = new Student("302", "nil", "-1", new Enrollment());
            Student student683 = new Student("683", "nil", "-1", new Enrollment());
            
            students = new Student[]
            { 
                student968,
                student516,
                student535,
                student091,
                student560,
                student345,
                student882,
                student599,
                student302,
                student683
            };
        }

        [Test]
        public void TestLinearSearchFound()
        {
            // arrange
            Student targetStudent = students[0];

            // act
            int index = Utility.LinearSearchArray(students, targetStudent);

            // assert
            Assert.AreEqual(index, 0, "Expected student found.");
        }

        [Test]
        public void TestLinearSearchNotFound()
        {
            // arrange
            Student studentNotInArray = new Student();

            // act
            int index = Utility.LinearSearchArray(students, studentNotInArray);

            // assert
            Assert.AreNotEqual(index, -1, "Expected student not found.");
        }

        [Test]
        public void TestBinarySearchFound()
        {
            // arrange
            Student targetStudent = students[1];

            // act
            int index = Utility.BinarySearchArray(students, targetStudent);

            // assert
            Assert.AreNotEqual(index, -1, "Expected student found.");
        }

        [Test]
        public void TestBinarySearchNotFound()
        {
            // arrange
            Student studentNotInArray = new Student();

            // act
            int index = Utility.BinarySearchArray(students, studentNotInArray);

            // assert
            Assert.AreNotEqual(index, -1, "Expected student not found.");
        }

        [Test]
        public void TestBubbleSortAscending()
        {
            // arrange
            Student[] studentsSorted = students.Clone() as Student[];
            Array.Sort(studentsSorted);

            // act
            Utility.BubbleSortAscending(students);

            // assert
            Assert.AreEqual(students, studentsSorted);
        }

        [Test]
        public void TestBubbleSortDescending()
        {
            // arrange
            Student[] studentsSorted = students.Clone() as Student[];
            Array.Sort(studentsSorted, (x, y) => y.CompareTo(x));

            // act
            Utility.BubbleSortDescending(students);

            // assert
            Assert.AreEqual(students, studentsSorted);
        }
    }
}
