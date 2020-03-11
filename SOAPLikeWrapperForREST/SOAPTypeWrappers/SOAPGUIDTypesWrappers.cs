using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public enum GuidCondition
    {

        /// <remarks/>
        Equal,

        /// <remarks/>
        NotEqual,

        /// <remarks/>
        IsNull,

        /// <remarks/>
        IsNotNull,
    }
  
    public partial class GuidSearch : GuidValue
    {

        private GuidCondition conditionField;

        private System.Guid value2Field;

        public GuidCondition Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public System.Guid Value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
    }
}
