/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Acumatica.RESTClient.Model;

namespace Acumatica.Default_18_200_001.Model
{
    /// <summary>
    /// CompanyFinancialPeriod
    /// </summary>
    [DataContract]
    public partial class CompanyFinancialPeriod : Entity,  IEquatable<CompanyFinancialPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyFinancialPeriod" /> class.
        /// </summary>
        /// <param name="company">company.</param>
        /// <param name="details">details.</param>
        /// <param name="financialYear">financialYear.</param>
        /// <param name="nbrOfPeriods">nbrOfPeriods.</param>
        /// <param name="startDate">startDate.</param>
        public CompanyFinancialPeriod(StringValue company = default(StringValue), IEnumerable<FinancialPeriodDetail> details = default(IEnumerable<FinancialPeriodDetail>), StringValue financialYear = default(StringValue), ShortValue nbrOfPeriods = default(ShortValue), DateTimeValue startDate = default(DateTimeValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Company = company;
            this.Details = details;
            this.FinancialYear = financialYear;
            this.NbrOfPeriods = nbrOfPeriods;
            this.StartDate = startDate;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public StringValue Company { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public IEnumerable<FinancialPeriodDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets FinancialYear
        /// </summary>
        [DataMember(Name="FinancialYear", EmitDefaultValue=false)]
        public StringValue FinancialYear { get; set; }

        /// <summary>
        /// Gets or Sets NbrOfPeriods
        /// </summary>
        [DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
        public ShortValue NbrOfPeriods { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTimeValue StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyFinancialPeriod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FinancialYear: ").Append(FinancialYear).Append("\n");
            sb.Append("  NbrOfPeriods: ").Append(NbrOfPeriods).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompanyFinancialPeriod);
        }

        /// <summary>
        /// Returns true if CompanyFinancialPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyFinancialPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyFinancialPeriod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) && 
                (
                    this.FinancialYear == input.FinancialYear ||
                    (this.FinancialYear != null &&
                    this.FinancialYear.Equals(input.FinancialYear))
                ) && base.Equals(input) && 
                (
                    this.NbrOfPeriods == input.NbrOfPeriods ||
                    (this.NbrOfPeriods != null &&
                    this.NbrOfPeriods.Equals(input.NbrOfPeriods))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.FinancialYear != null)
                    hashCode = hashCode * 59 + this.FinancialYear.GetHashCode();
                if (this.NbrOfPeriods != null)
                    hashCode = hashCode * 59 + this.NbrOfPeriods.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
