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
    /// ProjectTask
    /// </summary>
    [DataContract]
    public partial class ProjectTask : Entity,  IEquatable<ProjectTask>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTask" /> class.
        /// </summary>
        /// <param name="activityHistory">activityHistory.</param>
        /// <param name="attribute">attribute.</param>
        /// <param name="billingAndAllocationSettings">billingAndAllocationSettings.</param>
        /// <param name="cRMLink">cRMLink.</param>
        /// <param name="_default">_default.</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="description">description.</param>
        /// <param name="externalRefNbr">externalRefNbr.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="properties">properties.</param>
        /// <param name="status">status.</param>
        /// <param name="visibilitySettings">visibilitySettings.</param>
        public ProjectTask(IEnumerable<ProjectActivity> activityHistory = default(IEnumerable<ProjectActivity>), IEnumerable<AttributeValue> attribute = default(IEnumerable<AttributeValue>), ProjectTaskBillingAndAllocationSettings billingAndAllocationSettings = default(ProjectTaskBillingAndAllocationSettings), ProjectTaskToCRMLink cRMLink = default(ProjectTaskToCRMLink), BooleanValue _default = default(BooleanValue), ProjectTaskDefaultValues defaultValues = default(ProjectTaskDefaultValues), StringValue description = default(StringValue), StringValue externalRefNbr = default(StringValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), StringValue projectID = default(StringValue), StringValue projectTaskID = default(StringValue), ProjectTaskProperties properties = default(ProjectTaskProperties), StringValue status = default(StringValue), VisibilitySettings visibilitySettings = default(VisibilitySettings), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ActivityHistory = activityHistory;
            this.Attribute = attribute;
            this.BillingAndAllocationSettings = billingAndAllocationSettings;
            this.CRMLink = cRMLink;
            this.Default = _default;
            this.DefaultValues = defaultValues;
            this.Description = description;
            this.ExternalRefNbr = externalRefNbr;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.ProjectID = projectID;
            this.ProjectTaskID = projectTaskID;
            this.Properties = properties;
            this.Status = status;
            this.VisibilitySettings = visibilitySettings;
        }
        
        /// <summary>
        /// Gets or Sets ActivityHistory
        /// </summary>
        [DataMember(Name="ActivityHistory", EmitDefaultValue=false)]
        public IEnumerable<ProjectActivity> ActivityHistory { get; set; }

        /// <summary>
        /// Gets or Sets Attribute
        /// </summary>
        [DataMember(Name="Attribute", EmitDefaultValue=false)]
        public IEnumerable<AttributeValue> Attribute { get; set; }

        /// <summary>
        /// Gets or Sets BillingAndAllocationSettings
        /// </summary>
        [DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
        public ProjectTaskBillingAndAllocationSettings BillingAndAllocationSettings { get; set; }

        /// <summary>
        /// Gets or Sets CRMLink
        /// </summary>
        [DataMember(Name="CRMLink", EmitDefaultValue=false)]
        public ProjectTaskToCRMLink CRMLink { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="Default", EmitDefaultValue=false)]
        public BooleanValue Default { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name="DefaultValues", EmitDefaultValue=false)]
        public ProjectTaskDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExternalRefNbr
        /// </summary>
        [DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
        public StringValue ExternalRefNbr { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="ProjectID", EmitDefaultValue=false)]
        public StringValue ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="Properties", EmitDefaultValue=false)]
        public ProjectTaskProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets VisibilitySettings
        /// </summary>
        [DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
        public VisibilitySettings VisibilitySettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTask {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActivityHistory: ").Append(ActivityHistory).Append("\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  BillingAndAllocationSettings: ").Append(BillingAndAllocationSettings).Append("\n");
            sb.Append("  CRMLink: ").Append(CRMLink).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalRefNbr: ").Append(ExternalRefNbr).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VisibilitySettings: ").Append(VisibilitySettings).Append("\n");
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
            return this.Equals(input as ProjectTask);
        }

        /// <summary>
        /// Returns true if ProjectTask instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTask input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ActivityHistory == input.ActivityHistory ||
                    this.ActivityHistory != null &&
                    this.ActivityHistory.SequenceEqual(input.ActivityHistory)
                ) && base.Equals(input) && 
                (
                    this.Attribute == input.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.SequenceEqual(input.Attribute)
                ) && base.Equals(input) && 
                (
                    this.BillingAndAllocationSettings == input.BillingAndAllocationSettings ||
                    (this.BillingAndAllocationSettings != null &&
                    this.BillingAndAllocationSettings.Equals(input.BillingAndAllocationSettings))
                ) && base.Equals(input) && 
                (
                    this.CRMLink == input.CRMLink ||
                    (this.CRMLink != null &&
                    this.CRMLink.Equals(input.CRMLink))
                ) && base.Equals(input) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && base.Equals(input) && 
                (
                    this.DefaultValues == input.DefaultValues ||
                    (this.DefaultValues != null &&
                    this.DefaultValues.Equals(input.DefaultValues))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExternalRefNbr == input.ExternalRefNbr ||
                    (this.ExternalRefNbr != null &&
                    this.ExternalRefNbr.Equals(input.ExternalRefNbr))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && base.Equals(input) && 
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.VisibilitySettings == input.VisibilitySettings ||
                    (this.VisibilitySettings != null &&
                    this.VisibilitySettings.Equals(input.VisibilitySettings))
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
                if (this.ActivityHistory != null)
                    hashCode = hashCode * 59 + this.ActivityHistory.GetHashCode();
                if (this.Attribute != null)
                    hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                if (this.BillingAndAllocationSettings != null)
                    hashCode = hashCode * 59 + this.BillingAndAllocationSettings.GetHashCode();
                if (this.CRMLink != null)
                    hashCode = hashCode * 59 + this.CRMLink.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.DefaultValues != null)
                    hashCode = hashCode * 59 + this.DefaultValues.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalRefNbr != null)
                    hashCode = hashCode * 59 + this.ExternalRefNbr.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VisibilitySettings != null)
                    hashCode = hashCode * 59 + this.VisibilitySettings.GetHashCode();
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
