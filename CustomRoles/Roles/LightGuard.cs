using System.Collections.Generic;
using CustomRoles.API;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace SnivyCustomRoles.Roles;

[CustomRole(RoleTypeId.None)]
public class LightGuard : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 15;

    public StartTeam StartTeam { get; set; } = StartTeam.Guard;

    public override uint Id { get; set; } = 31;

    public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Protocol Enforcer";

    public override string Description { get; set; } =
        "A guard that is meant to keep D-Class in line. Starts in light containment but with no strong weaponry";

    public override string CustomInfo { get; set; } = "Protocol Enforcer";

    public override bool KeepInventoryOnSpawn { get; set; } = false;

    public override bool KeepRoleOnDeath { get; set; } = false;

    public override bool RemovalKillsPlayer { get; set; } = true;

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        RoleSpawnPoints = new List<RoleSpawnPoint>
        {
            new()
            {
                Role = RoleTypeId.Scientist,
                Chance = 100,
            },
        },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        "Silent Serenade",
        ItemType.Medkit.ToString(),
        ItemType.KeycardZoneManager.ToString(),
        ItemType.Painkillers.ToString(),
        ItemType.Radio.ToString(),
        ItemType.ArmorLight.ToString(),
    };
    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        {
            AmmoType.Nato9, 10
        },
    };
}