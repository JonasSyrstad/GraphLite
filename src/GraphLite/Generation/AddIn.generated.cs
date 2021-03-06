using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GraphLite
{
	public partial class AddIn
	{ 
		[JsonProperty("id")]
		public Guid? Id { get; set; }
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("properties")]
		public List<KeyValue> Properties { get; set; }
	}
}