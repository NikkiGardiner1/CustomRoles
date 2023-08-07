namespace CustomRoles.Roles;

using CustomRoles.Abilities;
using CustomRoles.API;

using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;

using MEC;
using PlayerRoles;
using System.Collections.Generic;
using UnityEngine;

[CustomRole(RoleTypeId.None)]
public class Biochemist : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 15;

    public StartTeam StartTeam { get; set; } = StartTeam.Scientist;

    public override uint Id { get; set; } = 32;

    public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Biochemist";

    public override string Description { get; set; } =
        "A scientist that specializes in biological altering. You can passively heal other people and explode on death.";

    public override string CustomInfo { get; set; } = "Biochemist";

    public override bool KeepInventoryOnSpawn { get; set; } = false;

    public override bool KeepRoleOnDeath { get; set; } = false;

    public override bool RemovalKillsPlayer { get; set; } = true;

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
    };
    public override List<CustomAbility>? CustomAbilities { get; set; } = new()
    {
        new HealingMist(),
        new Martyrdom(),
    };
    public override List<string> Inventory { get; set; } = new()
    {
        ItemType.Medkit.ToString(),
        ItemType.Adrenaline.ToString(),
        ItemType.Radio.ToString(),
    };
}