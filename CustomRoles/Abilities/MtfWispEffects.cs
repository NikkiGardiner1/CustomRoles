﻿namespace CustomRoles.Abilities;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.CustomRoles.API.Features;
using MEC;

[CustomAbility]
public class MtfWispEffects : PassiveAbility
{
    public override string Name { get; set; } = "MTF Wisp Effects.";

    public override string Description { get; set; } = "Enables walking through doors, Fog Control, Reduced Sprint";

    protected override void AbilityAdded(Player player)
    {
        Timing.CallDelayed(2.5f, () =>
        {
            player.EnableEffect(EffectType.Ghostly); 
            player.EnableEffect(EffectType.FogControl, 0);
            player.EnableEffect(EffectType.Exhausted);
        });
    }

    protected override void AbilityRemoved(Player player)
    {
        player.DisableEffect(EffectType.Ghostly);
        player.DisableEffect(EffectType.FogControl);
        player.DisableEffect(EffectType.Exhausted);
    }
}