namespace Acumatica.RESTClient.Auxiliary
{
    internal static class Constants
    {
        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        public const string ApplicationJsonAcceptContentType = "application/json";
        public const string TextJsonAcceptContentType = "text/json";
        public const string ApplicationXmlAcceptContentType = "application/xml";
        public const string TextXmlAcceptContentType = "text/xml";
        public const string WwwFormEncoded = "application/x-www-form-urlencoded";
        public const string OctetStream = "application/octet-stream";
        public const string AnyAcceptContentType = "*/*";
    }
}