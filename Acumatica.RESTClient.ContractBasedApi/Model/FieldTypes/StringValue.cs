using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class StringValue : RestValueBase<string>
    {
        public static implicit operator string(StringValue value) => value?.Value;
        public static implicit operator StringValue(string value) => new StringValue(value);

        public StringValue(string value = default)
        {
            this.Value = value;
        }
    }
}
