using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Subject
    {
        //constants
        public const string DEFAULT_SUBJECT_CODE = "No subjectCode provided.";
        public const string DEFAULT_SUBJECT_NAME = "No subjectName provided.";
        public const double DEFAULT_COST = -1;

        // variables
        private string subjectCode;
        private string subjectName;
        private double cost;

        // get set properties
        public string SubjectCode { get { return subjectCode; } set { subjectCode = value; } }
        public string SubjectName { get { return subjectName; } set { subjectName = value; } }
        public double Cost { get { return cost; } set { cost = value; } }

        // no arg
        public Subject() : this(DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_COST)
        {
        }

        // all arg
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("- Subject:");
            stringBuilder.AppendLine($"  - Cost:  {subjectCode}");
            stringBuilder.AppendLine($"  - Subject Name: {subjectName}");
            stringBuilder.AppendLine($"  - Cost: {cost}");
            return stringBuilder.ToString();
        }
    }
}
