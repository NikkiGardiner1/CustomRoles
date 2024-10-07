using Exiled.CustomRoles.API;
using SnivysCustomRolesAbilities.Abilities;

namespace CustomRoles.Roles;

using CustomRoles.API;

using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;

using MEC;
using PlayerRoles;
using System.Collections.Generic;
using UnityEngine;

[CustomRole(RoleTypeId.Scientist)]
public class ContainmentScientist : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 100;

    public StartTeam StartTeam { get; set; } = StartTeam.Scientist;

    public override uint Id { get; set; } = 30;

    public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Containment Engineer Scientist";

    public override string Description { get; set; } =
        "A scientist that starts in heavy containment, with a different loadout";

    public override string CustomInfo { get; set; } = "Containment Engineer Scientist";

    public override bool KeepInventoryOnSpawn { get; set; } = false;

    public override bool KeepRoleOnDeath { get; set; } = false;

    public override bool RemovalKillsPlayer { get; set; } = true;

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
    };

    public override List<string> Inventory { get; set; } = new()
    {
        ItemType.Medkit.ToString(),
        ItemType.KeycardContainmentEngineer.ToString(),
        ItemType.Adrenaline.ToString(),
        ItemType.Radio.ToString(),
    };

    public override List<CustomAbility>? CustomAbilities { get; set; } = new()
    {
        new RestrictedEscape(),
    };
}