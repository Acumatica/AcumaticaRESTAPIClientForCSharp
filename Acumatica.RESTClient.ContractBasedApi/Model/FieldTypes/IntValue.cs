using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class IntValue : RestValueBase<int?>
    {
        public static implicit operator int?(IntValue value) => value.Value;
        public static implicit operator IntValue(int? value) => new IntValue(value);

        public IntValue(int? value = default)
        {
            this.Value = value;
        }
    }
}
