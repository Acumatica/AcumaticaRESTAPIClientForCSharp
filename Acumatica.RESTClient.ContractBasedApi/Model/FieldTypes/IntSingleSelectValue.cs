using System;
using System.Globalization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class IntSingleSelectValue : RestValueBase<IntSelectInnerValue>
    {
        public static implicit operator int?(IntSingleSelectValue? value) => value?.Value?.ID;
        public static implicit operator IntSingleSelectValue(int? value) => new IntSingleSelectValue(value);

        /// <summary>
        /// Parameterless constructor required by the JSON deserializer. Without it
        /// Newtonsoft.Json binds the "value" member of the payload to the constructor
        /// parameter below instead of to <see cref="RestValueBase{TValue}.Value"/>.
        /// </summary>
        public IntSingleSelectValue()
        {
        }

        public IntSingleSelectValue(int? value)
        {
            if (value == null)
            {
                this.Value = null;
                return;
            }
            this.Value = new IntSelectInnerValue(value.Value);
        }
    }

    public class IntSelectInnerValue : IEquatable<IntSelectInnerValue>
    {
        public IntSelectInnerValue(int id)
        {
            ID = id;
        }

        public int ID { get; set; }

        public string? Description { get; set; }

        public override string ToString() => ID.ToString(CultureInfo.InvariantCulture);

        public bool Equals(IntSelectInnerValue? other) => other is not null && ID == other.ID;

        public override bool Equals(object? obj) => Equals(obj as IntSelectInnerValue);

        public override int GetHashCode() => ID.GetHashCode();
    }
}