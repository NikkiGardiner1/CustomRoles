namespace CustomRoles.Abilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.CustomRoles.API.Features;
using InventorySystem.Items.Firearms.Modules;
using MEC;
using PlayerStatsSystem;
using PlayerRoles;
using UnityEngine;

[CustomAbility]
public class Detect : ActiveAbility
{
    public override string Name { get; set; } = "Detect";

    public override string Description { get; set; } = "Detects Scientists or MTF near by.";

    public override float Duration { get; set; } = 0f;

    public override float Cooldown { get; set; } = 120f;

    protected override void AbilityUsed(Player player)
    {
        player.Hurt(50);
        List<Player> detectedPlayers = new List<Player>();

        foreach (Player p in Player.List)
        {
            if (Vector3.Distance(player.Position, p.Position) <= 30f && (p.Role == RoleTypeId.Scientist || p.Role == RoleTypeId.NtfCaptain || p.Role == RoleTypeId.NtfPrivate || p.Role == RoleTypeId.NtfSergeant || p.Role == RoleTypeId.NtfSpecialist || p.Role == RoleTypeId.FacilityGuard))
            {
                detectedPlayers.Add(p);
            }
        }

        if (detectedPlayers.Count > 0)
        {
            string message = "Detected Foundation Members: \n";
            foreach (Player detectedPlayer in detectedPlayers)
            {
                message += $"{detectedPlayer.Role}\n";
            }
            player.ShowHint(message, 10f);
        }
        else
        {
            player.ShowHint("No Foundation Members Detected Near Your Location.", 5f);
        }

        EndAbility(player);
    }
}