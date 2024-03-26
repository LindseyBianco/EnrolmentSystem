using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Enrollment
    {
        // constants
        public const string DEFAULT_DATE_ENROLLED = "No dateEnrolled provided.";
        public const string DEFAULT_GRADE = "No grade provided.";
        public const string DEFAULT_SEMESTER = "No semester provided.";

        // variables
        private string dateEnrolled;
        private string grade;
        private string semester;

        // get set properties
        public string DateEnrolled { get { return dateEnrolled; } set { dateEnrolled = value; } }
        public string Grade { get { return grade; } set { grade = value; } }
        public string Semester { get { return semester; } set { semester = value; } }
        public Subject Subject { get; set; }

        // no arg
        public Enrollment() : this(DEFAULT_DATE_ENROLLED, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {
        }

        // all arg
        public Enrollment(string dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("    - Enrollment:");
            stringBuilder.AppendLine($"       - Date Enrolled: {DateEnrolled}");
            stringBuilder.AppendLine($"       - Grade: {Grade}");
            stringBuilder.AppendLine($"       - Semester: {Semester}");
            stringBuilder.AppendLine($"{Subject}");
            return stringBuilder.ToString();
        }
    }
}
