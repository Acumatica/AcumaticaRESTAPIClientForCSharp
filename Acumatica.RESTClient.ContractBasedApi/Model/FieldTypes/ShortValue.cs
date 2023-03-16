using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
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
