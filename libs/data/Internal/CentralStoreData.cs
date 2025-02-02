using Godot;
using Godot.Collections;
using Newtonsoft.Json;

[JsonObject(MemberSerialization.OptIn)]
public class CentralStoreData : Object {
	[JsonProperty]
	public Array<ProjectFile> Projects;
	[JsonProperty]
	public Array<GodotVersion> Versions;
	[JsonProperty]
	public Array<GithubVersion> GHVersions;
	[JsonProperty]
	public Array<TuxfamilyVersion> TFVersions;
	[JsonProperty]
	public Array<Category> Categories;
	[JsonProperty]
	public Array<AssetPlugin> Plugins;
	[JsonProperty]
	public Array<AssetProject> Templates;
	[JsonProperty]
	public Settings Settings;

	public CentralStoreData() {
		Projects = new Array<ProjectFile>();
		Versions = new Array<GodotVersion>();
		GHVersions = new Array<GithubVersion>();
		TFVersions = new Array<TuxfamilyVersion>();
		Categories = new Array<Category>();
		Plugins = new Array<AssetPlugin>();
		Templates = new Array<AssetProject>();
		Settings = new Settings();
	}
}