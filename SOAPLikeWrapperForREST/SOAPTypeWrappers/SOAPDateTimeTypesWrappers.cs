using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public partial class DateTimeSearch : DateTimeValue
    {

        private DateTimeCondition conditionField;

        private System.Nullable<System.DateTime> value2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DateTimeCondition Condition
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

        public System.Nullable<System.DateTime> Value2
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

    public enum DateTimeCondition
    {

        /// <remarks/>
        Equal,

        /// <remarks/>
        NotEqual,

        /// <remarks/>
        IsBetween,

        /// <remarks/>
        IsGreaterThan,

        /// <remarks/>
        IsLessThan,

        /// <remarks/>
        IsGreaterThanOrEqualsTo,

        /// <remarks/>
        IsLessThanOrEqualsTo,

        /// <remarks/>
        Today,

        /// <remarks/>
        Overdue,

        /// <remarks/>
        Tomorrow,

        /// <remarks/>
        ThisWeek,

        /// <remarks/>
        ThisMonth,

        /// <remarks/>
        IsNull,

        /// <remarks/>
        IsNotNull,
    }

}
