using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class LongValue : RestValueBase<long?>
    {
        public static implicit operator long?(LongValue value) => value.Value;
        public static implicit operator LongValue(long? value) => new LongValue(value);

        public LongValue(long? value = default)
        {
            this.Value = value;
        }
    }
}
