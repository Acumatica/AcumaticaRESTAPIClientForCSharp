using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen TX205500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TaxCategory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.TX.TaxCategory 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the tax category, which can be specified by the user.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TaxCategoryTaxDetail>? Details { get; set; }

		/// <summary>
		/// "Exclude Listed Taxes" flag. Specifies how the taxes that are included in the category should be applied to the document line.false: Only the taxes of the category that are intersected with the taxes of the tax zone should be applied to the document line.true: All taxes of the tax zone except the taxes of the category should be applied to the document line.
		/// DAC Field Name: TaxCatFlag 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// Display Name: Exclude Listed Taxes 
		/// </summary>
		[DataMember(Name="ExcludeListedTaxes", EmitDefaultValue=false)]
		public BooleanValue? ExcludeListedTaxes { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The tax category ID. This is the key field, which can be specified by the user.
		/// DAC: PX.Objects.TX.TaxCategory 
		/// Display Name: Tax Category ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}