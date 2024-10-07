using SnivysCustomRolesAbilities.Abilities;

namespace CustomRoles.Roles;

using System.Collections.Generic;
using CustomRoles.API;

using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Interfaces;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PlayerEvent = Exiled.Events.Handlers.Player;
using PlayerRoles;
using System.ComponentModel;
using Exiled.API.Features.Core.Generic;

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

    protected override void SubscribeEvents()
    {
        PlayerEvent.Hurting += OnHurting;
        PlayerEvent.Shooting += OnShooting;

        base.SubscribeEvents();
    }

    protected override void UnsubscribeEvents()
    {
        PlayerEvent.Hurting -= OnHurting;
        PlayerEvent.Shooting -= OnShooting;

        base.UnsubscribeEvents();
    }

    private void OnHurting(HurtingEventArgs ev)
    {
        if (ev.Attacker is null) return;
        if ((Check(ev.Player) || Check(ev.Attacker)) && (ev.Player.IsCHI || ev.Attacker.IsCHI))
        {
            ev.Attacker.Broadcast(new Exiled.API.Features.Broadcast("<color=red>That MTF is a CI Spy</color>", 5));
            ev.IsAllowed = false;
        }   
    }

    private void OnShooting(ShootingEventArgs ev)
    {
        Exiled.API.Features.Player target = Exiled.API.Features.Player.Get(ev.TargetNetId);
        if (target != null && target.Role == RoleTypeId.ClassD && Check(ev.Player) || target != null && target.Role == RoleTypeId.ChaosConscript && Check(ev.Player)
            || target != null && target.Role == RoleTypeId.ChaosRepressor && Check(ev.Player) || target != null && target.Role == RoleTypeId.ChaosMarauder && Check(ev.Player)
            || target != null && target.Role == RoleTypeId.ChaosRifleman && Check(ev.Player))
        {
            ev.IsAllowed = false;
        }
    }
}