// Author: @AtonyGit, Adaption: @FlowerDevelops

using System;
using MiraAPI.Hud;
using MiraAPI.Networking;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

#nullable enable
public class SheriffKillButton : CustomActionButton<PlayerControl>
{
    public static readonly LoadableResourceAsset icon = new("VanillaPlus.Resources.Buttons.Crewmate.Sheriff.Shoot.png");
    public override string Name => "Shoot";
    public override float Cooldown => 10f;
    public override float EffectDuration => 0f; // 0 means no effect.
    public override int MaxUses => 0; // 0 means unlimited uses.
    public override LoadableAsset<Sprite> Sprite => icon;

    public override bool Enabled(RoleBehaviour? role)
    {
        return role is SheriffRole; // only show button when the player has SheriffRole
    }
    
    protected override void OnClick()
    {
        if (Target == null)
        {
            Error("Sheriff target = null");
            return;
        }

        PlayerControl.LocalPlayer.RpcCustomMurder(Target, MeetingCheck.OutsideMeeting);
    }

    private void Error(string v)
    {
        throw new NotImplementedException();
    }

    public override PlayerControl? GetTarget()
    {
        return PlayerControl.LocalPlayer.GetClosestPlayer(true, Distance);
    }

    public override void SetOutline(bool active)
    {
        Target?.cosmetics.SetOutline(active, new Il2CppSystem.Nullable<Color>(VPPallette.SheriffYellow));
    }
}