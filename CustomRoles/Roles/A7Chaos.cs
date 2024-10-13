using System.Collections.Generic;
using CustomRoles.API;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace SnivyCustomRoles.Roles;

[CustomRole(RoleTypeId.ChaosConscript)]
public class A7Chaos : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 25;

    public StartTeam StartTeam { get; set; } = StartTeam.Chaos;

    public override uint Id { get; set; } = 36;

    public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosConscript;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Chaos A7 Enjoyer";

    public override string Description { get; set; } =
        "A Chaos Rifleman but instead of an AK you get an A7";

    public override string CustomInfo { get; set; } = "Chaos Short Rifleman";

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        RoleSpawnPoints = new List<RoleSpawnPoint>
        {
            new()
            {
                Role = RoleTypeId.ChaosConscript,
                Chance = 100,
            },
        },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.GunA7}",
        $"{ItemType.KeycardChaosInsurgency}",
        $"{ItemType.Medkit}",
        $"{ItemType.ArmorCombat}",
        $"{ItemType.Painkillers}",
    };

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        {
            AmmoType.Nato762, 120
        },
    };
}