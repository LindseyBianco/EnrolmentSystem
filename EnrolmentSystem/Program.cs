using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // get hash code
            Console.WriteLine(student01.GetHashCode());

            Console.ReadKey();
        }
    }
}
