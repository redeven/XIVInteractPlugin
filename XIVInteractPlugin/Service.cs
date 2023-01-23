using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.Command;
using Dalamud.IoC;

namespace XIVInteractPlugin
{
    internal class Service
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [PluginService] public static CommandManager CommandManager { get; private set; }
        [PluginService] public static ClientState ClientState { get; private set; }
        [PluginService] public static TargetManager TargetManager { get; private set; }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
