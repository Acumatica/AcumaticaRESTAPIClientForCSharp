using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class StringSingleSelectValue : RestValueBase<StringSelectInnerValue>
    {
        public static implicit operator string?(StringSingleSelectValue? value) => value?.Value?.ID;
        public static implicit operator StringSingleSelectValue(string? value) => new StringSingleSelectValue(value);

        /// <summary>
        /// Parameterless constructor required by the JSON deserializer. Without it
        /// Newtonsoft.Json binds the "value" member of the payload to the constructor
        /// parameter below instead of to <see cref="RestValueBase{TValue}.Value"/>.
        /// </summary>
        public StringSingleSelectValue()
        {
        }

        public StringSingleSelectValue(string? value)
        {
            if (value == null)
            {
                this.Value = null;
                return;
            }
            this.Value = new StringSelectInnerValue(value);
        }
    }

    [DataContract]
    public class StringSelectInnerValue : IEquatable<StringSelectInnerValue>
    {
        public StringSelectInnerValue(string id)
        {
            ID = id;
        }

        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string? Description { get; set; }

        public override string ToString() => ID;

        public bool Equals(StringSelectInnerValue? other)
            => other is not null && string.Equals(ID, other.ID, StringComparison.Ordinal);

        public override bool Equals(object? obj) => Equals(obj as StringSelectInnerValue);

        public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(ID);
    }
}