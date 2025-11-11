using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
    [DataContract]
    public partial class BooleanValue : RestValueBase<bool?>
    {
        public static implicit operator bool?(BooleanValue value) => value.Value;
        public static implicit operator BooleanValue(bool? value) => new BooleanValue(value);

        public BooleanValue(bool? value = default)
        {
            this.Value = value;
        }
    }
}
