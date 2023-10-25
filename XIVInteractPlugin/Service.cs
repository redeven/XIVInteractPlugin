using Dalamud.Game.ClientState.Objects;
using Dalamud.IoC;
using Dalamud.Plugin.Services;

namespace XIVInteractPlugin
{
    internal class Service
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [PluginService] public static ICommandManager CommandManager { get; private set; }
        [PluginService] public static IClientState ClientState { get; private set; }
        [PluginService] public static ITargetManager TargetManager { get; private set; }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
