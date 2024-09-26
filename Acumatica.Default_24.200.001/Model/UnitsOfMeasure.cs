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
	/// Corresponds to the screen CS203500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Unit 
		/// DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnitID", EmitDefaultValue=false)]
		public StringValue? UnitID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: L3Code 
		/// DAC: PX.Objects.Localizations.CA.CS.UnitOfMeasure 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="L3Code", EmitDefaultValue=false)]
		public StringValue? L3Code { get; set; }

		[DataMember(Name="Conversion", EmitDefaultValue=false)]
		public List<Units>? Conversion { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}