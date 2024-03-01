using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Student : Person
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

        // no arg
        public Student() : this(DEF_STUDENT_ID, DEFAULT_PROGRAM, DEFAULT_DATE_REGISTERED, new Enrollment())
        {
        }

        // arg with enrolement
        public Student(int studentID, string program, string dateRegistered, Enrollment enrollment) : base()
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        // arg with enrolement and person
        public Student(int studentID, string program, string dateRegistered, Person person, Enrollment enrollment) : base(person.Name, person.Email, person.PhoneNumber, person.Address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        // ToString        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("- Student");
            stringBuilder.AppendLine($"  - StudentID: {studentID}");
            stringBuilder.AppendLine($"  - Program: {program}");
            stringBuilder.AppendLine($"  - Date Registered: {dateRegistered}");

            return stringBuilder.ToString();
        }

        // Equals method
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

        // overload equal operators
        public static bool operator ==(Student a, Student b)
        {
            return object.Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !object.Equals(a, b);
        }

        // override HashSet
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode() ^ this.dateRegistered.GetHashCode();
        }
    }
}
