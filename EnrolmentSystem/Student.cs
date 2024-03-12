using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Student : Person, IComparable<Student>
    {
        // variables
        private int studentID;
        private string program;
        private string dateRegistered;

        // get set properties
        public int StudentID { get { return studentID; } set { studentID = value; } }
        public string Program { get { return program; } set { program = value; } }
        public string DateRegistered { get { return dateRegistered; } set { dateRegistered = value; } }
        public Enrollment Enrollment { get; set; }

        const int DEF_STUDENT_ID = -1;
        const string DEFAULT_PROGRAM = "No program provided.";
        const string DEFAULT_DATE_REGISTERED = "No dateRegistered provided.";

        /// <summary>
        /// No-arg Default Constructor.
        /// Creates a new instance of the Student class with default values.
        /// </summary>
        public Student() : this(DEF_STUDENT_ID, DEFAULT_PROGRAM, DEFAULT_DATE_REGISTERED, new Enrollment())
        {
        }

        /// <summary>
        /// Constructor with Enrolment information.
        /// Initialises a new instance of the Student class with the specified student ID, program, date registered, and enrollment.
        /// </summary>
        /// <param name="studentID">The unique identifier of the student.</param>
        /// <param name="program">The program in which the student is enrolled.</param>
        /// <param name="dateRegistered">The date when the student was registered.</param>
        /// <param name="enrollment">The enrollment details of the student.</param>
        public Student(int studentID, string program, string dateRegistered, Enrollment enrollment) : base()
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        /// <summary>
        /// All-arg Constructor with Enrolment and Person information.
        /// Initialises a new instance of the Student class with the specified student ID, program, date registered, person details, and enrollment information.
        /// </summary>
        /// <param name="studentID">The unique identifier of the student.</param>
        /// <param name="program">The program in which the student is enrolled.</param>
        /// <param name="dateRegistered">The date when the student was registered.</param>
        /// <param name="person">The personal details of the student (name, email, phone number, address).</param>
        /// <param name="enrollment">The enrollment details of the student.</param>
        public Student(int studentID, string program, string dateRegistered, Person person, Enrollment enrollment) : base(person.Name, person.Email, person.PhoneNumber, person.Address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }
       
        /// <summary>
        /// Override ToString.
        /// Returns a string representation of the Student object.
        /// </summary>
        /// <returns>A string containing the Student's ID, program, and registration date.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("- Student");
            stringBuilder.AppendLine($"  - StudentID: {studentID}");
            stringBuilder.AppendLine($"  - Program: {program}");
            stringBuilder.AppendLine($"  - Date Registered: {dateRegistered}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Override Equals method.
        /// Determines whether the specified object is equal to the current student.
        /// </summary>
        /// <param name="obj">The object to compare with the current student.</param>
        /// <returns>True if the specified object is equal to the current student; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student student = (Student)obj;
            return student.StudentID == this.StudentID;
        }

        /// <summary>
        /// Overload Equal To Operator.
        /// Determines whether two Student objects are equal.
        /// </summary>
        /// <param name="a">The first Student object to compare.</param>
        /// <param name="b">The second Student object to compare.</param>
        /// <returns>True if the two Student objects are equal, false otherwise.</returns>
        public static bool operator ==(Student a, Student b)
        {
            return object.Equals(a, b);
        }

        /// <summary>
        /// Overload Not Equal To Operator.
        /// Determines whether two Student objects are not equal.
        /// </summary>
        /// <param name="a">The first Student object to compare.</param>
        /// <param name="b">The second Student object to compare.</param>
        /// <returns>True if the two Student objects are not equal; otherwise, false.</returns>
        public static bool operator !=(Student a, Student b)
        {
            return !object.Equals(a, b);
        }

        public static bool operator <(Student a, Student b)
        {
            return a.StudentID < b.StudentID;
        }

        public static bool operator <=(Student a, Student b)
        {
            return a.StudentID <= b.StudentID;
        }

        public static bool operator >(Student a, Student b)
        {
            return a.StudentID > b.StudentID;
        }

        public static bool operator >=(Student a, Student b)
        {
            return a.StudentID >= b.StudentID;
        }

        // override HashSet
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode() ^ this.dateRegistered.GetHashCode();
        }



        // override CompareTo
        public int CompareTo(Student other)
        {
            return this.StudentID.CompareTo(other.studentID);
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is Student))
                throw new ArgumentException("Expected Student istance is type Student.");
            return CompareTo((Student)obj);
        }

        
    }
}
