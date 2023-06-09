using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
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
