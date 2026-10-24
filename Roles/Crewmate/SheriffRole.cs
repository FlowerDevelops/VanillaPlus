using MiraAPI.GameEnd;
using MiraAPI.Roles;
using UnityEngine;
using VanillaPlus.GameOvers;

public class SheriffRole : ImpostorRole, ICustomRole
{
    public string RoleName => "Sheriff";
    public string RoleLongDescription => "Shoot the imposter to win!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => VPPallette.SheriffYellow;
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;
    public RoleOptionsGroup RoleOptionsGroup => RoleOptionsGroup.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        MaxRoleCount = 2,
    };
}