using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Address
    {
        // variables
        private string streetNum;
        private string streetName;
        private string suburb;
        private int postcode;
        private string state;

        // constants
        const string DEFAULT_STREET_NUM = "No streetNum provided.";
        const string DEFAULT_STREET_NAME = "No streetName provided.";
        const string DEFAULT_SUBURB = "No suburb provided.";
        const int DEFAULT_POSTCODE = -1;
        const string DEFAULT_STATE = "No state provided.";

        // get set properties
        public string StreetNum { get { return streetNum; } set { streetNum = value; } }
        public string StreetName { get { return streetName; } set { streetName = value; } }
        public string Suburb { get { return suburb; } set { suburb = value; } }
        public int Postcode { get { return postcode; } set { postcode = value; } }
        public string State { get { return state; } set { state = value; } }

        // no arg
        public Address() : this(DEFAULT_STREET_NUM, DEFAULT_STREET_NAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE)
        {
        }

        // all arg
        public Address(string streetNum, string streetName, string suburb, int postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("       - Address:");
            stringBuilder.AppendLine($"          - Street Num: {StreetNum}");
            stringBuilder.AppendLine($"          - Street Name: {StreetName}");
            stringBuilder.AppendLine($"          - Suburb: {Suburb}");
            stringBuilder.AppendLine($"          - Postcode: {Postcode}");
            stringBuilder.AppendLine($"          - State: {State}");
            return stringBuilder.ToString();
        }
    }
}
