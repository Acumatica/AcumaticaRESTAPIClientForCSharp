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
    /// EmailProcessing
    /// </summary>
    [DataContract]
    public partial class EmailProcessing : Entity,  IEquatable<EmailProcessing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailProcessing" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="accountEmailAccountID">accountEmailAccountID.</param>
        /// <param name="assignedToMe">assignedToMe.</param>
        /// <param name="assignedToOwner">assignedToOwner.</param>
        /// <param name="includeFailed">includeFailed.</param>
        /// <param name="result">result.</param>
        /// <param name="type">type.</param>
        public EmailProcessing(IntValue account = default(IntValue), StringValue accountEmailAccountID = default(StringValue), BooleanValue assignedToMe = default(BooleanValue), StringValue assignedToOwner = default(StringValue), BooleanValue includeFailed = default(BooleanValue), IEnumerable<EmailProcessingRow> result = default(IEnumerable<EmailProcessingRow>), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.AccountEmailAccountID = accountEmailAccountID;
            this.AssignedToMe = assignedToMe;
            this.AssignedToOwner = assignedToOwner;
            this.IncludeFailed = includeFailed;
            this.Result = result;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public IntValue Account { get; set; }

        /// <summary>
        /// Gets or Sets AccountEmailAccountID
        /// </summary>
        [DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
        public StringValue AccountEmailAccountID { get; set; }

        /// <summary>
        /// Gets or Sets AssignedToMe
        /// </summary>
        [DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
        public BooleanValue AssignedToMe { get; set; }

        /// <summary>
        /// Gets or Sets AssignedToOwner
        /// </summary>
        [DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
        public StringValue AssignedToOwner { get; set; }

        /// <summary>
        /// Gets or Sets IncludeFailed
        /// </summary>
        [DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
        public BooleanValue IncludeFailed { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="Result", EmitDefaultValue=false)]
        public IEnumerable<EmailProcessingRow> Result { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailProcessing {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AccountEmailAccountID: ").Append(AccountEmailAccountID).Append("\n");
            sb.Append("  AssignedToMe: ").Append(AssignedToMe).Append("\n");
            sb.Append("  AssignedToOwner: ").Append(AssignedToOwner).Append("\n");
            sb.Append("  IncludeFailed: ").Append(IncludeFailed).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as EmailProcessing);
        }

        /// <summary>
        /// Returns true if EmailProcessing instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailProcessing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailProcessing input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.AccountEmailAccountID == input.AccountEmailAccountID ||
                    (this.AccountEmailAccountID != null &&
                    this.AccountEmailAccountID.Equals(input.AccountEmailAccountID))
                ) && base.Equals(input) && 
                (
                    this.AssignedToMe == input.AssignedToMe ||
                    (this.AssignedToMe != null &&
                    this.AssignedToMe.Equals(input.AssignedToMe))
                ) && base.Equals(input) && 
                (
                    this.AssignedToOwner == input.AssignedToOwner ||
                    (this.AssignedToOwner != null &&
                    this.AssignedToOwner.Equals(input.AssignedToOwner))
                ) && base.Equals(input) && 
                (
                    this.IncludeFailed == input.IncludeFailed ||
                    (this.IncludeFailed != null &&
                    this.IncludeFailed.Equals(input.IncludeFailed))
                ) && base.Equals(input) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    this.Result.SequenceEqual(input.Result)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.AccountEmailAccountID != null)
                    hashCode = hashCode * 59 + this.AccountEmailAccountID.GetHashCode();
                if (this.AssignedToMe != null)
                    hashCode = hashCode * 59 + this.AssignedToMe.GetHashCode();
                if (this.AssignedToOwner != null)
                    hashCode = hashCode * 59 + this.AssignedToOwner.GetHashCode();
                if (this.IncludeFailed != null)
                    hashCode = hashCode * 59 + this.IncludeFailed.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
