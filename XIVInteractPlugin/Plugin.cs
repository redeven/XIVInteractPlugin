using System.Numerics;
using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Plugin;
using FFXIVClientStructs.FFXIV.Client.Game.Control;
using FFXIVClientStructs.FFXIV.Client.Game.Object;

namespace XIVInteractPlugin
{
    public unsafe class Plugin : IDalamudPlugin
    {
        public string Name => "XIV Interact";
        private const string CommandName = "/interact";

        public Plugin([RequiredVersion("1.0")] DalamudPluginInterface pluginInterface)
        {
            pluginInterface.Create<Service>();
            Service.CommandManager.AddHandler(CommandName, new CommandInfo(OnCommand)
            {
                HelpMessage = "Interacts with target. Same as the Confirm action."
            });
        }

        public void Dispose()
        {
            Service.CommandManager.RemoveHandler(CommandName);
        }

        private void OnCommand(string command, string args)
        {
            var target = Service.TargetManager.Target;
            var player = Service.ClientState.LocalPlayer;
            if (target != null && player != null)
            {
                if (Vector3.Distance(target.Position, player.Position) < GetValidInteractionDistance(target) && ((GameObject*)target.Address)->GetIsTargetable())
                {
                    TargetSystem.Instance()->InteractWithObject((GameObject*)target.Address);
                }
            }
        }

        private float GetValidInteractionDistance(Dalamud.Game.ClientState.Objects.Types.GameObject obj)
        {
            return 4.6f;
        }
    }
}
