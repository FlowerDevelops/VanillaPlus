using MiraAPI.Events;
using MiraAPI.Events.Vanilla.Gameplay;
using MiraAPI.Networking;

public static class BeforeMurderListener
{
    [RegisterEvent]
    public static void beforeMurderEvent(BeforeMurderEvent @event)
    {
        // Suicide ig
        if (@event.Source.PlayerId == @event.Target.PlayerId)
        {
            return;
        }

        if (@event.Source.Data.Role is SheriffRole)
        {
            if (!@event.Target.Data.Role.IsImpostor)
            {
                @event.Cancel();

                // Kill sheriff
                PlayerControl.LocalPlayer.RpcCustomMurder(
                    @event.Source
                );
            }
        } 
    }
}