using MiraAPI.GameEnd;
using MiraAPI.Roles;
using UnityEngine;
using VanillaPlus.GameOvers;

public class ScannerRole : ImpostorRole, ICustomRole
{
    public string RoleName => "Scanner";
    public string RoleLongDescription => "Scan the map and see positions!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => VPPallette.JesterOrange;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public RoleOptionsGroup RoleOptionsGroup => RoleOptionsGroup.Impostor;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        MaxRoleCount = 1,
    };

    
}