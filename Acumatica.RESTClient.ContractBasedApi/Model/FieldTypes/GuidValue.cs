using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class GuidValue : RestValueBase<Guid?>
    {
        public static implicit operator Guid?(GuidValue value) => value.Value;
        public static implicit operator GuidValue(Guid? value) => new GuidValue(value);

        public GuidValue(Guid? value = default)
        {
            this.Value = value;
        }
    }
}
