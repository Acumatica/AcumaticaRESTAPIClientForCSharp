using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class StringSingleSelectValue : RestValueBase<StringSelectInnerValue>
    {
        public static implicit operator string?(StringSingleSelectValue value) => value?.Value?.ID;
        public static implicit operator StringSingleSelectValue(string value) => new StringSingleSelectValue(value);

        public StringSingleSelectValue(string? value = default)
        {
            if(value == null)
            {
                this.Value = null;
                return;
			}
            this.Value = new StringSelectInnerValue(value);
        }
    }
    public class StringSelectInnerValue
    {
        public StringSelectInnerValue(string id)
        {
            ID = id;
        }
		public string ID { get; set; }
        public string? Description { get; set; }
    }
}
