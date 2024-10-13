using System.Collections.Generic;
using CustomRoles.API;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using SnivysCustomRolesAbilities.Abilities;

namespace SnivyCustomRoles.Roles;

[CustomRole(RoleTypeId.ChaosConscript)]
public class CISpy : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 10;

    public StartTeam StartTeam { get; set; } = StartTeam.Ntf;

    public override uint Id { get; set; } = 40;

    public override RoleTypeId Role { get; set; } = RoleTypeId.NtfSergeant;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Chaos Insurgency Spy";

    public override string Description { get; set; } = "A Chaos Insurgent that is disguised as a MTF Memeber";

    public override string CustomInfo { get; set; } = "NTF Sergeant";

    public override bool KeepInventoryOnSpawn { get; set; } = true;

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        RoleSpawnPoints = new List<RoleSpawnPoint>
        {
            new()
            {
                Role = RoleTypeId.NtfSpecialist,
                Chance = 100,
            },
        },
    };
    
    public override List<CustomAbility>? CustomAbilities { get; set; } = new()
    {
        new Disguised(),
        new RemoveDisguise(),
    };
}