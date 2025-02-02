using Godot;
using Godot.Collections;
using Newtonsoft.Json;

namespace Github {
	[JsonObject(MemberSerialization.OptIn)]
	public class Asset : Object {
		[JsonProperty]
		public string Url;
		[JsonProperty]
		public string BrowserDownloadUrl;
		[JsonProperty]
		public int Id;
		[JsonProperty]
		public string NodeId;
		[JsonProperty]
		public string Name;
		[JsonProperty]
		public string Label;
		[JsonProperty]
		public string State;
		[JsonProperty]
		public string ContentType;
		[JsonProperty]
		public int Size;
		[JsonProperty]
		public int DownloadCount;
		[JsonProperty]
		public System.DateTime CreatedAt;
		[JsonProperty]
		public System.DateTime UpdatedAt;
		[JsonProperty]
		public Author Uploader;

		public static Asset FromJson(string data) {
			return JsonConvert.DeserializeObject<Asset>(data,DefaultSettings.defaultJsonSettings);
		}
	}
}