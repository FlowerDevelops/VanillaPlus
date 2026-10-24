using MiraAPI.GameEnd;
using MiraAPI.Roles;
using UnityEngine;
using VanillaPlus.GameOvers;

public class JesterRole : ImpostorRole, ICustomRole
{
    public string RoleName => "Jester";
    public string RoleLongDescription => "Get voted out to win!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => VPPallette.JesterOrange;
    public ModdedRoleTeams Team => ModdedRoleTeams.Custom;
    public RoleOptionsGroup RoleOptionsGroup => RoleOptionsGroup.Neutral;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        MaxRoleCount = 1,
    };

    public override void OnDeath(DeathReason reason)
    {
        if (reason == DeathReason.Exile)
        {
            NetworkedPlayerInfo[] winners = {Player.Data};
            CustomGameOver.Trigger<JesterGameOver>(winners);
        }
    }
}