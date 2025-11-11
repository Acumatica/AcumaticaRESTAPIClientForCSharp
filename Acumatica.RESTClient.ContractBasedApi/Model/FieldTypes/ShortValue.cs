using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
    [DataContract]
    public partial class ShortValue : RestValueBase<short?>
    {
        public static implicit operator short?(ShortValue value) => value.Value;
        public static implicit operator ShortValue(short? value) => new ShortValue(value);

        public ShortValue(short? value = default)
        {
            this.Value = value;
        }
    }
}
