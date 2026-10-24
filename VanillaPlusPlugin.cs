using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace VanillaPlus;

[BepInAutoPlugin("nl.flowerdev", "VanillaPlus")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)] // The Mira API dependency attribute
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class VanillaPlusPlugin : BasePlugin, IMiraPlugin
{
    public Harmony Harmony { get; } = new(Id);

    public string OptionsTitleText => "VanillaPlus";

    public ConfigFile GetConfigFile() => Config;

    public override void Load()
    {
        Harmony.PatchAll();
    }
}