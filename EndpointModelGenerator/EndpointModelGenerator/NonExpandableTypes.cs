using System.Collections.Generic;

namespace EndpointModelGenerator
{
    public static class NonExpandableTypes
    {
        public static List<string> Types
        {
            get
            {
                return new List<string>
                {
                    "StringValue",
                    "IntValue",
                    "DecimalValue",
                    "BooleanValue",
                    "ByteValue",
                    "DateTimeValue",
                    "DoubleValue",
                    "GuidValue",
                    "LongValue",
                    "ShortValue",
                };
            }
        }
    }
}

