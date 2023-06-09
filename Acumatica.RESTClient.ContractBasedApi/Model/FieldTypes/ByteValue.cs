using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class ByteValue : RestValueBase<byte?>
    {
        public static implicit operator byte?(ByteValue value) => value.Value;
        public static implicit operator ByteValue(byte? value) => new ByteValue(value);

        public ByteValue(byte? value = default)
        {
            this.Value = value;
        }
    }
}
