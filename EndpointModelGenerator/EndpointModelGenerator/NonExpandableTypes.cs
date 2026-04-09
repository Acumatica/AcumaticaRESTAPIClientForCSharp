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
					"StringMultiSelectValue",
					"IntSingleSelectValue",
					"StringSingleSelectValue",
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

