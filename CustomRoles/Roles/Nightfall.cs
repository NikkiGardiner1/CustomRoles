namespace CustomRoles.Roles;

using System.Collections.Generic;
using CustomRoles.Abilities;
using CustomRoles.API;

using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PlayerRoles;

[CustomRole(RoleTypeId.ChaosConscript)]
public class Nightfall : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 5;

    public StartTeam StartTeam { get; set; } = StartTeam.Chaos;

    public override uint Id { get; set; } = 35;

    public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosConscript;

    public override int MaxHealth { get; set; } = 200;

    public override string Name { get; set; } = "Nightfall";

    public override string Description { get; set; } =
        "A Chaos Insurgent that is special. You figure out the rest.";

    public override string CustomInfo { get; set; } = "Nightfall";

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
        $"{ItemType.GunRevolver}",
        $"{ItemType.KeycardO5}",
        $"{ItemType.SCP500}",
        $"{ItemType.ArmorCombat}",
    };

    public override Dictionary<AmmoType, ushort> Ammo { get; set; } = new()
    {
        {
            AmmoType.Ammo44Cal, 20
        },
    };

    protected override void SubscribeEvents()
    {
        Player.DroppingItem += OnDroppingItem;
        Player.PickingUpItem += OnPickingUpItem;
        Player.UsingItem += OnUsingMedicalItem;
        base.SubscribeEvents();
    }

    protected override void UnsubscribeEvents()
    {
        Player.DroppingItem -= OnDroppingItem;
        Player.PickingUpItem -= OnPickingUpItem;
        Player.UsingItem -= OnUsingMedicalItem;
        base.UnsubscribeEvents();
    }

    private void OnUsingMedicalItem(UsingItemEventArgs ev)
    {
        if (Check(ev.Player) && ev.Item.Type == ItemType.Medkit)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.Painkillers)
            ev.IsAllowed = false;
    }

    private void OnPickingUpItem(PickingUpItemEventArgs ev)
    {
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.SCP500)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.Medkit)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.Painkillers)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.KeycardO5)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunE11SR)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunCrossvec)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunFSP9)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunLogicer)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunAK)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Pickup.Type == ItemType.GunShotgun)
            ev.IsAllowed = false;
    }

    private void OnDroppingItem(DroppingItemEventArgs ev)
    {
        if (Check(ev.Player) && ev.Item.Type == ItemType.SCP500)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.Medkit)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.Painkillers)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.KeycardO5)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunE11SR)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunCrossvec)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunFSP9)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunLogicer)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunAK)
            ev.IsAllowed = false;
        if (Check(ev.Player) && ev.Item.Type == ItemType.GunShotgun)
            ev.IsAllowed = false;
    }
}