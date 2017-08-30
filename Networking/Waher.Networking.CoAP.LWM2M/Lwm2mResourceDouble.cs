﻿using System;
using System.Collections.Generic;
using System.Text;
using Waher.Networking.CoAP.LWM2M.ContentFormats;

namespace Waher.Networking.CoAP.LWM2M
{
	/// <summary>
	/// Class managing an LWM2M resource double precision floating point value.
	/// </summary>
	public class Lwm2mResourceDouble : Lwm2mResource
	{
		private double? value;

		/// <summary>
		/// Class managing an LWM2M resource double precision floating point value.
		/// </summary>
		/// <param name="Id">ID of object.</param>
		/// <param name="InstanceId">ID of object instance.</param>
		/// <param name="ResourceId">ID of resource.</param>
		/// <param name="Value">Value of resource.</param>
		public Lwm2mResourceDouble(ushort Id, ushort InstanceId, ushort ResourceId, float? Value)
			: base(Id, InstanceId, ResourceId)
		{
			this.value = Value;
		}

		/// <summary>
		/// Value of resource.
		/// </summary>
		public override object Value => this.value;

		/// <summary>
		/// Resource value.
		/// </summary>
		public double? DoubleValue
		{
			get { return this.value; }
			set { this.value = value; }
		}

		/// <summary>
		/// Reads the value from a TLV record.
		/// </summary>
		/// <param name="Record">TLV record.</param>
		public override void Read(TlvRecord Record)
		{
			this.value = Record.AsDouble();
		}

		/// <summary>
		/// Reads the value from a TLV record.
		/// </summary>
		/// <param name="Output">Output.</param>
		public override void Write(ILwm2mWriter Output)
		{
			if (this.value.HasValue)
				Output.Write(IdentifierType.Resource, this.ResourceId, this.value.Value);
			else
				Output.Write(IdentifierType.Resource, this.ResourceId);
		}
	}
}
