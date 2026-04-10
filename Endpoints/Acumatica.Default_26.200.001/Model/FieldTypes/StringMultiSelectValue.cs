using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class StringMultiSelectValue : RestValueBase<List<StringSelectInnerValue>>
    {
        public static implicit operator List<string>(StringMultiSelectValue value) => value?.Value.Select(_=>_.ID).ToList();
        public static implicit operator StringMultiSelectValue(string value) => new StringMultiSelectValue(new List<string> { value });
		public static implicit operator StringMultiSelectValue(List<string> value) => new StringMultiSelectValue(value);

		public StringMultiSelectValue(List<string> value)
        {
            if(value == null)
            {
                this.Value = null;
                return;
			}
			this.Value = new List<StringSelectInnerValue>(value.Count);
            foreach (var singleValue in value)
            {
                this.Value.Add(new StringSelectInnerValue(singleValue));
            }
        }
    }
}
