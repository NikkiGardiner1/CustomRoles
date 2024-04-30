namespace CustomRoles.Abilities;

using Exiled.API.Features.Attributes;
using Exiled.API.Features.Items;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using Item = Exiled.API.Features.Items.Item;

[CustomAbility]
public class Martyrdom : PassiveAbility
{
    public override string Name { get; set; } = "Martyrdom";

    public override string Description { get; set; } = "Causes the player to explode upon death.";

    public float GrenadeFuseTime { get; set; } = 0.1f;

    protected override void SubscribeEvents()
    {
        Player.Dying += OnDying;
        base.SubscribeEvents();
    }

    protected override void UnsubscribeEvents()
    {
        Player.Dying -= OnDying;
        base.UnsubscribeEvents();
    }

    private void OnDying(DyingEventArgs ev)
    {
        if (Check(ev.Player))
        {
            ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
            grenade.FuseTime = GrenadeFuseTime;
            grenade.SpawnActive(ev.Player.Position, ev.Player);
        }
    }
}