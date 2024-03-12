using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 01 - Data Structures and Algorithms
            // Part 01

            // class testing
            Address address01 = new Address();
            Person person01 = new Person();
            Subject subject01 = new Subject();
            Enrollment enrollment01 = new Enrollment();
            Student student01 = new Student();

            Console.WriteLine(address01);
            Console.WriteLine(person01);
            Console.WriteLine(subject01);
            Console.WriteLine(enrollment01);
            Console.WriteLine(student01);

            Address address02 = new Address("1", "Main St", "Adelaide", 5000, "SA");
            Person person02 = new Person("Lindsey", "lindsey@student.com.au", "0401234567", address02);
            Subject subject02 = new Subject("ICT000123", "C#", 123.45);
            Enrollment enrollment02 = new Enrollment("01/03/24", "PASS", "S1", subject02);
            Student student02 = new Student(123, "IT", "01/03/24", person02, enrollment02);

            Console.WriteLine(address02);
            Console.WriteLine(person02);
            Console.WriteLine(subject02);
            Console.WriteLine(enrollment02);
            Console.WriteLine(student02);

            // equal method
            Address address03 = new Address("100", "Example St", "Adelaide", 5000, "SA");
            Person person03 = new Person("John Appleseed", "jappleseedy@student.com.au", "0407654321", address03);
            Subject subject03 = new Subject("ICT000456", "Java", 543.21);
            Enrollment enrollment03 = new Enrollment("01/03/24", "PASS", "S1", subject03);
            Student student03 = new Student(456, "IT", "01/03/24", person03, enrollment03);

            Console.WriteLine(student03.Equals(student02));
            Console.WriteLine(student03 == student02);

            // Part 01 - Hashing
            // get hash code
            Console.WriteLine(student01.GetHashCode());

            // Part 02 - Sorting and Searching Specifications
            // Part 02.01 - Searching
            Student student04 = new Student(789, "IT", "12/03/24", new Enrollment());
            Student student05 = new Student(987, "Chemistry", "12/03/24", new Enrollment());
            Student student06 = new Student(654, "Art", "12/03/24", new Enrollment());

            DisplayOrder(student04, student05);
            DisplayOrder(student05, student06);
            DisplayOrder(student04, student06);

            Console.ReadKey();
        }

        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
                Console.WriteLine("{0} = {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0} > {1}", x, y);
            else
                Console.WriteLine("{0} < {1}", x, y);
        }
    }
}
