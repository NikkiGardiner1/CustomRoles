﻿using System.Collections.Generic;
using CustomRoles.API;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;

namespace SnivyCustomRoles.Roles;

[CustomRole(RoleTypeId.None)]
public class ContainmentGuard : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 15;

    public StartTeam StartTeam { get; set; } = StartTeam.Guard;

    public override uint Id { get; set; } = 33;

    public override RoleTypeId Role { get; set; } = RoleTypeId.FacilityGuard;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Containment Guard";

    public override string Description { get; set; } =
        "A better equipped guard meant for recontaining SCPs";

    public override string CustomInfo { get; set; } = "Containment Guard";

    public override bool KeepInventoryOnSpawn { get; set; } = false;

    public override bool KeepRoleOnDeath { get; set; } = false;

    public override bool RemovalKillsPlayer { get; set; } = true;

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
    };
    public override List<string> Inventory { get; set; } = new()
    {
        ItemType.Painkillers.ToString(),
        ItemType.ArmorCombat.ToString(),
        ItemType.Radio.ToString(),
        ItemType.GunCrossvec.ToString(),
        ItemType.KeycardResearchCoordinator.ToString(),
    };
    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        {
            AmmoType.Nato9, 80
        },
    };
}