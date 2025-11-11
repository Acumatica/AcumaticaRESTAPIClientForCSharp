using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
    [DataContract]
    public partial class DoubleValue : RestValueBase<double?>
    {
        public static implicit operator double?(DoubleValue value) => value.Value;
        public static implicit operator DoubleValue(double? value) => new DoubleValue(value);

        public DoubleValue(double? value = default)
        {
            this.Value = value;
        }
    }
}
