using System.Collections.Generic;
using System.Diagnostics;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{ToDebugView()}")]
    public partial class StringValue : RestValueBase<string>
    {
        public static implicit operator string?(StringValue value) => value?.Value;
        public static implicit operator StringValue(string value) => new StringValue(value);

        public StringValue(string? value = default)
        {
            this.Value = value;
        }
        public Dictionary<string, string>? Translations { get; set; }


		public string ToDebugView()
        {
            var translations = Translations != null && Translations.Count > 0
                ? $" (Translations: {Translations.Count})"
                : string.Empty;

            return $"{Value}{(Error != null ? $" (Error: {Error})" : string.Empty)}{translations}";
        }
    }
}
