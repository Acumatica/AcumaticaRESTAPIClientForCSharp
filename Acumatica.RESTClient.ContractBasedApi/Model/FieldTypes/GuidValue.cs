using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
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
