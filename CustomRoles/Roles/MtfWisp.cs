using SnivysCustomRolesAbilities.Abilities;

namespace CustomRoles.Roles;

using System.Collections.Generic;
using CustomRoles.API;

using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PlayerRoles;
using JetBrains.Annotations;

[CustomRole(RoleTypeId.NtfSpecialist)]
public class MtfWisp : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 100;

    public StartTeam StartTeam { get; set; } = StartTeam.Ntf;

    public override uint Id { get; set; } = 41;

    public override RoleTypeId Role { get; set; } = RoleTypeId.NtfSpecialist;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "MTF Wisp";

    public override List<string> Inventory { get; set; } = new()
    {
        ItemType.GunCrossvec.ToString(),
        ItemType.GunRevolver.ToString(),
        ItemType.Medkit.ToString(),
        ItemType.Radio.ToString(),
        ItemType.ArmorCombat.ToString()
    };

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        {
            AmmoType.Nato9, 120
        },
    };
    public override string Description { get; set; } =
        "A MTF Specialist that has the ability to go through doors and being able to see farther.";

    public override string CustomInfo { get; set; } = "MTF Wisp";

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
        new Wisp(),
    };
}