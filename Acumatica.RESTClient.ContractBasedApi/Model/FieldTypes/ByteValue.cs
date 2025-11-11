using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
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
